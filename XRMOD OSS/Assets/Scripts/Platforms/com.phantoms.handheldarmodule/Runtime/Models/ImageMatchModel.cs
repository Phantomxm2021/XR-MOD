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

namespace HandheldARModule.Runtime.Models
{
    [System.Serializable]
    public class ImageMatchModel
    {
        public int id;
        public string metadata;
        public string timestamp;
        public int matchscore;
    }
}