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
using HandheldARModule.Runtime.Extension;
using HandheldARModule.Runtime.Models;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class FocusSlamDecorator : AbstractDecorator
    {
        private FocusPlacementExtension focusPlacementExtension;
        private ARComponentModel arComponent;

        public FocusSlamDecorator()
        {
            arComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(arComponent.XROriginGameObject, "Session Origin is null");

            focusPlacementExtension =
                arComponent.XROriginGameObject.AddComponent<FocusPlacementExtension>();
            
            Assert.IsNotNull(arComponent.ARSession);
            arComponent.ARSession.requestedTrackingMode = TrackingMode.PositionAndRotation;
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            if (!focusPlacementExtension.enabled)
                focusPlacementExtension.enabled = true;

            arComponent.ARRaycastManager.enabled = true;

            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;

            if (focusPlacementExtension)
                focusPlacementExtension.enabled = false;

            if (! arComponent.ARRaycastManager &&  arComponent.ARRaycastManager.descriptor == null) return;
            arComponent.ARRaycastManager.enabled = false;

            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;

            PauseAlgorithm();

            if (arComponent.ARPoseDriverExtension)
                arComponent.ARSession.requestedTrackingMode = TrackingMode.DontCare;

            if (focusPlacementExtension)
            {
                focusPlacementExtension.DestroyWithPlatform();
                focusPlacementExtension = null;
            }

            if (! arComponent.ARRaycastManager &&  arComponent.ARRaycastManager.descriptor == null) return;
            arComponent.ARRaycastManager.enabled = false;
            arComponent.ARRaycastManager.subsystem?.Stop();
            arComponent.ARRaycastManager.subsystem?.Destroy();

            arComponent.ARRaycastManager.DestroyWithPlatform();

            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return focusPlacementExtension.Running;
        }
    }
}