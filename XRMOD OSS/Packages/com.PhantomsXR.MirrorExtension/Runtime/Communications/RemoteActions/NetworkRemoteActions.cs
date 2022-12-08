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
    public class NetworkRemoteActions : NetworkBehaviour
    {
        #region Commands

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<string, NetworkIdentity>> CmdStringAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<float, NetworkIdentity>> CmdFloatAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<int, NetworkIdentity>> CmdIntAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<bool, NetworkIdentity>> CmdBoolAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<Vector3, NetworkIdentity>> CmdVector3Action;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> CmdQuaternionAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<GameObject, NetworkIdentity>> CmdGameObjectAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner. 
        /// </summary>
        public Dictionary<string, Action<TransformData, NetworkIdentity>> CmdTransformDataAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// Action<string,NetworkIdentity> Normally NetworkIdentity is set to owner.
        /// </summary>
        public Dictionary<string, Action<NetworkIdentity>> CmdAction;

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// </summary>
        [Command]
        public void CmdSender(string _eventName, NetworkIdentity _sender)
        {
            if (CmdAction == null) return;

            if (CmdAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players.
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdStringSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if (CmdStringAction == null) return;
            if (CmdStringAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdVector3Sender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if (CmdVector3Action == null) return;
            if (CmdVector3Action.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdQuaternionSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if (CmdQuaternionAction == null) return;
            if (CmdQuaternionAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdFloatSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if (CmdFloatAction == null) return;
            if (CmdFloatAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdBoolSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if (CmdBoolAction == null) return;
            if (CmdBoolAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdIntSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if (CmdIntAction == null) return;
            if (CmdIntAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdGameObjectSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if (CmdGameObjectAction == null) return;
            if (CmdGameObjectAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        /// <summary>
        /// Commands are sent from player objects on the client to player objects on the server.
        /// For security, Commands can only be sent from YOUR player object by default,
        /// so you cannot control the objects of other players. 
        /// </summary>
        /// <param name="_parameter"></param>
        [Command]
        public void CmdTransformDataSender(string _eventName, TransformData _parameter, NetworkIdentity _sender)
        {
            if (CmdTransformDataAction == null) return;
            if (CmdTransformDataAction.TryGetValue(_eventName, out var _event))
            {
                _event?.Invoke(_parameter, _sender);
            }
        }

        #endregion

        #region TargetRpc

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<string, NetworkIdentity>> TargetRpcStringAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<float, NetworkIdentity>> TargetRpcFloatAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<int, NetworkIdentity>> TargetRpcIntAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<bool, NetworkIdentity>> TargetRpcBoolAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<Vector3, NetworkIdentity>> TargetRpcVector3Action;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> TargetRpcQuaternionAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<GameObject, NetworkIdentity>> TargetRpcGameObjectAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<TransformData, NetworkIdentity>> TargetRpcTransformDataAction;

        ///<summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server.
        /// </summary> 
        public Dictionary<string, Action<NetworkIdentity>> TargetRpcAction;

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        [TargetRpc]
        public void TargetRpcSender(string _eventName, NetworkIdentity _sender)
        {
            if (TargetRpcAction == null) return;
            if (TargetRpcAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcStringSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcStringAction == null) return;
            if (TargetRpcStringAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcFloatSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcFloatAction == null) return;
            if (TargetRpcFloatAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcIntSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcIntAction == null) return;
            if (TargetRpcIntAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcBoolSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcBoolAction == null) return;
            if (TargetRpcBoolAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcVector3Sender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcVector3Action == null) return;
            if (TargetRpcVector3Action.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcQuaternionSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcQuaternionAction == null) return;
            if (TargetRpcQuaternionAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcGameObjectSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcGameObjectAction == null) return;
            if (TargetRpcGameObjectAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// TargetRpc functions are called by user code on the server,
        /// and then invoked on the corresponding client object on the client of the specified NetworkConnection.
        /// The arguments to the RPC call are serialized across the network,
        /// so that the client function is invoked with the same values as the function on the server. 
        /// </summary>
        /// <param name="_parameter"></param>
        [TargetRpc]
        public void TargetRpcTransformDataSender(string _eventName, TransformData _parameter, NetworkIdentity _sender)
        {
            if (TargetRpcTransformDataAction == null) return;
            if (TargetRpcTransformDataAction.TryGetValue(_eventName, out var _event))
                _event?.Invoke(_parameter, _sender);
        }

        #endregion

        #region ClientRpc

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<string, NetworkIdentity>> ClientRpcStringAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<float, NetworkIdentity>> ClientRpcFloatAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<int, NetworkIdentity>> ClientRpcIntAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<bool, NetworkIdentity>> ClientRpcBoolAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<Vector3, NetworkIdentity>> ClientRpcVector3Action;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<Quaternion, NetworkIdentity>> ClientRpcQuaternionAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<GameObject, NetworkIdentity>> ClientRpcGameObjectAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<TransformData, NetworkIdentity>> ClientRpcTransformDataAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        public Dictionary<string, Action<NetworkIdentity>> ClientRpcAction;

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        [ClientRpc]
        public void RpcClientRpcSender(string _eventName, NetworkIdentity _sender)
        {
            if (ClientRpcAction == null) return;
            if (ClientRpcAction.TryGetValue(_eventName, out Action<NetworkIdentity> _event))
                _event?.Invoke(_sender);
        }

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcStringSender(string _eventName, string _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcStringAction == null) return;
            if (ClientRpcStringAction.TryGetValue(_eventName, out Action<string, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcFloatSender(string _eventName, float _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcFloatAction.TryGetValue(_eventName, out Action<float, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcIntSender(string _eventName, int _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcIntAction == null) return;
            if (ClientRpcIntAction.TryGetValue(_eventName, out Action<int, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcBoolSender(string _eventName, bool _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcBoolAction == null) return;
            if (ClientRpcBoolAction.TryGetValue(_eventName, out Action<bool, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcVector3Sender(string _eventName, Vector3 _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcVector3Action == null) return;
            if (ClientRpcVector3Action.TryGetValue(_eventName, out Action<Vector3, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }


        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcQuaternionSender(string _eventName, Quaternion _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcQuaternionAction == null) return;
            if (ClientRpcQuaternionAction.TryGetValue(_eventName, out Action<Quaternion, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcGameObjectSender(string _eventName, GameObject _parameter, NetworkIdentity _sender)
        {
            if (ClientRpcGameObjectAction.TryGetValue(_eventName, out Action<GameObject, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }

        /// <summary>
        /// ClientRpc calls are sent from objects on the server to objects on clients.
        /// They can be sent from any server object with a NetworkIdentity that has been spawned.
        /// Since the server has authority, then there no security issues with server objects being able to send these calls.
        /// </summary>
        /// <param name="_parameter"></param>
        [ClientRpc]
        public void RpcClientRpcTransformDataSender(string _eventName, TransformData _parameter,
            NetworkIdentity _sender)
        {
            if (ClientRpcTransformDataAction == null) return;
            if (ClientRpcTransformDataAction.TryGetValue(_eventName, out Action<TransformData, NetworkIdentity> _event))
                _event?.Invoke(_parameter, _sender);
        }

        #endregion
    }
}