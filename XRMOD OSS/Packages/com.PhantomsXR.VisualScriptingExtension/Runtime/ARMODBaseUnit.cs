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

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class ARMODBaseUnit : Unit, ARMODUnitExecutor
    {
        [DoNotSerialize] [PortLabelHidden] public ControlInput inputTrigger;
        [DoNotSerialize] [PortLabelHidden] public ControlOutput outputTrigger;

        protected override void Definition()
        {
            inputTrigger = ControlInput(nameof(inputTrigger), Execute);
            outputTrigger = ControlOutput(nameof(outputTrigger));
            Succession(inputTrigger, outputTrigger);
        }

        public virtual ControlOutput Execute(Flow _arg)
        {
            throw new System.NotImplementedException();
        }
    }
}