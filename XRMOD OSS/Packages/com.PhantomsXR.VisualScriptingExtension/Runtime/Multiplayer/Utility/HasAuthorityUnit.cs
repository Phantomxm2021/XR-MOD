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

using System;
using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Has Authority"), UnitShortTitle("Has Authority")]
    public class HasAuthorityUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] [PortLabelHidden]
        public ValueInput Target;

        private NetworkIdentity networkIdentity;
        private bool hasAuthority;

        protected override void Definition()
        {
            base.Definition();
            Target = ValueInput(nameof(Target), (NetworkIdentity) null).NullMeansSelf();
            Result = ValueOutput(nameof(Result), _flow => hasAuthority);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            Assert.IsNotNull(Target);
            networkIdentity = _arg.GetValue<NetworkIdentity>(Target);
            hasAuthority = networkIdentity.hasAuthority;
            return outputTrigger;
        }
    }
}