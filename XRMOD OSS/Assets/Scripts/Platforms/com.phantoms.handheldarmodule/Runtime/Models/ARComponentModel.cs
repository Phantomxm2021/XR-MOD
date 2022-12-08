// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using HandheldARModule.Runtime.FeaturesDecorator;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Models
{
    public class ARComponentModel : IModel, IReleaseCommand
    {
        public GameObject CameraGameObject;
        public GameObject SessionGameObject;
        public GameObject XROriginGameObject;
#if ARFOUNDATION_5_0_0
        public XROrigin XROrigin;
#else
        public ARSessionOrigin XROrigin;
#endif
        public Camera ARCamera;
        public ARSession ARSession;
        public ARInputManager ARInputManager;
        public ARCameraManager ARCameraManager;

        public ARRaycastManager ARRaycastManager;

        // public ARPoseDriver ARPoseDriverExtension;
        public TrackedPoseDriver ARPoseDriverExtension;
        public ARCameraBackground ARCameraBackground;
        public ARAnchorManager ARAnchorManager;
        public AROcclusionManager AROcclusionManager;
        public ARTrackedImageManager ARTrackedImageManager;
        public ARMeshManager ARMeshManager;
        public ARPlaneManager ARPlaneManager;
        public ARPointCloudManager ARPointCloudManager;
        public ARGestureInteractor ARGestureInteractor;

        public readonly Dictionary<Type, AbstractDecorator> AbstractDecorators = new();

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void Release()
        {
            foreach (KeyValuePair<Type, AbstractDecorator> tmp_Decorator in AbstractDecorators)
            {
                tmp_Decorator.Value.StopAlgorithm();
            }

            AbstractDecorators.Clear();

            CameraGameObject = null;
            SessionGameObject = null;
            XROriginGameObject = null;
            ARCamera = null;
            ARSession = null;
            ARInputManager = null;
            ARCameraManager = null;
            ARPoseDriverExtension = null;
            ARCameraBackground = null;
            AROcclusionManager = null;
            ARTrackedImageManager = null;
            ARMeshManager = null;
            ARPlaneManager = null;
            ARPointCloudManager = null;
        }
    }
}