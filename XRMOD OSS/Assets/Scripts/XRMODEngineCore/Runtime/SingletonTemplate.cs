// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace XRMODEngineCore.Runtime
{
    public class SingletonTemplate<T> where T : class, new()
    {
        private static T _SINGLETON;

        protected SingletonTemplate()
        {
        }

        public T GetInstance => _SINGLETON ??= new T();
    }
}