using System;
using System.Collections.Generic;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/Attributes"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register ClientCallback Receiver"),
     UnitShortTitle("Register ClientCallback"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class ClientCallbackCallbackEventReceiver : BaseAttributeEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region ClientCallback

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkingCallbacks.ClientCallbackIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkingCallbacks.ClientCallbackIntAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackIntSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkingCallbacks.ClientCallbackBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkingCallbacks.ClientCallbackBoolAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackBoolSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkingCallbacks.ClientCallbackFloatAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackFloatSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkingCallbacks.ClientCallbackStringAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkingCallbacks.ClientCallbackVector3Action.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackVector3Sender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkingCallbacks.ClientCallbackQuaternionAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackQuaternionSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkingCallbacks.ClientCallbackGameObjectAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackGameObjectSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkingCallbacks.ClientCallbackTransformDataAction.Add(tmp_Callback,
                            (_parameter, _sender) =>
                            {
                                CustomEvent.Trigger(tmp_EventTarget,
                                    tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackTransformDataSender),
                                    _parameter, _sender);
                            });
                        break;
                    case Runtime.DataType.None:
                        NetworkingCallbacks.ClientCallbackAction.Add(tmp_Callback, (_sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkingCallbacks.ClientCallbackSender), _sender);
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