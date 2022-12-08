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

using Unity.VisualScripting;
using com.Phantoms.ARMODAPI.Runtime;


namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR"),UnitTitle("Exit AR")]
    public class ARMODExitAR : Unit
    {
        [DoNotSerialize][PortLabelHidden] public ControlInput inputTrigger;
        [DoNotSerialize] public ValueInput API;

        protected override void Definition()
        {
            inputTrigger = ControlInput(nameof(inputTrigger), Execute);

            API = ValueInput<API>(nameof(API), null);
        }

        private ControlOutput Execute(Flow _arg)
        {
            _arg.GetValue<API>(API)?.Exit();
            return null;
        }
    }
}