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
    public class FixedDecorator : AbstractDecorator
    {
        //private readonly Transform fixRoot;
        private readonly ARComponentModel arModel;
        private GameObject fixedGameObject;

        public FixedDecorator()
        {
            //fixRoot = GameObject.Find(ConstKey.CONST_AR_CAMERA_NAME).transform;
            arModel = IocContainer.GetIoc.Resolve<ARComponentModel>();
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            if (arModel.ARPoseDriverExtension == null) return;
            arModel.ARSession.requestedTrackingMode = TrackingMode.DontCare;
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            if (arModel.ARPoseDriverExtension == null) return;
            arModel.ARSession.requestedTrackingMode = TrackingMode.DontCare;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            if (arModel.ARPoseDriverExtension == null) return;
            arModel.ARSession.requestedTrackingMode = TrackingMode.PositionAndRotation;

            if (fixedGameObject)
                fixedGameObject.DestroyWithPlatform();
            hasStarted = false;
        }
    }
}