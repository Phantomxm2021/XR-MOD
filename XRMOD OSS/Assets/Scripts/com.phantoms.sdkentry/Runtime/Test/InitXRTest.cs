// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;
using com.phantoms.models.Runtime;
using UnityEngine;

namespace SDKEntry.Runtime.Test
{
    public class InitXRTest : MonoBehaviour
    {
        public SDKConfiguration Configure;
        public string ProjectUid = "180536908";

        private async void Start()
        {
            var tmp_SDKEntry = FindObjectOfType<SDKEntryPoint>();
            tmp_SDKEntry.InitSDK(JsonUtility.ToJson(Configure));
            await Task.Delay(1000);
            tmp_SDKEntry.LaunchXRQuery(ProjectUid);
        }
    }
}