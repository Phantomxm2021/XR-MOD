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
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    // [UnitCategory("ARMOD/Multiplayer/NetworkAttributes"), UnitTitle("Client")]
    public abstract class BaseClientAttributeUnit<T> : BaseNetworkAttributeUnit<T>
    {
        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput("Result", _flow => resultEventKey);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_AttributeComponent = _arg.GetValue<NetworkingCallbacks>(Attributes);
            Assert.IsNotNull(tmp_AttributeComponent);
            resultEventKey = nameof(tmp_AttributeComponent.ClientSender);
            var tmp_Value = _arg.GetValue<T>(Parameters);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            if (tmp_AttributeComponent.hasAuthority)
            {
                switch (tmp_Value)
                {
                    case int tmp_IntValue:
                        tmp_AttributeComponent.ClientIntSender(tmp_EventName, tmp_IntValue, tmp_Sender);
                        break;
                    case float tmp_FloatValue:
                        tmp_AttributeComponent.ClientFloatSender(tmp_EventName, tmp_FloatValue, tmp_Sender);
                        break;
                    case bool tmp_BoolValue:
                        tmp_AttributeComponent.ClientBoolSender(tmp_EventName, tmp_BoolValue, tmp_Sender);
                        break;
                    case string tmp_StringValue:
                        tmp_AttributeComponent.ClientStringSender(tmp_EventName, tmp_StringValue, tmp_Sender);
                        break;
                    case Vector3 tmp_Vector3Value:
                        tmp_AttributeComponent.ClientVector3Sender(tmp_EventName, tmp_Vector3Value, tmp_Sender);
                        break;
                    case Quaternion tmp_QuaternionValue:
                        tmp_AttributeComponent.ClientQuaternionSender(tmp_EventName, tmp_QuaternionValue, tmp_Sender);
                        break;
                    case GameObject tmp_GameObjectValue:
                        tmp_AttributeComponent.ClientGameObjectSender(tmp_EventName, tmp_GameObjectValue, tmp_Sender);
                        break;
                    case TransformData tmp_TransformData:
                        tmp_AttributeComponent.ClientTransformDataSender(tmp_EventName, tmp_TransformData, tmp_Sender);
                        break;
                }
            }
            else
                Debug.LogWarning("Current side has not authority!");

            return outputTrigger;
        }
    }
}