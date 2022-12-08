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
using UnityEngine.UI;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Get SystemLanguage")]
    [TypeIcon(typeof(Text))]
    public class ARMODGetSystemLanguage : ARMODBaseWithResultUnitIncludeApi
    {
        private string systemLanguage;


        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => systemLanguage);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            systemLanguage = _arg.GetValue<API>(Api).GetSystemLanguage();
            return outputTrigger;
        }
    }
}