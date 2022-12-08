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

using System;
using System.Collections.Generic;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Extension
{
    public class AnchorManagerExtension : MonoBehaviour
    {
        private readonly List<ARRaycastHit> hits = new List<ARRaycastHit>();
        private readonly List<ARAnchor> arAnchors = new List<ARAnchor>();

        private void Start()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(StickObject,
                nameof(ActionParameterDataType.StickObject));
        }

        public void RemoveAllAnchors()
        {
            if (IocContainer.GetIoc.Resolve<ARComponentModel>().ARAnchorManager.subsystem != null)
            {
                foreach (var tmp_Anchor in arAnchors)
                {
                    if (tmp_Anchor == null) continue;
                    if (tmp_Anchor.gameObject.TryGetComponent(typeof(AREnvironmentProbe), out _)) continue;
                    tmp_Anchor.gameObject.DestroyWithPlatform();
                }
            }

            arAnchors.Clear();
        }

        private void StickObject(BaseNotificationData _notifyData)
        {
            if (!(_notifyData is AnchorNotificationData tmp_Data)) return;
            if (!IsRunning()) return;

            switch (tmp_Data.StickType)
            {
                case AnchorNotificationData.StickTypeEnum.ByTrackableType:
                    var tmp_NeedToConverted = tmp_Data.TrackableType;
                    var tmp_TrackableTypes =
                        (TrackableType) Enum.Parse(typeof(TrackableType), tmp_NeedToConverted.ToString());
                    if (!IocContainer.GetIoc.Resolve<ARComponentModel>().ARRaycastManager
                            .Raycast(tmp_Data.Position, hits, tmp_TrackableTypes))
                    {
                        Debug.Log("Can not place here!");
                        return;
                    }

                    //tmp_HitPose = hits[0].pose;
                    break;
            }

            var tmp_Anchor = CreateAnchor(hits[0], tmp_Data);
            arAnchors.Add(tmp_Anchor);
            tmp_Data.NotificationAct?.Invoke();
            tmp_Data.NotificationActWithData?.Invoke(tmp_Anchor.gameObject);
        }

        private ARAnchor CreateAnchor(in ARRaycastHit _hit, AnchorNotificationData _anchorData)
        {
            if (!IsRunning()) return null;

            ARAnchor tmp_Anchor;
            GameObject tmp_VirtualObject;
            // If we hit a plane, try to "attach" the anchor to the plane
            if (_hit.trackable is ARPlane tmp_Plane)
            {
                var tmp_PlaneManager = IocContainer.GetIoc.Resolve<ARComponentModel>().ARPlaneManager;
                if (tmp_PlaneManager)
                {
                    tmp_Anchor = IocContainer.GetIoc.Resolve<ARComponentModel>().ARAnchorManager
                        .AttachAnchor(tmp_Plane, _hit.pose);
                    //Instantiate game object include IL-Scripts
                    tmp_VirtualObject = InstantiatePrefab(tmp_Anchor.transform, _anchorData.AnchorPrefab);
                    var tmp_VirtualTrans = tmp_VirtualObject.transform;
                    tmp_VirtualTrans.position = tmp_Anchor.transform.position + _anchorData.Offset;
                    tmp_VirtualTrans.rotation = _anchorData.Rotation;
                    //Remove (Clone) string from game object name
                    tmp_VirtualObject.name = tmp_VirtualObject.name.Replace("(Clone)", "");
                    return tmp_Anchor;
                }
            }

            GameObject tmp_NewAnchor = new GameObject($"Anchor-{_hit.trackableId}");
            var tmp_Transform = tmp_NewAnchor.transform;
            tmp_Transform.position = _hit.pose.position + _anchorData.Offset;
            tmp_Transform.rotation = _anchorData.Rotation;

            //Instantiate game object include IL-Scripts
            tmp_VirtualObject = InstantiatePrefab(tmp_NewAnchor.transform, _anchorData.AnchorPrefab);

            //Remove (Clone) string 
            tmp_VirtualObject.name = tmp_VirtualObject.name.Replace("(Clone)", "");

            tmp_Anchor = tmp_NewAnchor.AddComponent<ARAnchor>();
            return tmp_Anchor;
        }

        private GameObject InstantiatePrefab(Transform _transform, GameObject _prefab)
        {
            var tmp_InstantiateData = new InstantiateNotificationData()
            {
                Prefab = _prefab,
                Parent = _transform
            };
            var tmp_Results = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.Instantiate), tmp_InstantiateData);
            return tmp_Results?[0] as GameObject;
        }

        private void OnDisable()
        {
            hits.Clear();
            ActionNotificationCenter.DefaultCenter.RemoveObserver(ActionParameterDataType.StickObject.ToString());

            RemoveAllAnchors();
            // if (Application.isEditor)
            //     DestroyImmediate(this, true);
            // else
            //     Destroy(this);
        }


        private bool IsRunning()
        {
#if UNITY_EDITOR
            return true;
#else
            var tmp_ARAnchorManager = IocContainer.GetIoc.Resolve<ARComponentModel>().ARAnchorManager;
            return tmp_ARAnchorManager.subsystem != null && tmp_ARAnchorManager.subsystem.running;
#endif
        }
    }
}