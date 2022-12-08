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
using com.phantoms.models.Runtime;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Utility
{
    public class SceneGrab : MonoBehaviour, IUtility
    {
        public GameObject[] HandheldARGameObjects;
        public AROcclusionManager OcclusionManager;
        public ARGestureInteractor ARGestureInteractor;
        public GameObject BuiltinCamera;

        private void Start()
        {
            var tmp_CameraGo = GameObject.Find("BuiltCamera");
            if (tmp_CameraGo)
            {
                tmp_CameraGo.DestroyWithPlatform();
            }
        }

        [ContextMenu("Active Test")]
        public void ActiveARSession()
        {
            foreach (GameObject tmp_GameObject in HandheldARGameObjects)
            {
                tmp_GameObject.SetActive(true);
            }

            BuiltinCamera.SetActive(false);
        }
    }
}