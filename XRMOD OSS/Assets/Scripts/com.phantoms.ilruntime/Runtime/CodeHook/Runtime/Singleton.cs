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

namespace com.Phantoms.ILRuntime.Runtime.CodeHook
{
    public class Singleton<T> where T : class, new()
    {
        private Singleton()
        {
        }

        private static readonly Lazy<T> Instance = new Lazy<T>(() => new T());

        public static T GetInstance => Instance.Value;
    }
}