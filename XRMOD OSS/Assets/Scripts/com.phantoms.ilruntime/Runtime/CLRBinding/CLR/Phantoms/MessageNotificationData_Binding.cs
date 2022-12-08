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
    unsafe class MessageNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.MessageNotificationData);

            field = type.GetField("Message", flag);
            app.RegisterCLRFieldGetter(field, get_Message_0);
            app.RegisterCLRFieldSetter(field, set_Message_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Message_0, AssignFromStack_Message_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.MessageNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.MessageNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Message_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.MessageNotificationData)o).Message;
        }

        static StackObject* CopyToStack_Message_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.MessageNotificationData)o).Message;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Message_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.MessageNotificationData)o).Message = (System.String)v;
        }

        static StackObject* AssignFromStack_Message_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.Phantoms.ActionNotification.Runtime.MessageNotificationData)o).Message = @Message;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.MessageNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
