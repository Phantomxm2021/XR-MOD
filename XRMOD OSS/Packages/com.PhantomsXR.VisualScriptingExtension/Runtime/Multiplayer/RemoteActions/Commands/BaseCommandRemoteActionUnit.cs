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
    //[UnitCategory("ARMOD/Multiplayer/Remote Actions"), UnitTitle("Command")]
    public abstract class BaseCommandRemoteActionUnit<T> : BaseNetworkRemoteActionUnit<T>
    {
        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => resultEventKey);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkRemoteActions>(RemoteActions);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.CmdSender);
            var tmp_Value = _arg.GetValue<T>(Parameters);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);

            if (tmp_RemoteActions.hasAuthority)
            {
                switch (tmp_Value)
                {
                    case int tmp_IntValue:
                        tmp_RemoteActions.CmdIntSender(tmp_EventName, tmp_IntValue, tmp_Sender);
                        break;
                    case float tmp_FloatValue:
                        tmp_RemoteActions.CmdFloatSender(tmp_EventName, tmp_FloatValue, tmp_Sender);
                        break;
                    case bool tmp_BoolValue:
                        tmp_RemoteActions.CmdBoolSender(tmp_EventName, tmp_BoolValue, tmp_Sender);
                        break;
                    case string tmp_StringValue:
                        tmp_RemoteActions.CmdStringSender(tmp_EventName, tmp_StringValue, tmp_Sender);
                        break;
                    case Vector3 tmp_Vector3Value:
                        tmp_RemoteActions.CmdVector3Sender(tmp_EventName, tmp_Vector3Value, tmp_Sender);
                        break;
                    case Quaternion tmp_QuaternionValue:
                        tmp_RemoteActions.CmdQuaternionSender(tmp_EventName, tmp_QuaternionValue, tmp_Sender);
                        break;
                    case GameObject tmp_GameObjectValue:
                        tmp_RemoteActions.CmdGameObjectSender(tmp_EventName, tmp_GameObjectValue, tmp_Sender);
                        break;
                    case TransformData tmp_TransformData:
                        tmp_RemoteActions.CmdTransformDataSender(tmp_EventName, tmp_TransformData, tmp_Sender);
                        break;
                }
            }


            return outputTrigger;
        }
    }
}