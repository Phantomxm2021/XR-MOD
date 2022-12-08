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
     UnitTitle("Register ServerCallback Receiver"),
     UnitShortTitle("Register ServerCallback"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class ServerCallbackEventReceiver : BaseAttributeEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region ServerCallback

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkingCallbacks.ServerCallbackIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackIntAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkingCallbacks.ServerCallbackBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackBoolAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkingCallbacks.ServerCallbackFloatAction ??=
                            new Dictionary<string, Action<float, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackFloatAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkingCallbacks.ServerCallbackStringAction ??=
                            new Dictionary<string, Action<string, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackStringAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkingCallbacks.ServerCallbackVector3Action ??=
                            new Dictionary<string, Action<Vector3, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackVector3Action.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkingCallbacks.ServerCallbackQuaternionAction ??=
                            new Dictionary<string, Action<Quaternion, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackQuaternionAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkingCallbacks.ServerCallbackGameObjectAction ??=
                            new Dictionary<string, Action<GameObject, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackGameObjectAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkingCallbacks.ServerCallbackTransformDataAction ??=
                            new Dictionary<string, Action<TransformData, NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackTransformDataAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.None:
                        NetworkingCallbacks.ServerCallbackAction ??= new Dictionary<string, Action<NetworkIdentity>>();
                        NetworkingCallbacks.ServerCallbackAction.Add(tmp_Callback, _sender =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ServerCallbackSender), _sender);
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