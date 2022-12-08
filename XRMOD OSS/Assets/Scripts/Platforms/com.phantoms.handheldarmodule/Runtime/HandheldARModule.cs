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
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Command;
using HandheldARModule.Runtime.Models;
using HandheldARModule.Runtime.Utility;
using NativePlugins.Plugin;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Management;
using XRMODEngineCore.Runtime;
using XRMODEngineCore.Runtime.Enums;
using Object = UnityEngine.Object;

namespace HandheldARModule.Runtime
{
    public class HandheldARModule : IModule
    {
        /// <summary>
        /// Add the platform special features
        /// </summary>
        private readonly IPlatformDependenceInject platformInjector;

        private readonly GameObject platformInjectorGameObject;

        public HandheldARModule()
        {
            string tmp_PlatformName = DevicePlatformAPI.GetPlatformName();
            var tmp_PlatformInjectorPrefab = Resources.Load<GameObject>($"Prefabs/{tmp_PlatformName}Dependence");
            if (tmp_PlatformInjectorPrefab)
            {
                platformInjectorGameObject = Object.Instantiate(tmp_PlatformInjectorPrefab);
                platformInjector = platformInjectorGameObject.GetComponent<IPlatformDependenceInject>();
            }

            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                //Re-parse the json string to runtime project config,
                //if not re-parse the RuntimeProjectConfig type is BaseProjectConfigModel
                var tmp_Configures = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>();
                tmp_Configures.CurrentConfigures.Value =
                    JsonUtility.FromJson<ARConfiguresModel>(tmp_Configures.MetaData);
            }, nameof(ActionParameterDataType.OnXRDataGot));
        }

        public bool StartModule()
        {
            try
            {
                RegisterDependence();

                LoaderUtility.Initialize();

                //Register event for RuntimeProjectConfig changed
                IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.OnValueChanged += OnConfigUpdated;

                new QueryARDataAfterModuleAvailiability().Execute();

                var tmp_XrSetting = XRGeneralSettings.Instance;
                return tmp_XrSetting != null && tmp_XrSetting.Manager.isInitializationComplete;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                return false;
            }
        }

        private void RegisterDependence()
        {
            IocContainer.GetIoc.Register(new ARContextDataModel());
            IocContainer.GetIoc.Register(new ARComponentModel());

            IocContainer.GetIoc.Register(new BuildAnchorCommand());
            IocContainer.GetIoc.Register(new BuildEnvironmentCommand());
            IocContainer.GetIoc.Register(new BuildARAvailabilityCommand());
            IocContainer.GetIoc.Register(new BuildARCameraCommand());
            IocContainer.GetIoc.Register(new BuildARInteractionCommand());
            IocContainer.GetIoc.Register(new BuildFixedCommand());
            IocContainer.GetIoc.Register(new BuildImmersalCommand());
            IocContainer.GetIoc.Register(new BuildImageTrackCommand());
            IocContainer.GetIoc.Register(new BuildPlaneDetector());
            IocContainer.GetIoc.Register(new BuildPointCloudDetectorCommand());
            IocContainer.GetIoc.Register(new BuildThreeDofCommand());
            IocContainer.GetIoc.Register(new BuildFaceMeshCommand());
            IocContainer.GetIoc.Register(new BuildFocusSlamCommand());
            IocContainer.GetIoc.Register(new BuildGpuImageCommand());
            IocContainer.GetIoc.Register(new BuildLightEstimationCommand());
            IocContainer.GetIoc.Register(new BuildWebcamCommand());
            IocContainer.GetIoc.Register(new BuildOcclusionCommand());
            IocContainer.GetIoc.Register(new BuildARWordScaleCommand());
            IocContainer.GetIoc.Register(new InitializeARComponentCommand());
            IocContainer.GetIoc.Register(new BuildCheckARFeaturesAvailabilityCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireCurrentFrameCommand());
            IocContainer.GetIoc.Register(new BuildCheckARAvailabilityCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireLightEstimateCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireAROcclusionFrameCommand());
            IocContainer.GetIoc.Register(new BuildMakeContentAppearAtCommand());
            IocContainer.GetIoc.Register(new BuildARRaycastNotifierCommand());
            IocContainer.GetIoc.Register(new BuildARAlgorithmLifeControllerCommand());
            IocContainer.GetIoc.Register(new BuildCpuImageCommand());
            IocContainer.GetIoc.Register(new BuildImageCloudRecognizerCommand());
            IocContainer.GetIoc.Register(new BuildAcquireFrameBase64ImageCommand());
            IocContainer.GetIoc.Register(new ARAlgorithmUtility());

            if (platformInjector != null)
                platformInjector.Inject();
        }

        public bool PauseModule()
        {
            throw new NotImplementedException($"{nameof(HandheldARModule)} can not paused!");
        }

        public bool StopModule()
        {
            DisposeModule();
            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }

        public void RegisterCLR()
        {
            
        }

        private void DisposeModule()
        {
            IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.OnValueChanged -= OnConfigUpdated;

            
            var tmp_ARCamera = IocContainer.GetIoc.Resolve<ARComponentModel>().ARCamera;
            if(tmp_ARCamera)
                tmp_ARCamera.enabled = false;

            if (platformInjector != null)
            {
                platformInjector.UnInject();
                platformInjectorGameObject.DestroyWithPlatform();
            }
            
            IocContainer.GetIoc.UnRegister<BuildAnchorCommand>();
            IocContainer.GetIoc.UnRegister<BuildEnvironmentCommand>();
            IocContainer.GetIoc.UnRegister<BuildARAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<BuildARCameraCommand>();
            IocContainer.GetIoc.UnRegister<BuildARInteractionCommand>();
            IocContainer.GetIoc.UnRegister<BuildFixedCommand>();
            IocContainer.GetIoc.UnRegister<BuildImmersalCommand>();
            IocContainer.GetIoc.UnRegister<BuildImageTrackCommand>();
            IocContainer.GetIoc.UnRegister<BuildPlaneDetector>();
            IocContainer.GetIoc.UnRegister<BuildPointCloudDetectorCommand>();
            IocContainer.GetIoc.UnRegister<BuildAnchorCommand>();
            IocContainer.GetIoc.UnRegister<BuildThreeDofCommand>();
            IocContainer.GetIoc.UnRegister<BuildFaceMeshCommand>();
            IocContainer.GetIoc.UnRegister<BuildFocusSlamCommand>();
            IocContainer.GetIoc.UnRegister<BuildGpuImageCommand>();
            IocContainer.GetIoc.UnRegister<BuildLightEstimationCommand>();
            IocContainer.GetIoc.UnRegister<BuildWebcamCommand>();
            IocContainer.GetIoc.UnRegister<BuildOcclusionCommand>();
            IocContainer.GetIoc.UnRegister<InitializeARComponentCommand>();
            IocContainer.GetIoc.UnRegister<BuildARWordScaleCommand>();
            IocContainer.GetIoc.UnRegister<BuildCheckARFeaturesAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireCurrentFrameCommand>();
            IocContainer.GetIoc.UnRegister<BuildCheckARAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireLightEstimateCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireAROcclusionFrameCommand>();
            IocContainer.GetIoc.UnRegister<BuildMakeContentAppearAtCommand>();
            IocContainer.GetIoc.UnRegister<BuildARRaycastNotifierCommand>();
            IocContainer.GetIoc.UnRegister<BuildARAlgorithmLifeControllerCommand>();
            IocContainer.GetIoc.UnRegister<BuildCpuImageCommand>();
            IocContainer.GetIoc.UnRegister<BuildImageCloudRecognizerCommand>();
            IocContainer.GetIoc.UnRegister<BuildAcquireFrameBase64ImageCommand>();
            IocContainer.GetIoc.UnRegister<ARAlgorithmUtility>();
            IocContainer.GetIoc.UnRegister<ARComponentModel>();
            IocContainer.GetIoc.UnRegister<ARContextDataModel>();
        }

        private void OnConfigUpdated(IModel _config)
        {
            if (_config is not ARConfiguresModel tmp_Config) return;

            if (tmp_Config.SDKDeviceType != SDKDeviceType.HandheldAR)
            {
                string tmp_LogInfo = "This experience is not available for this device.";
                NativeAPI.ThrowException(tmp_LogInfo, -1);
                Debug.LogError(tmp_LogInfo);
                return;
            }

            AddFeatureDecorator(tmp_Config);
            MakeSureAlgorithm(tmp_Config.Algorithm);
        }

        private void MakeSureAlgorithm(AlgorithmType _arAlgorithmType)
        {
            ICommand tmp_ARFeatureCommand = null;
            switch (_arAlgorithmType)
            {
                case AlgorithmType.FocusSlam:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildFocusSlamCommand>();
                    break;
                case AlgorithmType.Anchor:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildAnchorCommand>();
                    break;
                case AlgorithmType.Gyro:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildThreeDofCommand>();
                    break;
                case AlgorithmType.Fixed:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildFixedCommand>();
                    break;
                case AlgorithmType.ImageTracker:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildImageTrackCommand>();
                    break;
                case AlgorithmType.Immersal:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildImmersalCommand>();
                    break;
                case AlgorithmType.FaceMesh:
                    tmp_ARFeatureCommand = IocContainer.GetIoc.Resolve<BuildFaceMeshCommand>();
                    break;
                case AlgorithmType.Classic3D:
                    Debug.Log("Will be ignore any xr features");
                    break;
            }


            var tmp_AutoStart = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value
                .AlgorithmAutoStart;
            if (tmp_AutoStart)
            {
                tmp_ARFeatureCommand?.Execute();
            }
        }

        private void AddFeatureDecorator(ARConfiguresModel _config)
        {
            if (_config.Algorithm == AlgorithmType.Classic3D) return;

            IocContainer.GetIoc.Resolve<InitializeARComponentCommand>().Execute();

            if (_config.AROcclusion)
            {
                IocContainer.GetIoc.Resolve<BuildOcclusionCommand>().Execute();
                IocContainer.GetIoc.Resolve<BuildTryAcquireAROcclusionFrameCommand>().Execute();
            }

            if (_config.CanInteraction)
            {
                IocContainer.GetIoc.Resolve<BuildARInteractionCommand>().Execute();
            }

            if (_config.EnvironmentProbe)
            {
                IocContainer.GetIoc.Resolve<BuildEnvironmentCommand>().Execute();
            }

            if (!string.IsNullOrEmpty(_config.CustomPlaneVisualizerName))
            {
                IocContainer.GetIoc.Resolve<BuildPlaneDetector>().Execute();
            }

            if (_config.LightEstimation)
            {
                IocContainer.GetIoc.Resolve<BuildLightEstimationCommand>().Execute();
                IocContainer.GetIoc.Resolve<BuildTryAcquireLightEstimateCommand>().Execute();
            }

            if (string.IsNullOrEmpty(_config.CustomPointCloudVisualizerName)
                || _config.CustomPlaneVisualizerName != ConstKey.CONST_DEFAULT_POINT_CLOUD_VISUALIZER_NAME)
            {
                IocContainer.GetIoc.Resolve<BuildPointCloudDetectorCommand>().Execute();
            }

            if (_config.CoachingOverlay)
            {
                platformInjector.AddFeature("BuildCoachingOverlayCommand");
            }

            if (_config.Algorithm == AlgorithmType.Meshing)
            {
                platformInjector.AddFeature("Meshing");
            }

            IocContainer.GetIoc.Resolve<BuildARWordScaleCommand>().Execute();
        }
    }
}