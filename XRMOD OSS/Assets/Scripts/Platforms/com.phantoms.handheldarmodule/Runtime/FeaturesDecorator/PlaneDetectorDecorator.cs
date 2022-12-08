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
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class PlaneDetectorDecorator : AbstractDecorator
    {
        private ARPlaneManager planeManager;
        private ARContextDataModel arContextData;

        public PlaneDetectorDecorator()
        {
            arContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ARComponent.XROriginGameObject);
            planeManager = tmp_ARComponent.XROriginGameObject.AddComponent<ARPlaneManager>();
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARPlaneManager = planeManager;
            planeManager.enabled = false;
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            planeManager.requestedDetectionMode = arContextData.PlaneDetectionMode;
            planeManager.planePrefab = arContextData.PlaneVisualizer;
            planeManager.enabled = true;
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            if (!planeManager && planeManager.descriptor == null)
            {
                Debug.LogError("Plane detection manager not exist!");
                return;
            }

            planeManager.enabled = false;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            if (!planeManager && planeManager.descriptor == null) return;
            // if (planeManager.planePrefab)
            // {
            //     Object.DestroyImmediate(planeManager.planePrefab, true);
            //     planeManager.planePrefab = null;
            // }

            planeManager.enabled = false;
            planeManager.subsystem?.Stop();
            planeManager.subsystem?.Destroy();
            Object.Destroy(planeManager);
            planeManager = null;
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return planeManager != null && planeManager.subsystem.running;
        }
    }
}