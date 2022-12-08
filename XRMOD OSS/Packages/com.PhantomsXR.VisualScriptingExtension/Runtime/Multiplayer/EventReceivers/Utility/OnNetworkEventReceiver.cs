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
using com.Phantoms.ActionNotification.Runtime;
using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/Other")]
    [ UnitSurtitle("Event Receiver")]
    [UnitShortTitle("Register NetworkStatus")]
    [UnitTitle("Register NetworkStatus Receiver")]
    [TypeIcon(type: typeof(AnimatorMessageListener))]
    public class OnNetworkEventReceiver : ARMODBaseUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;

        private GameObject eventTarget;

        protected override void Definition()
        {
            base.Definition();
            EventTarget = ValueInput(nameof(EventTarget), (GameObject)null).NullMeansSelf();

            ActionNotificationCenter.DefaultCenter.AddObserver(OnMultiplayerEvent,
                nameof(ActionParameterDataType.OnMultiplayerEvent));
        }

        public override ControlOutput Execute(Flow _arg)
        {
            eventTarget = _arg.GetValue<GameObject>(EventTarget);
            return outputTrigger;
        }

        public override void Dispose()
        {
            base.Dispose();
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.OnMultiplayerEvent));
        }

        private void OnMultiplayerEvent(BaseNotificationData _baseData)
        {
            if (_baseData is MultiplayerConnectionResponseData tmp_Data)
            {
                switch (tmp_Data.NetworkStatus)
                {
                    case NetworkStatus.OnStartServer:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnStartServer),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnServerReady:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnServerReady),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnStopServer:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnStopServer),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnServerAddPlayer:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnServerAddPlayer),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnServerDisconnect:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnServerDisconnect),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnServerConnect:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnServerConnect),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnStartClient:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnStartClient),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnStopClient:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnStopClient),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnClientNotReady:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnClientNotReady),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnClientConnect:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnClientConnect),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnClientDisconnect:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnClientDisconnect),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnRoomStopClient:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnRoomStopClient),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnRoomStopServer:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnRoomStopServer),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnRoomServerPlayersReady:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnRoomServerPlayersReady),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnClientEnterRoom:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnClientEnterRoom),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.OnClientExitRoom:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.OnClientExitRoom),
                            tmp_Data.NetworkConnection);
                        break;
                    case NetworkStatus.ReadyStateChanged:
                        CustomEvent.Trigger(eventTarget, nameof(NetworkStatus.ReadyStateChanged),
                            tmp_Data.NetworkConnection);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}