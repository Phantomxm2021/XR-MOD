// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.ILCode.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using com.Phantoms.ILRuntime.Runtime;

namespace ILRuntime.Runtime.Generated
{
    public class PicoILCodeBindings
    {
        public static void Binding()
        {
            var tmp_App = CodesHook.GetAppDomain;
            PXR_Boundary_Binding.Register(tmp_App);
            PXR_HandTracking_Binding.Register(tmp_App);
            PXR_Input_Binding.Register(tmp_App);
            UserService_Binding.Register(tmp_App);
            CoreService_Binding.Register(tmp_App);

            new DelegateRegister().Register(tmp_App);
        }
    }
}