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

using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Register Prefab")]
    public class RegisterPrefabUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput Prefab;

        protected override void Definition()
        {
            base.Definition();
            Prefab = ValueInput(nameof(Prefab), (GameObject) null);
            Requirement(Prefab, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Prefab = _arg.GetValue<GameObject>(Prefab);
            Assert.IsNotNull(tmp_Prefab);
            XRMODServices.GetBridge().RegisterPrefab(tmp_Prefab);
            return outputTrigger;
        }
    }
}