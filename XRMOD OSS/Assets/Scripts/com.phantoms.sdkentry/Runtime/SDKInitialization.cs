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

using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace SDKEntry.Runtime
{
    public static class SDKInitialization
    {
        private const string CONST_SDK_ENTRY_PREFAB_PATH = "Prefabs/EntryPoint";
        private const string CONST_CLONE_TAG = "(Clone)";
#if !UNITY_EDITOR || ENABLE_ARMOD_AUTOSTART
        [RuntimeInitializeOnLoadMethod]
#endif
        public static void Initialize()
        {
            QualitySettings.SetQualityLevel(3,true);
            if (Object.FindObjectOfType<SDKEntryPoint>() != null)
            {
                Debug.LogWarning("SDK Entry Point is already!");
                return;
            }

            Application.targetFrameRate = 60;
            
            var tmp_SDKEntryPrefab = Resources.Load(CONST_SDK_ENTRY_PREFAB_PATH);
            GameObject tmp_SDKEntry =
                Object.Instantiate(tmp_SDKEntryPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            Assert.IsNotNull(tmp_SDKEntry);
            tmp_SDKEntry.name = tmp_SDKEntry.name.Replace(CONST_CLONE_TAG, string.Empty);
        }
    }
}