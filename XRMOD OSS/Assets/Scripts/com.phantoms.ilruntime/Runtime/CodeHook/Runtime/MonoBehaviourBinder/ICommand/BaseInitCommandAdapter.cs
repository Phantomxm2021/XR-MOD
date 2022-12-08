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
using ILRuntime.Runtime.Intepreter;
using UnityEngine;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook.ICommand
{
    public abstract class BaseInitCommandAdapter<T> : ICommandForInitAdapter<T> where T : class,new()
    {
        protected readonly GameObject GameObject;
        protected readonly ILTypeInstance Instance;
        protected readonly MonoData MonoData;
        protected readonly IType ILType;

        public BaseInitCommandAdapter(GameObject _gameObject, ILTypeInstance _instance, MonoData _monoData,
            IType _iLType)
        {
            GameObject = _gameObject;
            Instance = _instance;
            MonoData = _monoData;
            ILType = _iLType;
        }

        public abstract T Execute();
    }
}