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
using UnityEngine;

namespace com.Phantoms.ARMODAPI.Runtime
{
    public class GameObjectRuntimeTag : MonoBehaviour, IRuntimeTag
    {
        public string RuntimeTag;
        // public bool RegisterImmediatelyl = true;
        
        public bool DoCompareTag(string _tag)
        {
            return String.CompareOrdinal(RuntimeTag, _tag) == 0;
        }
    }
}