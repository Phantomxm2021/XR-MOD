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
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/Command"),
     UnitTitle("Default Command Trigger"),
     UnitSubtitle("None"),
     UnitShortTitle("Command Trigger"),
     TypeIcon(typeof(CustomEvent))]
    public class CommandRemoteActionsUnit : BaseNetworkRemoteActionsWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkRemoteActions>(RemoteActions);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.CmdSender);
            if (tmp_RemoteActions.hasAuthority)
            {
                tmp_RemoteActions.CmdSender(tmp_EventName, tmp_Sender);
            }

            return outputTrigger;
        }
    }
}