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

namespace  com.Phantoms.ARMODPackageTools.Core
{
    [System.Serializable]
    public class AssemblyDataModel
    {
        public string name;
        public string rootNamespace;
        public List<string> references;

        public List<string> includePlatforms;


        public List<string> excludePlatforms;


        public bool allowUnsafeCode;


        public bool overrideReferences;


        public List<string> precompiledReferences;


        public bool autoReferenced;


        public List<string> defineConstraints;

        public List<string> versionDefines;


        public bool noEngineReferences;
    }
}