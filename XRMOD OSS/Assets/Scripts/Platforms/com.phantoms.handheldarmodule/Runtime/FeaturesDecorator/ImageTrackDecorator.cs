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
using System.Collections;
using System.Collections.Generic;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;
using TrackingState = UnityEngine.XR.ARSubsystems.TrackingState;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class ImageTrackDecorator : AbstractDecorator
    {
        private ARTrackedImageManager trackedImageManager;

        //private readonly int maxNumOfMovingImages;
        private readonly Dictionary<string, ARTrackedImage> allArTrackedImages;
        private MarkerNotificationData markerNotificationData = new();

        private List<AddReferenceImageJobState> addReferenceImagesJobState;
        private readonly ARComponentModel arComponentModel;

        public ImageTrackDecorator()
        {
            arComponentModel = IocContainer.GetIoc.Resolve<ARComponentModel>();

            trackedImageManager = arComponentModel.XROriginGameObject.AddComponent<ARTrackedImageManager>();
            trackedImageManager.enabled = false;
            arComponentModel.ARTrackedImageManager = trackedImageManager;

            allArTrackedImages = new Dictionary<string, ARTrackedImage>();

            arComponentModel.ARTrackedImageManager.requestedMaxNumberOfMovingImages =
                ((ARConfiguresModel) IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value)
                .MaxMovingOfTracking;
        }


        private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs _args)
        {
            foreach (ARTrackedImage tmp_Image in _args.added)
            {
                //Avoid identifying the same image multiple times
                if (allArTrackedImages.ContainsKey(tmp_Image.name)) return;
                allArTrackedImages.Add(tmp_Image.name, tmp_Image);

                markerNotificationData.MarkerName = tmp_Image.referenceImage.name;
                markerNotificationData.MarkerState = MarkerTrackingState.Added;
                markerNotificationData.MarkerTrackable = tmp_Image.transform;

                ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                    markerNotificationData);
            }


            foreach (var tmp_Image in _args.updated)
            {
                markerNotificationData.MarkerName = tmp_Image.referenceImage.name;
                switch (tmp_Image.trackingState)
                {
                    case TrackingState.None:
                        markerNotificationData.MarkerState = MarkerTrackingState.None;
                        break;
                    case TrackingState.Limited:
                        markerNotificationData.MarkerState = MarkerTrackingState.Limited;
                        break;
                    case TrackingState.Tracking:
                        markerNotificationData.MarkerState = MarkerTrackingState.Tracking;
                        break;
                }

                markerNotificationData.MarkerTrackable = tmp_Image.transform;

                ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                    markerNotificationData);
            }
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            try
            {
                Object.FindObjectOfType<MonoBehaviour>().StartCoroutine(ProcessImage());
                hasStarted = true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw new Exception(tmp_Exception.Message);
            }
        }

        private IEnumerator ProcessImage()
        {
            // IReferenceImageLibrary tmp_ImageData = null;
            MutableRuntimeReferenceImageLibrary tmp_RuntimeLibrary = null;
            if (trackedImageManager.referenceLibrary == null)
            {
                try
                {
                    var tmp_ReferenceImageLib =
                        IocContainer.GetIoc.Resolve<ARContextDataModel>().ReferenceImageLibrary;
                    if (trackedImageManager.subsystem == null || tmp_ReferenceImageLib == null)
                        yield break;

                    tmp_RuntimeLibrary = trackedImageManager.CreateRuntimeLibrary() as
                        MutableRuntimeReferenceImageLibrary;
                    addReferenceImagesJobState = new List<AddReferenceImageJobState>();
                    foreach (XRReferenceImage tmp_ReferenceImage in tmp_ReferenceImageLib)
                    {
                        if (tmp_ReferenceImage.texture == null || !tmp_ReferenceImage.texture.isReadable)
                            continue;

                        var tmp_JobState =
                            tmp_RuntimeLibrary.ScheduleAddImageWithValidationJob(tmp_ReferenceImage.texture,
                                tmp_ReferenceImage.name, tmp_ReferenceImage.width);
                        addReferenceImagesJobState.Add(tmp_JobState);
                    }
                }
                catch (InvalidOperationException tmp_Exception)
                {
                    Debug.LogError(tmp_Exception.Message);
                    throw new InvalidOperationException(tmp_Exception.Message);
                }
            }

            while (!addReferenceImagesJobState[addReferenceImagesJobState.Count - 1].jobHandle.IsCompleted)
            {
                yield return null;
            }


            Assert.IsNotNull(tmp_RuntimeLibrary, "Create ReferenceLibrary failed!");
            trackedImageManager.referenceLibrary = tmp_RuntimeLibrary;


            // trackedImageManager.requestedMaxNumberOfMovingImages = maxNumOfMovingImages;
            trackedImageManager.enabled = true;
            trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }


        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            try
            {
                if (!trackedImageManager && trackedImageManager.descriptor == null) return;
                Assert.IsNotNull(trackedImageManager, "TrackedImageManager is no exist");
                trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
                trackedImageManager.enabled = false;
                hasStarted = false;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw new Exception(tmp_Exception.Message);
            }
        }


        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            try
            {
                if (!trackedImageManager && trackedImageManager.descriptor == null) return;

                PauseAlgorithm();

                if (trackedImageManager.trackedImagePrefab)
                {
                    Object.DestroyImmediate(trackedImageManager.trackedImagePrefab, true);
                    trackedImageManager.trackedImagePrefab = null;
                }

                Assert.IsNull(trackedImageManager.trackedImagePrefab, "trackedImagePrefab != null");

                var tmp_ReferenceImageLib =
                    IocContainer.GetIoc.Resolve<ARContextDataModel>().ReferenceImageLibrary;

                if (tmp_ReferenceImageLib)
                {
                    Object.DestroyImmediate(tmp_ReferenceImageLib, true);
                }

                Assert.IsNull(tmp_ReferenceImageLib, "TrackedImageManager != null");

                trackedImageManager.subsystem?.Stop();
                trackedImageManager.subsystem?.Destroy();


                trackedImageManager.enabled = false;
                if (trackedImageManager)
                {
                    Object.Destroy(trackedImageManager);
                    trackedImageManager = null;
                }

                allArTrackedImages.Clear();
                Assert.IsNull(trackedImageManager, "TrackedImageManager != null");

                markerNotificationData = null;
                hasStarted = false;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw new Exception(tmp_Exception.Message);
            }
        }

        public override bool SupportThisFeature()
        {
            return trackedImageManager.descriptor != null;
        }
    }
}