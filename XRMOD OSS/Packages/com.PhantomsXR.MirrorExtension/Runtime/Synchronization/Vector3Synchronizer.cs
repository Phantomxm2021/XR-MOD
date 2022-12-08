using System;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class Vector3Synchronizer : NetworkBehaviour, ISynchronizerHook<Vector3>
    {
        /// <summary>
        /// To caching the value
        /// </summary>
        [SerializeField] protected Vector3 synchronousValue;

        /// <summary>
        /// Return the caching value
        /// </summary>
        public Vector3 GetSynchronousValue => synchronousValue;

        /// <summary>
        /// Callback executed after data synchronization
        /// </summary>
        private Action<Vector3,NetworkIdentity> onValueSynchronization;

        [Command]
        public void CmdModifyValue(Vector3 _vector3,NetworkIdentity _sender)
        {
            RpcSynchronizingValue(_vector3,_sender);
        }

        [ClientRpc]
        public void RpcSynchronizingValue(Vector3 _syncedValue,NetworkIdentity _sender)
        {
            //if (hasAuthority) return;
            synchronousValue = _syncedValue;
            onValueSynchronization?.Invoke(synchronousValue,_sender);
        }

        public void RegisterValueSyncedCallback(Action<Vector3,NetworkIdentity> _callback)
        {
            onValueSynchronization = _callback;
        }

        public void UnRegisterValueSyncedCallback()
        {
            onValueSynchronization = null;
        }
    }
}