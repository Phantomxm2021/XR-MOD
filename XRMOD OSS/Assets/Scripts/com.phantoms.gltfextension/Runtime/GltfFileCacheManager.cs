// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the glTFExtension.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using GLTFast.Export;
using GLTFast.Logging;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.phantoms.gltfextension.Runtime
{
    public class GltfFileCacheManager
    {
        private GltfCacheDb gltfCacheDb = new GltfCacheDb();

        public static string CachePath =>
            Path.Combine(Application.isEditor
                ? Application.dataPath.Replace("Assets", "")
                : Application.temporaryCachePath, "XRMODEngine/XRFileCache");


        public GltfFileCacheManager()
        {
            if (!Directory.Exists(CachePath))
            {
                Directory.CreateDirectory(CachePath);
            }

            // var tmp_GltfExportShaderVariantCollection =
            //     Resources.Load<ShaderVariantCollection>("glTFExport");
            // tmp_GltfExportShaderVariantCollection.WarmUp();
            // Resources.UnloadAsset(tmp_GltfExportShaderVariantCollection);
            ConnectCacheDb();
        }

        public string GetRecord(Uri _recordUri)
        {
            var tmp_FileName = Path.GetFileName(_recordUri.LocalPath);
            bool tmp_RecordHasExist = gltfCacheDb.cacheDict.TryGetValue(tmp_FileName, out var tmp_Record);
            if (tmp_RecordHasExist)
            {
                return File.Exists(tmp_Record.GltfFilePath) ? tmp_Record.GltfFilePath : string.Empty;
            }

            return String.Empty;
        }

        public async Task<bool> AddNewRecord(Uri _recordUri, GameObject[] _recordGo)
        {
            var tmp_FileName = Path.GetFileName(_recordUri.LocalPath);
            var tmp_SaveFilePath = Path.Combine(CachePath, tmp_FileName);
            var tmp_TimestampForFile =
                string.IsNullOrEmpty(_recordUri.Query)
                    ? GetTimeStamp()
                    : _recordUri.Query.Split("=")[1];
            if (gltfCacheDb.cacheDict.TryGetValue(tmp_FileName, out var tmp_Record))
            {
                if (tmp_Record.Timestamp == tmp_TimestampForFile)
                {
                    return false;
                }

                gltfCacheDb.cacheDict[tmp_FileName] = new GltfRecord
                {
                    GltfFilePath = tmp_SaveFilePath,
                    Timestamp = tmp_TimestampForFile
                };
            }
            else
            {
                gltfCacheDb.cacheDict.Add(tmp_FileName, new GltfRecord
                {
                    GltfFilePath = tmp_SaveFilePath,
                    Timestamp = tmp_TimestampForFile
                });
            }

            // CollectingLogger lets you programatically go through
            // errors and warnings the export raised
            var tmp_Logger = new CollectingLogger();

            var tmp_ExportSettings = new ExportSettings()
            {
                format = GltfFormat.Binary,
                fileConflictResolution = FileConflictResolution.Overwrite
            };
            var tmp_Exporter = new GameObjectExport(exportSettings: tmp_ExportSettings, new GameObjectExportSettings
                {
                    onlyActiveInHierarchy = true
                },
                logger: tmp_Logger);
            tmp_Exporter.AddScene(_recordGo, tmp_FileName);
            bool tmp_Success = await tmp_Exporter.SaveToFileAndDispose(tmp_SaveFilePath);
            CacheDictSerializer();
            return tmp_Success;
        }

        public void AddNewRecord(Uri _recordUri)
        {
            var tmp_FileName = Path.GetFileName(_recordUri.LocalPath);
            var tmp_SaveFilePath = Path.Combine(CachePath, tmp_FileName);
            var tmp_TimestampForFile = string.IsNullOrEmpty(_recordUri.Query)
                ? GetTimeStamp()
                : _recordUri.Query.Split("=")[1];
            if (gltfCacheDb.cacheDict.TryGetValue(tmp_FileName, out var tmp_Record))
            {
                if (tmp_Record.Timestamp == tmp_TimestampForFile)
                {
                    return;
                }

                gltfCacheDb.cacheDict[tmp_FileName] = new GltfRecord
                {
                    GltfFilePath = tmp_SaveFilePath,
                    Timestamp = tmp_TimestampForFile
                };
            }
            else
            {
                gltfCacheDb.cacheDict.Add(tmp_FileName, new GltfRecord
                {
                    GltfFilePath = tmp_SaveFilePath,
                    Timestamp = tmp_TimestampForFile
                });
            }

            CacheDictSerializer();
        }

        public void CleanUp()
        {
            gltfCacheDb.cacheDict.Clear();
            Assert.AreEqual(gltfCacheDb.cacheDict.Count, 0);
        }

        private void CacheDictSerializer()
        {
            var tmp_GltfCacheDbJson = gltfCacheDb.Serializer();
            File.WriteAllText(Path.Combine(CachePath, "gltfCacheDb.json"), tmp_GltfCacheDbJson);
        }

        private void ConnectCacheDb()
        {
            var tmp_GltfCacheDbPath = Path.Combine(CachePath, "gltfCacheDb.json");
            if (!File.Exists(tmp_GltfCacheDbPath)) return;
            var tmp_GltfCacheDbStr = File.ReadAllText(tmp_GltfCacheDbPath, Encoding.Default);
            gltfCacheDb.DeSerializer(tmp_GltfCacheDbStr);
        }

        public string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
    }
}