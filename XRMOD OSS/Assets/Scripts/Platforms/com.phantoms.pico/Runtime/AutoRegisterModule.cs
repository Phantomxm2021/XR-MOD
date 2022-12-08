// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using NativePlugins.Plugin;
using Unity.XR.PXR;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace Pico.Runtime
{
    public class AutoRegisterModule : MonoBehaviour
    {
        private void Awake()
        {
            if (DevicePlatformAPI.IsPico())
                IocContainer.GetIoc.Register<IModule>(new PicoModule());
        }
    }
}