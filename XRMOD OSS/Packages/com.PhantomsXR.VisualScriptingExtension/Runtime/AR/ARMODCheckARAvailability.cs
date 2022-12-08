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


namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR"), UnitTitle("Check AR Availability")]
    public class ARMODCheckARAvailability : Unit
    {
        [DoNotSerialize] [PortLabelHidden] public ControlInput inputTrigger;
        [DoNotSerialize] public ControlOutput True;
        [DoNotSerialize] public ControlOutput False;
        [DoNotSerialize] public ValueInput API;

        protected override void Definition()
        {
            inputTrigger = ControlInput(nameof(inputTrigger), Execute);
            True = ControlOutput(nameof(True));
            False = ControlOutput(nameof(False));
            API = ValueInput<API>(nameof(API), null);
            Requirement(API, inputTrigger);
            Succession(inputTrigger, True);
            Succession(inputTrigger, False);
        }

        private ControlOutput Execute(Flow _arg)
        {
            return _arg.GetValue<API>(API).CheckARAvailability() ? True : False;
        }
    }
}
#endif