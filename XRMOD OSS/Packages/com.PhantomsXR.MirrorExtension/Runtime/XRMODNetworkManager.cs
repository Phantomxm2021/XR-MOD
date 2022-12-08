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
using Mirror;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    public class XRMODNetworkManager : NetworkManager
    {
        private ActionNotificationCenter anc;
        private MultiplayerConnectionResponseData connectionResponseData;
        public Action RegisterCustomServerHandler;
        public Action OnServerStartCallback;

        public override void Awake()
        {
            base.Awake();
            anc = ActionNotificationCenter.DefaultCenter;
        }

        private void OnEnable()
        {
            XRMODServices.GetBridge().Initialize();
        }

        private void OnDisable()
        {
            XRMODServices.GetBridge().Deinitialize();
        }

        #region Client callbacks

        public override void OnStartClient()
        {
            base.OnStartClient();
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkStatus = NetworkStatus.OnStartClient
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnStopClient()
        {
            base.OnStopClient();
            connectionResponseData = new MultiplayerConnectionResponseData {NetworkStatus = NetworkStatus.OnStopClient};
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnClientNotReady(NetworkConnection conn)
        {
            base.OnClientNotReady(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn,
                NetworkStatus = NetworkStatus.OnClientNotReady
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnClientConnect(NetworkConnection conn)
        {
            base.OnClientConnect(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn, NetworkStatus = NetworkStatus.OnClientConnect
            };

            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }


        public override void OnClientDisconnect(NetworkConnection conn)
        {
            base.OnClientDisconnect(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn, NetworkStatus = NetworkStatus.OnClientDisconnect
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        #endregion


        #region Server callbacks

        public override void OnServerConnect(NetworkConnection conn)
        {
            base.OnServerConnect(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn, NetworkStatus = NetworkStatus.OnServerConnect
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }


        public override void OnServerReady(NetworkConnection conn)
        {
            base.OnServerReady(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn, NetworkStatus = NetworkStatus.OnServerReady
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnServerDisconnect(NetworkConnection conn)
        {
            base.OnServerDisconnect(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn, NetworkStatus = NetworkStatus.OnServerDisconnect
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnServerAddPlayer(NetworkConnection conn)
        {
            base.OnServerAddPlayer(conn);
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkConnection = conn, NetworkStatus = NetworkStatus.OnServerAddPlayer
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnStartServer()
        {
            base.OnStartServer();
            //Register custom spawner
            RegisterCustomServerHandler?.Invoke();

            //Server start callback
            OnServerStartCallback?.Invoke();
            
            connectionResponseData = new MultiplayerConnectionResponseData
            {
                NetworkStatus = NetworkStatus.OnStartServer
            };
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        public override void OnStopServer()
        {
            base.OnStopServer();
            connectionResponseData = new MultiplayerConnectionResponseData {NetworkStatus = NetworkStatus.OnStopServer};
            anc.PostNotification(nameof(ActionParameterDataType.OnMultiplayerEvent), connectionResponseData);
        }

        #endregion
    }
}