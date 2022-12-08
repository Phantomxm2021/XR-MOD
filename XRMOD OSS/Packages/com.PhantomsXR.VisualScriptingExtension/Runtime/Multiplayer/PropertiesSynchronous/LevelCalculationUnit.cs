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
    [UnitCategory("ARMOD/Multiplayer/EntityProperties"), UnitTitle("Level Calculation Trigger")]
    public class LevelCalculationUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput Level;
        [DoNotSerialize] public ValueInput PlayerProperties;
        [DoNotSerialize] public ValueInput CalculationType;
        [DoNotSerialize] public ValueInput Sender;

        protected override void Definition()
        {
            base.Definition();
            Level = ValueInput<int>(nameof(Level));
            PlayerProperties = ValueInput<NetworkPropertiesSync>(nameof(PlayerProperties));
            CalculationType = ValueInput(nameof(CalculationType), Runtime.CalculationType.Increase);
            Sender = ValueInput(nameof(Sender), (NetworkIdentity) null);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Level = _arg.GetValue<int>(Level);
            var tmp_Properties = _arg.GetValue<NetworkPropertiesSync>(PlayerProperties);
            Assert.IsNotNull(tmp_Properties);
            var tmp_CalculationType = _arg.GetValue<CalculationType>(CalculationType);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);

            if (!tmp_Properties.hasAuthority) return outputTrigger;

            switch (tmp_CalculationType)
            {
                case Runtime.CalculationType.Increase:
                    tmp_Properties.CmdLevelUp(tmp_Level, tmp_Sender);
                    break;
                case Runtime.CalculationType.Decrease:
                    tmp_Properties.CmdDegradeLevel(tmp_Level, tmp_Sender);
                    break;
            }

            return outputTrigger;
        }
    }
}