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
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace SDKEntry.Runtime
{
    public class SceneInitialization
    {
        private Camera uiCamera;

        public bool Executed()
        {
            try
            {
                // uiCamera = GameObject.FindWithTag(ConstKey.CONST_UI_CAMERA_TAG).GetComponent<Camera>();
                // var tmp_MainCamera = Camera.main;
                // var tmp_MainAdditionalCameraData = tmp_MainCamera.GetUniversalAdditionalCameraData();
                // tmp_MainAdditionalCameraData.cameraStack.Add(uiCamera);

                var tmp_SDKInformation = Resources.Load<SDKInformation>(nameof(SDKInformation));
                if (SceneManager.GetActiveScene().name != "Main") return false;
                if (tmp_SDKInformation.DeviceLauncher == null) return true;
                var tmp_DeviceLauncher = Object.Instantiate(tmp_SDKInformation.DeviceLauncher);
                tmp_DeviceLauncher.transform.localPosition = Vector3.zero;
                tmp_DeviceLauncher.transform.localRotation = Quaternion.identity;

                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
            }

            return false;
        }
    }
}