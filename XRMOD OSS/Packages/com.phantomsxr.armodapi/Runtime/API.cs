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
using System.Threading.Tasks;
using com.Phantoms.ARMODPackageTools.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.Video;
using Object = UnityEngine.Object;
using com.Phantoms.ActionNotification.Runtime;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace com.Phantoms.ARMODAPI.Runtime
{
    public class API
    {
        private readonly string projectName;

        /// <summary>
        /// Create API instance
        /// </summary>
        /// <param name="_projectName">current project name</param>
        public API(string _projectName)
        {
            projectName = _projectName;
        }

        #region Project or Apps

        /// <summary>
        /// Get current ARExperience project info.
        /// For example you want to use for restful api
        /// </summary>
        /// <returns>Project Info</returns>
        public string TryAcquireProjectInfo()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireProjectInfo), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Get current App temporary cache Path.
        /// </summary>
        /// <returns>Temporary Cache Path</returns>
        public string TryAcquireTemporaryCachePath()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireTemporaryCachePath), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// Get current sdk type
        /// </summary>
        /// <returns>Current sdk type</returns>
        public string TryAcquireSdkType()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireSdkType), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Get the custom config data from SDK[2.0.0-pre.12]
        /// </summary>
        /// <returns>Config data</returns>
        public string TryAcquireLaunchConfig()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireCustomConfig), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region UGUI

        private GraphicRaycaster graphicRaycaster;
        private static readonly int _SKYBOX_CUBEMAP_TEX = Shader.PropertyToID("_Tex");

        /// <summary>
        /// It is used to determine whether ugui objects are touched.
        /// Prevent raycast ray penetration when clicking ugui objects.
        /// </summary>
        /// <returns>True:Touch ugui object,False:Not touching the UGUI object</returns>
        public bool IsPointerOverUi()
        {
            var tmp_CurrentEventSystem = EventSystem.current;
            if (!tmp_CurrentEventSystem) return false;

            PointerEventData tmp_EventData = new PointerEventData(EventSystem.current)
            {
                pressPosition = Input.mousePosition,
                position = Input.mousePosition
            };

            List<RaycastResult> tmp_List = new List<RaycastResult>();
            if (null == graphicRaycaster)
                graphicRaycaster = Object.FindObjectOfType<GraphicRaycaster>();
            else
                graphicRaycaster.Raycast(tmp_EventData, tmp_List);
            return tmp_List.Count > 0;
        }

        #endregion

        #region KV

        /// <summary>
        /// Store temporary data locally
        /// </summary>
        /// <param name="_key">Unique name</param>
        /// <param name="_value">Data that needs to be saved</param>
        public void SaveKeyAndValue(string _key, string _value)
        {
            PlayerPrefs.SetString(projectName + _key, _value);
        }

        /// <summary>
        /// Read data temporarily stored on the device
        /// </summary>
        /// <param name="_key">Unique name</param>
        /// <returns>The data queried</returns>
        public string GetValueByKey(string _key)
        {
            return PlayerPrefs.GetString(projectName + _key);
        }

        /// <summary>
        /// Removes data and index fields that are temporarily stored locally
        /// </summary>
        /// <param name="_key">Unique name</param>
        public void RemoveKeyAndValue(string _key)
        {
            PlayerPrefs.DeleteKey(_key);
        }

        #endregion

        #region Asset loader

        /// <summary>
        /// Load a unity asset from our package by project name and wanna load asset name.
        /// </summary>
        /// <param name="_wannaLoadedAssetName">you wanna load asset name</param>
        /// <param name="_loadedCallback">call back when loaded</param>
        /// <typeparam name="T">Unity Object</typeparam>
        public void LoadAsset<T>(string _wannaLoadedAssetName, Action<T> _loadedCallback) where T : Object
        {
            BasePackageLoaderUtility.LoadAssetFromPackage(projectName, _wannaLoadedAssetName, _loadedCallback);
        }

        /// <summary>
        /// Away/Task. Load asset from package by project name.
        /// </summary>
        /// <param name="_wannaLoadedAssetName"></param>
        /// <typeparam name="T">Unity Object</typeparam>
        /// <returns>Task</returns>
        public async Task<T> LoadAssetAsync<T>(string _wannaLoadedAssetName) where T : Object
        {
            return await BasePackageLoaderUtility.LoadAssetFromPackage<T>(projectName, _wannaLoadedAssetName);
        }

        /// <summary>
        /// Load the Gltf model from the network
        /// </summary>
        /// <param name="_url">gltf file url</param>
        /// <param name="_result">acquired callback</param>
        public void TryAcquireNetworkMesh(string _url, Action<GameObject> _result = null)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.TryAcquireNetworkMesh), new BaseNotificationData()
                {
                    BaseData = _url,
                    NotificationActWithData = _resultData =>
                    {
                        if (_resultData is GameObject tmp_GameObject)
                        {
                            _result?.Invoke(tmp_GameObject);
                        }
                    }
                });
        }


        /// <summary>
        /// Download the model from the url ,and caching it on local. Will not be instantiated.
        /// </summary>
        /// <param name="_url">gltf file url</param>
        /// <param name="_result">acquired callback</param>
        public void DownloadNetworkMesh(string _url, Action<string> _result = null)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.DownloadMesh), new BaseNotificationData()
                {
                    BaseData = _url,
                    NotificationActWithData = _resultData =>
                    {
                        if (_resultData is string tmp_LocalPath)
                        {
                            _result?.Invoke(tmp_LocalPath);
                        }
                    }
                });
        }

        #endregion

        #region Device

        /// <summary>
        /// Get the device's info
        /// </summary>
        /// <returns>devices info-Json</returns>
        public string GetDeviceInfo()
        {
            DeviceInfo tmp_DeviceInfo = new DeviceInfo()
            {
                deviceModel = SystemInfo.deviceModel,
                deviceName = SystemInfo.deviceName,
                deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier,
                graphicsDeviceName = SystemInfo.graphicsDeviceName,
                graphicsDeviceType = SystemInfo.deviceType.ToString(),
                graphicsDeviceVendor = SystemInfo.graphicsDeviceVendor,
                graphicsDeviceVersion = SystemInfo.graphicsDeviceVersion,
                graphicsDeviceID = SystemInfo.graphicsDeviceID,
                graphicsDeviceVendorID = SystemInfo.graphicsDeviceVendorID,
                graphicsMemorySize = SystemInfo.graphicsMemorySize,
                graphicsMultiThreaded = SystemInfo.graphicsMultiThreaded,
                graphicsShaderLevel = SystemInfo.graphicsShaderLevel,
                maxTextureSize = SystemInfo.maxTextureSize,
                npotSupport = SystemInfo.npotSupport.ToString(),
                operatingSystem = SystemInfo.operatingSystem,
                processorCount = SystemInfo.processorCount,
                processorFrequency = SystemInfo.processorFrequency,
                processorType = SystemInfo.processorType,
                supportedRenderTargetCount = SystemInfo.supportedRenderTargetCount,
                supports2DArrayTextures = SystemInfo.supports2DArrayTextures,
                supports3DTextures = SystemInfo.supports3DTextures,
                supportsAccelerometer = SystemInfo.supportsAccelerometer,
                supportsAudio = SystemInfo.supportsAudio,
                supportsComputeShaders = SystemInfo.supportsComputeShaders,
                supportsGyroscope = SystemInfo.supportsGyroscope,
                supportsImageEffects = true,
                supportsLocationService = SystemInfo.supportsLocationService,
                supportsMotionVectors = SystemInfo.supportsMotionVectors,
                supportsVibration = SystemInfo.supportsVibration,
                systemMemorySize = SystemInfo.systemMemorySize,
                unsupportedIdentifier = SystemInfo.unsupportedIdentifier
            };
            return JsonUtility.ToJson(tmp_DeviceInfo);
        }


        /// <summary>
        /// Acquire system language
        /// </summary>
        /// <returns>system language</returns>
        public string GetSystemLanguage()
        {
            return Application.systemLanguage.ToString();
        }


        /// <summary>
        /// set up the screen orientation
        /// </summary>
        /// <param name="_orientation">screen orientation</param>
        public void SetScreenOrientation(ScreenOrientation _orientation)
        {
            Screen.orientation = _orientation;
        }

        #endregion

        #region Media

        public void MediaRecorder(bool _stop, bool _takePhotoMode)
        {
            if (_takePhotoMode)
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.TakePhoto),
                    new BaseNotificationData());
            }
            else
            {
                if (_stop)
                {
                    ActionNotificationCenter.DefaultCenter.PostNotification(
                        nameof(ActionParameterDataType.StopVideoRecording), new BaseNotificationData());
                    return;
                }

                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.StartVideoRecording), new BaseNotificationData());
            }
        }

        #endregion

        #region AR

