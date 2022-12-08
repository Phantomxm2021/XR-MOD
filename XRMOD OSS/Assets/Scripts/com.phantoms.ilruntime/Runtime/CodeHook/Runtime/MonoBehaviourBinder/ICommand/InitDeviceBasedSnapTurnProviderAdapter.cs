// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook.ICommand
{
    public class
        InitDeviceBasedSnapTurnProviderAdapter : BaseInitCommandAdapter<DeviceBasedSnapTurnProviderAdapter.Adapter>
    {
        public InitDeviceBasedSnapTurnProviderAdapter(GameObject _gameObject, ILTypeInstance _instance,
            MonoData _monoData,
            IType _iLType) : base(_gameObject, _instance, _monoData, _iLType)
        {
        }

        public override DeviceBasedSnapTurnProviderAdapter.Adapter Execute()
        {
            var tmp_XRBaseInteractableAdapter = GameObject.AddComponent<DeviceBasedSnapTurnProviderAdapter.Adapter>();
            tmp_XRBaseInteractableAdapter.enabled = false;
            tmp_XRBaseInteractableAdapter.ILInstance = Instance;
            tmp_XRBaseInteractableAdapter.AppDomain = CodesHook.GetAppDomain;
            Instance.CLRInstance = tmp_XRBaseInteractableAdapter;
            MonoData.ClrInstance = tmp_XRBaseInteractableAdapter;
            MonoData.Added = true;
            Utility.InvokeConstructor(Instance, ILType);
            return tmp_XRBaseInteractableAdapter;
        }
    }
}