// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using NativePlugins.Plugin;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime
{
#if HANDHELD_ARMODULE_INSTALL
    public class AutoRegisterModule : MonoBehaviour
    {
        public void Awake()
        {
            RegisterModule();
        }

        private void RegisterModule()
        {
            if (!DevicePlatformAPI.IsHandheldAR()) return;
            Debug.Log($"Handheld AR Module Register");
            IocContainer.GetIoc.Register<IModule>(new HandheldARModule());
        }
    }
#endif
}