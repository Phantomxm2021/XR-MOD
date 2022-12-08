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

using ILRuntime.Runtime.Enviorment;
using UnityEngine;

namespace com.Phantoms.ILRuntime.Runtime
{
    public class RegisterValueBinding : IRegister
    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
            _appDomain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
            _appDomain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
        }
    }
}