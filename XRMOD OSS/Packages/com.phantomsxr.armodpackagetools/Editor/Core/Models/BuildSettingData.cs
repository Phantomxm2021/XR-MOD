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

using UnityEditor;
using UnityEngine;

namespace  com.Phantoms.ARMODPackageTools.Core
{
    [System.Serializable]
    public class BuildSettingData:ScriptableObject
    {
        public BuildTargetGroup BuildTargetGroup = BuildTargetGroup.iOS;
        public BuildTarget BuildTarget = BuildTarget.iOS;
        public BuildCompressionType BuildCompression = BuildCompressionType.LZ4;
    }

    public enum BuildCompressionType
    {
        Uncompressed,
        LZ4,
        LZMA,
        UncompressedRuntime,
        LZ4Runtime
    }
}