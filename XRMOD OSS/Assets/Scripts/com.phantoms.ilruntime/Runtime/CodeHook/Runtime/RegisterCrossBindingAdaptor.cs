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

using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime.Enviorment;

namespace com.Phantoms.ILRuntime.Runtime
{
    public class RegisterCrossBindingAdaptor : IRegister

    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.RegisterCrossBindingAdaptor(new AsyncStateMachineClassInheritanceAdaptor());
            _appDomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new MonoBehaviourAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new BaseNotificationDataAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new ExceptionAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new IComparer_1_TransformAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new UIMonoBehaviourAdaptor());
            _appDomain.RegisterCrossBindingAdaptor(new XRGrabInteractableAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new XRBaseInteractableAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new XRBaseInteractorAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new ActionBasedContinuousMoveProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new DeviceBasedContinuousMoveProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new DeviceBasedContinuousTurnProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new DeviceBasedSnapTurnProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new ConstrainedMoveProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new GrabMoveProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new LocomotionProviderAdapter());
            _appDomain.RegisterCrossBindingAdaptor(new TeleportationProviderAdapter());
        }
    }
}