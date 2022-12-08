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
    unsafe class ActionNotificationCenter_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter);
            args = new Type[]{};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_0);
            args = new Type[]{};
            method = type.GetMethod("get_DefaultCenter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DefaultCenter_1);
            args = new Type[]{typeof(System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData>), typeof(System.String)};
            method = type.GetMethod("AddObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddObserver_2);
            args = new Type[]{typeof(System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object>), typeof(System.String)};
            method = type.GetMethod("AddObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddObserver_3);
            args = new Type[]{typeof(System.String), typeof(System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData>)};
            method = type.GetMethod("RemoveObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveObserver_4);
            args = new Type[]{typeof(System.String), typeof(System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object>)};
            method = type.GetMethod("RemoveObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveObserver_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("RemoveObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveObserver_6);
            args = new Type[]{typeof(System.String), typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData)};
            method = type.GetMethod("PostNotification", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PostNotification_7);
            args = new Type[]{typeof(System.String), typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData)};
            method = type.GetMethod("PostNotificationWithResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PostNotificationWithResult_8);



            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter[s]);


        }


        static StackObject* Release_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Release();

            return __ret;
        }

        static StackObject* get_DefaultCenter_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter.DefaultCenter;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddObserver_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData> @_action = (System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData>)typeof(System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddObserver(@_action, @_name);

            return __ret;
        }

        static StackObject* AddObserver_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object> @_action = (System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object>)typeof(System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddObserver(@_action, @_name);

            return __ret;
        }

        static StackObject* RemoveObserver_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData> @_action = (System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData>)typeof(System.Action<com.Phantoms.ActionNotification.Runtime.BaseNotificationData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveObserver(@_name, @_action);

            return __ret;
        }

        static StackObject* RemoveObserver_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object> @_action = (System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object>)typeof(System.Func<com.Phantoms.ActionNotification.Runtime.BaseNotificationData, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveObserver(@_name, @_action);

            return __ret;
        }

        static StackObject* RemoveObserver_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveObserver(@_name);

            return __ret;
        }

        static StackObject* PostNotification_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.BaseNotificationData @_object = (com.Phantoms.ActionNotification.Runtime.BaseNotificationData)typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PostNotification(@_name, @_object);

            return __ret;
        }

        static StackObject* PostNotificationWithResult_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.BaseNotificationData @_object = (com.Phantoms.ActionNotification.Runtime.BaseNotificationData)typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter)typeof(com.Phantoms.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PostNotificationWithResult(@_name, @_object);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
