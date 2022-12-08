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
using UnityEngine;
using NativePlugins.Plugin;
using UnityEngine.SceneManagement;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ILRuntime.Runtime;
using com.phantoms.models.Runtime;
using SDKEntry.Runtime.DataRequest;
using SDKEntry.Runtime.Models;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

// ReSharper disable once CheckNamespace
namespace SDKEntry.Runtime
{
    public class SDKEntryPoint : MonoBehaviour
    {
        private CodesHook codesHook;
        private SDKEntryPointModel sdkEntryPointModel;
        private bool awakeInvoked;

        #region Unity Callback

        /// <summary>
        /// Setup this game object not destroy on load new scene
        /// </summary>
        private void Awake()
        {
            DontDestroyOnLoad(this);

            // Let developer know xr-mod engine was launching
            // Sometimes developer need display the xr module launch UI/UX to tell user XR Module launching
            NativeAPI.OnXrModLaunch();

            // Malloc the module
            new ModuleDependenceRegisterHandler().Handle();

            // Caching the sdk entry point model
            sdkEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();

            // Access the XR-Module and we need to converted to IFetchModule.
            // Because we will add event for query server data.
            ActionNotificationCenter.DefaultCenter.AddObserver(_ =>
                {
                    var tmp_ProjectUid = IocContainer.GetIoc.Resolve<BaseContextDataModel>().ProjectUid;
                    var tmp_BuildLoadingUIHandler = new BuildLoadingUIHandler();
                    var tmp_GetARExperienceProjectHandler =
                        new FetchXRResourcesHandler(NetworkRequestType.InfoByUId, tmp_ProjectUid);
                    var tmp_CacheProjectInformationHandler = new CacheProjectInformationHandler();
                    var tmp_OversizeCheckHandler = new OversizeCheckHandler();
                    var tmp_GetXRPackageConfigHandler = new GetXRPackageConfigHandler();
                    var tmp_SdkVersionCheckHandler = new SdkVersionCheckHandler();
                    var tmp_LaunchXRModuleHandler = new LaunchXRModuleHandler();
                    var tmp_RemoveLoadingUIHandler = new RemoveLoadingUIHandler();
                    var tmp_CreateUIEventSystemHandler = new CreateUIEventSystemHandler();
                    var tmp_AddExceptionCollectorHandler = new AddExceptionCollectorHandler();

                    tmp_BuildLoadingUIHandler
                        .SetNext(tmp_GetARExperienceProjectHandler)
                        .SetNext(tmp_CacheProjectInformationHandler)
                        .SetNext(tmp_OversizeCheckHandler)
                        .SetNext(tmp_GetXRPackageConfigHandler)
                        .SetNext(tmp_SdkVersionCheckHandler)
                        .SetNext(tmp_LaunchXRModuleHandler)
                        .SetNext(tmp_RemoveLoadingUIHandler)
                        .SetNext(tmp_CreateUIEventSystemHandler)
                        .SetNext(tmp_AddExceptionCollectorHandler);
                    tmp_BuildLoadingUIHandler.Handle();
                },
                nameof(ActionParameterDataType.FetchProjectDetail));
            // Listen CodeHook allocation status
            IocContainer.GetIoc.Resolve<BaseContextDataModel>().CodeHook.OnValueChanged += _hook =>
            {
                if (_hook != null)
                    codesHook = _hook;
            };

            // Entry main scene
            SceneManager.sceneLoaded += OnSceneLoad;
            SceneManager.LoadScene(nameof(SceneTags.Main), LoadSceneMode.Single);
            awakeInvoked = true;
        }


        /// <summary>
        /// Update event for XR-MOD hot-codes
        /// </summary>
        private void Update()
        {
            codesHook?.OnUpdate();
        }

        #endregion


        #region SDK Interface

