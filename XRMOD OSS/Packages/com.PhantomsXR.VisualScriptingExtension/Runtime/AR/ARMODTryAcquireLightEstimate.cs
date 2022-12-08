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
#if UNITY_IOS || UNITY_ANDROID

using Unity.VisualScripting;
using com.Phantoms.ARMODAPI.Runtime;

using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR/Data")]
    [UnitTitle("Light Estimate")]
    [TypeIcon(typeof(Light))]
    public class ARMODTryAcquireLightEstimate : ARMODBaseWithResultUnitIncludeApi
    {
        private Light light;

        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => light);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            light = _arg.GetValue<API>(Api).TryAcquireLightEstimateValue();
            return outputTrigger;
        }
    }
}
#endif