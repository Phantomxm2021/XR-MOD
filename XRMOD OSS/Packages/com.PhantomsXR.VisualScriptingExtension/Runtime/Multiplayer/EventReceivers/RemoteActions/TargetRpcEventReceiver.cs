using System;
using System.Collections.Generic;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/RemoteActions"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register TargetRPC Receiver"),
     UnitShortTitle("Register TargetRPC"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class TargetRpcEventReceiver : BaseRemoteActionEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region TargetRPC

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkRemoteActions.TargetRpcIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcIntAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcIntSender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkRemoteActions.TargetRpcBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcBoolAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcBoolSender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkRemoteActions.TargetRpcFloatAction ??=
                            new Dictionary<string, Action<float, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcFloatAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcFloatSender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkRemoteActions.TargetRpcStringAction ??=
                            new Dictionary<string, Action<string, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcStringAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcSender), _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkRemoteActions.TargetRpcVector3Action ??=
                            new Dictionary<string, Action<Vector3, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcVector3Action.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcVector3Sender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkRemoteActions.TargetRpcQuaternionAction ??=
                            new Dictionary<string, Action<Quaternion, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcQuaternionAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcQuaternionSender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkRemoteActions.TargetRpcGameObjectAction ??=
                            new Dictionary<string, Action<GameObject, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcGameObjectAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcGameObjectSender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkRemoteActions.TargetRpcTransformDataAction ??=
                            new Dictionary<string, Action<TransformData, NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcTransformDataAction.Add(tmp_Callback, (_parameter, sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcTransformDataSender),
                                _parameter, sender);
                        });
                        break;
                    case Runtime.DataType.None:
                        NetworkRemoteActions.TargetRpcAction ??= new Dictionary<string, Action<NetworkIdentity>>();
                        NetworkRemoteActions.TargetRpcAction.Add(tmp_Callback, (_sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.TargetRpcSender), _sender);
                        });
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.ToString());
            }

            #endregion
        }
    }
}