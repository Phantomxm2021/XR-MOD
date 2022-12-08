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
    [UnitCategory("ARMOD/Multiplayer/EntityProperties"), UnitTitle("Set PlayerName Trigger")]
    public class SetPlayerNameUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput PlayerName;
        [DoNotSerialize, NullMeansSelf] public ValueInput PlayerProperties;
        [DoNotSerialize] public ValueInput Sender;

        protected override void Definition()
        {
            base.Definition();
            PlayerName = ValueInput<string>(nameof(PlayerName));
            PlayerProperties = ValueInput(nameof(PlayerProperties), (NetworkPropertiesSync) null).NullMeansSelf();
            Sender = ValueInput(nameof(Sender), (NetworkIdentity) null);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_NewName = _arg.GetValue<string>(PlayerName);
            var tmp_Properties = _arg.GetValue<NetworkPropertiesSync>(PlayerProperties);
            Assert.IsNotNull(tmp_Properties);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            if (!tmp_Properties.hasAuthority) return outputTrigger;
            tmp_Properties.CmdSetObjectName(tmp_NewName, tmp_Sender);
            return outputTrigger;
        }
    }
}