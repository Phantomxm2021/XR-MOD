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
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class BaseNetworkAttributeWithoutParameterUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput Attributes;
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize][NullMeansSelf]  public ValueInput Sender;
        [DoNotSerialize]  public ValueInput EventName;
        protected string resultEventKey = String.Empty;

        protected override void Definition()
        {
            base.Definition();
            Attributes = ValueInput(nameof(Attributes), (NetworkingCallbacks)null).NullMeansSelf();
            EventTarget = ValueInput(nameof(EventTarget), (GameObject)null).NullMeansSelf();
            EventName = ValueInput<string>(nameof(EventName),string.Empty);
            Sender = ValueInput(nameof(Sender),(NetworkIdentity)null).NullMeansSelf();
            Result = ValueOutput(nameof(Result), _flow => resultEventKey);
        }
    }
}