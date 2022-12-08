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


namespace com.Phantoms.ActionNotification.Runtime
{
    public interface IActionNotificationCenter<in T>
    {
        void AddObserver(T _action, string _name);
        void RemoveObserver(string _name, T _action);
        void RemoveObserver(string _name);
        void PostNotification(string _name, BaseNotificationData _notificationData);
        
    }
}