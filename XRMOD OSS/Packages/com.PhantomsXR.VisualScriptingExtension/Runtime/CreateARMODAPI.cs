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
    [UnitCategory("ARMOD"), UnitTitle("ARMOD API"),UnitShortTitle("ARMOD API")]
    public class CreateARMODAPI : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] public ValueInput ProjectName;
        private API api;

        protected override void Definition()
        {
            base.Definition();
            ProjectName = ValueInput(nameof(ProjectName), (string)null);
            Result = ValueOutput(nameof(API), _flow => api);
            Requirement(ProjectName, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            api = new API(_arg.GetValue<string>(ProjectName));
            return outputTrigger;
        }
    }
}