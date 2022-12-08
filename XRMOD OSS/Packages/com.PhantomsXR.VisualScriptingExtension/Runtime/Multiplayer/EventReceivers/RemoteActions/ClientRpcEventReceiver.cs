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
     UnitTitle("Register ClientRpc Receiver"),
     UnitShortTitle("Register ClientRpc"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class ClientRpcEventReceiver : BaseRemoteActionEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region RpcClientRpc

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkRemoteActions.ClientRpcIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkRemoteActions.ClientRpcIntAction.Add(tmp_Callback,
                            (_parameter, _sender) =>
                            {
                                CustomEvent.Trigger(tmp_EventTarget, tmp_Callback, _parameter, _sender);
                            });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkRemoteActions.ClientRpcBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkRemoteActions.ClientRpcBoolAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcBoolSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkRemoteActions.ClientRpcFloatAction ??=
                            new Dictionary<string, Action<float, NetworkIdentity>>();
                        NetworkRemoteActions.ClientRpcFloatAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcFloatSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkRemoteActions.ClientRpcStringAction ??=
                            new Dictionary<string, Action<string, NetworkIdentity>>();

                        NetworkRemoteActions.ClientRpcStringAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkRemoteActions.ClientRpcVector3Action ??=
                            new Dictionary<string, Action<Vector3, NetworkIdentity>>();

                        NetworkRemoteActions.ClientRpcVector3Action.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcVector3Sender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkRemoteActions.ClientRpcQuaternionAction ??=
                            new Dictionary<string, Action<Quaternion, NetworkIdentity>>();

                        NetworkRemoteActions.ClientRpcQuaternionAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcQuaternionSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkRemoteActions.ClientRpcGameObjectAction ??=
                            new Dictionary<string, Action<GameObject, NetworkIdentity>>();

                        NetworkRemoteActions.ClientRpcGameObjectAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcGameObjectSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkRemoteActions.ClientRpcTransformDataAction ??=
                            new Dictionary<string, Action<TransformData, NetworkIdentity>>();

                        NetworkRemoteActions.ClientRpcTransformDataAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcTransformDataSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.None:
                        NetworkRemoteActions.ClientRpcAction ??= new Dictionary<string, Action<NetworkIdentity>>();
                        NetworkRemoteActions.ClientRpcAction.Add(tmp_Callback, _sender =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.RpcClientRpcSender), _sender);
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