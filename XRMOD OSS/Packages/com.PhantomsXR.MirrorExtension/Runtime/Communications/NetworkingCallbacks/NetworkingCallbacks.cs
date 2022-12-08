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
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class NetworkingCallbacks : NetworkBehaviour
    {
        #region Server

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<NetworkIdentity>> ServerAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<string, NetworkIdentity>> ServerStringAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<float, NetworkIdentity>> ServerFloatAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<int, NetworkIdentity>> ServerIntAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<bool, NetworkIdentity>> ServerBoolAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<Vector3, NetworkIdentity>> ServerVector3Action;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> ServerQuaternionAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<GameObject, NetworkIdentity>> ServerGameObjectAction;

        /// <summary>
        /// Server attribute callback action
        /// </summary>
        public Dictionary<string, Action<TransformData, NetworkIdentity>> ServerTransformDataAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerStringSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if (ServerStringAction == null) return;
            if (ServerStringAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerFloatSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if (ServerFloatAction == null) return;
            if (ServerFloatAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerIntSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if (ServerIntAction == null) return;
            if (ServerIntAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerBoolSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if (ServerBoolAction == null) return;
            if (ServerBoolAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerVector3Sender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if (ServerVector3Action == null) return;
            if (ServerVector3Action.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerQuaternionSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if (ServerQuaternionAction == null) return;
            if (ServerQuaternionAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerSender(string _eventName, NetworkIdentity _sender)
        {
            if (ServerAction == null) return;
            if (ServerAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerGameObjectSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if (ServerGameObjectAction == null) return;
            if (ServerGameObjectAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Server]
        public void ServerTransformDataSender(string _eventName, TransformData _parameter, NetworkIdentity _sender)
        {
            if (ServerTransformDataAction == null) return;
            if (ServerTransformDataAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        #endregion

        #region Client

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<string, NetworkIdentity>> ClientStringAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<float, NetworkIdentity>> ClientFloatAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<int, NetworkIdentity>> ClientIntAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<bool, NetworkIdentity>> ClientBoolAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<Vector3, NetworkIdentity>> ClientVector3Action;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> ClientQuaternionAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<GameObject, NetworkIdentity>> ClientGameObjectAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<TransformData, NetworkIdentity>> ClientTransformDataAction;

        /// <summary>
        /// Client attribute callback action
        /// </summary>
        public Dictionary<string, Action<NetworkIdentity>> ClientAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientSender(string _eventName, NetworkIdentity _sender)
        {
            if (ClientAction == null) return;
            if (ClientAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_sender);
        }

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientStringSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if (ClientStringAction == null) return;
            if (ClientStringAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientFloatSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if (ClientFloatAction == null) return;
            if (ClientFloatAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientIntSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if (ClientIntAction == null) return;
            if (ClientIntAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientBoolSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if (ClientBoolAction == null) return;
            if (ClientBoolAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientVector3Sender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if (ClientVector3Action == null) return;
            if (ClientVector3Action.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientQuaternionSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if (ClientQuaternionAction == null) return;
            if (ClientQuaternionAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientGameObjectSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if (ClientGameObjectAction == null) return;
            if (ClientGameObjectAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [Client]
        public void ClientTransformDataSender(string _eventName, TransformData _parameter, NetworkIdentity _sender)
        {
            if (ClientTransformDataAction == null) return;
            if (ClientTransformDataAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        #endregion

        #region Server Callback

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<string, NetworkIdentity>> ServerCallbackStringAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<float, NetworkIdentity>> ServerCallbackFloatAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<int, NetworkIdentity>> ServerCallbackIntAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<bool, NetworkIdentity>> ServerCallbackBoolAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<Vector3, NetworkIdentity>> ServerCallbackVector3Action;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> ServerCallbackQuaternionAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<GameObject, NetworkIdentity>> ServerCallbackGameObjectAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<TransformData, NetworkIdentity>> ServerCallbackTransformDataAction;

        /// <summary>
        /// Only a server can call the method (throws a warning or an error when called on a client).
        /// </summary>
        public Dictionary<string, Action<NetworkIdentity>> ServerCallbackAction;

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, NetworkIdentity _sender)
        {
            if(ServerCallbackAction==null)return;
            if (ServerCallbackAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackStringAction==null)return;
            if (ServerCallbackStringAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackFloatAction==null)return;
            if (ServerCallbackFloatAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackIntAction==null)return;
            if (ServerCallbackIntAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackBoolAction==null)return;
            if (ServerCallbackBoolAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackVector3Action==null)return;
            if (ServerCallbackVector3Action.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackQuaternionAction==null)return;
            if (ServerCallbackQuaternionAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackGameObjectAction==null)return;
            if (ServerCallbackGameObjectAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        ///  Same as Server but does not throw warning when called on client.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ServerCallback]
        public void ServerCallbackSender(string _eventName, TransformData _parameter, NetworkIdentity _sender)
        {
            if(ServerCallbackTransformDataAction==null)return;
            if (ServerCallbackTransformDataAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        #endregion

        #region Client Callback

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<string, NetworkIdentity>> ClientCallbackStringAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<float, NetworkIdentity>> ClientCallbackFloatAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<int, NetworkIdentity>> ClientCallbackIntAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<bool, NetworkIdentity>> ClientCallbackBoolAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<Vector3, NetworkIdentity>> ClientCallbackVector3Action;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> ClientCallbackQuaternionAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<GameObject, NetworkIdentity>> ClientCallbackGameObjectAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<TransformData, NetworkIdentity>> ClientCallbackTransformDataAction;

        /// <summary>
        /// Only a Client can call the method (throws a warning or an error when called on the server).
        /// </summary>
        public Dictionary<string, Action<NetworkIdentity>> ClientCallbackAction;

        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackSender(string _eventName, NetworkIdentity _sender)
        {
            if(ClientCallbackAction==null)return;
            if (ClientCallbackAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_sender);
        }

        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackStringSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackStringAction==null)return;
            if (ClientCallbackStringAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackFloatSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackFloatAction==null)return;
            if (ClientCallbackFloatAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackIntSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackIntAction==null)return;
            if (ClientCallbackIntAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackBoolSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackBoolAction==null)return;
            if (ClientCallbackBoolAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackVector3Sender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackVector3Action==null)return;
            if (ClientCallbackVector3Action.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackQuaternionSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackQuaternionAction==null)return;
            if (ClientCallbackQuaternionAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackGameObjectSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if(ClientCallbackGameObjectAction==null)return;
            if (ClientCallbackGameObjectAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// Same as Client but does not throw warning when called on server.
        /// </summary>
        /// <param name="_eventName"></param>
        /// <param name="_parameter"></param>
        /// <param name="_sender"></param>
        [ClientCallback]
        public void ClientCallbackTransformDataSender(string _eventName, TransformData _parameter,
            NetworkIdentity _sender)
        {
            if(ClientCallbackTransformDataAction==null)return;
            if (ClientCallbackTransformDataAction.TryGetValue(_eventName, out var tmp_Event))
                tmp_Event?.Invoke(_parameter, _sender);
        }

        #endregion
    }
}