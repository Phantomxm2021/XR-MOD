using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
public unsafe class Vector3Binder_Binding
{
    public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
    {
        BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                            BindingFlags.DeclaredOnly;
        MethodBase method;
        Type[] args;
        Type type = typeof(global::Vector3Binder);
        args = new Type[] {typeof(ILRuntime.Runtime.Enviorment.AppDomain)};
        method = type.GetMethod("RegisterCLRRedirection", flag, null, args, null);
        app.RegisterCLRMethodRedirection(method, RegisterCLRRedirection_0);


        app.RegisterCLRCreateDefaultInstance(type, () => new global::Vector3Binder());
        app.RegisterCLRCreateArrayInstance(type, s => new global::Vector3Binder[s]);

        args = new Type[] { };
        method = type.GetConstructor(flag, null, args, null);
        app.RegisterCLRMethodRedirection(method, Ctor_0);
    }


    static StackObject* RegisterCLRRedirection_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
        CLRMethod __method, bool isNewObj)
    {
        ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        StackObject* ptr_of_this_method;
        StackObject* __ret = ILIntepreter.Minus(__esp, 2);

        ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        ILRuntime.Runtime.Enviorment.AppDomain @appdomain =
            (ILRuntime.Runtime.Enviorment.AppDomain) typeof(ILRuntime.Runtime.Enviorment.AppDomain).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        __intp.Free(ptr_of_this_method);

        ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        global::Vector3Binder instance_of_this_method =
            (global::Vector3Binder) typeof(global::Vector3Binder).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        __intp.Free(ptr_of_this_method);

        instance_of_this_method.RegisterCLRRedirection(@appdomain);

        return __ret;
    }


    static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
        bool isNewObj)
    {
        ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        StackObject* __ret = ILIntepreter.Minus(__esp, 0);

        var result_of_this_method = new global::Vector3Binder();

        return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
    }
}