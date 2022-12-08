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


using System.Collections.Generic;
using UnityEngine;

namespace com.Phantoms.ARMODPackageTools.Runtime
{
    [System.Serializable]
    public class BundleDetails
    {
        public string m_FileName;

        public uint m_Crc;

        public string m_Hash;

        //public List<string> m_Dependencies;
    }

    [System.Serializable]
    public class XRExperienceData
    {
        public string BundleName;
        public List<string> AddressableName;
        public List<string> AssetsName;
        public BundleDetails BundleDetails;
    }
}