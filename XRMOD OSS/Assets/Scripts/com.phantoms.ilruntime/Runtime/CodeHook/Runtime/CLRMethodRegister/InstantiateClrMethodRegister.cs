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
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ILRuntime.Runtime;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Generated;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.phantoms.ilruntime.Runtime.CodeHook.Runtime.CLRMethodRegister
{
    public class InstantiateClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            Type[] tmp_Args = null;

            var tmp_ObjectType = typeof(UnityEngine.Object);
            MethodInfo instantiateMethod;
            var tmp_AllMethods = tmp_ObjectType.GetMethods().ToList().FindAll(f => f.Name == "Instantiate");

            tmp_Args = new[] {typeof(GameObject)};
            foreach (var tmp_MethodInfo in tmp_AllMethods)
            {
                if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject)))
                {
                    instantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(instantiateMethod, Instantiate_7);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Transform)))
                {
                    instantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(instantiateMethod, Instantiate_8);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Transform), typeof(System.Boolean)))
                {
                    instantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(instantiateMethod, Instantiate_9);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Vector3), typeof(Quaternion)))
                {
                    instantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(instantiateMethod, Instantiate_10);
                }
                else if (tmp_MethodInfo.MatchGenericParameters(tmp_Args, typeof(GameObject), typeof(GameObject),
                             typeof(Vector3), typeof(Quaternion), typeof(Transform)))
                {
                    instantiateMethod = tmp_MethodInfo.MakeGenericMethod(tmp_Args);
                    _appDomain.RegisterCLRMethodRedirection(instantiateMethod, Instantiate_11);
                }
            }


            foreach (var tmp_MethodInfo in tmp_AllMethods)
            {
                var tmp_AllParams = tmp_MethodInfo.GetParameters();
                switch (tmp_AllParams.Length)
                {
                    case 1:
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_12);
                        break;
                    case 2:
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_13);
                        break;
                    case 3 when tmp_AllParams[1].ParameterType == typeof(Transform) &&
                                tmp_AllParams[2].ParameterType == typeof(Boolean):
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_14);
                        break;
                    case 3 when tmp_AllParams[1].ParameterType == typeof(Vector3) &&
                                tmp_AllParams[2].ParameterType == typeof(Quaternion):
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_15);
                        break;
                    case 4 when tmp_AllParams[1].ParameterType == typeof(Vector3) &&
                                tmp_AllParams[2].ParameterType == typeof(Quaternion) &&
                                tmp_AllParams[3].ParameterType == typeof(Transform):
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_16);
                        break;
                    default:
                        _appDomain.RegisterCLRMethodRedirection(tmp_MethodInfo, Instantiate_17);
                        break;
                }
            }
        }

        private object InstantiateForMainProject(BaseNotificationData _arg)
        {
            if (_arg is not InstantiateNotificationData tmp_Data) return null;
            if (appDomain == null)
            {
                Assert.IsNotNull(tmp_Data.Prefab);
                return Object.Instantiate(tmp_Data.Prefab);
            }
            else
            {
                Utility.CheckoutIlTypeInstance(tmp_Data.Prefab, out var tmp_Go, out var tmp_Type);
                var tmp_ResultOfThisMethod = UnityEngine.Object.Instantiate(tmp_Go);
                var tmp_Res = Utility.Instantiate(tmp_Go, tmp_ResultOfThisMethod, appDomain, tmp_Type);

                if (tmp_Type == null && tmp_Res is GameObject tmp_GameObject
                                     && tmp_GameObject.GetType() != tmp_Data.Prefab.GetType())
                {
                    return tmp_GameObject.GetComponent(tmp_Data.Prefab.GetType());
                }

                return tmp_Res;
            }
        }

        private unsafe StackObject* Instantiate_7(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.Instantiate(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_8(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @parent);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.Instantiate(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_9(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @parent, @worldPositionStays);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.Instantiate(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_10(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @position, @rotation);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.Instantiate(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_11(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original, @position, @rotation, @parent);
            Utility.Instantiate(original, result_of_this_method, __domain);
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack,
                Utility.Instantiate(original, result_of_this_method, __domain));
        }

        private unsafe StackObject* Instantiate_12(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object @original = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go);
            object res = Utility.Instantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_13(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @parent);
            object res = Utility.Instantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_14(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @worldPositionStays = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @parent, @worldPositionStays);
            object res = Utility.Instantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_15(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @position, @rotation);
            object res = Utility.Instantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_16(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @parent =
                (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @rotation =
                (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @position =
                (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Utility.CheckoutIlTypeInstance(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @position, @rotation, @parent);
            object res = Utility.Instantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }
            IocContainer.GetIoc.Resolve<UserInstantiatedObjects>().AddGameObject(result_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        private unsafe StackObject* Instantiate_17(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            throw new NotSupportedException("No support");
        }
    }
}