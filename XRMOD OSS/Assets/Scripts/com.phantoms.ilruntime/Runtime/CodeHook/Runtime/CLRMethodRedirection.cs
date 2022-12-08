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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODPackageTools.Runtime;
using com.Phantoms.ILRuntime.Runtime.CodeHook;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.U2D;
using UnityEngine.Video;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
using Object = UnityEngine.Object;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    [Obsolete("This class has been deprecated.",true)]
    public class CLRMethodRedirection
    {
        private static readonly Dictionary<MethodInfo, CancellationTokenSource> InvokeRepeatingTokens = new(0);

        private static readonly Dictionary<MethodInfo, CancellationTokenSource> InvokeTokens = new(0);

        public static AppDomain _APP_DOMAIN;

        private static readonly ActionNotificationCenter anc = ActionNotificationCenter.DefaultCenter;
        
        public static void InitILInstantiateForMainProject()
        {
            anc.AddObserver(InstantiateForMainProject, nameof(ActionParameterDataType.Instantiate));
        }

        private static object InstantiateForMainProject(BaseNotificationData _arg)
        {
            if (!(_arg is InstantiateNotificationData tmp_Data)) return null;
            if (_APP_DOMAIN == null)
            {
                Assert.IsNotNull(tmp_Data.Prefab);
                return Object.Instantiate(tmp_Data.Prefab);
            }
            else
            {
                SetGOForInstantiate(tmp_Data.Prefab, out var tmp_Go, out var tmp_Type);
                var tmp_ResultOfThisMethod = UnityEngine.Object.Instantiate(tmp_Go);
                var tmp_Res = DoInstantiate(tmp_Go, tmp_ResultOfThisMethod, _APP_DOMAIN, tmp_Type);

                if (tmp_Type == null && tmp_Res is GameObject && tmp_Res.GetType() != tmp_Data.Prefab.GetType())
                {
                    return ((GameObject) tmp_Res).GetComponent(tmp_Data.Prefab.GetType());
                }

                return tmp_Res;
            }
        }


        /// <summary>
        /// AddComponent
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException"></exception>
        public unsafe  StackObject* AddComponent(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;

            var ptr = __esp - 1;
            GameObject instance = StackObject.ToObject(ptr, __domain, __mStack) as GameObject;
            if (instance == null)
                throw new NullReferenceException();
            __intp.Free(ptr);

            var tmp_GenericArgument = __method.GenericArguments;
            if (tmp_GenericArgument is not {Length: 1}) return __esp;
            var tmp_Type = tmp_GenericArgument[0];
            object tmp_Res;
            if (tmp_Type is CLRType)
            {
                tmp_Res = instance.AddComponent(tmp_Type.TypeForCLR);
            }
            else
            {
                //We need to create the code in ARExperience manually
                //We could not use `new` key word to create the MonoBehaviour
                var tmp_ILInstance = new ILTypeInstance(tmp_Type as ILType, false);
                
                //Add the adapter for our game object
                var tmp_MonoAdapterInstance = instance.AddComponent<MonoBehaviourAdapter.Adapter>();
                
                //Because our adapter has not the ARExperience code's instance, So we need to assign it manually
                tmp_MonoAdapterInstance.ILInstance = tmp_ILInstance;
                tmp_MonoAdapterInstance.AppDomain = __domain;

                //Replace the CLRInstance, because the default instance value is not create by `AddComponent`
                tmp_ILInstance.CLRInstance = tmp_MonoAdapterInstance;

                //For ILRuntime
                tmp_Res = tmp_MonoAdapterInstance.ILInstance;

                //Invoke the Awake
                tmp_MonoAdapterInstance.Awake();


                //Execute constructor
                if (tmp_Type.BaseType.ReflectionType is ILRuntimeType)
                {
                    tmp_Type.ReflectionType.GetConstructor(new Type[] { })?.Invoke(instance, new object[] { });
                }
                else
                {
                    var tmp_Constructor = tmp_Type.GetConstructor(Extensions.EmptyParamList);
                    if (tmp_Constructor != null)
                    {
                        __domain.Invoke(tmp_Constructor, tmp_Res, null);
                    }
                }
            }

            return ILIntepreter.PushObject(ptr, __mStack, tmp_Res);
        }


        public unsafe static StackObject* GetComponent(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
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
                    tmp_GameObject = FindGOFromHotClass(tmp_IlTypeInstance);
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

        /// <summary>
        /// Redirection CancelInvoke
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public static unsafe StackObject* CancelInvoke_3(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
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
        public static unsafe StackObject* CancelInvoke_4(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
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
        public static unsafe StackObject* IsInvoking_5(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
        public static unsafe StackObject* IsInvoking_6(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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

        /// <summary>
        /// InvokeRepeating
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public static unsafe StackObject* InvokeRepeating_2(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            DoInvokeRepeating(val, mi, time, repeatRate, adapter.gameObject);

            return __ret;
        }

        public static async void DoInvokeRepeating<T>(T val, MethodInfo methodInfo, float time, float duration,
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
        /// Invoke
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public static unsafe StackObject* Invoke_1(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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
            DoInvoke(val, mi, time, adapter.gameObject);

            return __ret;
        }

        public static async void DoInvoke<T>(T val, MethodInfo methodInfo, float time, GameObject go)
        {
            if (time > 0)
            {
                try
                {
                    await Task.Delay((int) (time * 1000), InvokeTokens[methodInfo].Token);
                }
                catch (Exception ex)
                {
                    if (ex is TaskCanceledException)
                    {
                        return;
                    }
                }
            }

            try
            {
                if (go != null)
                {
                    methodInfo.Invoke(val, null);
                    InvokeTokens.Remove(methodInfo);
                }
            }
            catch (MissingReferenceException)
            {
            }
        }

        /// <summary>
        /// find ilrt gameObject
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GameObject FindGOFromHotClass(ILTypeInstance instance)
        {
            var returnType = (instance as ILTypeInstance).Type;
            if (returnType.ReflectionType == typeof(MonoBehaviour))
            {
                var pi = returnType.ReflectionType.GetProperty("gameObject");
                return pi.GetValue((instance as ILTypeInstance).CLRInstance) as GameObject;
            }
            else if (returnType.ReflectionType.IsSubclassOf(typeof(MonoBehaviour)))
            {
                var pi = returnType.ReflectionType.BaseType.GetProperty("gameObject");
                return pi.GetValue((instance as ILTypeInstance).CLRInstance) as GameObject;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// SendMessage
        /// </summary>
        /// <param name="go"></param>
        /// <param name="methodName"></param>
        /// <param name="value"></param>
        /// <param name="option"></param>
        public static bool DoSendMessageOnHotCode(GameObject go, string methodName, object value = null,
            SendMessageOptions option = SendMessageOptions.RequireReceiver)
        {
            bool found = false;

            var clrInstances = go.GetComponents<CrossBindingAdaptorType>();
            for (int i = 0; i < clrInstances.Length; i++)
            {
                var clrInstance = clrInstances[i];
                if (clrInstance.ILInstance != null)
                {
                    IType t = clrInstance.ILInstance.Type;
                    if (value == null)
                    {
                        IMethod m = t.GetMethod(methodName, 0);
                        if (m != null)
                        {
                            _APP_DOMAIN.Invoke(m, clrInstance.ILInstance, null);
                            found = true;
                        }
                    }
                    else
                    {
                        IMethod m = t.GetMethod(methodName, 1);
                        if (m != null)
                        {
                            _APP_DOMAIN.Invoke(m, clrInstance.ILInstance, value);
                            found = true;
                        }
                    }
                }
            }

            return found;
        }

        public unsafe static StackObject* BroadcastMessage_1(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName))
            {
                instance_of_this_method.SendMessage(@methodName);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(g.gameObject, methodName))
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

        public unsafe static StackObject* BroadcastMessage_2(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, value))
            {
                instance_of_this_method.SendMessage(@methodName, @value);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(g.gameObject, methodName, value))
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

        public unsafe static StackObject* BroadcastMessage_3(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, null, options))
            {
                instance_of_this_method.SendMessage(@methodName, @options);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(g.gameObject, methodName, null, options))
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

        public unsafe static StackObject* BroadcastMessage_4(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"BroadcastMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, value, options))
            {
                instance_of_this_method.SendMessage(@methodName, @value, @options);
            }

            var go = instance_of_this_method.GetComponentsInChildren<Transform>(true);

            foreach (var g in go)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(g.gameObject, methodName, value, options))
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

        public unsafe static StackObject* SendMessageUpwards_1(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning(
            //    $"SendMessageUpwards方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName))
            {
                instance_of_this_method.SendMessage(@methodName);
            }

            var go = instance_of_this_method.transform.parent.gameObject;
            while (go != null)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(go, methodName))
                    {
                        go.SendMessage(@methodName);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }

                go = go.transform.parent.gameObject;
            }


            return __ret;
        }

        public unsafe static StackObject* SendMessageUpwards_2(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning(
            //   $"SendMessageUpwards方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, value))
            {
                instance_of_this_method.SendMessage(@methodName, @value);
            }

            var go = instance_of_this_method.transform.parent.gameObject;
            while (go != null)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(go, methodName, value))
                    {
                        go.SendMessage(@methodName, @value);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }

                go = go.transform.parent.gameObject;
            }

            return __ret;
        }

        public unsafe static StackObject* SendMessageUpwards_3(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning(
            //    $"SendMessageUpwards方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, null, options))
            {
                instance_of_this_method.SendMessage(@methodName, @options);
            }

            var go = instance_of_this_method.transform.parent.gameObject;
            while (go != null)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(go, methodName, null, options))
                    {
                        go.SendMessage(@methodName, @options);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }

                go = go.transform.parent.gameObject;
            }


            return __ret;
        }

        public unsafe static StackObject* SendMessageUpwards_4(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning(
            //    $"SendMessageUpwards方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, value, options))
            {
                instance_of_this_method.SendMessage(@methodName, @value, @options);
            }

            var go = instance_of_this_method.transform.parent.gameObject;
            while (go != null)
            {
                try
                {
                    if (!DoSendMessageOnHotCode(go, methodName, value, options))
                    {
                        go.SendMessage(@methodName, @value, @options);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }

                go = go.transform.parent.gameObject;
            }

            return __ret;
        }

        public unsafe static StackObject* SendMessage_1(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName))
            {
                instance_of_this_method.SendMessage(@methodName);
            }

            return __ret;
        }

        public unsafe static StackObject* SendMessage_2(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, value))
            {
                instance_of_this_method.SendMessage(@methodName, @value);
            }

            return __ret;
        }

        public unsafe static StackObject* SendMessage_3(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, null, options))
            {
                instance_of_this_method.SendMessage(@methodName, @options);
            }

            return __ret;
        }

        public unsafe static StackObject* SendMessage_4(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
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
                instance_of_this_method = FindGOFromHotClass((ILTypeInstance) instance);
            }
            else
            {
                return __esp;
            }

            __intp.Free(ptr_of_this_method);

            //Debug.LogWarning($"SendMessage方法被重定向了，会尝试调用热更脚本的'{methodName}'方法，若热更里没有，则会尝试调用本地的该方法，如果本地没对应，会报错，可忽略");

            if (!DoSendMessageOnHotCode(instance_of_this_method, methodName, value, options))
            {
                instance_of_this_method.SendMessage(@methodName, @value, @options);
            }

            return __ret;
        }


        /// <summary>
        /// Find GameObject
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="ins"></param>
        /// <param name="returnType"></param>
        private static void SetGOForInstantiate(object instance, out GameObject ins, out ILType returnType)
        {
            returnType = null;
            switch (instance)
            {
                case GameObject tmp_Instance:
                    ins = tmp_Instance;
                    break;
                case ILTypeInstance tmp_Instance:
                    returnType = tmp_Instance.Type;
                    ins = FindGOFromHotClass(tmp_Instance);
                    Assert.IsNotNull(ins);
                    break;
                default:
                    ins = (instance as Component)?.gameObject;
                    break;
            }
        }

        public static void CleanGoForInstantiate(ref GameObject res, GameObject ins, AppDomain __domain)
        {
            var clrInstances = res.GetComponents<CrossBindingAdaptorType>();
            var clrInstances4Ins = ins.GetComponents<CrossBindingAdaptorType>();
            for (int i = 0; i < clrInstances.Length; i++)
            {
                var clrInstance = clrInstances[i];
                var clrInstance4Ins = clrInstances4Ins[i];

                ILTypeInstance
                    ilInstance =
                        clrInstance4Ins.ILInstance
                            .Clone();
                var t = clrInstance4Ins.GetType();

                if (clrInstance4Ins is MonoBehaviourAdapter.Adapter)
                {
                    ((MonoBehaviourAdapter.Adapter) clrInstance).Reset();
                    ((MonoBehaviourAdapter.Adapter) clrInstance).ILInstance = ilInstance;
                    ((MonoBehaviourAdapter.Adapter) clrInstance).AppDomain = __domain;
                }
                else
                {
                    var ILInstance = t.GetField("instance",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    var AppDomain = t.GetField("appdomain",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    ILInstance.SetValue(clrInstance, ilInstance);
                    AppDomain.SetValue(clrInstance, __domain);
                }

                if (clrInstance4Ins.ILInstance.CLRInstance == clrInstance4Ins)
                {
                    ilInstance.CLRInstance = clrInstance;
                }
                else
                {
                    ilInstance.CLRInstance = ilInstance;
                }

                bool activated = false;
                var awakeMethod = clrInstance.GetType().GetMethod("Awake",
                    BindingFlags.Default | BindingFlags.Public
                                         | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                         BindingFlags.NonPublic | BindingFlags.Static);
                if (awakeMethod == null)
                {
                    awakeMethod = t.GetMethod("Awake",
                        BindingFlags.Default | BindingFlags.Public
                                             | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                             BindingFlags.NonPublic | BindingFlags.Static);
                }
                else
                {
                    awakeMethod.Invoke(clrInstance, null);
                    activated = true;
                }

                if (awakeMethod == null)
                {
                    //Debug.LogError($"{t.FullName}不包含Awake方法，无法激活，已跳过");
                }
                else if (!activated)
                {
                    awakeMethod.Invoke(t, null);
                }
            }
        }


        internal static unsafe StackObject* Instantiate_7(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @original =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(@original);

            return ILIntepreter.PushObject(__ret, __mStack,
                DoInstantiate(original, result_of_this_method, __domain));
        }

        internal static unsafe StackObject* Instantiate_8(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            return ILIntepreter.PushObject(__ret, __mStack,
                DoInstantiate(original, result_of_this_method, __domain));
        }

        internal static unsafe StackObject* Instantiate_9(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            return ILIntepreter.PushObject(__ret, __mStack,
                DoInstantiate(original, result_of_this_method, __domain));
        }

        internal static unsafe StackObject* Instantiate_10(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            return ILIntepreter.PushObject(__ret, __mStack,
                DoInstantiate(original, result_of_this_method, __domain));
        }

        internal static unsafe StackObject* Instantiate_11(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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
            DoInstantiate(original, result_of_this_method, __domain);

            return ILIntepreter.PushObject(__ret, __mStack,
                DoInstantiate(original, result_of_this_method, __domain));
        }

        internal static unsafe StackObject* Instantiate_12(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object @original = StackObject.ToObject(ptr_of_this_method, __domain, __mStack);
            __intp.Free(ptr_of_this_method);

            SetGOForInstantiate(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go);
            object res = DoInstantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        internal static unsafe StackObject* Instantiate_13(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            SetGOForInstantiate(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @parent);
            object res = DoInstantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        internal static unsafe StackObject* Instantiate_14(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            SetGOForInstantiate(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @parent, @worldPositionStays);
            object res = DoInstantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        internal static unsafe StackObject* Instantiate_15(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            SetGOForInstantiate(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @position, @rotation);
            object res = DoInstantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        internal static unsafe StackObject* Instantiate_16(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
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

            SetGOForInstantiate(original, out var go, out var type);
            var result_of_this_method = UnityEngine.Object.Instantiate(go, @position, @rotation, @parent);
            object res = DoInstantiate(go, result_of_this_method, __domain, type);
            if (type == null && res is GameObject && res.GetType() != original.GetType())
            {
                res = ((GameObject) res).GetComponent(original.GetType());
            }

            return ILIntepreter.PushObject(__ret, __mStack, res);
        }

        internal static unsafe StackObject* Instantiate_17(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            throw new NotSupportedException("No support");
        }

        /// <summary>
        /// Log.PrintError
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe static StackObject* PrintError(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.LogError(message + "\n\n==========ILRuntime StackTrace==========\n" + stacktrace);
            return __ret;
        }

        /// <summary>
        /// Log.PrintWarning
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe static StackObject* PrintWarning(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.LogWarning(message + "\n\n==========ILRuntime StackTrace==========\n" + stacktrace);
            return __ret;
        }

        /// <summary>
        /// Log.Print
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe static StackObject* Print(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.Log(message + "\n\n==========ILRuntime StackTrace==========\n" + stacktrace);
            return __ret;
        }

        /// <summary>
        /// Debug.LogError
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe static StackObject* LogError(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.LogError(message + "\n\n==========ILRuntime StackTrace==========\n" + stacktrace);
            return __ret;
        }

        /// <summary>
        /// Debug.LogWarning
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe static StackObject* LogWarning(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.LogWarning(message + "\n\n==========ILRuntime StackTrace==========\n" + stacktrace);
            return __ret;
        }

        /// <summary>
        /// Debug.Log
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        public unsafe static StackObject* Log(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.Log(message + "\n Stacktrace" + stacktrace);
            return __ret;
        }


        public unsafe static StackObject* FindObjectOfType(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            CLRMethod __method, bool isNewObj)
        {
            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            object tmp_Res = null;
            var tmp_Type = tmp_GenericArgument[0];
            if (tmp_Type is CLRType)
            {
                tmp_Res = Object.FindObjectOfType(tmp_Type.TypeForCLR);
            }
            else
            {
//                if (tmp_Type.TypeForCLR == typeof(NetworkBehaviourAdapter.Adapter))
//                {
//                    var tmp_ClrInstances = Object.FindObjectsOfType<NetworkBehaviourAdapter.Adapter>();
//                    foreach (var tmp_ClrInstance in tmp_ClrInstances)
//                    {
//                        if (tmp_ClrInstance.ILInstance == null) continue;
//                        if (tmp_ClrInstance.ILInstance.Type.FullName != tmp_Type.FullName) continue;
//                        tmp_Res = tmp_ClrInstance.ILInstance;
//                        break;
//                    }
//                }
//                else
//                {
                var tmp_ClrInstances = Object.FindObjectsOfType<MonoBehaviourAdapter.Adapter>();
                foreach (var tmp_ClrInstance in tmp_ClrInstances)
                {
                    if (tmp_ClrInstance.ILInstance == null) continue;
                    if (tmp_ClrInstance.ILInstance.Type.FullName != tmp_Type.FullName) continue;
                    tmp_Res = tmp_ClrInstance.ILInstance;
                    break;
                }
//                }
            }

            return ILIntepreter.PushObject(__esp, __mStack, tmp_Res);
        }

        public unsafe static StackObject* LoadAssetOfType(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];

            if (tmp_Type.TypeForCLR == typeof(GameObject))
            {
                LoadGenericResource<GameObject>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Texture2D))
            {
                LoadGenericResource<Texture2D>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Material))
            {
                LoadGenericResource<Material>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(VideoClip))
            {
                LoadGenericResource<VideoClip>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(AudioClip))
            {
                LoadGenericResource<AudioClip>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Animation))
            {
                LoadGenericResource<Animation>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Sprite))
            {
                LoadGenericResource<Sprite>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(SpriteAtlas))
            {
                LoadGenericResource<SpriteAtlas>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Font))
            {
                LoadGenericResource<Font>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(TextAsset))
            {
                LoadGenericResource<TextAsset>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(Shader))
            {
                LoadGenericResource<Shader>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(PhysicMaterial))
            {
                LoadGenericResource<PhysicMaterial>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }
            else if (tmp_Type.TypeForCLR == typeof(ComputeShader))
            {
                LoadGenericResource<ComputeShader>(__intp, __esp, __mStack, ptr_of_this_method, __domain);
            }

            return __ret;
        }


        public static unsafe StackObject* LoadAssetOfTypeAsync(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);


            System.String @_wannaLoadAssetName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_projectName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];
            if (tmp_Type.TypeForCLR == typeof(GameObject))
            {
                return LoadGenericResourceAsync<GameObject>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Texture2D))
            {
                return LoadGenericResourceAsync<Texture2D>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Material))
            {
                return LoadGenericResourceAsync<Material>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(VideoClip))
            {
                return LoadGenericResourceAsync<VideoClip>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(AudioClip))
            {
                return LoadGenericResourceAsync<AudioClip>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Animation))
            {
                return LoadGenericResourceAsync<Animation>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Sprite))
            {
                return LoadGenericResourceAsync<Sprite>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(SpriteAtlas))
            {
                return LoadGenericResourceAsync<SpriteAtlas>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Font))
            {
                return LoadGenericResourceAsync<Font>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(TextAsset))
            {
                return LoadGenericResourceAsync<TextAsset>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(Shader))
            {
                return LoadGenericResourceAsync<Shader>(__mStack, @_projectName, @_wannaLoadAssetName, __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(PhysicMaterial))
            {
                return LoadGenericResourceAsync<PhysicMaterial>(__mStack, @_projectName, @_wannaLoadAssetName,
                    __ret);
            }

            if (tmp_Type.TypeForCLR == typeof(ComputeShader))
            {
                return LoadGenericResourceAsync<ComputeShader>(__mStack, @_projectName, @_wannaLoadAssetName,
                    __ret);
            }

            return __ret;
        }

        private static unsafe StackObject* LoadGenericResourceAsync<T>(List<object> __mStack, string _projectName,
            string _wannaLoadAssetName, StackObject* __ret) where T : UnityEngine.Object
        {
            var result_of_this_method =
                BasePackageLoaderUtility.LoadAssetFromPackage<T>(@_projectName, @_wannaLoadAssetName);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        private static unsafe void LoadGenericResource<T>(ILIntepreter __intp, StackObject* __esp,
            List<object> __mStack,
            StackObject* ptr_of_this_method, AppDomain __domain) where T : UnityEngine.Object
        {
            System.Action<T> @_loadedCallback =
                (System.Action<T>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_wannaLoadedAssetName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_projectName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            BasePackageLoaderUtility.LoadAssetFromPackage(@_projectName, @_wannaLoadedAssetName, @_loadedCallback);
        }


        private static object DoInstantiate(GameObject original, GameObject res, AppDomain __domain,
            IType type = null)
        {
            res.name = res.name.Replace("(Clone)", string.Empty);

            //Caching to dictionary for API.FindGameObjectByName
            //InstantiateUtility.StoreGameObject(res);

            if (res.GetComponentsInChildren<CrossBindingAdaptorType>(true).Length == 0)
            {
                if (res.GetComponentsInChildren<MonoBinder>(true).Length > 0)
                {
                    BinderManager.DoBind(res.GetComponentsInChildren<MonoBinder>(true).ToList());
                }

                return res;
            }

            bool needClassBind = false;

            foreach (var t in res.GetComponentsInChildren<Transform>())
            {
                var go = t.gameObject;
                var cb = go.GetComponent<MonoBinder>();
                if (cb != null && go.GetComponent<CrossBindingAdaptorType>() != null)
                {
                    UnityEngine.Object.DestroyImmediate(cb);
                }
            }


            if (original.GetComponentsInChildren<MonoBinder>(true).Length > 0)
            {
                needClassBind = true;
            }

            var clrInstances = res.GetComponentsInChildren<CrossBindingAdaptorType>(true);
            var clrInstances4Ins = original.GetComponentsInChildren<CrossBindingAdaptorType>(true);

            ILTypeInstance result = null;
            for (int i = 0; i < clrInstances.Length; i++)
            {
                var clrInstance = clrInstances[i];
                var clrInstance4Ins = clrInstances4Ins[i];

                ILTypeInstance ilInstance =
                    clrInstance4Ins.ILInstance
                        .Clone();

                var t = clrInstance4Ins.GetType();
                if (ilInstance.Type == type && result == null)
                {
                    result = ilInstance;
                }

                if (clrInstance4Ins is MonoBehaviourAdapter.Adapter)
                {
                    var adapter = ((MonoBehaviourAdapter.Adapter) clrInstance4Ins);
                    var self = ((MonoBehaviourAdapter.Adapter) clrInstance);
                    self.Reset();
                    self.ILInstance = ilInstance;
                    self.AppDomain = __domain;
                }
                else
                {
                    var tmp_IlInstance = t.GetField("instance",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    var tmp_AppDomain = t.GetField("appdomain",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    tmp_IlInstance.SetValue(clrInstance, ilInstance);
                    tmp_AppDomain.SetValue(clrInstance, __domain);
                }

                if (clrInstance4Ins.ILInstance.CLRInstance == clrInstance4Ins)
                {
                    ilInstance.CLRInstance = clrInstance;
                }
                else
                {
                    ilInstance.CLRInstance = ilInstance;
                }


                var awakeMethod = (clrInstance.GetType() != null ? clrInstance.GetType() : t).GetMethod("Awake",
                    BindingFlags.Default | BindingFlags.Public
                                         | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                         BindingFlags.NonPublic | BindingFlags.Static);
                if (awakeMethod != null)
                {
                    awakeMethod.Invoke(clrInstance, null);
                }
                else
                {
                    //Debug.LogError($"{t.FullName}不包含Awake方法，无法激活，已跳过");
                }

                if (needClassBind)
                {
                    BinderManager.DoBind();
                }
                else
                {
                    if (res.GetComponentInChildren<MonoBinder>(true))
                    {
                        BinderManager.DoBind(res.GetComponentsInChildren<MonoBinder>(true).ToList());
                    }
                }
            }

            if (type != null)
            {
                return result;
            }
            else
            {
                return res;
            }
        }
    }
}