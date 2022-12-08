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

using HandheldARModule.Runtime.Extension;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
#if UNITY_IOS
    public class CoachingOverlayDecorator : AbstractDecorator
    {
        private readonly CoachingOverlayExtension coachingOverlayExtension;

        public CoachingOverlayDecorator()
        {
            coachingOverlayExtension = IocContainer.GetIoc.Resolve<ARComponentModel>().SessionGameObject
                .AddComponent<CoachingOverlayExtension>();
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            coachingOverlayExtension.ActivateCoaching(true);
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            coachingOverlayExtension.DisableCoaching(true);
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            if (coachingOverlayExtension)
                Object.Destroy(coachingOverlayExtension);
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return coachingOverlayExtension.supported;
        }
    }
#endif
}