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

using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class ARMODBaseWithResultUnitIncludeApi : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] public ValueInput Api;

        protected override void Definition()
        {
            base.Definition();
            Api = ValueInput<API>(nameof(API));
        }
    }
}