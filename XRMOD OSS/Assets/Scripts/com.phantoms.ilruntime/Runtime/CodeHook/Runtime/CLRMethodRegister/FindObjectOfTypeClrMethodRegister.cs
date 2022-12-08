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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEditor;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    public class FindObjectOfTypeClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;

            var objectType = typeof(UnityEngine.Object);
            var args = new Type[] {typeof(System.Type)};
            var findObjectsOfTypeMethod2 = objectType.GetMethod("FindObjectsOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(findObjectsOfTypeMethod2, FindObjectsOfType_11);
            var findObjectsOfTypeMethod = objectType.GetMethods().ToList()
                .FindAll(f => f.Name == "FindObjectsOfType" && f.IsGenericMethod);
            foreach (var methodInfo in findObjectsOfTypeMethod)
            {
                _appDomain.RegisterCLRMethodRedirection(methodInfo, FindObjectsOfType_10);
            }

            args = new Type[] {typeof(System.Type)};
            var findObjectOfTypeMethod2 = objectType.GetMethod("FindObjectOfType", flag, null, args, null);
            _appDomain.RegisterCLRMethodRedirection(findObjectOfTypeMethod2, FindObjectOfType_11);
            var findObjectOfTypeMethod = objectType.GetMethods().ToList()
                .FindAll(f => f.Name == "FindObjectOfType" && f.IsGenericMethod);
            foreach (var methodInfo in findObjectOfTypeMethod)
            {
                _appDomain.RegisterCLRMethodRedirection(methodInfo, FindObjectOfType_10);
            }
        }

        private unsafe StackObject* FindObjectsOfType_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var genericArgument = __method.GenericArguments;

            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;
                if (type is CLRType)
                {
                    res = UnityEngine.Object.FindObjectsOfType(type.TypeForCLR);
                }
                else
                {
                    var adapters = GetAllMonoAdapters();
                    var ilInstances = ((ILTypeInstance[]) GetHotComponent(adapters, type as ILType))
                        .Select(i => i.CLRInstance).ToArray();
                    int length = ilInstances.Length;
                    res = Array.CreateInstance(type.TypeForCLR, length);
                    for (int idx = 0; idx < length; idx++)
                    {
                        ((Array) res).SetValue(ilInstances[idx], idx);
                    }
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        static unsafe StackObject* FindObjectsOfType_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is ILRuntimeType ilType)
            {
                var adapters = GetAllMonoAdapters();
                var ilInstances = ((ILTypeInstance[]) GetHotComponent(adapters, ilType.ILType));
                int n = ilInstances.Length;
                res = Array.CreateInstance(ilType.ILType.TypeForCLR, n);
                for (int i = 0; i < n; i++)
                    ((Array) res).SetValue(ilInstances[i], i);
            }
            else
            {
                res = UnityEngine.Object.FindObjectsOfType(type);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }


        static unsafe StackObject* FindObjectOfType_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            StackObject* ptr_of_this_method;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type =
                (System.Type) typeof(System.Type).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            object res;
            if (type is ILRuntimeType ilType)
            {
                var adapters = GetAllMonoAdapters();
                var ilInstances = ((ILTypeInstance[]) GetHotComponent(adapters, ilType.ILType));
                res = ilInstances.Length > 0 ? ilInstances[0] : null;
            }
            else
            {
                res = UnityEngine.Object.FindObjectOfType(type);
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        static unsafe StackObject* FindObjectOfType_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var genericArgument = __method.GenericArguments;
            //FindObjectsOfType应该有且只有1个泛型参数
            if (genericArgument != null && genericArgument.Length == 1)
            {
                var type = genericArgument[0];
                object res;

                if (type is CLRType)
                {
                    res = Object.FindObjectOfType(type.TypeForCLR);
                }
                else
                {
                    var adapters = GetAllMonoAdapters();
                    var ilInstances = ((ILTypeInstance[]) GetHotComponent(adapters, type as ILType));
                    res = ilInstances.Length > 0 ? ilInstances[0] : null;
                }

                return ILIntepreter.PushObject(__ret, __mStack, res);
            }

            return __esp;
        }

        private static List<CrossBindingAdaptorType> GetAllMonoAdapters()
        {
            return Object.FindObjectsOfType<MonoBehaviour>(true).ToList()
                .FindAll(x => x.GetType().GetInterfaces().Contains(typeof(CrossBindingAdaptorType)))
                .Select(x => (CrossBindingAdaptorType) x)
                .ToList();
        }

        public static object GetHotComponent(List<CrossBindingAdaptorType> adapters, ILType type)
        {
            return adapters
                .FindAll(a => a.ILInstance != null && a.ILInstance.Type.CanAssignTo(type))
                .Select(a => a.ILInstance).ToArray();
        }
    }
}