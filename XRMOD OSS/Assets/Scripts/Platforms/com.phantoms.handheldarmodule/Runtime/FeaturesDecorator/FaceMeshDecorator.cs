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
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class FaceMeshDecorator : AbstractDecorator
    {
        private ARFaceManager arFaceManager;
        private FaceMeshNotificationData faceMeshNotificationData;
        private readonly IDictionary<string, GameObject> faceObjects;
        private readonly GameObject faceGameObject;

        public FaceMeshDecorator()
        {
            ARComponentModel tmp_ArModel = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ArModel.ARSession);
            tmp_ArModel.ARSession.requestedTrackingMode = TrackingMode.DontCare;

            Assert.IsNotNull(tmp_ArModel.ARCameraManager);
            tmp_ArModel.ARCameraManager.requestedFacingDirection = CameraFacingDirection.User;
            faceGameObject = Resources.Load<GameObject>("Prefabs/ARDefaultFace");

            Assert.IsNotNull(tmp_ArModel.XROriginGameObject);
            arFaceManager = tmp_ArModel.XROriginGameObject.AddComponent<ARFaceManager>();
            arFaceManager.facePrefab = faceGameObject;
            arFaceManager.facesChanged += OnFacesChanged;
            arFaceManager.requestedMaximumFaceCount =
                ((ARConfiguresModel) IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value)
                .MaximumFaceCount;

            arFaceManager.enabled = false;

            faceMeshNotificationData = new FaceMeshNotificationData();
            faceMeshNotificationData.ActionName = "FaceMesh";

            faceObjects = new Dictionary<string, GameObject>();
        }


        private void OnFacesChanged(ARFacesChangedEventArgs _obj)
        {
            foreach (ARFace tmp_ARFace in _obj.added)
            {
                if (faceObjects.ContainsKey(tmp_ARFace.trackableId.ToString())) continue;
                faceObjects.Add(tmp_ARFace.trackableId.ToString(), tmp_ARFace.gameObject);
                UpdateFaceData(tmp_ARFace, true);
            }

            foreach (ARFace tmp_ARFace in _obj.updated)
            {
                UpdateFaceData(tmp_ARFace);
            }

            foreach (ARFace tmp_ARFace in _obj.removed)
            {
                UpdateFaceData(tmp_ARFace);
            }

            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                faceMeshNotificationData);
        }


        public override async void StartAlgorithm()
        {
            if (hasStarted) return;
            //Prevent the resource from registering event listeners for loading before completion,
            //resulting in failure to respond
            await Task.Delay(1500);
            arFaceManager.enabled = true;
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            arFaceManager.facesChanged -= OnFacesChanged;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;

            hasStarted = false;

            // ReSharper disable once InconsistentNaming
            foreach (KeyValuePair<string, GameObject> tmp_KV in faceObjects)
            {
                if (tmp_KV.Value != null)
                    Object.DestroyImmediate(tmp_KV.Value, true);
            }

            faceObjects.Clear();

            if (arFaceManager)
            {
                arFaceManager.facesChanged -= OnFacesChanged;
                arFaceManager.enabled = false;
                Object.DestroyImmediate(arFaceManager, true);
                arFaceManager = null;
            }


            faceMeshNotificationData = null;
        }

        // public override void PushData(object _data)
        // {
        //     switch (_data)
        //     {
        //         case int tmp_Data:
        //             arFaceManager.requestedMaximumFaceCount = tmp_Data;
        //             break;
        //     }
        // }

        public override bool SupportThisFeature()
        {
            return arFaceManager.descriptor != null;
        }


        private void UpdateFaceData(ARFace _arFace, bool _isAdded = false)
        {
            faceMeshNotificationData.TrackingId = _arFace.trackableId.ToString();
            switch (_arFace.trackingState)
            {
                case TrackingState.None:
                    faceMeshNotificationData.FaceTrackingState = FaceTrackingState.None;
                    break;
                case TrackingState.Limited:
                    faceMeshNotificationData.FaceTrackingState = FaceTrackingState.Limited;
                    break;
                case TrackingState.Tracking:
                    faceMeshNotificationData.FaceTrackingState = FaceTrackingState.Tracking;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (_isAdded)
                faceMeshNotificationData.FaceTrackingState = FaceTrackingState.Added;

            faceMeshNotificationData.FaceAnchor = _arFace.gameObject;
            faceMeshNotificationData.vertices = _arFace.vertices;
            faceMeshNotificationData.indices = _arFace.indices;
            faceMeshNotificationData.normals = _arFace.normals;
            faceMeshNotificationData.uvs = _arFace.uvs;
        }
    }
}