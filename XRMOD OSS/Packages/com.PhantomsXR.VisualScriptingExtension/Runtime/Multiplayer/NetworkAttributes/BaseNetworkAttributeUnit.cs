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
using UnityEngine;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class BaseNetworkAttributeUnit<T> : ARMODBaseWithResultUnit
    {
        protected string resultEventKey = String.Empty;

        [DoNotSerialize] [NullMeansSelf] public ValueInput Attributes;
        [DoNotSerialize] public ValueInput Parameters;
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize] [NullMeansSelf] public ValueInput Sender;
        [DoNotSerialize] public ValueInput EventName;

        protected override void Definition()
        {
            base.Definition();
            Attributes = ValueInput(nameof(Attributes), (NetworkingCallbacks) null).NullMeansSelf();
            Parameters = ValueInput<T>(nameof(Parameters), default);
            EventName = ValueInput<string>(nameof(EventName), default);
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            Sender = ValueInput(nameof(Sender), (NetworkIdentity) null).NullMeansSelf();
        }
    }
}