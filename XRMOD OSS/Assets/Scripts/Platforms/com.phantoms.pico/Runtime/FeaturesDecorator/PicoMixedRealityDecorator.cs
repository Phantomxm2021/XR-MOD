// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.models.Runtime;
using Pico.Runtime.ExtensionComponents;
using Pico.Runtime.Models;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using XRMODEngineCore.Runtime;

namespace Pico.Runtime.FeaturesDecorator
{
    public class PicoMixedRealityDecorator : IFeatureDecorator
    {
        private bool rpHDROptionState = false;
        private PicoRuntimeContextData runtimeContextData;

        public void StartAlgorithm()
        {
            runtimeContextData = IocContainer.GetIoc.Resolve<PicoRuntimeContextData>();
            if (runtimeContextData.LeftHandTeleportInteractorGo)
                runtimeContextData.LeftHandTeleportInteractorGo.SetActive(false);
            if (runtimeContextData.RightHandTeleportInteractorGo)
                runtimeContextData.RightHandTeleportInteractorGo.SetActive(false);
            if (runtimeContextData.CharacterCtrl)
                runtimeContextData.CharacterCtrl.enabled = false;
            if (runtimeContextData.CharacterCtrlDriver)
                runtimeContextData.CharacterCtrlDriver.enabled = false;
            if (runtimeContextData.DynamicMoveProvider)
                runtimeContextData.DynamicMoveProvider.enabled = false;
            if (runtimeContextData.ContinuousTurnProvider)
                runtimeContextData.ContinuousTurnProvider.enabled = false;
            if (runtimeContextData.TeleportationProvider)
                runtimeContextData.TeleportationProvider.enabled = false;
            if (runtimeContextData.LocomotionProvider)
                runtimeContextData.LocomotionProvider.enabled = false;
            
            if (GraphicsSettings.currentRenderPipeline is not UniversalRenderPipelineAsset tmp_Pipeline) return;

            //Cached it, for reset after this feature has been removed
            rpHDROptionState = tmp_Pipeline.supportsHDR;
            tmp_Pipeline.supportsHDR = false;
            var tmp_MainCamera = IocContainer.GetIoc.Resolve<BaseContextDataModel>().MainCamera;
            if (tmp_MainCamera == null)
                tmp_MainCamera = Camera.main;
            var tmp_Uac = tmp_MainCamera.GetComponent<UniversalAdditionalCameraData>();
            tmp_Uac.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
            tmp_Uac.stopNaN = false;
            tmp_Uac.renderPostProcessing = false;
            tmp_MainCamera.gameObject.AddComponent<PicoMixedRealityRedress>();
        }

        public void PauseAlgorithm()
        {
            throw new System.NotImplementedException();
        }

        public void StopAlgorithm()
        {
            if (runtimeContextData.LeftHandTeleportInteractorGo)
                runtimeContextData.LeftHandTeleportInteractorGo.SetActive(true);
            if (runtimeContextData.RightHandTeleportInteractorGo)
                runtimeContextData.RightHandTeleportInteractorGo.SetActive(true);


            if (GraphicsSettings.currentRenderPipeline is not UniversalRenderPipelineAsset tmp_Pipeline) return;
            tmp_Pipeline.supportsHDR = rpHDROptionState;
            var tmp_MainCamera = IocContainer.GetIoc.Resolve<BaseContextDataModel>().MainCamera;
            if (tmp_MainCamera.gameObject.TryGetComponent<PicoMixedRealityRedress>(out var tmp_Component))
            {
                Object.Destroy(tmp_Component);
            }
        }
    }
}