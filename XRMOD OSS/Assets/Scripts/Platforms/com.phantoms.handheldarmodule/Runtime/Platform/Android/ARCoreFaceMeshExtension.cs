// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using System;
using com.Phantoms.ActionNotification.Runtime;
using UnityEngine.XR.ARFoundation;

namespace HandheldARModule.Runtime.Android
{
    /// <summary>
    /// Fix for ARFoundation 4.2.
    /// Because Remove event not working.
    /// </summary>
    public class ARCoreFaceMeshExtension : MonoBehaviour
    {
#if UNITY_ANDROID
        private ARFace arFace;
        private FaceMeshNotificationData faceMeshNotificationData;
        public float ScaleFactor = 0.85f;

        private void Start()
        {
            arFace = GetComponent<ARFace>();
            faceMeshNotificationData = new FaceMeshNotificationData();
            transform.localScale = Vector3.one * ScaleFactor;
        }

        private void OnDisable()
        {
            for (int tmp_Idx = 0; tmp_Idx < transform.childCount; tmp_Idx++)
            {
                Transform tmp_Transform;
                (tmp_Transform = transform).GetChild(tmp_Idx).SetParent(null);
                tmp_Transform.localPosition = Vector3.zero;
                tmp_Transform.localRotation = Quaternion.identity;
            }
        }

        public void OnDestroy()
        {
            faceMeshNotificationData.TrackingId = arFace.trackableId.ToString();
            faceMeshNotificationData.FaceTrackingState = FaceTrackingState.None;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                faceMeshNotificationData);
        }
#endif
    }
}