using System;
using System.Collections.Generic;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/Attributes"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register Server Receiver"),
     UnitShortTitle("Register Server"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class ServerEventReceiver : BaseAttributeEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region Server

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkingCallbacks.ServerIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkingCallbacks.ServerIntAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerIntSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkingCallbacks.ServerBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkingCallbacks.ServerBoolAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerBoolSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkingCallbacks.ServerFloatAction ??=
                            new Dictionary<string, Action<float, NetworkIdentity>>();
                        NetworkingCallbacks.ServerFloatAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerFloatSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkingCallbacks.ServerStringAction ??=
                            new Dictionary<string, Action<string, NetworkIdentity>>();
                        NetworkingCallbacks.ServerStringAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkingCallbacks.ServerVector3Action ??=
                            new Dictionary<string, Action<Vector3, NetworkIdentity>>();
                        NetworkingCallbacks.ServerVector3Action.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerVector3Sender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkingCallbacks.ServerQuaternionAction ??=
                            new Dictionary<string, Action<Quaternion, NetworkIdentity>>();
                        NetworkingCallbacks.ServerQuaternionAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerQuaternionSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkingCallbacks.ServerGameObjectAction ??=
                            new Dictionary<string, Action<GameObject, NetworkIdentity>>();
                        NetworkingCallbacks.ServerGameObjectAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerGameObjectSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkingCallbacks.ServerTransformDataAction ??=
                            new Dictionary<string, Action<TransformData, NetworkIdentity>>();
                        NetworkingCallbacks.ServerTransformDataAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerTransformDataSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.None:
                        NetworkingCallbacks.ServerAction ??= new Dictionary<string, Action<NetworkIdentity>>();
                        NetworkingCallbacks.ServerAction.Add(tmp_Callback, _sender =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerSender), _sender);
                        });
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
            }

            #endregion
        }
    }
}