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

namespace HandheldARModule.Runtime.Models
{
    public class ImmersalContextDataModel
    {
        public string DeveloperToken;
        public bool AutoStart = true;
        public bool UseFiltering = true;
        public bool ResetOnMapChange=false;
        public float LocalizationInterval = 2f;
        public bool UseServerLocalizer;
        public bool BurstMode = true;
        public bool StopLocalizedAfterSuccess;
    }
}