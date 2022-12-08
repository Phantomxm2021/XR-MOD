using System;
using System.Collections.Generic;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/Attributes"),
     UnitSurtitle("Receiver"),
     UnitTitle("Register Client Event Receiver"),
     UnitShortTitle("Register Client Event"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class ClientEventReceiver : BaseAttributeEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region Client

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkingCallbacks.ClientIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkingCallbacks.ClientIntAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientIntSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkingCallbacks.ClientBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkingCallbacks.ClientBoolAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientBoolSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkingCallbacks.ClientFloatAction ??=
                            new Dictionary<string, Action<float, NetworkIdentity>>();
                        NetworkingCallbacks.ClientFloatAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientFloatSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkingCallbacks.ClientStringAction ??=
                            new Dictionary<string, Action<string, NetworkIdentity>>();
                        NetworkingCallbacks.ClientStringAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientSender), _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkingCallbacks.ClientVector3Action ??=
                            new Dictionary<string, Action<Vector3, NetworkIdentity>>();
                        NetworkingCallbacks.ClientVector3Action.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientVector3Sender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkingCallbacks.ClientQuaternionAction ??=
                            new Dictionary<string, Action<Quaternion, NetworkIdentity>>();
                        NetworkingCallbacks.ClientQuaternionAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientQuaternionSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkingCallbacks.ClientGameObjectAction ??=
                            new Dictionary<string, Action<GameObject, NetworkIdentity>>();
                        NetworkingCallbacks.ClientGameObjectAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientGameObjectSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkingCallbacks.ClientTransformDataAction ??=
                            new Dictionary<string, Action<TransformData, NetworkIdentity>>();
                        NetworkingCallbacks.ClientTransformDataAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientTransformDataSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.None:
                        NetworkingCallbacks.ClientAction ??= new Dictionary<string, Action<NetworkIdentity>>();
                        NetworkingCallbacks.ClientAction.Add(tmp_Callback, _sender =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackTransformDataSender),
                                _sender);
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