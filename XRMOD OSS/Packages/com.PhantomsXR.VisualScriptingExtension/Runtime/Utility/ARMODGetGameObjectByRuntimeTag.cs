// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Get GameObjectBy Tag"), UnitShortTitle("Get GameObjectBy Tag"),
     TypeIcon(typeof(GameObject))]
    public class ARMODGetGameObjectByRuntimeTag : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [PortLabel("Runtime Tag")] public ValueInput runtimeTagStr;

        private GameObject resultGameObject;

        protected override void Definition()
        {
            base.Definition();
            runtimeTagStr = ValueInput(nameof(runtimeTagStr), string.Empty);
            Result = ValueOutput(nameof(Result), _flow => resultGameObject);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Tag = _arg.GetValue<string>(runtimeTagStr);
            RuntimeTagManager.GetRuntimeTagManager.GetGameObjectByTag(tmp_Tag, out resultGameObject);
            return outputTrigger;
        }
    }
}