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

using UnityEngine;

namespace com.Phantoms.ActionNotification.Runtime
{
    public class TryAcquireCurrentFrameNotificationData : BaseNotificationData
    {
        public TextureFormat AcquiredTextureFormat;
        public ConversionType ConversionType;
    }

    public enum ConversionType
    {
        Synchronous,
        Asynchronous
    }
}