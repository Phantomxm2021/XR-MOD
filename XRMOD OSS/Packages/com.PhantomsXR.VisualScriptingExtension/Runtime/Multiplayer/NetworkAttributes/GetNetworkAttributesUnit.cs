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

using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes"), UnitTitle("Get Network Attribute")]
    public class GetNetworkAttributesUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf]public ValueInput Target;
        private NetworkingCallbacks attributes;

        protected override void Definition()
        {
            base.Definition();
            Target = ValueInput(nameof(Target),(GameObject)null).NullMeansSelf();
            Result = ValueOutput(nameof(Result), _flow => attributes);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            Assert.IsNotNull(Target);
            attributes = _arg.GetValue<GameObject>(Target).GetComponent<NetworkingCallbacks>();
            return outputTrigger;
        }
    }
}