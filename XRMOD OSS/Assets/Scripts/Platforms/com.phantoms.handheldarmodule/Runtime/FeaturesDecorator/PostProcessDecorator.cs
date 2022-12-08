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

using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class PostProcessDecorator : AbstractDecorator
    {
        private readonly UniversalAdditionalCameraData uac;
        private ARComponentModel arComponent;

        public PostProcessDecorator()
        {
            arComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            var tmp_MainCamera = arComponent.ARCamera;
            if (tmp_MainCamera == null)
                tmp_MainCamera = GameObject.Find(ConstKey.CONST_NATIVE_CAMERA_NAME).GetComponent<Camera>();
            uac = tmp_MainCamera.GetComponent<UniversalAdditionalCameraData>();
            uac.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
            uac.stopNaN = true;
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            uac.renderPostProcessing = true;
            hasStarted = false;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            uac.renderPostProcessing = false;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            uac.renderPostProcessing = false;
            uac.antialiasing = AntialiasingMode.None;
            uac.stopNaN = false;
            hasStarted = false;
        }
    }
}