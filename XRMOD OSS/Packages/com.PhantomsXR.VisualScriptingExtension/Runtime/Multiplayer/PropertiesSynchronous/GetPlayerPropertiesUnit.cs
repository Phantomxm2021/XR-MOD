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

using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EntityProperties"), UnitTitle("Get EntityProperties")]
    public class GetPlayerPropertiesUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput Target;
        private NetworkPropertiesSync networkPropertiesSync;

        protected override void Definition()
        {
            base.Definition();
            Target = ValueInput(nameof(Target), (GameObject)null).NullMeansSelf();
            Result = ValueOutput(nameof(Result), _flow => networkPropertiesSync);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Player = _arg.GetValue<GameObject>(Target);
            Assert.IsNotNull(tmp_Player);
            networkPropertiesSync = tmp_Player.GetComponent<NetworkPropertiesSync>();
            Assert.IsNotNull(networkPropertiesSync);
            return outputTrigger;
        }
    }
}