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

using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace HandheldARModule.Runtime.Utility
{
    public static class Extension
    {
        public static bool TryAcquireLatestCpuImageVersionAgnostic(this ARCameraManager _cameraManager,
            out XRCpuImage _cameraImage)
        {
            return _cameraManager.
#if ARFOUNDATION_5_0_0
                TryAcquireLatestCpuImage
#else
                TryGetLatestImage
#endif
                    (out _cameraImage);
        }

#if UNITY_EDITOR
        public static void DebugLogOnlyEditor(string _msg)
        {
            Debug.Log(_msg);
        }
#endif
    }
}