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

using UnityEngine;

namespace com.phantoms.models.Runtime
{
    public static class DestroyExtension
    {
        public static void DestroyWithPlatform(this UnityEngine.Object _object)
        {
            if (Application.isEditor)
            {
                Object.DestroyImmediate(_object, true);
            }
            else
            {
                Object.Destroy(_object);
            }
        }
    }
}