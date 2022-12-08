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
using UnityEngine.XR.Interaction.Toolkit.AR;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class ARInteractionDecorator : AbstractDecorator
    {
        private readonly ARGestureInteractor gestureInteractor;

        public ARInteractionDecorator() {
            ARComponentModel tmp_ArModel =IocContainer.GetIoc.Resolve<ARComponentModel>();
            gestureInteractor = tmp_ArModel.ARGestureInteractor;
            tmp_ArModel.ARGestureInteractor = gestureInteractor;
        }

        
        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            if (gestureInteractor)
                gestureInteractor.enabled = true;
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;

            if (gestureInteractor)
                gestureInteractor.enabled = false;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;

            if (gestureInteractor)
                gestureInteractor.enabled = false;
            hasStarted = false;
        }
    }
}