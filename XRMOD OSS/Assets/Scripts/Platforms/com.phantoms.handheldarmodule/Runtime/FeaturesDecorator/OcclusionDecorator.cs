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

using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using HandheldARModule.Runtime.Utility;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;


namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class OcclusionDecorator : AbstractDecorator
    {
        private readonly AROcclusionManager occlusionManager;

        public OcclusionDecorator()
        {
            occlusionManager = Object.FindObjectOfType<SceneGrab>().OcclusionManager;
            IocContainer.GetIoc.Resolve<ARComponentModel>().AROcclusionManager = occlusionManager;
            Assert.IsNotNull(occlusionManager, "Occlusion Manager is null");
            occlusionManager.enabled = false;
        }

        public override void StartAlgorithm()
        {
            if (!occlusionManager) return;
            if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_Config) return;
            occlusionManager.environmentDepthTemporalSmoothingRequested = tmp_Config.TemporalSmoothing;
            occlusionManager.requestedEnvironmentDepthMode = tmp_Config.EnvironmentDepthMode;
            occlusionManager.requestedHumanDepthMode = tmp_Config.HumanSegmentationDepthMode;
            occlusionManager.requestedHumanStencilMode = tmp_Config.HumanSegmentationStencilMode;
            occlusionManager.requestedOcclusionPreferenceMode = tmp_Config.OcclusionPreferenceMode;

            occlusionManager.enabled = true;
        }

        public override void PauseAlgorithm()
        {
            if (occlusionManager)
            {
                occlusionManager.enabled = true;
            }
        }

        public override void StopAlgorithm()
        {
            if (occlusionManager.environmentDepthTexture)
                Object.DestroyImmediate(occlusionManager.environmentDepthTexture, true);

            if (occlusionManager.humanDepthTexture)
                Object.DestroyImmediate(occlusionManager.humanDepthTexture, true);

            if (occlusionManager.humanStencilTexture)
                Object.DestroyImmediate(occlusionManager.humanStencilTexture, true);

            if (occlusionManager.environmentDepthConfidenceTexture)
                Object.DestroyImmediate(occlusionManager.environmentDepthConfidenceTexture, true);

            if (occlusionManager.descriptor != null)
            {
                occlusionManager.subsystem.Stop();
                occlusionManager.subsystem.Destroy();
            }
           
            // if (!occlusionManager) return;
            // occlusionManager.enabled = false;
            // occlusionManager.DestroyWithPlatform();
        }
    }
}