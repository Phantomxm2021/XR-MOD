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

using HandheldARModule.Runtime.Utility;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Extension;
using HandheldARModule.Runtime.Models;
using NativePlugins.Plugin;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class LightEstimationDecorator : AbstractDecorator
    {
        private readonly GameObject lightEstimationGo;
        private readonly LightEstimationExtension lightEstimationExtension;
        private ARComponentModel arComponent;

        public LightEstimationDecorator()
        {
            arComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();
            var tmp_ARContextDataModel = IocContainer.GetIoc.Resolve<ARContextDataModel>();

            Assert.IsNotNull(arComponent.ARCameraManager);
            lightEstimationGo = new GameObject(ConstKey.CONST_LIGHT_ESTIMATION);
            lightEstimationExtension = lightEstimationGo.AddComponent<LightEstimationExtension>();
            lightEstimationExtension.enabled = false;
            lightEstimationExtension.CameraManager = arComponent.ARCameraManager;

            tmp_ARContextDataModel.EnableHDR.OnValueChanged = _useHDR =>
            {
                arComponent.ARCameraManager.requestedLightEstimation = _useHDR
                    ? LightEstimation.MainLightIntensity
                      | LightEstimation.AmbientColor
                      | LightEstimation.AmbientIntensity
                      | LightEstimation.AmbientSphericalHarmonics
                      | LightEstimation.MainLightDirection
                    : LightEstimation.AmbientColor
                      | LightEstimation.AmbientIntensity;
            };
        }

        public override void StartAlgorithm()
        {
            if (!lightEstimationGo) return;
            var tmp_RuntimeProjectConfig =
                (ARConfiguresModel) IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value;
            IocContainer.GetIoc.Resolve<ARContextDataModel>().EnableHDR.Value = tmp_RuntimeProjectConfig.LightEstimationHDR;
            lightEstimationGo.GetComponent<Light>().shadowStrength = tmp_RuntimeProjectConfig.ShadowStrength;

            lightEstimationExtension.enabled = true;
        }

        public override void PauseAlgorithm()
        {
            if (!lightEstimationGo) return;
            lightEstimationExtension.enabled = false;
        }

        public override void StopAlgorithm()
        {
            if (!lightEstimationGo) return;
            lightEstimationExtension.enabled = false;
            lightEstimationExtension.DestroyWithPlatform();
            lightEstimationGo.DestroyWithPlatform();
        }
    }
}