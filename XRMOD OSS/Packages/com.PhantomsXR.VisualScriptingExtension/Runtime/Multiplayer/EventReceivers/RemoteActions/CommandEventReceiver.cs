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
     UnitTitle("Register Command Receiver"),
     UnitShortTitle("Register Command"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class CommandEventReceiver : BaseRemoteActionEventReceiver
    {
        protected override void RegisterPropertiesSyncedEvent(Flow _arg)
        {
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Callback = _arg.GetValue<string>(EventName);

            #region Command

            try
            {
                switch (DataTypeEnum)
                {
                    case Runtime.DataType.Int:
                        NetworkRemoteActions.CmdIntAction ??=
                            new Dictionary<string, Action<int, NetworkIdentity>>();
                        NetworkRemoteActions.CmdIntAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdIntSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Bool:
                        NetworkRemoteActions.CmdBoolAction ??=
                            new Dictionary<string, Action<bool, NetworkIdentity>>();
                        NetworkRemoteActions.CmdBoolAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdBoolSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Float:
                        NetworkRemoteActions.CmdFloatAction ??=
                            new Dictionary<string, Action<float, NetworkIdentity>>();
                        NetworkRemoteActions.CmdFloatAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdFloatSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.String:
                        NetworkRemoteActions.CmdStringAction ??=
                            new Dictionary<string, Action<string, NetworkIdentity>>();
                        NetworkRemoteActions.CmdStringAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdSender), _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Vector3:
                        NetworkRemoteActions.CmdVector3Action ??=
                            new Dictionary<string, Action<Vector3, NetworkIdentity>>();
                        NetworkRemoteActions.CmdVector3Action.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdVector3Sender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.Quaternion:
                        NetworkRemoteActions.CmdQuaternionAction ??=
                            new Dictionary<string, Action<Quaternion, NetworkIdentity>>();
                        NetworkRemoteActions.CmdQuaternionAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdQuaternionSender),
                                _parameter);
                        });
                        break;
                    case Runtime.DataType.GameObject:
                        NetworkRemoteActions.CmdGameObjectAction ??=
                            new Dictionary<string, Action<GameObject, NetworkIdentity>>();
                        NetworkRemoteActions.CmdGameObjectAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdGameObjectSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.TransformData:
                        NetworkRemoteActions.CmdTransformDataAction ??=
                            new Dictionary<string, Action<TransformData, NetworkIdentity>>();
                        NetworkRemoteActions.CmdTransformDataAction.Add(tmp_Callback, (_parameter, _sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdTransformDataSender),
                                _parameter, _sender);
                        });
                        break;
                    case Runtime.DataType.None:
                        NetworkRemoteActions.CmdAction ??= new Dictionary<string, Action<NetworkIdentity>>();
                        NetworkRemoteActions.CmdAction.Add(tmp_Callback, (_sender) =>
                        {
                            CustomEvent.Trigger(tmp_EventTarget,
                                tmp_Callback ?? nameof(NetworkRemoteActions.CmdSender), _sender);
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