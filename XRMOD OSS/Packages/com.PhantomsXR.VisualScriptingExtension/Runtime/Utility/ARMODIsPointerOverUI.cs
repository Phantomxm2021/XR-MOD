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
    [UnitCategory("ARMOD/Utility"), UnitTitle("Is PointerOverUI Checker")]
    [TypeIcon(typeof(Touch))]
    public class ARMODIsPointerOverUI : Unit
    {
        [DoNotSerialize] public ControlInput inputTrigger;
        [DoNotSerialize] public ControlOutput True;
        [DoNotSerialize] public ControlOutput False;


        [DoNotSerialize] public ValueInput API;

        protected override void Definition()
        {
            inputTrigger = ControlInput(nameof(inputTrigger), Execute);
            False = ControlOutput(nameof(False));
            True = ControlOutput(nameof(True));
            API = ValueInput<API>(nameof(API), null);
            Requirement(API,inputTrigger);
            Succession(inputTrigger,True);
            Succession(inputTrigger,False);
        }

        private ControlOutput Execute(Flow _arg)
        {
            return _arg.GetValue<API>(API).IsPointerOverUi() ? True : False;
        }
    }
}