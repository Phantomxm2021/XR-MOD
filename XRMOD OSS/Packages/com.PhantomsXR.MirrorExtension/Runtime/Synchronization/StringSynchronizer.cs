using System;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class StringSynchronizer : NetworkBehaviour, ISynchronizerHook<string>
    {
        /// <summary>
        /// To caching the value
        /// </summary>
        [SerializeField] protected string synchronousValue;

        /// <summary>
        /// Return the caching value
        /// </summary>
        public string GetSynchronousValue => synchronousValue;

        /// <summary>
        /// Callback executed after data synchronization
        /// </summary>
        private Action<string,NetworkIdentity> onValueSynchronization;


        [Command]
        public void CmdModifyValue(string _newValue,NetworkIdentity _sender)
        {
            RpcSynchronizingValue(_newValue,_sender);
        }


        [ClientRpc]
        public void RpcSynchronizingValue(string _syncedValue,NetworkIdentity _sender)
        {
            if (hasAuthority) return;
            synchronousValue = _syncedValue;
            onValueSynchronization?.Invoke(_syncedValue,_sender);
        }

        public void RegisterValueSyncedCallback(Action<string,NetworkIdentity> _callback)
        {
            onValueSynchronization = _callback;
        }

        public void UnRegisterValueSyncedCallback()
        {
            onValueSynchronization = null;
        }
    }
}