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
using Mirror;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    public interface ISynchronizerHook<T>
    {
        /// <summary>
        /// Calling in the client but run on server side only.
        /// Call RpcSynchronizingValue to synchronize data on the client.
        /// </summary>
        /// <param name="_newValue">new value</param>
        void CmdModifyValue(T _newValue,NetworkIdentity _sender);

        /// <summary>
        /// Calling in the server but run on client side only.
        /// To synchronize data on the client.
        /// </summary>
        /// <param name="_syncedValue"></param>
        void RpcSynchronizingValue(T _syncedValue,NetworkIdentity _sender);

        
        /// <summary>
        /// Register the callback.
        /// This callback will be executing in the value synced.
        /// </summary>
        /// <param name="_callback">Callback function</param>
        void RegisterValueSyncedCallback(Action<T,NetworkIdentity> _callback);

        
        /// <summary>
        /// unregister the callback.
        /// </summary>
        void UnRegisterValueSyncedCallback();
    }
}