#if UNITY_IOS || UNITY_ANDROID
        /// <summary>
        /// Resize the AR world scale
        /// </summary>
        /// <param name="_worldScale">new world scale</param>
        public void ResizeARWorldScale(float _worldScale)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ResizeARWorldScale),
                new ResizeARWorldScaleNotificationData() {WorldScale = _worldScale});
        }

        /// <summary>
        /// Addition AR algorithm, It will allow multiple algorithms to be mixed.
        /// </summary>
        /// <param name="_data"></param>
        public void ChangeARAlgorithmLife(ARAlgorithmNotificationData _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ARAlgorithmLifeCTRL),
                _data);
        }

        /// <summary>
        /// This does not move the content; instead, it moves and orients the ARSessionOrigin
        /// such that the content appears to be at the raycast hit position.
        /// </summary>
        /// <param name="_contentTrans">LookAt transform</param>
        /// <param name="_position">Position of content appears</param>
        /// <param name="_rotation">Rotation of content appears</param>
        public void MakeContentAppearAt(Transform _contentTrans, Vector3 _position, Quaternion _rotation)
        {
            MakeContentAppearAtNotificationData tmp_NotificationData = new MakeContentAppearAtNotificationData()
            {
                Position = _position,
                Rotation = _rotation,
                ContentTrans = _contentTrans
            };

            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.MakeContentAppearAt),
                tmp_NotificationData);
        }

        /// <summary>
        /// Cast a ray from a point in screen space against trackables,
        /// that is, detected features such as planes.
        /// </summary>
        /// <param name="_inputPosition">input point</param>
        /// <param name="_trackableType">trackable type</param>
        /// <param name="_callback">cast callback</param>
        public void ARRaycast(Vector3 _inputPosition,
            TrackableTypeEnum _trackableType = TrackableTypeEnum.PlaneWithinPolygon,
            Action<Pose> _callback = null)
        {
            ARRaycastNotificationData tmp_NotificationData = new ARRaycastNotificationData();
            tmp_NotificationData.ScreenPoint = _inputPosition;
            tmp_NotificationData.TrackableType = _trackableType;
            tmp_NotificationData.NotificationActWithData = _result =>
            {
                if (_result is not Pose tmp_Pose) return;
                _callback?.Invoke(tmp_Pose);
            };
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ARRaycast),
                tmp_NotificationData);
        }

        /// <summary>
        /// Get current AR frame
        /// </summary>
        /// <returns>It maybe null, plz attention</returns>
        public Texture2D TryAcquireCurrentFrame(TryAcquireCurrentFrameNotificationData _data)
        {
            var tmp_Objects = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireCurrentFrame), _data);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return null;
            if (tmp_Objects[0] is Texture2D tmp_Texture2D)
                return tmp_Texture2D;
            return null;
        }

        /// <summary>
        /// Get AR Occlusion frame. SDK 0.0.2
        /// </summary>
        /// <returns>AR Occlusion frame texture2d. It maybe null, plz attention</returns>
        public Texture2D TryAcquireAROcclusionFrame(AROcclusionNotificationData _data)
        {
            var tmp_Objects =
                ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.TryAcquireAROcclusionFrame), _data);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return null;
            if (tmp_Objects[0] is Texture2D tmp_Texture2D)
                return tmp_Texture2D;
            return null;
        }

        /// <summary>
        /// Get light estimate value
        /// </summary>
        /// <returns>It maybe null, plz attention</returns>
        public Light TryAcquireLightEstimateValue()
        {
            var tmp_Objects = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireLightEstimateValue), null);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return null;
            if (tmp_Objects[0] is Light tmp_Light)
                return tmp_Light;
            return null;
        }

        /// <summary>
        /// Check whether the current device supports ARKit or ARCore.
        /// </summary>
        /// <returns>True:Supports,False:otherwise</returns>
        public bool CheckARAvailability()
        {
            var tmp_Objects =
                ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.CheckARAvailability), null);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return false;
            if (tmp_Objects[0] is string tmp_Availability)
                return tmp_Availability.Equals("True");
            return false;
        }
