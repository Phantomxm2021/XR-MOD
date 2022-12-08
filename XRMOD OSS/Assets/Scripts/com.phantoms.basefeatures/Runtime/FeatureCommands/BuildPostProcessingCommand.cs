// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.models.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildPostProcessingCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        private BaseContextDataModel arComponentModel;
        private UniversalAdditionalCameraData uac;


        public void Execute()
        {
            base.Initializer();
            var tmp_MainCamera = IocContainer.GetIoc.Resolve<BaseContextDataModel>().MainCamera;
            if (tmp_MainCamera == null)
                tmp_MainCamera = Camera.main;
            uac = tmp_MainCamera.GetComponent<UniversalAdditionalCameraData>();
            uac.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
            uac.stopNaN = true;
            uac.renderPostProcessing = true;
        }

        public void Release()
        {
            if (uac == null) return;
            uac.renderPostProcessing = false;
            uac.antialiasing = AntialiasingMode.None;
            uac.stopNaN = false;
        }
    }
}