        /// <summary>
        /// Init sdk with configure
        /// </summary>
        /// <param name="_config">config string</param>
        public void InitSDK(string _config)
        {
            try
            {
                if (!awakeInvoked)
                    Awake();

                var tmp_SDKConfig = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration;
                tmp_SDKConfig.OnValueChanged += _ =>
                {
                    if (tmp_SDKConfig.Value.AppModel == AppModel.Offline)
                    {
                        IocContainer.GetIoc.Resolve<OfflineLicenseValidator>().Execute();
                    }

                    sdkEntryPointModel.SdkInitialed.Value = true;
                };

                tmp_SDKConfig.Value = JsonUtility.FromJson<SDKConfiguration>(_config);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                NativeAPI.ThrowException(nameof(ErrorCode.INIT_SDK_FAILED),
                    (int) ErrorCode.INIT_SDK_FAILED);
                throw;
            }
        }


        /// <summary>
        /// Query AR experiences content with id
        /// </summary>
        /// <param name="_arExperiencesId">AR experiences id</param>
        public void LaunchXRQuery(string _arExperiencesId)
        {
            try
            {
                Assert.IsNotNull(sdkEntryPointModel, "sdkEntryPointModel == null");
                if (!sdkEntryPointModel.SdkInitialed.Value)
                {
                    Debug.LogError($"SDK is not initialized. [{nameof(LaunchXRQuery)}] will be not working!");
                    return;
                }

                var tmp_BaseContextDataModel = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
                Assert.IsNotNull(tmp_BaseContextDataModel, "tmp_BaseContextDataModel == null");
                tmp_BaseContextDataModel.ProjectUid = _arExperiencesId;
                var tmp_Module = IocContainer.GetIoc.Resolve<IModule>();
                Assert.IsNotNull(tmp_Module, "tmp_Module == null");
                tmp_Module.StartModule();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        #region Image recognization

        /// <summary>
        /// API for native app, querying project through pictures. It's a loop.
        /// </summary>
        public void LaunchARScanner()
        {
            if (!sdkEntryPointModel.SdkInitialed.Value) return;
            // StartCoroutine(AlgorithmCreator.CheckAvailability(_state =>
            // {
            //     CheckAvailabilityCallback(_state);
            //     if (imageCloudRecognizer == null)
            //     {
            //         CreateImageCloudRecognizerHandler();
            //         NativeAPI.RecognitionStart();
            //     }
            //
            //     InvokeRepeating(nameof(RepeatRecognizer), 3f,
            //         sdkConfiguration.imageCloudRecognizerConfig.frequencyOfScan);
            // }));
        }

        /// <summary>
        /// Querying project through pictures
        /// </summary>
        private void RepeatRecognizer()
        {
            var tmp_MaximumOfRetries = IocContainer.GetIoc.Resolve<SDKConfiguration>().imageCloudRecognizerConfig
                .maximumOfRetries;
            if (sdkEntryPointModel.MaximumOfRetries.Value >= tmp_MaximumOfRetries)
            {
                StopRecognizer();
                NativeAPI.ThrowException(nameof(ErrorCode.REACHED_MAXIMUM_OF_RETRIES),
                    (int) ErrorCode.REACHED_MAXIMUM_OF_RETRIES);
                return;
            }


            // imageCloudRecognizer.StartAlgorithm();
            sdkEntryPointModel.MaximumOfRetries.Value++;
        }

        /// <summary>
        /// Create a handler for querying project through pictures
        /// </summary>
        private void CreateImageCloudRecognizerHandler()
        {
            // imageCloudRecognizer = AlgorithmCreator.ImageCloudRecognizer(_tag =>
            // {
            //     StopRecognizer(true);
            //     NativeAPI.RecognitionComplete();
            //     TryAcquireDataOperation(_tag, NetworkRequestType.ProjectInfoQueryByMarker);
            // }, sdkConfiguration.imageCloudRecognizerConfig.gateway);
        }

        /// <summary>
        /// Stop auto recognize 
        /// </summary>
        /// <param name="_stopAll">Stop all recognition processes</param>
        private void StopRecognizer(bool _stopAll = false)
        {
            CancelInvoke(nameof(RepeatRecognizer));

            if (_stopAll)
            {
                // imageCloudRecognizer?.StopAlgorithm();
                // imageCloudRecognizer = null;
            }

            sdkEntryPointModel.MaximumOfRetries.Value = 0;
        }

        #endregion

        /// <summary>
        /// Close SDK
        /// </summary>
        public bool Dispose()
        {
            try
            {
                // Avoid crashes caused by coroutines or calls
                foreach (MonoBehaviour tmp_Behaviour in FindObjectsOfType<MonoBehaviour>())
                {
                    tmp_Behaviour.CancelInvoke();
                    tmp_Behaviour.StopAllCoroutines();
                }

                StopRecognizer(true);

                new DisposeXRMODEngineHandler().Handle();

                //Broken the AR session
                SceneManager.LoadScene(nameof(SceneTags.Clear), LoadSceneMode.Single);

                awakeInvoked = false;
                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
                //return false;
            }
        }


        /// <summary>
        /// Set the display direction of the AR view
        /// </summary>
        /// <param name="_orientation">Display direction enumeration</param>
        // ReSharper disable once InconsistentNaming
        public void SetUIInterfaceOrientation(string _orientation)
        {
            Screen.orientation = (ScreenOrientation) int.Parse(_orientation);
        }

        /// <summary>
        /// clean all cache
        /// </summary>
        public void CleanCache()
        {
            if (Caching.ClearCache())
            {
                Debug.Log("Cache was cleaned");
            }
        }

        /// <summary>
        /// Call this method will continue to download the assets
        /// </summary>
        public void ContinueToDownloadAssets()
        {
            if (!sdkEntryPointModel.BreakDownloadWhenGreaterPresetSize.Value) return;
            sdkEntryPointModel.BreakDownloadWhenGreaterPresetSize.Value = false;
            var tmp_GetXRPackageConfigHandler = new GetXRPackageConfigHandler();
            var tmp_SdkVersionCheckHandler = new SdkVersionCheckHandler();
            var tmp_LaunchXRModuleHandler = new LaunchXRModuleHandler();
            var tmp_RemoveLoadingUIHandler = new RemoveLoadingUIHandler();
            var tmp_CreateUIEventSystemHandler = new CreateUIEventSystemHandler();
            var tmp_AddExceptionCollectorHandler = new AddExceptionCollectorHandler();

            tmp_GetXRPackageConfigHandler
                .SetNext(tmp_SdkVersionCheckHandler)
                .SetNext(tmp_LaunchXRModuleHandler)
                .SetNext(tmp_RemoveLoadingUIHandler)
                .SetNext(tmp_CreateUIEventSystemHandler)
                .SetNext(tmp_AddExceptionCollectorHandler);
            tmp_GetXRPackageConfigHandler.Handle();
        }


        /// <summary>
        /// Receive the message data from XR-MOD Launcher
        /// </summary>
        /// <param name="_data">Will receive message data</param>
        public void OnMessageReceived(string _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                new MessageNotificationData()
                {
                    Message = _data,
                    ActionName = nameof(OnMessageReceived),
                });
        }

        #endregion


        /// <summary>
        /// It will executed after scene loaded
        /// </summary>
        /// <param name="_scene">Load scene</param>
        /// <param name="_sceneMode">Load mode</param>
        private void OnSceneLoad(Scene _scene, LoadSceneMode _sceneMode)
        {
            switch (_scene.name)
            {
                case nameof(SceneTags.Main):
                    new SceneInitialization().Executed();
                    break;
                case nameof(SceneTags.Clear):
                    new SceneDeactivated().Executed();
                    SceneManager.sceneLoaded -= OnSceneLoad;
                    break;
                case nameof(SceneTags.Initilizer): break;
            }
        }

        public void Dis()
        {
            Dispose();
        }
    }
}