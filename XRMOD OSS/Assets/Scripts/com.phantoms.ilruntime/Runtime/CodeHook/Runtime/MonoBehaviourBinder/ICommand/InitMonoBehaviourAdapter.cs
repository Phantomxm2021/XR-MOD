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
    public class InitMonoBehaviourAdapter : BaseInitCommandAdapter<MonoBehaviourAdapter.Adapter>
    {
        public InitMonoBehaviourAdapter(GameObject _gameObject, ILTypeInstance _instance, MonoData _monoData,
            IType _iLType) : base(_gameObject, _instance, _monoData, _iLType)
        {
        }

        public override MonoBehaviourAdapter.Adapter Execute()
        {
            var tmp_Adapter = GameObject.AddComponent<MonoBehaviourAdapter.Adapter>();
            tmp_Adapter.enabled = false;
            tmp_Adapter.ILInstance = Instance;
            tmp_Adapter.AppDomain = CodesHook.GetAppDomain;
            Instance.CLRInstance = tmp_Adapter;
            MonoData.ClrInstance = tmp_Adapter;
            MonoData.Added = true;
            Utility.InvokeConstructor(Instance, ILType);
            return tmp_Adapter;
        }
    }
}