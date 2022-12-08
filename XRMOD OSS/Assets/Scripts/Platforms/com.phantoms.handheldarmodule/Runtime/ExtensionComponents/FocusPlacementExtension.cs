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

using System.Collections.Generic;
using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.Models;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;
using PlaneAlignment = com.Phantoms.ActionNotification.Runtime.PlaneAlignment;
using PlaneClassification = com.Phantoms.ActionNotification.Runtime.PlaneClassification;

namespace HandheldARModule.Runtime.Extension
{
    public class FocusPlacementExtension : MonoBehaviour
    {
        public float FindingSquareDist = .5f;

        private Transform mainCameraTransform;
        private Vector3 center;
        private Vector3 hitPosition;
        private Quaternion hitRotation;
        private ARRaycastManager arRaycastManager;
        private Camera arCamera;

        private readonly FocusResultNotificationData focusNotificationData = new FocusResultNotificationData()
            {ActionName = "OnFocusNotify"};

        internal bool Running;
        private List<ARRaycastHit> hits;


        private void Update()
        {
            //if (Application.isEditor) return;
            if (!Running) return;
            if (!mainCameraTransform) return;
            if (arRaycastManager == null)
            {
                ARComponentModel tmp_ArModel = IocContainer.GetIoc.Resolve<ARComponentModel>();
                arRaycastManager = tmp_ArModel.ARRaycastManager;
                arCamera = tmp_ArModel.ARCamera;
            }

            if (arRaycastManager && arRaycastManager.Raycast(center, hits, TrackableType.PlaneWithinPolygon))
            {
                var tmp_HitPose = hits[0].pose;
                hitPosition = tmp_HitPose.position;
                hitRotation = tmp_HitPose.rotation;

                focusNotificationData.FocusPos = hitPosition;
                focusNotificationData.FocusRot = hitRotation;
                focusNotificationData.FocusState = FindingType.Found;
                if (hits[0].trackable is ARPlane tmp_ARPlane)
                {
                    focusNotificationData.PlaneAlignment =
                        (com.Phantoms.ActionNotification.Runtime.PlaneAlignment) tmp_ARPlane.alignment;
                    focusNotificationData.size = tmp_ARPlane.size;
                    focusNotificationData.PlaneClassification =
                        (com.Phantoms.ActionNotification.Runtime.PlaneClassification) tmp_ARPlane.classification;
                }
            }
            else
            {
                float tmp_DotValue = Vector3.Dot(mainCameraTransform.forward, Vector3.down);
                if (!(tmp_DotValue > 0))
                {
                    focusNotificationData.FocusState = FindingType.Limit;
                }
                else
                {
                    var tmp_UnFocusedPosition = arCamera.ScreenToWorldPoint(center);

                    Vector3 tmp_VecToCamera = tmp_UnFocusedPosition - mainCameraTransform.position;
                    Vector3 tmp_VecOrthoghonal = Vector3.Cross(tmp_VecToCamera, Vector3.up);
                    Vector3 tmp_VecForward = Vector3.Cross(tmp_VecOrthoghonal, Vector3.up);
                    var tmp_UnFocusedRotation = Quaternion.LookRotation(tmp_VecForward, Vector3.up);

                    focusNotificationData.FocusPos = tmp_UnFocusedPosition;
                    focusNotificationData.FocusRot = tmp_UnFocusedRotation;
                    focusNotificationData.FocusState = FindingType.Finding;
                }

                focusNotificationData.PlaneAlignment = PlaneAlignment.None;
                focusNotificationData.size = Vector2.zero;
                focusNotificationData.PlaneClassification = PlaneClassification.None;
            }

            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, focusNotificationData);
        }

        private void OnDisable()
        {
            hits?.Clear();
            Running = false;
            ActionNotificationCenter.DefaultCenter.RemoveObserver(ConstKey.CONST_ON_EVENT);
        }


        public void Start()
        {
            mainCameraTransform = IocContainer.GetIoc.Resolve<ARComponentModel>().ARCamera.transform;
#if ARFOUNDATION_4_0_0
            var tmp_Origin = FindObjectOfType<ARSessionOrigin>().transform;
#elif ARFOUNDATION_5_0_0
            var tmp_Origin = FindObjectOfType<XROrigin>().transform;
#endif
            center = new Vector3(Screen.width / 2, Screen.height / 2,
                FindingSquareDist * tmp_Origin.lossyScale.x);
            hits = new List<ARRaycastHit>();
            Running = true;

            ActionNotificationCenter.DefaultCenter.AddObserver(AlgorithmSetter,
                ConstKey.CONST_SET_FOCUS_ALGORITHM_STATE);
        }

        private void AlgorithmSetter(BaseNotificationData _data)
        {
            enabled = ((AlgorithmSetterNotificationData) (_data)).AlgorithmState;
        }
    }
}