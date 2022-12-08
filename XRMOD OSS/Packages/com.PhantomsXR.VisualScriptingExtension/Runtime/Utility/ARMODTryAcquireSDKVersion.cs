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
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Try Acquire SDK Version")]
    [TypeIcon(typeof(AnimatorStateInfo))]
    public class ARMODTryAcquireSDKVersion : ARMODBaseWithResultUnitIncludeApi
    {
        private string sdkVersion;

        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _ => sdkVersion);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_API = _arg.GetValue<API>(Api);
            sdkVersion = tmp_API.TryAcquireSDKVersion();
            return outputTrigger;
        }
    }
}