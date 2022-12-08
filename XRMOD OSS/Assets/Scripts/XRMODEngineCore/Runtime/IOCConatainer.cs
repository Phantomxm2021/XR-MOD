// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The XRMODEngineCore.Runtime cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace XRMODEngineCore.Runtime
{
    public static class IocContainer
    {
        private static Ioc instance;
        public static Ioc GetIoc => instance ??= new Ioc();
    }
}