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
    [UnitCategory("ARMOD/Native"), UnitTitle("Get DeviceInfo")]
    [TypeIcon(typeof(AnimatorStateInfo))]
    public class ARMODGetDeviceInfo : ARMODBaseWithResultUnitIncludeApi
    {
        private string deviceInfoJson;

        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => deviceInfoJson);
            Requirement(Api,inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            deviceInfoJson = _arg.GetValue<API>(Api).GetDeviceInfo();
            return outputTrigger;
        }
    }
}