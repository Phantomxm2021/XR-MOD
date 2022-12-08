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
using System.Collections;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class NetworkPropertiesSync : NetworkBehaviour
    {
        [SyncVar(hook = nameof(OnHealthChange)), SerializeField]
        private int health = 0;

        [SyncVar(hook = nameof(OnObjectNameChange)), SerializeField]
        private string objectName = String.Empty;

        [SyncVar(hook = nameof(OnObjectLevelChange)), SerializeField]
        private int objectLevel = 0;

        [SyncVar(hook = nameof(OnCustomPropertiesChange)), SerializeField]
        private string customProperties = String.Empty;

        public int GetHealth => health;
        public int GetObjectLevel => objectLevel;

        public string GetObjectName => objectName;
        public string GetCustomProperties => customProperties;

        public Action<float, NetworkIdentity> HealthSyncedCallback;
        public Action<int, NetworkIdentity> ObjectLevelSyncedCallback;
        public Action<string, NetworkIdentity> ObjectNameSyncedCallback;
        public Action<string, NetworkIdentity> CustomPropertiesSyncedCallback;

        [SyncVar] public NetworkIdentity Sender;

        [Command(requiresAuthority = false)]
        public void CmdSubtractHealth(int _newValue, NetworkIdentity _sender)
        {
            Sender = _sender;
            health -= _newValue;
        }

        [Command(requiresAuthority = false)]
        public void CmdAddHealth(int _newValue, NetworkIdentity _sender)
        {
            Sender = _sender;
            health += _newValue;
        }

        [Command(requiresAuthority = false)]
        public void CmdSetObjectName(string _name, NetworkIdentity _sender)
        {
            Sender = _sender;
            objectName = _name;
        }

        [Command(requiresAuthority = false)]
        public void CmdLevelUp(int _additionLevel, NetworkIdentity _sender)
        {
            Sender = _sender;
            objectLevel += _additionLevel;
        }

        [Command(requiresAuthority = false)]
        public void CmdDegradeLevel(int _level, NetworkIdentity _sender)
        {
            Sender = _sender;
            objectLevel -= _level;
        }

        [Command(requiresAuthority = false)]
        public void CmdUpdateCustomProperties(string _customProperties, NetworkIdentity _sender)
        {
            Sender = _sender;
            customProperties = _customProperties;
        }

        #region Sync Hook

        private void OnCustomPropertiesChange(string _old, string _customProperties)
        {
            CustomPropertiesSyncedCallback?.Invoke(_customProperties, Sender);
        }


        private void OnObjectLevelChange(int _old, int _newValue)
        {
            ObjectLevelSyncedCallback?.Invoke(_newValue, Sender);
        }


        private void OnHealthChange(int _old, int _newValue)
        {
            HealthSyncedCallback?.Invoke(_newValue, Sender);
        }


        private void OnObjectNameChange(string _old, string _new)
        {
            ObjectNameSyncedCallback?.Invoke(_new, Sender);
        }

        #endregion
    }
}