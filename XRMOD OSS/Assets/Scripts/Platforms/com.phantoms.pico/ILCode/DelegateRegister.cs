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
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace ILRuntime.Runtime.Generated
{
    public class DelegateRegister
    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.DelegateManager.RegisterMethodDelegate<Pico.Platform.Message<Pico.Platform.Models.User>>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>>();
            _appDomain.DelegateManager
                .RegisterDelegateConvertor<Pico.Platform.Message<Pico.Platform.Models.User>.Handler>(
                    _act =>
                    {
                        return new Pico.Platform.Message<Pico.Platform.Models.User>.Handler((_message) =>
                        {
                            ((Action<Pico.Platform.Message<Pico.Platform.Models.User>>) _act)(_message);
                        });
                    });
            _appDomain.DelegateManager
                .RegisterDelegateConvertor<Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>.Handler>(
                    _act =>
                    {
                        return new Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>.Handler((_message) =>
                        {
                            ((Action<Pico.Platform.Message<Pico.Platform.PlatformInitializeResult>>) _act)(_message);
                        });
                    });
        }
    }
}