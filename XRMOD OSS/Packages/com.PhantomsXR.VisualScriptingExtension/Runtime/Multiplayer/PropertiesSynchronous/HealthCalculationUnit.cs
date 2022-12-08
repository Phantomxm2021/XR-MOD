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
using Mirror;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public enum CalculationType
    {
        Increase,
        Decrease
    }


    [UnitCategory("ARMOD/Multiplayer/EntityProperties"), UnitTitle("Health Calculation Trigger")]
    public class HealthCalculationUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput Health;
        [DoNotSerialize] [NullMeansSelf] public ValueInput PlayerProperties;
        [DoNotSerialize] public ValueInput CalculationType;
        [DoNotSerialize] public ValueInput Sender;


        protected override void Definition()
        {
            base.Definition();
            Health = ValueInput<int>(nameof(Health));
            PlayerProperties = ValueInput(nameof(PlayerProperties), (NetworkPropertiesSync) null).NullMeansSelf();
            CalculationType = ValueInput(nameof(Runtime.CalculationType), Runtime.CalculationType.Increase);
            Sender = ValueInput<NetworkIdentity>(nameof(Sender),null);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Health = _arg.GetValue<int>(Health);
            var tmp_Properties = _arg.GetValue<NetworkPropertiesSync>(PlayerProperties);
            Assert.IsNotNull(tmp_Properties);
            var tmp_MathematicalType = _arg.GetValue<CalculationType>(CalculationType);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);

            //Do not send any message when network client is not connected.
            if (!NetworkClient.active) return outputTrigger;

            switch (tmp_MathematicalType)
            {
                case Runtime.CalculationType.Increase:
                    tmp_Properties.CmdAddHealth(tmp_Health, tmp_Sender);
                    break;
                case Runtime.CalculationType.Decrease:
                    tmp_Properties.CmdSubtractHealth(tmp_Health, tmp_Sender);
                    break;
            }

            return outputTrigger;
        }
    }
}