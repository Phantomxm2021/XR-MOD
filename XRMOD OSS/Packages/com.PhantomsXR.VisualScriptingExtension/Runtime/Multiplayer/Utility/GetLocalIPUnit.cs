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
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;


namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Get LocalIP")]
    public class GetLocalIPUnit : Unit
    {
        [DoNotSerialize] [PortLabelHidden] public ControlInput inputTrigger;
        [DoNotSerialize] [PortLabelHidden] public ControlOutput outputTrigger;
        [DoNotSerialize] public ValueOutput IPAddress;

        private string iPAddress;

        protected override void Definition()
        {
            inputTrigger = ControlInput(nameof(inputTrigger), Execute);
            outputTrigger = ControlOutput(nameof(outputTrigger));
            IPAddress = ValueOutput(nameof(IPAddress), _flow => iPAddress);
            Succession(inputTrigger, outputTrigger);
        }

        private ControlOutput Execute(Flow _arg)
        {
            iPAddress = XRMODServices.GetBridge().GetLocalIP();
            return outputTrigger;
        }
    }
}