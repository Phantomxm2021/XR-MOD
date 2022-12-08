// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

#if UNITY_IOS
using UnityEngine.XR.ARKit;
using UnityEngine.XR.ARSubsystems;
#endif

namespace HandheldARModule.Runtime.Platform.iOS
{
    public class ARKitCoachingOverlayAvailabilityCommand : ICommand
    {
        public void Execute()
        {
#if UNITY_IOS
            if (Application.isEditor)
            {
                IocContainer.GetIoc.Resolve<ARContextDataModel>().ARKitCoachingOverlayAvailability = false;
                return;
            }

            var tmp_SessionDescriptors = new List<XRSessionSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_SessionDescriptors);
            if (tmp_SessionDescriptors.Count > 0 && ARKitSessionSubsystem.coachingOverlaySupported)
                IocContainer.GetIoc.Resolve<ARContextDataModel>().ARKitCoachingOverlayAvailability = true;
#endif
        }
    }
}