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
using System.Threading;
using System.Threading.Tasks;
using com.Phantoms.ILRuntime.Runtime;
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
namespace ILRuntime.Runtime.Generated
{
    public class InvokeClrMethodRegister : AbstractRegister
    {
        private static readonly Dictionary<MethodInfo, CancellationTokenSource> InvokeTokens = new(0);
        private static readonly Dictionary<MethodInfo, CancellationTokenSource> InvokeRepeatingTokens = new(0);

        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            var tmp_Args = new Type[] {typeof(String), typeof(Single)};
            var tmp_InvokeMethod =
                ConstData.MOMO_TYPE.GetMethod("Invoke", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_InvokeMethod, Invoke_1);

            tmp_Args = new Type[] {typeof(String), typeof(float), typeof(float)};
            var tmp_InvokeRepeatingMethod =
                ConstData.MOMO_TYPE.GetMethod("InvokeRepeating", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_InvokeRepeatingMethod, InvokeRepeating_2);


            var tmp_CancelInvokeMethod =
                ConstData.MOMO_TYPE.GetMethod("CancelInvoke", ConstData.CONST_BINDING_FLAGS, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_CancelInvokeMethod, CancelInvoke_3);

            tmp_CancelInvokeMethod = ConstData.MOMO_TYPE.GetMethod("CancelInvoke", ConstData.CONST_BINDING_FLAGS, null,
                new[] {typeof(System.String)}, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_CancelInvokeMethod, CancelInvoke_4);

            var tmp_IsInvokingMethod =
                ConstData.MOMO_TYPE.GetMethod("IsInvoking", ConstData.CONST_BINDING_FLAGS, null, Type.EmptyTypes, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_IsInvokingMethod, IsInvoking_5);

            tmp_IsInvokingMethod =
                ConstData.MOMO_TYPE.GetMethod("IsInvoking", ConstData.CONST_BINDING_FLAGS, null,
                    new[] {typeof(System.String)}, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_IsInvokingMethod, IsInvoking_6);
        }

