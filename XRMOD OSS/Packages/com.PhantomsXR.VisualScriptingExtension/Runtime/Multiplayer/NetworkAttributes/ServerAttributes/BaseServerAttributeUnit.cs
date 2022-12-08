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
    // [UnitCategory("ARMOD/Multiplayer/NetworkAttributes"), UnitTitle("Server")]
    public abstract class BaseServerAttributeUnit<T> : BaseNetworkAttributeUnit<T>
    {
        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => resultEventKey);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_AttributeComponent = _arg.GetValue<NetworkingCallbacks>(Attributes);
            Assert.IsNotNull(tmp_AttributeComponent);
            resultEventKey = nameof(tmp_AttributeComponent.ServerSender);
            var tmp_Value = _arg.GetValue<T>(Parameters);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            if (!NetworkClient.localPlayer.isServer) return outputTrigger;
            switch (tmp_Value)
            {
                case int tmp_IntValue:
                    tmp_AttributeComponent.ServerIntSender(tmp_EventName, tmp_IntValue, tmp_Sender);
                    break;
                case float tmp_FloatValue:
                    tmp_AttributeComponent.ServerFloatSender(tmp_EventName, tmp_FloatValue, tmp_Sender);
                    break;
                case bool tmp_BoolValue:
                    tmp_AttributeComponent.ServerBoolSender(tmp_EventName, tmp_BoolValue, tmp_Sender);
                    break;
                case string tmp_StringValue:
                    tmp_AttributeComponent.ServerStringSender(tmp_EventName, tmp_StringValue, tmp_Sender);
                    break;
                case Vector3 tmp_Vector3Value:
                    tmp_AttributeComponent.ServerVector3Sender(tmp_EventName, tmp_Vector3Value, tmp_Sender);
                    break;
                case Quaternion tmp_QuaternionValue:
                    tmp_AttributeComponent.ServerQuaternionSender(tmp_EventName, tmp_QuaternionValue, tmp_Sender);
                    break;
                case GameObject tmp_GameObjectValue:
                    tmp_AttributeComponent.ServerGameObjectSender(tmp_EventName, tmp_GameObjectValue, tmp_Sender);
                    break;
                case TransformData tmp_TransformData:
                    tmp_AttributeComponent.ServerTransformDataSender(tmp_EventName, tmp_TransformData, tmp_Sender);
                    break;
            }

            return outputTrigger;
        }
    }
}