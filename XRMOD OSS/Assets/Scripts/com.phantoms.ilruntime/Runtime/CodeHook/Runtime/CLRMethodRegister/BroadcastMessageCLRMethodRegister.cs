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
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    public class BroadcastMessageClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);

            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;


            Type tmp_GameObjectType = typeof(GameObject);

            var tmp_Args = new Type[] {typeof(System.String)};
            var tmp_BroadcastMessageMethod1 =
                tmp_GameObjectType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod1, BroadcastMessage_1);
            tmp_Args = new Type[] {typeof(System.String), typeof(System.Object)};
            var tmp_BroadcastMessageMethod2 =
                tmp_GameObjectType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod2, BroadcastMessage_2);
            tmp_Args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            var tmp_BroadcastMessageMethod3 =
                tmp_GameObjectType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod3, BroadcastMessage_3);
            tmp_Args = new Type[]
                {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            var tmp_BroadcastMessageMethod4 =
                tmp_GameObjectType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod4, BroadcastMessage_4);

            //Component
            Type tmp_ComponentType = typeof(Component);
            tmp_Args = new Type[] {typeof(System.String)};
            var tmp_BroadcastMessageMethod4ComponentType1 =
                tmp_ComponentType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod4ComponentType1, BroadcastMessage_1);
            tmp_Args = new Type[] {typeof(System.String), typeof(System.Object)};
            var tmp_BroadcastMessageMethod4ComponentType2 =
                tmp_ComponentType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod4ComponentType2, BroadcastMessage_2);
            tmp_Args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            var tmp_BroadcastMessageMethod4ComponentType3 =
                tmp_ComponentType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod4ComponentType3, BroadcastMessage_3);
            tmp_Args = new Type[]
                {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            var tmp_BroadcastMessageMethod4ComponentType4 =
                tmp_ComponentType.GetMethod("BroadcastMessage", flag, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_BroadcastMessageMethod4ComponentType4, BroadcastMessage_4);
        }

        private unsafe StackObject* BroadcastMessage_1(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @methodName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);

            UnityEngine.GameObject instance_of_this_method;

            object instance = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            if (instance is GameObject)
            {
                instance_of_this_method =
                    (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(instance);
            }
            else if (instance is ILTypeInstance)
            {
                instance_of_this_method = Utility.FindGameFromILTypeInstance((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName))
            {
                instance_of_this_method.SendMessage(@methodName);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!Utility.SendMessageWithILTypeInstance(appDomain, g.gameObject, methodName))
                    {
                        g.SendMessage(@methodName);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }

            return __ret;
        }

        private unsafe StackObject* BroadcastMessage_2(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @value =
                (System.Object) typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @methodName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);

            UnityEngine.GameObject instance_of_this_method;

            object instance = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            if (instance is GameObject)
            {
                instance_of_this_method =
                    (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(instance);
            }
            else if (instance is ILTypeInstance)
            {
                instance_of_this_method = Utility.FindGameFromILTypeInstance((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName, value))
            {
                instance_of_this_method.SendMessage(@methodName, @value);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!Utility.SendMessageWithILTypeInstance(appDomain, g.gameObject, methodName, value))
                    {
                        g.SendMessage(@methodName, @value);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }

            return __ret;
        }

        private unsafe StackObject* BroadcastMessage_3(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SendMessageOptions @options =
                (UnityEngine.SendMessageOptions) typeof(UnityEngine.SendMessageOptions).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @methodName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);

            UnityEngine.GameObject instance_of_this_method;

            object instance = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            if (instance is GameObject)
            {
                instance_of_this_method =
                    (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(instance);
            }
            else if (instance is ILTypeInstance)
            {
                instance_of_this_method = Utility.FindGameFromILTypeInstance((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName, null, options))
            {
                instance_of_this_method.SendMessage(@methodName, @options);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!Utility.SendMessageWithILTypeInstance(appDomain, g.gameObject, methodName, null, options))
                    {
                        g.SendMessage(@methodName, @options);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }

            return __ret;
        }

        private unsafe StackObject* BroadcastMessage_4(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SendMessageOptions @options =
                (UnityEngine.SendMessageOptions) typeof(UnityEngine.SendMessageOptions).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @value =
                (System.Object) typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @methodName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);

            UnityEngine.GameObject instance_of_this_method;

            object instance = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            if (instance is GameObject)
            {
                instance_of_this_method =
                    (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(instance);
            }
            else if (instance is ILTypeInstance)
            {
                instance_of_this_method = Utility.FindGameFromILTypeInstance((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName, value, options))
            {
                instance_of_this_method.SendMessage(@methodName, @value, @options);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!Utility.SendMessageWithILTypeInstance(appDomain, g.gameObject, methodName, value, options))
                    {
                        g.SendMessage(@methodName, @value, @options);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }

            return __ret;
        }
    }
}