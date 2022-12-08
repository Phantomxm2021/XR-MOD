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

using Mirror;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Network Animator Trigger"), TypeIcon(typeof(Animator))]
    public class NetworkAnimatorTriggerUnit : ARMODBaseUnit
    {
        public enum TriggerTypeEnum
        {
            SetTrigger,
            ResetTrigger
        }

        [DoNotSerialize] public ValueInput TriggerName;
        [DoNotSerialize, NullMeansSelf] public ValueInput Animator;
        [DoNotSerialize] public ValueInput TriggerType;

        protected override void Definition()
        {
            base.Definition();
            TriggerName = ValueInput(nameof(TriggerName), (string) null);
            TriggerType = ValueInput(nameof(TriggerType), TriggerTypeEnum.SetTrigger);
            Animator = ValueInput(nameof(Animator), (NetworkAnimator) null).NullMeansSelf();
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_TriggerName = _arg.GetValue<string>(TriggerName);
            Assert.IsNotNull(tmp_TriggerName);

            var tmp_Animator = _arg.GetValue<NetworkAnimator>(Animator);
            Assert.IsNotNull(tmp_Animator);
            switch (_arg.GetValue<TriggerTypeEnum>(TriggerType))
            {
                case TriggerTypeEnum.ResetTrigger:
                    tmp_Animator.ResetTrigger(tmp_TriggerName);
                    break;
                case TriggerTypeEnum.SetTrigger:
                    tmp_Animator.SetTrigger(tmp_TriggerName);
                    break;
            }

            return outputTrigger;
        }
    }
}