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

namespace com.Phantoms.ActionNotification.Runtime
{
    public class BaseNotificationData : IDisposable
    {
        /// <summary>
        /// Callback without return data. Execute after receiving notification message
        /// </summary>
        public Action NotificationAct;

        /// <summary>
        /// Callback with return data. Execute after received notification message 
        /// </summary>
        public Action<object> NotificationActWithData;

        /// <summary>
        /// Type of action
        /// </summary>
        public string ActionName;

        /// <summary>
        /// meta data
        /// </summary>
        public string BaseData;

        public virtual void Dispose()
        {
            NotificationAct = null;
            ActionName = null;
            BaseData = null;
        }
    }
}