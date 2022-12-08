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
    public class ThreeDofDecorator : AbstractDecorator
    {
        private Transform gyroRoot;
        private ARComponentModel arComponent;

        public ThreeDofDecorator()
        {
            arComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();
            gyroRoot = GameObject.Find(ConstKey.CONST_TRACKABLES_NAME).transform;
            Assert.IsNotNull(gyroRoot, "gyroRoot != null");
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            arComponent.ARSession.requestedTrackingMode = TrackingMode.RotationOnly;
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            arComponent.ARSession.requestedTrackingMode = TrackingMode.DontCare;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            arComponent.ARSession.requestedTrackingMode = TrackingMode.PositionAndRotation;
            if (gyroRoot.childCount > 0)
            {
                for (int tmp_Idx = 0; tmp_Idx < gyroRoot.childCount; tmp_Idx++)
                {
                    gyroRoot.GetChild(tmp_Idx).gameObject.DestroyWithPlatform();
                }
            }

            gyroRoot = null;
            hasStarted = false;
        }
    }
}