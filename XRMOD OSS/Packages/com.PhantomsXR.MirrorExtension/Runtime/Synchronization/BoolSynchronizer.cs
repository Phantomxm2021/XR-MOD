using System;
using Mirror;
using Unity.Collections;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    public class BoolSynchronizer : NetworkBehaviour, ISynchronizerHook<bool>
    {
        /// <summary>
        /// To caching the value
        /// </summary>
        [SerializeField] protected bool synchronousValue;

        /// <summary>
        /// Return the caching value
        /// </summary>
        public bool GetSynchronousValue => synchronousValue;

        /// <summary>
        /// Callback executed after data synchronization
        /// </summary>
        private Action<bool, NetworkIdentity> onValueSynchronization;


        [Command]
        public void CmdModifyValue(bool _newValue, NetworkIdentity _sender)
        {
            RpcSynchronizingValue(_newValue, _sender);
        }

        [ClientRpc]
        public void RpcSynchronizingValue(bool _syncedValue, NetworkIdentity _sender)
        {
            synchronousValue = _syncedValue;
            onValueSynchronization?.Invoke(synchronousValue, _sender);
        }

        public void RegisterValueSyncedCallback(Action<bool, NetworkIdentity> _callback)
        {
            onValueSynchronization = _callback;
        }

        public void UnRegisterValueSyncedCallback()
        {
            onValueSynchronization = null;
        }
    }
}