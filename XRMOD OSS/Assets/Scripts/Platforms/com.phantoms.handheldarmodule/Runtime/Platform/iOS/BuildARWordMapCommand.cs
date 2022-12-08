// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.Models;
using Unity.Collections;
using UnityEngine;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;
#if UNITY_IOS
using UnityEngine.XR.ARKit;

namespace HandheldARModule.Runtime.Platform.iOS
{
    public class BuildARWordMapCommand : ICommand, IReleaseCommand
    {
        private IEnumerator loadCoroutine;
        private IEnumerator saveCoroutine;

        public BuildARWordMapCommand()
        {
            Execute();
        }

        public void Execute()
        {
            var tmp_Notify = ActionNotificationCenter.DefaultCenter;
            tmp_Notify.AddObserver(OnARWordMapLoadNotification, nameof(ActionParameterDataType.LoadARWordMap));
            tmp_Notify.AddObserver(OnARWordMapSaveNotification, nameof(ActionParameterDataType.SaveARWordMap));
        }

        public void Release()
        {
            var tmp_Notify = ActionNotificationCenter.DefaultCenter;
            tmp_Notify.RemoveObserver(nameof(ActionParameterDataType.LoadARWordMap));
            tmp_Notify.RemoveObserver(nameof(ActionParameterDataType.SaveARWordMap));
            var tmp_Mono = Object.FindObjectOfType<MonoBehaviour>();
            if (loadCoroutine != null)
            {
                tmp_Mono.StopCoroutine(loadCoroutine);
                loadCoroutine = null;
            }

            if (saveCoroutine != null)
            {
                tmp_Mono.StopCoroutine(saveCoroutine);
                saveCoroutine = null;
            }
        }


        void OnARWordMapLoadNotification(BaseNotificationData _baseNotification)
        {
            if (!string.IsNullOrEmpty(_baseNotification.BaseData))
            {
                IocContainer.GetIoc.Resolve<ARContextDataModel>().ARKitWordMapSavePath = _baseNotification.BaseData;
            }

            loadCoroutine = LoadARWordMapData();
            Object.FindObjectOfType<MonoBehaviour>().StartCoroutine(loadCoroutine);
        }

        void OnARWordMapSaveNotification(BaseNotificationData _baseNotification)
        {
            if (!string.IsNullOrEmpty(_baseNotification.BaseData))
            {
                IocContainer.GetIoc.Resolve<ARContextDataModel>().ARKitWordMapSavePath = _baseNotification.BaseData;
            }

            saveCoroutine = SaveARWordMapData();
            Object.FindObjectOfType<MonoBehaviour>().StartCoroutine(saveCoroutine);
        }

        void SaveAndDisposeWorldMap(ARWorldMap _worldMap)
        {
            var tmp_ARWordMapPath = IocContainer.GetIoc.Resolve<ARContextDataModel>().ARKitWordMapSavePath;
            var tmp_Data = _worldMap.Serialize(Allocator.Temp);

            if (File.Exists(tmp_ARWordMapPath))
                File.Delete(tmp_ARWordMapPath);

            var tmp_ARWordMapFile = File.Open(tmp_ARWordMapPath, FileMode.Create);
            var tmp_Writer = new BinaryWriter(tmp_ARWordMapFile);
            tmp_Writer.Write(tmp_Data.ToArray());
            tmp_Writer.Close();
            tmp_Data.Dispose();
            _worldMap.Dispose();
            tmp_ARWordMapFile.Close();
            Debug.Log($"ARWorldMap written to {tmp_ARWordMapPath}");
        }

        IEnumerator SaveARWordMapData()
        {
            var tmp_SessionSubsystem =
                (ARKitSessionSubsystem) IocContainer.GetIoc.Resolve<ARComponentModel>().ARSession.subsystem;
            if (tmp_SessionSubsystem == null)
            {
                Debug.LogError(ConstKey.CONST_NO_SESSION_ERROR);
                yield break;
            }

            var tmp_Request = tmp_SessionSubsystem.GetARWorldMapAsync();

            while (!tmp_Request.status.IsDone())
                yield return null;

            if (tmp_Request.status.IsError())
            {
                Debug.LogError($"Session serialization failed with status {tmp_Request.status}");
                yield break;
            }

            var tmp_WorldMap = tmp_Request.GetWorldMap();
            tmp_Request.Dispose();
            SaveAndDisposeWorldMap(tmp_WorldMap);
        }

        IEnumerator LoadARWordMapData()
        {
            var tmp_SessionSubsystem =
                (ARKitSessionSubsystem) IocContainer.GetIoc.Resolve<ARComponentModel>().ARSession.subsystem;
            var tmp_ARWordMapPath = IocContainer.GetIoc.Resolve<ARContextDataModel>().ARKitWordMapSavePath;

            if (tmp_SessionSubsystem == null)
            {
                Debug.Log(ConstKey.CONST_NO_SESSION_ERROR);
                yield break;
            }

            var tmp_ARWordMapFile = File.Open(tmp_ARWordMapPath, FileMode.Open);

            const int tmp_const_BytesPerFrame = 1024 * 10;
            var tmp_BytesRemaining = tmp_ARWordMapFile.Length;
            var tmp_BinaryReader = new BinaryReader(tmp_ARWordMapFile);
            var tmp_AllBytes = new List<byte>();
            while (tmp_BytesRemaining > 0)
            {
                var tmp_Bytes = tmp_BinaryReader.ReadBytes(tmp_const_BytesPerFrame);
                tmp_AllBytes.AddRange(tmp_Bytes);
                tmp_BytesRemaining -= tmp_const_BytesPerFrame;
                yield return null;
            }

            var tmp_Data = new NativeArray<byte>(tmp_AllBytes.Count, Allocator.Temp);
            tmp_Data.CopyFrom(tmp_AllBytes.ToArray());

            if (ARWorldMap.TryDeserialize(tmp_Data, out var tmp_WorldMap))
                tmp_Data.Dispose();
            else
                tmp_Data.Dispose();

            if (tmp_WorldMap.valid)
            {
                tmp_SessionSubsystem.ApplyWorldMap(tmp_WorldMap);
            }
            else
            {
                Debug.LogError(ConstKey.CONST_INVALID_ARWORD_DATA);
                throw new Exception(ConstKey.CONST_INVALID_ARWORD_DATA);
            }


            tmp_BinaryReader.Close();
            tmp_ARWordMapFile.Close();
        }
    }
}
#endif