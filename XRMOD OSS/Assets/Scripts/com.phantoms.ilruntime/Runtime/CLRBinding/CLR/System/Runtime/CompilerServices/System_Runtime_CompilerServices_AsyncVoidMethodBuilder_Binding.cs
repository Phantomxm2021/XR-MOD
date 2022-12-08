using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.CLR.Utils;
using ILRuntime.CLRBinding.Adapter;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding
    {
        private static ILRuntime.Runtime.Enviorment.AppDomain appDomain;

        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            appDomain = app;
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder);
            args = new Type[] { };
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;
            foreach (var m in type.GetMethods())
            {
                if (m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }

                    lst.Add(m);
                }
            }

            args = new Type[]
            {
                typeof(AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("Start", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Start_1);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>),
                typeof(AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>).MakeByRefType(),
                            typeof(AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_2);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(System.Exception)};
            method = type.GetMethod("SetException", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetException_3);
            args = new Type[] { };
            method = type.GetMethod("SetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResult_4);
            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip>),
                typeof(AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip>).MakeByRefType(),
                            typeof(AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_5);

                        break;
                    }
                }
            }

            //Fix ExecutionEngineException:Attempting to call method
            //'AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>'
            //for which no ahead of time(AOT) code was generated.
            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter),
                typeof(AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter).MakeByRefType(),
                            typeof(AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_6);

                        break;
                    }
                }
            }

            app.RegisterCLRCreateDefaultInstance(type,
                () => new System.Runtime.CompilerServices.AsyncVoidMethodBuilder());
        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method,
            AutoList __mStack, ref System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                {
                    __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
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
                    if (t is ILType)
                    {
                        ((ILType) t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        ((CLRType) t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.AsyncVoidMethodBuilder[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }

        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Start_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                @stateMachine =
                    (AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
                    typeof(AsyncStateMachineClassInheritanceAdaptor.
                        AsyncStateMachineAdaptor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method
                .Start<AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                >(ref @stateMachine);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @stateMachine;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stateMachine;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                @stateMachine =
                    (AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
                    typeof(AsyncStateMachineClassInheritanceAdaptor.
                        AsyncStateMachineAdaptor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>,
                    AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @stateMachine;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stateMachine;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @awaiter;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @awaiter;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetException_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Exception @exception =
                (System.Exception) typeof(System.Exception).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetException(@exception);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetResult_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetResult();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                @stateMachine =
                    (AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
                    typeof(AsyncStateMachineClassInheritanceAdaptor.
                        AsyncStateMachineAdaptor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip>,
                    AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @stateMachine;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stateMachine;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @awaiter;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip>[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @awaiter;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                @stateMachine =
                    (AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
                    typeof(AsyncStateMachineClassInheritanceAdaptor.
                        AsyncStateMachineAdaptor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Runtime.CompilerServices.TaskAwaiter @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter)
                typeof(System.Runtime.CompilerServices.TaskAwaiter).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,
                    AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @stateMachine;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stateMachine;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @awaiter;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @awaiter;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }
    }
}