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

using com.Phantoms.ActionNotification.Runtime;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    public class BaseMultiplayerData : BaseNotificationData
    {
        public NetworkStatus NetworkStatus;
    }

    public enum NetworkStatus
    {
        //NetworkManager callback keys
        OnStartServer,
        OnServerReady,
        OnStopServer,
        OnServerAddPlayer,
        OnServerDisconnect,
        OnServerConnect,
        OnStartClient,
        OnStopClient,
        OnClientNotReady,
        OnClientConnect,
        OnClientDisconnect,

        //NetworkRoomManager callback keys
        OnRoomStopClient,
        OnRoomStopServer,
        OnRoomServerPlayersReady,

        //NetworkRoomPlayer callback keys
        OnClientEnterRoom,
        OnClientExitRoom,
        ReadyStateChanged,
    }
}