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
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Compare Runtime Tag"), UnitShortTitle("Compare Runtime Tag"),
     TypeIcon(typeof(Equal))]
    public class ARMODCompareRuntimeTagUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] [PortLabelHidden]
        public ValueInput Target;

        [DoNotSerialize] [PortLabel("Tag")] public ValueInput compareTagStr;

        private bool theSame;

        protected override void Definition()
        {
            base.Definition();
            Target = ValueInput(nameof(Target), (GameObject) null).NullMeansSelf();
            compareTagStr = ValueInput(nameof(compareTagStr), string.Empty);
            Result = ValueOutput<bool>(nameof(Result), _flow => theSame);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            theSame = false;
            var tmp_RuntimeGo = _arg.GetValue<GameObject>(Target);
            Assert.IsNotNull(tmp_RuntimeGo);
            var tmp_Irt = tmp_RuntimeGo.GetComponent<IRuntimeTag>();
            if (tmp_Irt == null) return outputTrigger;
            Assert.IsNotNull(tmp_Irt);
            Debug.Log(_arg.GetValue<string>(compareTagStr));
            theSame = tmp_Irt.DoCompareTag(_arg.GetValue<string>(compareTagStr));
            return outputTrigger;
        }
    }
}