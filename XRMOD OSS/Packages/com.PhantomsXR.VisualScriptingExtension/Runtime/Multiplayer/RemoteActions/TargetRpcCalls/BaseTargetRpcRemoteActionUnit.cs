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
using Mirror;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    // [UnitCategory("ARMOD/Multiplayer/Remote Actions"), UnitTitle("Rpc Target")]
    public abstract class BaseTargetRpcRemoteActionUnit<T> : BaseNetworkRemoteActionUnit<T>
    {
        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => resultEventKey);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_ActionsComponent = _arg.GetValue<NetworkRemoteActions>(RemoteActions);
            Assert.IsNotNull(tmp_ActionsComponent);
            resultEventKey = nameof(tmp_ActionsComponent.TargetRpcSender);
            var tmp_Value = _arg.GetValue<T>(Parameters);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            if (tmp_ActionsComponent.isServer)
            {
                switch (tmp_Value)
                {
                    case int tmp_IntValue:
                        tmp_ActionsComponent.TargetRpcIntSender(tmp_EventName, tmp_IntValue, tmp_Sender);
                        break;
                    case float tmp_FloatValue:
                        tmp_ActionsComponent.TargetRpcFloatSender(tmp_EventName, tmp_FloatValue, tmp_Sender);
                        break;
                    case bool tmp_BoolValue:
                        tmp_ActionsComponent.TargetRpcBoolSender(tmp_EventName, tmp_BoolValue, tmp_Sender);
                        break;
                    case string tmp_StringValue:
                        tmp_ActionsComponent.TargetRpcStringSender(tmp_EventName, tmp_StringValue, tmp_Sender);
                        break;
                    case Vector3 tmp_Vector3Value:
                        tmp_ActionsComponent.TargetRpcVector3Sender(tmp_EventName, tmp_Vector3Value, tmp_Sender);
                        break;
                    case Quaternion tmp_QuaternionValue:
                        tmp_ActionsComponent.TargetRpcQuaternionSender(tmp_EventName, tmp_QuaternionValue, tmp_Sender);
                        break;
                    case GameObject tmp_GameObjectValue:
                        tmp_ActionsComponent.TargetRpcGameObjectSender(tmp_EventName, tmp_GameObjectValue, tmp_Sender);
                        break;
                    case TransformData tmp_TransformData:
                        tmp_ActionsComponent.TargetRpcTransformDataSender(tmp_EventName, tmp_TransformData, tmp_Sender);
                        break;
                }
            }
            else
                Debug.LogWarning("Current side is not Server!");

            return outputTrigger;
        }
    }
}