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

using System.Collections.Generic;
using System.Linq;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    public class GetComponentClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);

            var tmp_GetComponentMethod = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_i => _i.Name == "GetComponent" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_GetComponentMethod, GetComponent);


            var tmp_GetComponentMethod1 = ConstData.GAME_OBJECT_TYPE.GetMethods().ToList()
                .Find(_i => _i.Name == "GetComponent" && _i.GetGenericArguments().Length == 1);
            _appDomain.RegisterCLRMethodRedirection(tmp_GetComponentMethod1, GetComponent);
        }

        private unsafe StackObject* GetComponent(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;

            var ptr = __esp - 1;
            var instance = StackObject.ToObject(ptr, __domain, __mStack);
            if (instance == null)
                throw new System.NullReferenceException();
            __intp.Free(ptr);

            var genericArgument = __method.GenericArguments;
            if (genericArgument == null || genericArgument.Length != 1) return __esp;
            GameObject tmp_GameObject;
            switch (instance)
            {
                case GameObject tmp_Instance:
                    tmp_GameObject = tmp_Instance;
                    break;
                case Component tmp_Component:
                    tmp_GameObject = tmp_Component.gameObject;
                    break;
                case ILTypeInstance tmp_IlTypeInstance:
                    tmp_GameObject = Utility.FindGameFromILTypeInstance(tmp_IlTypeInstance);
                    break;
                default:
                    Debug.LogError(
                        $"[Get Component Error]: Not Support type of parameter:{instance.GetType().FullName}");
                    return __esp;
            }

            var type = genericArgument[0];
            object res = null;
            if (type is CLRType)
            {
                res = tmp_GameObject.GetComponent(type.TypeForCLR);
                if (res is CrossBindingAdaptorType crossBindingAdaptorType)
                {
                    res = crossBindingAdaptorType.ILInstance;
                }
            }
            else
            {
                var clrInstances = tmp_GameObject.GetComponents(typeof(CrossBindingAdaptorType))
                    .Cast<CrossBindingAdaptorType>().ToArray();

                foreach (var clrInstance in clrInstances)
                {
                    if (clrInstance.ILInstance == null) continue;
                    if (!clrInstance.ILInstance.Type.CanAssignTo(type)) continue;
                    res = clrInstance.ILInstance;
                    break;
                }
            }

            return ILIntepreter.PushObject(ptr, __mStack, res);
        }
    }
}