#endif


#if UNITY_IOS || UNITY_ANDROID || UNITY_WEBGL || UNITY_EDITOR
        /// <summary>
        /// Check AR features is support on current device
        /// </summary>
        /// <param name="_featureName"></param>
        /// <returns></returns>
        public bool CheckFeatureAvailability(string _featureName)
        {
            var tmp_BaseData = new BaseNotificationData {BaseData = _featureName};
            var tmp_Results =
                ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.CheckARFeaturesAvailability), tmp_BaseData);
            if (tmp_Results == null || tmp_Results.Count == 0) return false;
            if (tmp_Results[0] is string tmp_Availability)
                return tmp_Availability.Equals("True");
            return false;
        }
#endif

        /// <summary>
        /// Get current sdk version
        /// </summary>
        /// <returns>SDK Version string</returns>
        public string TryAcquireSDKVersion()
        {
            var tmp_VersionObjects = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireSDKVersion),
                null);
            if (tmp_VersionObjects != null && tmp_VersionObjects.Count > 0) return tmp_VersionObjects[0] as string;
            return null;
        }


        /// <summary>
        /// Exit the AR
        /// </summary>
        public void Exit()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.Exit), null);
        }

        /// <summary>
        /// Create an anchor and place game object. If you are main algorithm mode is not a `Anchor`, you must call `AdditionARAlgorithm` to activate it.
        /// </summary>
        /// <param name="_anchorNotification">Data sent to the anchor manager</param>
        public void StickObject(AnchorNotificationData _anchorNotification)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.StickObject),
                _anchorNotification);
        }

        #endregion

        #region Native API

        /// <summary>
        /// Use the built-in browser of the app to open the url
        /// </summary>
        /// <param name="_data">Data sent to the built-in browser</param>
        public void OpenBuiltInBrowser(OpenBuiltInNotificationData _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OpenBuiltInBrowser), _data);
        }


        /// <summary>
        /// Try Acquire App Info
        /// </summary>
        /// <param name="_data">Try acquire operation type</param>
        public void TryAcquireAppInfo(TryAcquireAppInfoNotificationData _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.TryAcquireAppInfo), _data);
        }


        /// <summary>
        /// Send the message to sdk, the message can be a string or json.
        /// When this method is called the [ReceivedMessage] method on the SDK side will receive the sent message.[2.0.0-pre.12]
        /// </summary>
        /// <param name="_data">Will send message data</param>
        public void SendMessageToSDK(string _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SendMessageToSDK),
                new BaseNotificationData()
                {
                    BaseData = _data,
                    ActionName = nameof(SendMessageToSDK)
                });
        }

        #endregion

        #region Graphices

        /// <summary>
        /// Custom Render Pipe Profile
        /// </summary>
        /// <param name="_pipelineAsset">Render pipe profile</param>
        public void OverrideRenderPipelineAtRuntime(UniversalRenderPipelineAsset _pipelineAsset)
        {
            if (QualitySettings.renderPipeline == null) return;
            QualitySettings.SetQualityLevel(4, true);
            QualitySettings.renderPipeline = _pipelineAsset;
        }


        /// <summary>
        /// Custom skybox
        /// </summary>
        /// <param name="_material">Skybox material</param>
        public void OverrideSkyBox(Material _material)
        {
            RenderSettings.skybox = _material;
            RenderSettings.defaultReflectionMode = DefaultReflectionMode.Custom;
#if UNITY_2022
            RenderSettings.customReflectionTexture = _material.GetTexture(_SKYBOX_CUBEMAP_TEX);
#else
            RenderSettings.customReflection = _material.GetTexture(_SKYBOX_CUBEMAP_TEX);
#endif
            var tmp_ReflectionProbes = Object.FindObjectsOfType<ReflectionProbe>();
            foreach (ReflectionProbe tmp_ReflectionProbe in tmp_ReflectionProbes)
            {
                tmp_ReflectionProbe.RenderProbe();
            }
        }

        #endregion
    }
}