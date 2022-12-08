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
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

//TODO: Environment probe crash when OnDestroy method called.
namespace HandheldARModule.Runtime.FeaturesDecorator
{
    /// <summary>
    /// Environment probes are a technique of capturing real-world imagery from the
    /// device’s camera and organizing that information into an environment texture,
    /// such as a cube map, that contains the view in all directions from a certain
    /// point in the scene. Rendering 3D objects using this environment texture allows
    /// for real-world imagery to be reflected in the rendered objects, which creates
    /// realistic reflections and lighting of virtual objects as influenced by the real-world views.
    /// </summary>
    public class EnvironmentProbeDecorator : AbstractDecorator
    {
        private readonly AREnvironmentProbeManager environmentProbeManager;
        private ARComponentModel arComponentModel;

        public EnvironmentProbeDecorator()
        {
            arComponentModel = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(arComponentModel.XROriginGameObject);
            environmentProbeManager =
                arComponentModel.XROriginGameObject.AddComponent<AREnvironmentProbeManager>();
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;

            if (environmentProbeManager)
            {
                if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                    ARConfiguresModel tmp_Config) return;

                environmentProbeManager.environmentTextureHDRRequested = tmp_Config.UseEnvironmentHDRTexture;
                environmentProbeManager.automaticPlacementRequested = tmp_Config.AutoPlacementOfEnvironmentProbe;
                environmentProbeManager.enabled = true;
            }

            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            if (environmentProbeManager)
                environmentProbeManager.enabled = false;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            if (!environmentProbeManager && environmentProbeManager.descriptor == null) return;

            //Avoid AREnvironmentProbe always working when environment probe manager stopped.
            var tmp_AREnvironmentProbes = Object.FindObjectsOfType<AREnvironmentProbe>();
            foreach (AREnvironmentProbe tmp_AREnvironmentProbe in tmp_AREnvironmentProbes)
            {
                // tmp_AREnvironmentProbe.DestroyWithPlatform();
                if (tmp_AREnvironmentProbe)
                    Object.DestroyImmediate(tmp_AREnvironmentProbe, true);
                Assert.IsNull(tmp_AREnvironmentProbe);
            }


            environmentProbeManager.subsystem?.Stop();
            environmentProbeManager.subsystem?.Destroy();
            environmentProbeManager.enabled = false;
            environmentProbeManager.DestroyWithPlatform();
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return environmentProbeManager.descriptor != null;
        }
    }
}