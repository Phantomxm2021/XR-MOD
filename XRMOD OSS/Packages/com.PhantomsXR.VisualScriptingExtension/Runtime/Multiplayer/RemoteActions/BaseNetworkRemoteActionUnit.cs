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
    public abstract class BaseNetworkRemoteActionUnit<T> : ARMODBaseWithResultUnit
    {
        protected string resultEventKey = String.Empty;

        [DoNotSerialize] [NullMeansSelf] public ValueInput RemoteActions;
        [DoNotSerialize] public ValueInput Parameters;
        [DoNotSerialize] public ValueInput EventName;
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize] public ValueInput Sender;

        protected override void Definition()
        {
            base.Definition();
            RemoteActions = ValueInput(nameof(RemoteActions), (NetworkRemoteActions) null).NullMeansSelf();
            Parameters = ValueInput<T>(nameof(Parameters), default);
            EventName = ValueInput(nameof(EventName), (string) null);
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            Sender = ValueInput(nameof(Sender), (NetworkIdentity) null);
        }
    }
}