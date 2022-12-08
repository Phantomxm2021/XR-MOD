// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.XR.PXR;
using UnityEngine;

namespace Pico.Runtime.ExtensionComponents
{
    public class PicoMixedRealityRedress : MonoBehaviour
    {
        private void OnEnable()
        {
            OnApplicationFocus(true);
        }

        private void OnDisable()
        {
            PXR_Boundary.EnableSeeThroughManual(false);
        }

        private void OnApplicationFocus(bool _hasFocus)
        {
            if (!_hasFocus) return;
            PXR_Boundary.EnableSeeThroughManual(_hasFocus);
        }
    }
}