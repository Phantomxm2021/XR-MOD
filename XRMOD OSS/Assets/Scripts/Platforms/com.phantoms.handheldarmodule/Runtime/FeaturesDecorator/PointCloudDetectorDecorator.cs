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

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class PointCloudDetectorDecorator : AbstractDecorator
    {
        private readonly ARPointCloudManager pointCloudManager;
        private ARContextDataModel arModel;

        public PointCloudDetectorDecorator()
        {
            arModel = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ARComponent.XROriginGameObject);
            pointCloudManager =
                tmp_ARComponent.XROriginGameObject.TryGetComponent(
                    out ARPointCloudManager tmp_PointCloudManager)
                    ? tmp_PointCloudManager
                    : tmp_ARComponent.XROriginGameObject.AddComponent<ARPointCloudManager>();
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARPointCloudManager = pointCloudManager;
            pointCloudManager.enabled = false;
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            pointCloudManager.pointCloudPrefab = arModel.PointCloudVisualizer;
            pointCloudManager.enabled = true;
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            if (!pointCloudManager && pointCloudManager.descriptor == null) return;
            pointCloudManager.enabled = false;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            if (!pointCloudManager && pointCloudManager.descriptor == null) return;
            pointCloudManager.enabled = false;
            pointCloudManager.subsystem?.Stop();
            pointCloudManager.subsystem?.Destroy();
            Object.Destroy(pointCloudManager);
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return pointCloudManager.subsystem.running;
        }
    }
}