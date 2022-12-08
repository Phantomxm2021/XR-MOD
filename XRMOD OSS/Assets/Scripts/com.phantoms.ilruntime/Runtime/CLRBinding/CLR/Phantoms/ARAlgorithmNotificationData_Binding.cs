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
    unsafe class ARAlgorithmNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData);

            field = type.GetField("ARAlgorithmType", flag);
            app.RegisterCLRFieldGetter(field, get_ARAlgorithmType_0);
            app.RegisterCLRFieldSetter(field, set_ARAlgorithmType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ARAlgorithmType_0, AssignFromStack_ARAlgorithmType_0);
            field = type.GetField("ARAlgorithmOperator", flag);
            app.RegisterCLRFieldGetter(field, get_ARAlgorithmOperator_1);
            app.RegisterCLRFieldSetter(field, set_ARAlgorithmOperator_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ARAlgorithmOperator_1, AssignFromStack_ARAlgorithmOperator_1);
            field = type.GetField("Mixed", flag);
            app.RegisterCLRFieldGetter(field, get_Mixed_2);
            app.RegisterCLRFieldSetter(field, set_Mixed_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mixed_2, AssignFromStack_Mixed_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_ARAlgorithmType_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmType;
        }

        static StackObject* CopyToStack_ARAlgorithmType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ARAlgorithmType_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmType = (com.Phantoms.ActionNotification.Runtime.ARAlgorithmType)v;
        }

        static StackObject* AssignFromStack_ARAlgorithmType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.ARAlgorithmType @ARAlgorithmType = (com.Phantoms.ActionNotification.Runtime.ARAlgorithmType)typeof(com.Phantoms.ActionNotification.Runtime.ARAlgorithmType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmType = @ARAlgorithmType;
            return ptr_of_this_method;
        }

        static object get_ARAlgorithmOperator_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmOperator;
        }

        static StackObject* CopyToStack_ARAlgorithmOperator_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmOperator;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ARAlgorithmOperator_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmOperator = (com.Phantoms.ActionNotification.Runtime.ARAlgorithmOperator)v;
        }

        static StackObject* AssignFromStack_ARAlgorithmOperator_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.ARAlgorithmOperator @ARAlgorithmOperator = (com.Phantoms.ActionNotification.Runtime.ARAlgorithmOperator)typeof(com.Phantoms.ActionNotification.Runtime.ARAlgorithmOperator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).ARAlgorithmOperator = @ARAlgorithmOperator;
            return ptr_of_this_method;
        }

        static object get_Mixed_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).Mixed;
        }

        static StackObject* CopyToStack_Mixed_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).Mixed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Mixed_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).Mixed = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Mixed_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Mixed = ptr_of_this_method->Value == 1;
            ((com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)o).Mixed = @Mixed;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
