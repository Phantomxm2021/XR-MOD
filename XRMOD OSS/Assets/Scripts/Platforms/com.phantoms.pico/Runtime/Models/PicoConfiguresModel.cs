// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the PicoVR.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if UNITY_ANDROID && PICO_INSTALL
using com.phantoms.models.Runtime;

namespace Pico.Runtime.Models
{
    public class PicoConfiguresModel:BaseProjectConfigModel
    {
        public bool MixedReality=false;
    }
}
#endif
