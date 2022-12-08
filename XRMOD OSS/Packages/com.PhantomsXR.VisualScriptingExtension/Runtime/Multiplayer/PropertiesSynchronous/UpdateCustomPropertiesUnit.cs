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
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EntityProperties"), UnitTitle("Update CustomProperties Trigger")]
    public class UpdateCustomPropertiesUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput CustomProperties;
        [DoNotSerialize, NullMeansSelf] public ValueInput PlayerProperties;
        [DoNotSerialize] public ValueInput Sender;

        protected override void Definition()
        {
            base.Definition();
            CustomProperties = ValueInput(nameof(CustomProperties), (string) null);
            PlayerProperties = ValueInput<NetworkPropertiesSync>(nameof(PlayerProperties)).NullMeansSelf();
            Sender = ValueInput<NetworkIdentity>(nameof(Sender), null);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_CustomProperties = _arg.GetValue<string>(CustomProperties);
            var tmp_Properties = _arg.GetValue<NetworkPropertiesSync>(PlayerProperties);
            Assert.IsNotNull(tmp_Properties);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);

            if (!tmp_Properties.hasAuthority) return outputTrigger;
            tmp_Properties.CmdUpdateCustomProperties(tmp_CustomProperties, tmp_Sender);
            return outputTrigger;
        }
    }
}