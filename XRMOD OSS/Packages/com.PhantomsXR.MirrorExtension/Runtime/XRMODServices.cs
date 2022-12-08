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
using System.Net;
using System.Net.Sockets;
using kcp2k;
using Mirror;
using Mirror.Discovery;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once IdentifierTypo
    public class XRMODServices
    {
        // ReSharper disable once IdentifierTypo
        private XRMODServices()
        {
        }

        private static XRMODServices _INSTANCE;

        public static XRMODServices GetBridge()
        {
            return _INSTANCE ??= new XRMODServices();
        }

        public Action<GameObject> SpawnCallback;

        // ReSharper disable once UnassignedField.Global
        // ReSharper disable once MemberCanBePrivate.Global
        private Action<ServerResponse> onServerFoundCallback;

        private XRMODNetworkManager networkManager;
        private LocalPlayerBinding localPlayerBinding;
        private NetworkDiscovery networkDiscovery;

        internal void Initialize()
        {
            networkManager = Object.FindObjectOfType<XRMODNetworkManager>();

            //Register the prefab creator. To avoid the NetworkConnection error.[Server side Only]
            networkManager.RegisterCustomServerHandler = () =>
            {
                NetworkServer.RegisterHandler<CreatePrefabData>(CreatePrefab);
                NetworkServer.RegisterHandler<AssignClientAuthorityMessage>(AssignClientAuthorityHandler);
            };
            
            networkManager.OnServerStartCallback= InitializeAndStartDiscovery;
        }


        internal void Deinitialize()
        {
            if (networkDiscovery)
            {
                networkDiscovery.OnServerFound.RemoveAllListeners();
                networkDiscovery.StopDiscovery();
            }

            NetworkServer.UnregisterHandler<CreatePrefabData>();

            networkManager.spawnPrefabs.Clear();
            networkManager.StopHost();
            networkManager.StopClient();
            networkManager.StopServer();
            Object.Destroy(networkManager);


            _INSTANCE = null;
        }

        #region Spawn Operation

        /// <summary>
        /// Custom create prefab func
        /// </summary>
        /// <param name="_conn">LocalConnectionToClient</param>
        /// <param name="_data">Create prefab message</param>
        private void CreatePrefab(NetworkConnection _conn, CreatePrefabData _data)
        {
            try
            {
                //Get the prefab from SpawningSystem
                var tmp_Prefab = Utility.GetPrefabFromSpawningSystem(_data.PrefabName);
                Assert.IsNotNull(tmp_Prefab);

                //Instanced the prefab
                Utility.Instantiate(tmp_Prefab, out var tmp_InstancedPrefab);
                Assert.IsNotNull(tmp_InstancedPrefab);

                //Set position and rotation
                var tmp_InstancedPrefabTrans = tmp_InstancedPrefab.transform;
                if (_data.WorldPos)
                {
                    tmp_InstancedPrefabTrans.position = _data.Position;
                    tmp_InstancedPrefabTrans.rotation = _data.Rotation;
                }
                else
                {
                    tmp_InstancedPrefabTrans.localPosition = _data.Position;
                    tmp_InstancedPrefabTrans.localRotation = _data.Rotation;
                }

                //Notice the all client 
                NetworkServer.Spawn(tmp_InstancedPrefab, _conn);
                SpawnCallback?.Invoke(tmp_InstancedPrefab);

                //Remove the Clone tag from instanced prefab game object. Then adding the connection id to it.
                var tmp_InstancedIdentityComponent = tmp_InstancedPrefab.GetComponent<NetworkIdentity>();
                tmp_InstancedPrefab.name = tmp_InstancedPrefab.name.Replace("(Clone)", string.Empty);
                tmp_InstancedPrefab.name = $"{tmp_InstancedPrefab.name}[netId={tmp_InstancedIdentityComponent.netId}]";

                //Binding the prefab to local player and make the dev api easy to access
                if (_data.IsPlayerBinding)
                    _conn.identity.GetComponent<LocalPlayerBinding>().BindingPlayerGameObject(tmp_InstancedPrefab.name);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
            }
        }

        private void AssignClientAuthorityHandler(NetworkConnection _conn, AssignClientAuthorityMessage _data)
        {
            if (_data.AssignedObject.connectionToClient != null)
                _data.AssignedObject.RemoveClientAuthority();
            _data.AssignedObject.AssignClientAuthority(_conn);
        }


        /// <summary>
        /// Register the prefab for spawn
        /// </summary>
        /// <param name="_needToRegisterPrefab">Prefab to register</param>
        public void RegisterPrefab(GameObject _needToRegisterPrefab)
        {
            if (networkManager == null) return;
            if (!networkManager.spawnPrefabs.Contains(_needToRegisterPrefab))
            {
                networkManager.spawnPrefabs.Add(_needToRegisterPrefab);
            }
        }

        /// <summary>
        /// TryAcquire the network object from the Registration table.
        /// </summary>
        /// <param name="_prefabName">The prefab name</param>
        /// <returns>The prefab in registration table</returns>
        public GameObject GetNetworkPrefab(string _prefabName)
        {
            return Utility.GetPrefabFromSpawningSystem(_prefabName);
        }

        /// <summary>
        /// Spawn the prefab in the Networking.
        /// At the first, you must call the [RegisterPrefabToSpawningSystem] to register the prefab to spawning system.
        /// Otherwise it will not be able to spawning
        /// </summary>
        /// <param name="_prefabName"></param>
        /// <param name="_position"></param>
        /// <param name="_rotation"></param>
        /// <param name="_worldPos"></param>
        public void SpawnPrefab(string _prefabName, Vector3 _position, Quaternion _rotation, bool _worldPos)
        {
            NetworkClient.connection.Send(new CreatePrefabData
            {
                PrefabName = _prefabName,
                Position = _position,
                Rotation = _rotation,
                WorldPos = _worldPos,
                IsPlayerBinding = false
            });
        }


        /// <summary>
        /// Spawn the prefab in the Networking.
        /// At the first, you must call the [RegisterPrefabToSpawningSystem] to register the prefab to spawning system.
        /// Otherwise it will not be able to spawning
        /// </summary>
        /// <param name="_prefabName"></param>
        public void SpawnPrefab(string _prefabName)
        {
            NetworkClient.connection.Send(new CreatePrefabData
            {
                PrefabName = _prefabName,
                Position = Vector3.zero,
                Rotation = Quaternion.identity,
                WorldPos = true,
                IsPlayerBinding = false
            });
        }

        /// <summary>
        /// Spawn the player in the Networking.
        /// At the first, you must call the [RegisterPrefabToSpawningSystem] to register the prefab to spawning system.
        /// Otherwise it will not be able to spawning
        /// </summary>
        /// <param name="_prefabName"></param>
        public void SpawnPlayer(string _prefabName)
        {
            try
            {
                Assert.AreNotEqual(_prefabName, string.Empty);
                NetworkClient.connection.Send(new CreatePrefabData
                {
                    PrefabName = _prefabName,
                    IsPlayerBinding = true,
                    Position = Vector3.zero,
                    Rotation = Quaternion.identity,
                    WorldPos = false
                });
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
            }
        }

        /// <summary>
        /// Destroy the network object.
        /// </summary>
        /// <param name="_entity">Network object</param>
        public void UnSpawnNetworkObject(GameObject _entity)
        {
            NetworkServer.UnSpawn(_entity);
        }

        /// <summary>
        /// Get the local player game object
        /// </summary>
        /// <returns>local player game object</returns>
        public GameObject GetLocalPlayer()
        {
            try
            {
                if (localPlayerBinding == null)
                    localPlayerBinding = NetworkClient.localPlayer.GetComponent<LocalPlayerBinding>();
                localPlayerBinding.GetCustomLocalPlayer(out GameObject tmp_CustomPlayer);
                return tmp_CustomPlayer;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        /// <summary>
        /// Spawn the given game object on all clients which are ready.
        /// </summary>
        /// <param name="_gameObject">Need to synchronous game object</param>
        /// <param name="_connection">NetworkConnection</param>
        public void SpawnSync(GameObject _gameObject, NetworkConnection _connection = null)
        {
            if (_connection == null)
                NetworkServer.Spawn(_gameObject);
            else
            {
                NetworkServer.Spawn(_gameObject, _connection);
            }
        }


        /// <summary>
        /// destroy object on the network 
        /// </summary>
        /// <param name="_gameObject">Want to destroy game object</param>
        public void NetworkObjectDestroy(GameObject _gameObject)
        {
            NetworkServer.Destroy(_gameObject);
        }


        /// <summary>
        /// Assign control of an object to a client via the client's NetworkConnection.
        /// This causes hasAuthority to be set on the client that owns the object,
        /// and NetworkBehaviour.OnStartAuthority will be called on that client.
        /// This object then will be in the NetworkConnection.clientOwnedObjects
        /// list for the connection.
        /// 
        /// Authority can be removed with RemoveClientAuthority. Only one client
        /// can own an object at any time. This does not need to be called for
        /// player objects, as their authority is setup automatically.
        /// </summary>
        /// <param name="_assignedObject"></param>
        /// <param name="_connection"></param>
        public void AssignClientAuthority(NetworkIdentity _assignedObject, NetworkIdentity _connection)
        {
            if (!NetworkServer.active) return;
            if (_assignedObject.connectionToClient != null)
                _assignedObject.RemoveClientAuthority();
            _assignedObject.AssignClientAuthority(_connection.connectionToClient);
        }

        #endregion

        #region Connection Operation

        /// <summary>
        /// Start host
        /// </summary>
        public void StartHost()
        {
            networkManager.StartHost();
        }


        /// <summary>
        /// Start a server
        /// </summary>
        public void StartAsAServer()
        {
            networkManager.StartServer();
        }

        /// <summary>
        /// Connect to the server
        /// </summary>
        /// <param name="_iPAddress"></param>
        /// <param name="_port"></param>
        public void ConnectToServer(string _iPAddress, string _port)
        {
            networkManager.networkAddress = _iPAddress;
            if (ushort.TryParse(_port, out ushort tmp_UshortPort))
                Object.FindObjectOfType<KcpTransport>().Port = tmp_UshortPort;
            networkManager.StartClient();
        }

        /// <summary>
        /// Connect to the server by discovery
        /// </summary>
        public void ConnectToServerByDiscovery()
        {
            onServerFoundCallback = _serverResponse => { networkManager.StartClient(_serverResponse.uri); };
            InitializeAndStartDiscovery();
        }

        /// <summary>
        /// Initialize eDiscovery
        /// </summary>
        private void InitializeAndStartDiscovery()
        {
            //Toggled discovery
            networkDiscovery = Object.FindObjectOfType<NetworkDiscovery>();
            if (!networkDiscovery) return;
            if (!NetworkServer.active)
            {
                networkDiscovery.OnServerFound.AddListener(_response => { onServerFoundCallback?.Invoke(_response); });
                networkDiscovery.StartDiscovery();
            }
            else
                networkDiscovery.AdvertiseServer();
        }

        /// <summary>
        /// Disconnected from server
        /// </summary>
        public void Disconnected()
        {
            networkManager.StopClient();
        }


        /// <summary>
        /// Get the device ip address
        /// </summary>
        /// <returns>ipv4 address</returns>
        public string GetLocalIP()
        {
            try
            {
                string tmp_HostName = Dns.GetHostName();
                IPHostEntry tmp_IpEntry = Dns.GetHostEntry(tmp_HostName);
                foreach (var tmp_Address in tmp_IpEntry.AddressList)
                {
                    if (tmp_Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return tmp_Address.ToString();
                    }
                }

                return string.Empty;
            }
            catch (Exception tmp_Exception)
            {
                Console.WriteLine(tmp_Exception);
                throw;
            }
        }


        /// <summary>
        /// Get the local connection
        /// </summary>
        /// <returns>Connection to server</returns>
        public NetworkConnection GetLocalNetworkConnection()
        {
            return NetworkClient.localPlayer.connectionToServer;
        }

        #endregion


        /// <summary>
        /// This method is used for AOT code generation only. Do not call it at runtime.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public void UsedOnlyForAOTCodeGeneration()
        {
            // IL2CPP needs only this line.
            NetworkManager.singleton.RegisterServerMessages();
            NetworkManager.singleton.RegisterClientMessages();

            // Include an exception so we can be sure to know if this method is ever called.
            throw new InvalidOperationException(
                "This method is used for AOT code generation only. Do not call it at runtime.");
        }
    }
}