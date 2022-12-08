// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ARFeatureModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildARRaycastNotifierCommand : ICommand, IReleaseCommand
    {
        readonly List<ARRaycastHit> hits = new List<ARRaycastHit>();

        public BuildARRaycastNotifierCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(ARRaycastNotifier,
                nameof(ActionParameterDataType.ARRaycast));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ARRaycast));
        }

        /// <summary>
        /// Cast a ray from a point in screen space against trackables,
        /// that is, detected features such as planes.
        /// </summary>
        /// <param name="_data">Input data</param>
        private void ARRaycastNotifier(BaseNotificationData _data)
        {
            if (_data is not ARRaycastNotificationData tmp_Data) return;
            ARComponentModel tmp_ArModel = IocContainer.GetIoc.Resolve<ARComponentModel>();

            if (tmp_ArModel.ARRaycastManager == null)
            {
                if (!tmp_ArModel.XROriginGameObject.TryGetComponent(out tmp_ArModel.ARRaycastManager))
                    tmp_ArModel.ARRaycastManager = tmp_ArModel.XROriginGameObject.AddComponent<ARRaycastManager>();
            }


            if (tmp_ArModel.ARRaycastManager.Raycast(tmp_Data.ScreenPoint, hits, TrackableType.PlaneWithinPolygon))
            {
                Debug.Log(hits[0].trackable is ARPlane);
                tmp_Data.NotificationActWithData?.Invoke(hits[0].pose);
            }
        }
    }
}