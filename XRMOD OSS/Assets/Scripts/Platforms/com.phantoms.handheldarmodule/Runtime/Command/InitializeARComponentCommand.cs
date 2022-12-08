// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The com.Phantoms.ARAlgorithm.Runtime cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using HandheldARModule.Runtime.Models;
using HandheldARModule.Runtime.Utility;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class InitializeARComponentCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            Object.FindObjectOfType<SceneGrab>().ActiveARSession();

            ARComponentModel tmp_ARComponentData = IocContainer.GetIoc.Resolve<ARComponentModel>();

            tmp_ARComponentData.XROriginGameObject = GameObject.FindWithTag(ConstKey.CONST_AR_SESSION_ORIGIN_NAME);
            tmp_ARComponentData.SessionGameObject = GameObject.FindWithTag(ConstKey.CONST_AR_SESSION_NAME);

            Assert.IsNotNull(tmp_ARComponentData.SessionGameObject);
            Assert.IsNotNull(tmp_ARComponentData.XROriginGameObject);

            tmp_ARComponentData.ARSession = tmp_ARComponentData.SessionGameObject.GetComponentInChildren<ARSession>();
            Assert.IsNotNull(tmp_ARComponentData.ARSession);

            tmp_ARComponentData.ARInputManager =
                tmp_ARComponentData.SessionGameObject.GetComponentInChildren<ARInputManager>();
            Assert.IsNotNull(tmp_ARComponentData.ARInputManager);

            if (!tmp_ARComponentData.XROriginGameObject) return;
#if ARFOUNDATION_5_0_0
            tmp_ARComponentData.XROrigin = tmp_ARComponentData.XROriginGameObject.GetComponent<XROrigin>();
#else
            tmp_ARComponentData.XROrigin = tmp_ARComponentData.XROriginGameObject.GetComponent<ARSessionOrigin>();
#endif
            Assert.IsNotNull(tmp_ARComponentData.XROrigin);

            tmp_ARComponentData.ARCamera = tmp_ARComponentData.XROriginGameObject.GetComponentInChildren<Camera>();
            Assert.IsNotNull(tmp_ARComponentData.ARCamera);

            tmp_ARComponentData.CameraGameObject = tmp_ARComponentData.ARCamera.gameObject;
            Assert.IsNotNull(tmp_ARComponentData.CameraGameObject);

            // tmp_ARComponentData.ARPoseDriverExtension = tmp_ARComponentData.ARCamera.GetComponent<ARPoseDriver>();
            // Assert.IsNotNull(tmp_ARComponentData.ARPoseDriverExtension);
            tmp_ARComponentData.ARPoseDriverExtension = tmp_ARComponentData.ARCamera.GetComponent<TrackedPoseDriver>();
            Assert.IsNotNull(tmp_ARComponentData.ARPoseDriverExtension);


            tmp_ARComponentData.ARCameraManager = tmp_ARComponentData.ARCamera.GetComponent<ARCameraManager>();
            Assert.IsNotNull(tmp_ARComponentData.ARCameraManager);

            tmp_ARComponentData.ARCameraBackground = tmp_ARComponentData.ARCamera.GetComponent<ARCameraBackground>();
            Assert.IsNotNull(tmp_ARComponentData.ARCameraBackground);

            tmp_ARComponentData.ARGestureInteractor = tmp_ARComponentData.ARCamera.GetComponent<ARGestureInteractor>();
            Assert.IsNotNull(tmp_ARComponentData.ARGestureInteractor);
        }

        public void Release()
        {
        }
    }
}