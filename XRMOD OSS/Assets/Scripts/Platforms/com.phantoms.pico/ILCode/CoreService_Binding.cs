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

namespace ILRuntime.Runtime.Generated
{
    unsafe class CoreService_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Pico.Platform.CoreService);
            args = new Type[]{};
            method = type.GetMethod("IsInitialized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsInitialized_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("AsyncInitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AsyncInitialize_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GameInitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GameInitialize_3);
            args = new Type[]{};
            method = type.GetMethod("GameInitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GameInitialize_4);
            args = new Type[]{};
            method = type.GetMethod("GameUninitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GameUninitialize_5);

            field = type.GetField("Initialized", flag);
            app.RegisterCLRFieldGetter(field, get_Initialized_0);
            app.RegisterCLRFieldSetter(field, set_Initialized_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Initialized_0, AssignFromStack_Initialized_0);
            field = type.GetField("UninitializedError", flag);
            app.RegisterCLRFieldGetter(field, get_UninitializedError_1);
            app.RegisterCLRFieldSetter(field, set_UninitializedError_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_UninitializedError_1, AssignFromStack_UninitializedError_1);
            field = type.GetField("UserIdEmptyError", flag);
            app.RegisterCLRFieldGetter(field, get_UserIdEmptyError_2);
            app.RegisterCLRFieldSetter(field, set_UserIdEmptyError_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_UserIdEmptyError_2, AssignFromStack_UserIdEmptyError_2);




        }


        static StackObject* IsInitialized_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Pico.Platform.CoreService.IsInitialized();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* AsyncInitialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @appId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Pico.Platform.CoreService.AsyncInitialize(@appId);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @appId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Pico.Platform.CoreService.Initialize(@appId);

            return __ret;
        }

        static StackObject* GameInitialize_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @accessToken = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Pico.Platform.CoreService.GameInitialize(@accessToken);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GameInitialize_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Pico.Platform.CoreService.GameInitialize();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GameUninitialize_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Pico.Platform.CoreService.GameUninitialize();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_Initialized_0(ref object o)
        {
            return Pico.Platform.CoreService.Initialized;
        }

        static StackObject* CopyToStack_Initialized_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Pico.Platform.CoreService.Initialized;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Initialized_0(ref object o, object v)
        {
            Pico.Platform.CoreService.Initialized = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Initialized_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Initialized = ptr_of_this_method->Value == 1;
            Pico.Platform.CoreService.Initialized = @Initialized;
            return ptr_of_this_method;
        }

        static object get_UninitializedError_1(ref object o)
        {
            return Pico.Platform.CoreService.UninitializedError;
        }

        static StackObject* CopyToStack_UninitializedError_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Pico.Platform.CoreService.UninitializedError;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UninitializedError_1(ref object o, object v)
        {
            Pico.Platform.CoreService.UninitializedError = (System.String)v;
        }

        static StackObject* AssignFromStack_UninitializedError_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @UninitializedError = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Pico.Platform.CoreService.UninitializedError = @UninitializedError;
            return ptr_of_this_method;
        }

        static object get_UserIdEmptyError_2(ref object o)
        {
            return Pico.Platform.CoreService.UserIdEmptyError;
        }

        static StackObject* CopyToStack_UserIdEmptyError_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Pico.Platform.CoreService.UserIdEmptyError;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UserIdEmptyError_2(ref object o, object v)
        {
            Pico.Platform.CoreService.UserIdEmptyError = (System.String)v;
        }

        static StackObject* AssignFromStack_UserIdEmptyError_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @UserIdEmptyError = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Pico.Platform.CoreService.UserIdEmptyError = @UserIdEmptyError;
            return ptr_of_this_method;
        }




    }
}
