using System;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class NumberSynchronizer : NetworkBehaviour, ISynchronizerHook<float>
    {
        /// <summary>
        /// To caching the value
        /// </summary>
        [SerializeField] protected float synchronousValue;

        /// <summary>
        /// Return the caching value
        /// </summary>
        public float GetSynchronousValue => synchronousValue;

        /// <summary>
        /// Callback executed after data synchronization
        /// </summary>
        private Action<float,NetworkIdentity> onValueSynchronization;


        [Command]
        public void CmdModifyValue(float _newValue,NetworkIdentity _sender)
        {
            RpcSynchronizingValue(_newValue,_sender);
        }

        [ClientRpc]
        public void RpcSynchronizingValue(float _syncedValue,NetworkIdentity _sender)
        {
            if (hasAuthority) return;
            synchronousValue = _syncedValue;
            onValueSynchronization?.Invoke(synchronousValue,_sender);
        }

        public void RegisterValueSyncedCallback(Action<float,NetworkIdentity> _callback)
        {
            onValueSynchronization = _callback;
        }

        public void UnRegisterValueSyncedCallback()
        {
            onValueSynchronization = null;
        }
    }
}