        /// <summary>
        /// Invoke
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe StackObject* Invoke_1(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @time = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @methodName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ILTypeInstance val = (ILTypeInstance) (StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            UnityEngine.MonoBehaviour adapter =
                (UnityEngine.MonoBehaviour) typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Type type = val.Type.ReflectionType;
            MethodInfo mi = type.GetMethod(methodName,
                System.Reflection.BindingFlags.IgnoreCase
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static);

            if (mi == null)
            {
                adapter.Invoke(methodName, time);
                return __ret;
            }

            InvokeTokens[mi] = new CancellationTokenSource();
            Invoke(val, mi, time, adapter.gameObject);

            return __ret;
        }

        private async void Invoke<T>(T _val, MethodInfo _methodInfo, float _time, GameObject _go)
        {
            if (_time > 0)
            {
                try
                {
                    await Task.Delay((int) (_time * 1000), InvokeTokens[_methodInfo].Token);
                }
                catch (Exception tmp_Ex)
                {
                    if (tmp_Ex is TaskCanceledException)
                    {
                        return;
                    }
                }
            }

            try
            {
                if (_go == null) return;
                _methodInfo.Invoke(_val, null);
                InvokeTokens.Remove(_methodInfo);
            }
            catch (MissingReferenceException)
            {
            }
        }


        /// <summary>
        /// InvokeRepeating
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private unsafe StackObject* InvokeRepeating_2(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @repeatRate = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @time = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @methodName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            ILTypeInstance val = (ILTypeInstance) (StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            UnityEngine.MonoBehaviour adapter =
                (UnityEngine.MonoBehaviour) typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Type type = val.Type.ReflectionType;
            MethodInfo mi = type.GetMethod(methodName,
                System.Reflection.BindingFlags.IgnoreCase
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static);

            if (mi == null)
            {
                adapter.InvokeRepeating(@methodName, @time, @repeatRate);
                return __ret;
            }

            InvokeRepeatingTokens[mi] = new CancellationTokenSource();

            InvokeRepeating(val, mi, time, repeatRate, adapter.gameObject);

            return __ret;
        }

        private async void InvokeRepeating<T>(T val, MethodInfo methodInfo, float time, float duration,
            GameObject go)
        {
            if (time > 0)
            {
                try
                {
                    await Task.Delay((int) (time * 1000), InvokeRepeatingTokens[methodInfo].Token);
                }
                catch (Exception ex)
                {
                    if (ex is TaskCanceledException)
                    {
                        return;
                    }
                }
            }

            while (!InvokeRepeatingTokens[methodInfo].IsCancellationRequested)
            {
                try
                {
                    if (go != null)
                    {
                        methodInfo?.Invoke(val, null);
                    }
                    else
                    {
                        InvokeRepeatingTokens[methodInfo].Cancel();
                    }
                }
                catch (MissingReferenceException)
                {
                }

                try
                {
                    await Task.Delay((int) (duration * 1000), InvokeRepeatingTokens[methodInfo].Token);
                }
                catch (Exception ex)
                {
                    if (ex is TaskCanceledException)
                    {
                        return;
                    }
                }
            }

            InvokeRepeatingTokens.Remove(methodInfo);
        }

        /// <summary>
        /// Redirection CancelInvoke
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private  unsafe StackObject* CancelInvoke_3(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILTypeInstance val = (ILTypeInstance) (StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            UnityEngine.MonoBehaviour adapter =
                (UnityEngine.MonoBehaviour) typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            Type type = val.Type.ReflectionType;
            MethodInfo[] methods = type.GetMethods(
                System.Reflection.BindingFlags.IgnoreCase
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static);

            adapter.CancelInvoke();
            foreach (var mi in methods)
            {
                if (InvokeTokens.TryGetValue(mi, out var ts))
                {
                    ts.Cancel();
                }

                if (InvokeRepeatingTokens.TryGetValue(mi, out ts))
                {
                    ts.Cancel();
                }
            }

            return __ret;
        }

        // <summary>
        /// CancelInvoke
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private  unsafe StackObject* CancelInvoke_4(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack, CLRMethod __method, bool isNewObj)
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
            ILTypeInstance val = (ILTypeInstance) (StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            UnityEngine.MonoBehaviour adapter =
                (UnityEngine.MonoBehaviour) typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            Type type = val.Type.ReflectionType;
            MethodInfo mi = type.GetMethod(methodName,
                System.Reflection.BindingFlags.IgnoreCase
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static);

            if (mi == null)
            {
                adapter.CancelInvoke(@methodName);
                return __ret;
            }
            else
            {
                if (InvokeTokens.TryGetValue(mi, out var ts))
                {
                    ts.Cancel();
                }

                if (InvokeRepeatingTokens.TryGetValue(mi, out ts))
                {
                    ts.Cancel();
                }
            }

            return __ret;
        }

        /// <summary>
        /// IsInvoking
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private unsafe StackObject* IsInvoking_5(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILTypeInstance val = (ILTypeInstance) (StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            UnityEngine.MonoBehaviour adapter =
                (UnityEngine.MonoBehaviour) typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = adapter.IsInvoking();
            if (!result_of_this_method)
            {
                Type type = val.Type.ReflectionType;
                MethodInfo[] methods = type.GetMethods(
                    System.Reflection.BindingFlags.IgnoreCase
                    | System.Reflection.BindingFlags.NonPublic
                    | System.Reflection.BindingFlags.Static);
                foreach (var mi in methods)
                {
                    if (InvokeTokens.TryGetValue(mi, out var ts))
                    {
                        if (!ts.IsCancellationRequested)
                        {
                            result_of_this_method = true;
                            break;
                        }
                    }

                    if (InvokeRepeatingTokens.TryGetValue(mi, out ts))
                    {
                        if (!ts.IsCancellationRequested)
                        {
                            result_of_this_method = true;
                            break;
                        }
                    }
                }
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        /// <summary>
        /// IsInvoking
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private unsafe StackObject* IsInvoking_6(ILIntepreter __intp, StackObject* __esp,
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
            ILTypeInstance val = (ILTypeInstance) (StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            UnityEngine.MonoBehaviour adapter =
                (UnityEngine.MonoBehaviour) typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = adapter.IsInvoking(@methodName);
            if (!result_of_this_method)
            {
                Type type = val.Type.ReflectionType;
                MethodInfo mi = type.GetMethod(methodName,
                    System.Reflection.BindingFlags.IgnoreCase
                    | System.Reflection.BindingFlags.NonPublic
                    | System.Reflection.BindingFlags.Static);
                if (InvokeTokens.TryGetValue(mi, out var ts))
                {
                    if (!ts.IsCancellationRequested)
                    {
                        result_of_this_method = true;
                    }
                }

                if (!result_of_this_method)
                {
                    if (InvokeRepeatingTokens.TryGetValue(mi, out ts))
                    {
                        if (!ts.IsCancellationRequested)
                        {
                            result_of_this_method = true;
                        }
                    }
                }
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
    }
}