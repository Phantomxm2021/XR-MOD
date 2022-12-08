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
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

#if UNITY_IOS
using UnityEngine.XR.ARKit;
#endif

namespace HandheldARModule.Runtime.Platform.iOS
{
    public class ARCollaborationAvailabilityCommand : ICommand
    {
        public void Execute()
        {
#if UNITY_IOS
            if (Application.isEditor)
            {
                IocContainer.GetIoc.Resolve<ARContextDataModel>().IsARCollaborationAvailability = false;
                return;
            }

            var tmp_RayCastDescriptors = new List<XRRaycastSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_RayCastDescriptors);
            var tmp_PlaneDescriptors = new List<XRPlaneSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_PlaneDescriptors);
            var tmp_ParticipantDescriptors = new List<XRParticipantSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_ParticipantDescriptors);

            if (tmp_PlaneDescriptors.Count > 0 && tmp_RayCastDescriptors.Count > 0 &&
                tmp_ParticipantDescriptors.Count > 0 && ARKitSessionSubsystem.supportsCollaboration)
                IocContainer.GetIoc.Resolve<ARContextDataModel>().IsARCollaborationAvailability = true;
#endif
        }
    }
}