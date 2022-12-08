using System;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class QuaternionSynchronizer : NetworkBehaviour, ISynchronizerHook<Quaternion>
    {
        /// <summary>
        /// To caching the value
        /// </summary>
        [SerializeField] protected Quaternion synchronousValue;

        /// <summary>
        /// Return the caching value
        /// </summary>
        public Quaternion GetSynchronousValue => synchronousValue;

        /// <summary>
        /// Callback executed after data synchronization
        /// </summary>
        private Action<Quaternion,NetworkIdentity> onValueSynchronous;

        [Command]
        public void CmdModifyValue(Quaternion _newValue,NetworkIdentity _sender)
        {
            RpcSynchronizingValue(_newValue,_sender);
        }

        [ClientRpc]
        public void RpcSynchronizingValue(Quaternion _syncedValue,NetworkIdentity _sender)
        {
            if (hasAuthority) return;
            synchronousValue = _syncedValue;
            onValueSynchronous?.Invoke(_syncedValue,_sender);
        }

        public void RegisterValueSyncedCallback(Action<Quaternion,NetworkIdentity> _callback )
        {
            onValueSynchronous = _callback;
        }

        public void UnRegisterValueSyncedCallback()
        {
            onValueSynchronous = null;
        }
    }
}