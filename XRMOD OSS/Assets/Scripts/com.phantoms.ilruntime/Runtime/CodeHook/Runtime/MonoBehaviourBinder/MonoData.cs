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

using System;
using System.Collections.Generic;
using ILRuntime.Runtime.Enviorment;
using UnityEngine;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook
{
    [System.Serializable]
    public class MonoData
    {
        public string ClassNamespace;
        public string ClassName;

        public List<MonoField> Fields = new();

        internal bool BoundData;
        internal bool Added;
        internal bool Activated;

        internal CrossBindingAdaptorType ClrInstance;
        internal Type ClassType;

    }
}