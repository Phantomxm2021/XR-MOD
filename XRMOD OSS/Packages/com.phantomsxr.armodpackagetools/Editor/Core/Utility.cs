// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
// using com.Phantoms.ARMODPackageTools.Runtime;
// using com.Phantoms.WebRequestExtension.Runtime.WebRequest;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public static class Utility
    {
        public static bool IsCorrectProjectStructure(string _path)
        {
            DirectoryInfo tmp_DirectoryInfo = new DirectoryInfo(_path);
            var tmp_FileInfos = tmp_DirectoryInfo.GetDirectories();
            var tmp_ArtworkFolder = tmp_FileInfos.Where(_info => _info.Name.Equals("Artwork")).ToArray().Length > 0;
            var tmp_ScriptsFolder = tmp_FileInfos.Where(_info => _info.Name.Equals("Scripts")).ToArray().Length > 0;
            var tmp_CacheFolder = tmp_FileInfos.Where(_info => _info.Name.Equals("Cache")).ToArray().Length > 0;
            return tmp_ArtworkFolder && tmp_ScriptsFolder && tmp_CacheFolder;
        }

        public static bool IsUrl(string _str)
        {
            try
            {
                const string tmp_URL = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
                return Regex.IsMatch(_str, tmp_URL);
            }
            catch (Exception tmp_Ex)
            {
                Debug.LogError(tmp_Ex.Message);
                return false;
            }
        }

        public static string GetRootDataPath(string _fileName = null)
        {
            var tmp_DataPath = $"Assets/{ConstKey.TOOLS_DATA_CACHE_FOLDER}/Data/";
            if (!Directory.Exists(tmp_DataPath))
                Directory.CreateDirectory(tmp_DataPath);
            return string.IsNullOrEmpty(_fileName) ? tmp_DataPath : Path.Combine(tmp_DataPath, _fileName);
        }


        public static void DrawHorizontalDivLine(int _height = 1)
        {
            Rect tmp_Rect = EditorGUILayout.GetControlRect(false, _height);
            tmp_Rect.height = _height;
            EditorGUI.DrawRect(tmp_Rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        public static string ShortenPath(string _fullPath)
        {
            int tmp_SubStringStartPos = _fullPath.IndexOf("Assets", StringComparison.Ordinal);
            return _fullPath.Substring(tmp_SubStringStartPos, _fullPath.Length - tmp_SubStringStartPos);
        }


        /// <summary>
        /// Copy files to the specified directory of the current project
        /// </summary>
        /// <param name="_sourceFilePath">Source file</param>
        /// <param name="_destFilePath">Dest file</param>
        /// <param name="_suffix">file suffix</param>
        /// <returns>Asset path in current project</returns>
        public static string CopyFileToProject(string _sourceFilePath, string _destFilePath, string _suffix = null)
        {
            if (!File.Exists(_sourceFilePath))
            {
                return null;
            }

            string tmp_FileName = new DirectoryInfo(_sourceFilePath).Name.ToLower();
            string tmp_DestPath;
            if (!string.IsNullOrEmpty(_suffix))
                tmp_DestPath = Path.Combine(_destFilePath, tmp_FileName) + "." + _suffix;
            else
                tmp_DestPath = Path.Combine(_destFilePath, tmp_FileName);

            File.Copy(_sourceFilePath, tmp_DestPath, true);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            return ShortenPath(tmp_DestPath);
        }


        public static bool RightClicked(Rect _area)
        {
            return Event.current.type == EventType.ContextClick
                   && Event.current.button == 1
                   && _area.Contains(Event.current.mousePosition);
        }

        // public static void SaveProjectConfigCache(ProjectListElementModel _project, string _destFilePath)
        // {
        //     if (!Directory.Exists(_destFilePath))
        //         Directory.CreateDirectory(_destFilePath);
        //
        //     var tmp_ConfigCache = JsonUtility.ToJson(_project);
        //     File.WriteAllText(Path.Combine(_destFilePath, "ConfigCacheJson.json"), tmp_ConfigCache, Encoding.UTF8);
        //     AssetDatabase.Refresh();
        // }

        // public static void ReadProjectConfigCache(string _destFilePath, out ProjectListElementModel _projectListElement)
        // {
        //     try
        //     {
        //         var tmp_AllText = File.ReadAllText(_destFilePath, Encoding.UTF8);
        //         _projectListElement = JsonUtility.FromJson<ProjectListElementModel>(tmp_AllText);
        //     }
        //     catch (Exception tmp_Exception)
        //     {
        //         Debug.LogError(tmp_Exception.Message);
        //         _projectListElement = null;
        //
        //     }
        // }


        public static void ReadProjectConfigCache(string _destFilePath, out ProjectModel _projectModel)
        {
            try
            {
                var tmp_AllText = File.ReadAllText(_destFilePath, Encoding.UTF8);
                _projectModel = JsonUtility.FromJson<ProjectModel>(tmp_AllText);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                _projectModel = null;
            }
        }

//        public static Texture2D GenerateQrCode(string _qrMessage)
//        {
//            var tmp_QrCodeTexture = new Texture2D(256, 256, TextureFormat.RGB24, false);
//            tmp_QrCodeTexture.SetPixels32(Encode(_qrMessage, 256, 256));
//            tmp_QrCodeTexture.Apply(false);
//            return tmp_QrCodeTexture;
//        }

//        private static Color32[] Encode(string _formatStr, int _width, int _height)
//        {
//            var tmp_Writer = new BarcodeWriter
//            {
//                Format = BarcodeFormat.QR_CODE,
//                Options = new QrCodeEncodingOptions
//                {
//                    Height = _height,
//                    Width = _width    
//                }
//            };
//            return tmp_Writer.Write(_formatStr);
//        }
        internal static async Task<Texture2D> TextureDownloader(string _url)
        {
            if (string.IsNullOrEmpty(_url) || !IsUrl(_url)) return null;
            UnityWebRequest tmp_WebRequest = UnityWebRequestTexture.GetTexture(_url);
            await tmp_WebRequest.SendWebRequest();
            switch (tmp_WebRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.ProtocolError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(tmp_WebRequest.error);
                    break;
            }

            return DownloadHandlerTexture.GetContent(tmp_WebRequest);
        }


        public static string GetScriptAssembliesFolder =>
            Application.dataPath.Replace("Assets", "Library/ScriptAssemblies/");


        /// <summary>
        /// Get the path to the assembly file
        /// </summary>
        /// <param name="_source">The assembly file</param>
        /// <returns>True:Current XR-MOD project has editing,otherwise.</returns>
        public static bool GetProjectScriptAssemblyFullName(out string _source)
        {
            _source = string.Empty;

            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            if (string.IsNullOrEmpty(tmp_ProjectDetailCacheData.Configures.DomainName)) return false;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name);
            _source = $"{tmp_SourceFilePath}.runtime.dll";
            return true;
        }
        
        
        /// <summary>
        /// Get the path to the assembly file
        /// </summary>
        /// <param name="_source">The assembly file</param>
        /// <returns>True:Current XR-MOD project has editing,otherwise.</returns>
        public static bool GetCustomPluginAssemblyFullName(out string _source)
        {
            _source = string.Empty;

            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            if (string.IsNullOrEmpty(tmp_ProjectDetailCacheData.Configures.DomainName)) return false;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name);
            _source = $"{tmp_SourceFilePath}.runtime.ClrBinding.dll";
            return true;
        }

        public static bool GetRuntimeScriptPath(out string _dest)
        {
            _dest = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            _dest = Path.Combine(tmp_ProjectDetailCacheData.GetProjectPath(), "Scripts/Runtime");

            return true;
        }

        public static bool GetAutomaticGeneratedPath(out string _dest)
        {
            _dest = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            _dest = Path.Combine(tmp_ProjectDetailCacheData.GetProjectPath(), "AutomaticGenerated");

            if (!Directory.Exists(_dest))
                Directory.CreateDirectory(_dest);
            return true;
        }

        public static bool GetNamespace(out string _namespace)
        {
            _namespace = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;
            _namespace = tmp_ProjectDetailCacheData.Configures.DomainName;
            return true;
        }

        public static bool GetProjectName(out string _projectName)
        {
            _projectName = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;
            _projectName = tmp_ProjectDetailCacheData.Configures.ProjectName;
            return true;
        }

        public static bool MakeSureProjectDetailData(out ProjectDetailCacheData _data)
        {
            _data = null;
            if (PackageToolsEditor.ALL_PROJECT_CACHE == null) return false;
            if (PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData() == null) return false;
            var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (!tmp_EditingProjectData) return false;
            _data = tmp_EditingProjectData.DetailCacheData;
            return true;
        }

        /// <summary>
        /// Create the script assemble
        /// </summary>
        /// <param name="_fileName"></param>
        /// <param name="_suffix"></param>
        /// <param name="_path"></param>
        /// <param name="_includePlatforms"></param>
        /// <param name="_references"></param>
        public static void GenerationASMDEF(string _fileName, string _suffix, string _path,
            List<string> _includePlatforms,
            List<string> _references)
        {
            var tmp_FileName = !string.IsNullOrEmpty(_suffix) ? $"{_fileName}.{_suffix}" : _fileName;

            //Create assembly defined
            var tmp_RuntimeAssemblyDefined = new AssemblyDataModel
            {
                name = tmp_FileName,
                autoReferenced = true,
                allowUnsafeCode = true,
                includePlatforms = _includePlatforms,
                references = _references,
                rootNamespace = tmp_FileName
            };

            string tmp_RuntimeAssemblyDefinedJson = JsonUtility.ToJson(tmp_RuntimeAssemblyDefined);
            File.WriteAllText(Path.Combine(_path, $"{tmp_FileName}.asmdef"),
                tmp_RuntimeAssemblyDefinedJson);
        }
    }
}