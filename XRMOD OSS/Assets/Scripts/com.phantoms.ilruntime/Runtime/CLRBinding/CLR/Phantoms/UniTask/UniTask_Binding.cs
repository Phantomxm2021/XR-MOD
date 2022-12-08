// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Runtime.CLRBingding.CLR.Phantoms.
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
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe public class UniTask_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Cysharp.Threading.Tasks.UniTask);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTask>)};
            method = type.GetMethod("ToCoroutine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToCoroutine_0);
            args = new Type[]{};
            method = type.GetMethod("get_Status", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Status_1);
            args = new Type[]{};
            method = type.GetMethod("GetAwaiter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAwaiter_2);
            args = new Type[]{};
            method = type.GetMethod("SuppressCancellationThrow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SuppressCancellationThrow_3);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_4);
            args = new Type[]{};
            method = type.GetMethod("Preserve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Preserve_5);
            args = new Type[]{};
            method = type.GetMethod("AsAsyncUnitUniTask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AsAsyncUnitUniTask_6);
            args = new Type[]{};
            method = type.GetMethod("Yield", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Yield_7);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.PlayerLoopTiming)};
            method = type.GetMethod("Yield", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Yield_8);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Yield", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Yield_9);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Yield", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Yield_10);
            args = new Type[]{};
            method = type.GetMethod("NextFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NextFrame_11);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.PlayerLoopTiming)};
            method = type.GetMethod("NextFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NextFrame_12);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("NextFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NextFrame_13);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("NextFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NextFrame_14);
            args = new Type[]{typeof(UnityEngine.MonoBehaviour), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("WaitForEndOfFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitForEndOfFrame_15);
            args = new Type[]{};
            method = type.GetMethod("WaitForFixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitForFixedUpdate_16);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("WaitForFixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitForFixedUpdate_17);
            args = new Type[]{typeof(System.Int32), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("DelayFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DelayFrame_18);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Delay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Delay_19);
            args = new Type[]{typeof(System.TimeSpan), typeof(System.Boolean), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Delay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Delay_20);
            args = new Type[]{typeof(System.Int32), typeof(Cysharp.Threading.Tasks.DelayType), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Delay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Delay_21);
            args = new Type[]{typeof(System.TimeSpan), typeof(Cysharp.Threading.Tasks.DelayType), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Delay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Delay_22);
            args = new Type[]{typeof(System.Exception)};
            method = methods.Where(t => t.Name.Equals("FromException") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, FromException_23);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = methods.Where(t => t.Name.Equals("FromCanceled") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, FromCanceled_24);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTask>)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_25);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTask>)};
            method = type.GetMethod("Lazy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Lazy_26);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTaskVoid>)};
            method = type.GetMethod("Void", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Void_27);
            args = new Type[]{typeof(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Void", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Void_28);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTaskVoid>)};
            method = type.GetMethod("Action", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Action_29);
            args = new Type[]{typeof(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("Action", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Action_30);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTaskVoid>)};
            method = type.GetMethod("UnityAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnityAction_31);
            args = new Type[]{typeof(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("UnityAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnityAction_32);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTask>)};
            method = type.GetMethod("Defer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Defer_33);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = methods.Where(t => t.Name.Equals("Never") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, Never_34);
            args = new Type[]{typeof(System.Action), typeof(System.Boolean), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("RunOnThreadPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RunOnThreadPool_35);
            args = new Type[]{typeof(System.Action<System.Object>), typeof(System.Object), typeof(System.Boolean), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("RunOnThreadPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RunOnThreadPool_36);
            args = new Type[]{typeof(System.Func<Cysharp.Threading.Tasks.UniTask>), typeof(System.Boolean), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("RunOnThreadPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RunOnThreadPool_37);
            args = new Type[]{typeof(System.Func<System.Object, Cysharp.Threading.Tasks.UniTask>), typeof(System.Object), typeof(System.Boolean), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("RunOnThreadPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RunOnThreadPool_38);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("SwitchToMainThread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchToMainThread_39);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("SwitchToMainThread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchToMainThread_40);
            args = new Type[]{typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("ReturnToMainThread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnToMainThread_41);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("ReturnToMainThread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnToMainThread_42);
            args = new Type[]{typeof(System.Action), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming)};
            method = type.GetMethod("Post", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Post_43);
            args = new Type[]{};
            method = type.GetMethod("SwitchToThreadPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchToThreadPool_44);
            args = new Type[]{};
            method = type.GetMethod("SwitchToTaskPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchToTaskPool_45);
            args = new Type[]{typeof(System.Threading.SynchronizationContext), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("SwitchToSynchronizationContext", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchToSynchronizationContext_46);
            args = new Type[]{typeof(System.Threading.SynchronizationContext), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("ReturnToSynchronizationContext", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnToSynchronizationContext_47);
            args = new Type[]{typeof(System.Boolean), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("ReturnToCurrentSynchronizationContext", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnToCurrentSynchronizationContext_48);
            args = new Type[]{typeof(System.Func<System.Boolean>), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("WaitUntil", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitUntil_49);
            args = new Type[]{typeof(System.Func<System.Boolean>), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming), typeof(System.Threading.CancellationToken)};
            method = type.GetMethod("WaitWhile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitWhile_50);
            args = new Type[]{typeof(System.Threading.CancellationToken), typeof(Cysharp.Threading.Tasks.PlayerLoopTiming)};
            method = type.GetMethod("WaitUntilCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitUntilCanceled_51);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.UniTask[])};
            method = type.GetMethod("WhenAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WhenAll_52);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask>)};
            method = type.GetMethod("WhenAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WhenAll_53);
            args = new Type[]{typeof(Cysharp.Threading.Tasks.UniTask[])};
            method = type.GetMethod("WhenAny", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WhenAny_54);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask>)};
            method = type.GetMethod("WhenAny", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WhenAny_55);

            field = type.GetField("CompletedTask", flag);
            app.RegisterCLRFieldGetter(field, get_CompletedTask_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CompletedTask_0, null);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Cysharp.Threading.Tasks.UniTask());
            app.RegisterCLRCreateArrayInstance(type, s => new Cysharp.Threading.Tasks.UniTask[s]);

            args = new Type[]{typeof(Cysharp.Threading.Tasks.IUniTaskSource), typeof(System.Int16)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Cysharp.Threading.Tasks.UniTask instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Cysharp.Threading.Tasks.UniTask[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* ToCoroutine_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTask> @taskFactory = (System.Func<Cysharp.Threading.Tasks.UniTask>)typeof(System.Func<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.ToCoroutine(@taskFactory);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Status_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cysharp.Threading.Tasks.UniTask instance_of_this_method = (Cysharp.Threading.Tasks.UniTask)typeof(Cysharp.Threading.Tasks.UniTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Status;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAwaiter_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cysharp.Threading.Tasks.UniTask instance_of_this_method = (Cysharp.Threading.Tasks.UniTask)typeof(Cysharp.Threading.Tasks.UniTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.GetAwaiter();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SuppressCancellationThrow_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cysharp.Threading.Tasks.UniTask instance_of_this_method = (Cysharp.Threading.Tasks.UniTask)typeof(Cysharp.Threading.Tasks.UniTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.SuppressCancellationThrow();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cysharp.Threading.Tasks.UniTask instance_of_this_method = (Cysharp.Threading.Tasks.UniTask)typeof(Cysharp.Threading.Tasks.UniTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.ToString();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Preserve_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cysharp.Threading.Tasks.UniTask instance_of_this_method = (Cysharp.Threading.Tasks.UniTask)typeof(Cysharp.Threading.Tasks.UniTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Preserve();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AsAsyncUnitUniTask_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Cysharp.Threading.Tasks.UniTask instance_of_this_method = (Cysharp.Threading.Tasks.UniTask)typeof(Cysharp.Threading.Tasks.UniTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.AsAsyncUnitUniTask();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Yield_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Yield();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Yield_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Yield(@timing);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Yield_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Yield(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Yield_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Yield(@timing, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* NextFrame_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.NextFrame();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* NextFrame_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.NextFrame(@timing);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* NextFrame_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.NextFrame(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* NextFrame_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.NextFrame(@timing, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitForEndOfFrame_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MonoBehaviour @coroutineRunner = (UnityEngine.MonoBehaviour)typeof(UnityEngine.MonoBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WaitForEndOfFrame(@coroutineRunner, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitForFixedUpdate_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WaitForFixedUpdate();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitForFixedUpdate_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WaitForFixedUpdate(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DelayFrame_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @delayTiming = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @delayFrameCount = ptr_of_this_method->Value;


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.DelayFrame(@delayFrameCount, @delayTiming, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Delay_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @delayTiming = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @ignoreTimeScale = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @millisecondsDelay = ptr_of_this_method->Value;


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Delay(@millisecondsDelay, @ignoreTimeScale, @delayTiming, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Delay_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @delayTiming = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @ignoreTimeScale = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.TimeSpan @delayTimeSpan = (System.TimeSpan)typeof(System.TimeSpan).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Delay(@delayTimeSpan, @ignoreTimeScale, @delayTiming, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Delay_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @delayTiming = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Cysharp.Threading.Tasks.DelayType @delayType = (Cysharp.Threading.Tasks.DelayType)typeof(Cysharp.Threading.Tasks.DelayType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @millisecondsDelay = ptr_of_this_method->Value;


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Delay(@millisecondsDelay, @delayType, @delayTiming, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Delay_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @delayTiming = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Cysharp.Threading.Tasks.DelayType @delayType = (Cysharp.Threading.Tasks.DelayType)typeof(Cysharp.Threading.Tasks.DelayType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.TimeSpan @delayTimeSpan = (System.TimeSpan)typeof(System.TimeSpan).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Delay(@delayTimeSpan, @delayType, @delayTiming, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FromException_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Exception @ex = (System.Exception)typeof(System.Exception).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.FromException(@ex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FromCanceled_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.FromCanceled(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Create_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTask> @factory = (System.Func<Cysharp.Threading.Tasks.UniTask>)typeof(System.Func<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Create(@factory);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Lazy_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTask> @factory = (System.Func<Cysharp.Threading.Tasks.UniTask>)typeof(System.Func<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Lazy(@factory);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Void_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTaskVoid> @asyncAction = (System.Func<Cysharp.Threading.Tasks.UniTaskVoid>)typeof(System.Func<Cysharp.Threading.Tasks.UniTaskVoid>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Cysharp.Threading.Tasks.UniTask.Void(@asyncAction);

            return __ret;
        }

        static StackObject* Void_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid> @asyncAction = (System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>)typeof(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Cysharp.Threading.Tasks.UniTask.Void(@asyncAction, @cancellationToken);

            return __ret;
        }

        static StackObject* Action_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTaskVoid> @asyncAction = (System.Func<Cysharp.Threading.Tasks.UniTaskVoid>)typeof(System.Func<Cysharp.Threading.Tasks.UniTaskVoid>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Action(@asyncAction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Action_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid> @asyncAction = (System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>)typeof(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Action(@asyncAction, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UnityAction_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTaskVoid> @asyncAction = (System.Func<Cysharp.Threading.Tasks.UniTaskVoid>)typeof(System.Func<Cysharp.Threading.Tasks.UniTaskVoid>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.UnityAction(@asyncAction);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UnityAction_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid> @asyncAction = (System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>)typeof(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTaskVoid>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.UnityAction(@asyncAction, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Defer_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Cysharp.Threading.Tasks.UniTask> @factory = (System.Func<Cysharp.Threading.Tasks.UniTask>)typeof(System.Func<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Defer(@factory);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Never_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.Never(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RunOnThreadPool_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @configureAwait = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Action @action = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.RunOnThreadPool(@action, @configureAwait, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RunOnThreadPool_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @configureAwait = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Object @state = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Action<System.Object> @action = (System.Action<System.Object>)typeof(System.Action<System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.RunOnThreadPool(@action, @state, @configureAwait, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RunOnThreadPool_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @configureAwait = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Func<Cysharp.Threading.Tasks.UniTask> @action = (System.Func<Cysharp.Threading.Tasks.UniTask>)typeof(System.Func<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.RunOnThreadPool(@action, @configureAwait, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RunOnThreadPool_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @configureAwait = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Object @state = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Func<System.Object, Cysharp.Threading.Tasks.UniTask> @action = (System.Func<System.Object, Cysharp.Threading.Tasks.UniTask>)typeof(System.Func<System.Object, Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.RunOnThreadPool(@action, @state, @configureAwait, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SwitchToMainThread_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.SwitchToMainThread(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SwitchToMainThread_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.SwitchToMainThread(@timing, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReturnToMainThread_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.ReturnToMainThread(@cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReturnToMainThread_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.ReturnToMainThread(@timing, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Post_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @action = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Cysharp.Threading.Tasks.UniTask.Post(@action, @timing);

            return __ret;
        }

        static StackObject* SwitchToThreadPool_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.SwitchToThreadPool();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SwitchToTaskPool_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.SwitchToTaskPool();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SwitchToSynchronizationContext_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Threading.SynchronizationContext @synchronizationContext = (System.Threading.SynchronizationContext)typeof(System.Threading.SynchronizationContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.SwitchToSynchronizationContext(@synchronizationContext, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReturnToSynchronizationContext_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Threading.SynchronizationContext @synchronizationContext = (System.Threading.SynchronizationContext)typeof(System.Threading.SynchronizationContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.ReturnToSynchronizationContext(@synchronizationContext, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReturnToCurrentSynchronizationContext_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @dontPostWhenSameContext = ptr_of_this_method->Value == 1;


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.ReturnToCurrentSynchronizationContext(@dontPostWhenSameContext, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitUntil_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Func<System.Boolean> @predicate = (System.Func<System.Boolean>)typeof(System.Func<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WaitUntil(@predicate, @timing, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitWhile_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Func<System.Boolean> @predicate = (System.Func<System.Boolean>)typeof(System.Func<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WaitWhile(@predicate, @timing, @cancellationToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitUntilCanceled_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cysharp.Threading.Tasks.PlayerLoopTiming @timing = (Cysharp.Threading.Tasks.PlayerLoopTiming)typeof(Cysharp.Threading.Tasks.PlayerLoopTiming).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Threading.CancellationToken @cancellationToken = (System.Threading.CancellationToken)typeof(System.Threading.CancellationToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WaitUntilCanceled(@cancellationToken, @timing);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WhenAll_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cysharp.Threading.Tasks.UniTask[] @tasks = (Cysharp.Threading.Tasks.UniTask[])typeof(Cysharp.Threading.Tasks.UniTask[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WhenAll(@tasks);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WhenAll_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> @tasks = (System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask>)typeof(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WhenAll(@tasks);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WhenAny_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Cysharp.Threading.Tasks.UniTask[] @tasks = (Cysharp.Threading.Tasks.UniTask[])typeof(Cysharp.Threading.Tasks.UniTask[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WhenAny(@tasks);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WhenAny_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> @tasks = (System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask>)typeof(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.WhenAny(@tasks);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_CompletedTask_0(ref object o)
        {
            return Cysharp.Threading.Tasks.UniTask.CompletedTask;
        }

        static StackObject* CopyToStack_CompletedTask_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Cysharp.Threading.Tasks.UniTask.CompletedTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Cysharp.Threading.Tasks.UniTask();
            ins = (Cysharp.Threading.Tasks.UniTask)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int16 @token = (short)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Cysharp.Threading.Tasks.IUniTaskSource @source = (Cysharp.Threading.Tasks.IUniTaskSource)typeof(Cysharp.Threading.Tasks.IUniTaskSource).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new Cysharp.Threading.Tasks.UniTask(@source, @token);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}