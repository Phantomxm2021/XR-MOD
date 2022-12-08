// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
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
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Generated;
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
    public class SendMessageClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);

            //GameObject
            Type tmp_GameObjectType = typeof(GameObject);
            var tmp_Args = new Type[] {typeof(System.String)};
            var tmp_SendMessageMethod1 =
                tmp_GameObjectType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod1, SendMessage_1);
            tmp_Args = new Type[] {typeof(System.String), typeof(System.Object)};
            var tmp_SendMessageMethod2 =
                tmp_GameObjectType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod2, SendMessage_2);
            tmp_Args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            var tmp_SendMessageMethod3 =
                tmp_GameObjectType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null) ??
                throw new ArgumentNullException(
                    "GameObjectType.GetMethod(\"SendMessage\", flag, null, tmp_Args, null)");
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod3, SendMessage_3);
            tmp_Args = new Type[]
                {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            var tmp_SendMessageMethod4 =
                tmp_GameObjectType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod4, SendMessage_4);

            //Component
            Type tmp_ComponentType = typeof(Component);
            tmp_Args = new Type[] {typeof(System.String)};
            var tmp_SendMessageMethod4ComponentType1 =
                tmp_ComponentType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod4ComponentType1, SendMessage_1);
            tmp_Args = new Type[] {typeof(System.String), typeof(System.Object)};
            var tmp_SendMessageMethod4ComponentType2 =
                tmp_ComponentType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null) ??
                throw new ArgumentNullException(
                    "tmp_ComponentType.GetMethod(\"SendMessage\", flag, null, tmp_Args, null)");
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod4ComponentType2, SendMessage_2);
            tmp_Args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            var tmp_SendMessageMethod4ComponentType3 =
                tmp_ComponentType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null) ??
                throw new ArgumentNullException(
                    "tmp_ComponentType.GetMethod(\"SendMessage\", flag, null, tmp_Args, null)");
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod4ComponentType3, SendMessage_3);
            tmp_Args = new Type[]
                {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            var tmp_SendMessageMethod4ComponentType4 =
                tmp_ComponentType.GetMethod("SendMessage", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_SendMessageMethod4ComponentType4, SendMessage_4);
        }

        private unsafe StackObject* SendMessage_1(ILIntepreter __intp, StackObject* __esp,
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

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName))
            {
                instance_of_this_method.SendMessage(@methodName);
            }

            return __ret;
        }

        private unsafe StackObject* SendMessage_2(ILIntepreter __intp, StackObject* __esp,
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

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName, value))
            {
                instance_of_this_method.SendMessage(@methodName, @value);
            }

            return __ret;
        }

        private unsafe StackObject* SendMessage_3(ILIntepreter __intp, StackObject* __esp,
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

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName, null, options))
            {
                instance_of_this_method.SendMessage(@methodName, @options);
            }

            return __ret;
        }

        private unsafe StackObject* SendMessage_4(ILIntepreter __intp, StackObject* __esp,
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

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!Utility.SendMessageWithILTypeInstance(appDomain, instance_of_this_method, methodName, value, options))
            {
                instance_of_this_method.SendMessage(@methodName, @value, @options);
            }

            return __ret;
        }
    }
}