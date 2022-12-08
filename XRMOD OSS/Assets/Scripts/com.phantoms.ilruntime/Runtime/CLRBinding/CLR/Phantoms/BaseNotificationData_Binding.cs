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
    unsafe class BaseNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_0);

            field = type.GetField("NotificationAct", flag);
            app.RegisterCLRFieldGetter(field, get_NotificationAct_0);
            app.RegisterCLRFieldSetter(field, set_NotificationAct_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotificationAct_0, AssignFromStack_NotificationAct_0);
            field = type.GetField("NotificationActWithData", flag);
            app.RegisterCLRFieldGetter(field, get_NotificationActWithData_1);
            app.RegisterCLRFieldSetter(field, set_NotificationActWithData_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotificationActWithData_1, AssignFromStack_NotificationActWithData_1);
            field = type.GetField("ActionName", flag);
            app.RegisterCLRFieldGetter(field, get_ActionName_2);
            app.RegisterCLRFieldSetter(field, set_ActionName_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionName_2, AssignFromStack_ActionName_2);
            // field = type.GetField("WorldScale", flag);
            // app.RegisterCLRFieldGetter(field, get_WorldScale_3);
            // app.RegisterCLRFieldSetter(field, set_WorldScale_3);
            // app.RegisterCLRFieldBinding(field, CopyToStack_WorldScale_3, AssignFromStack_WorldScale_3);
            field = type.GetField("BaseData", flag);
            app.RegisterCLRFieldGetter(field, get_BaseData_4);
            app.RegisterCLRFieldSetter(field, set_BaseData_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_BaseData_4, AssignFromStack_BaseData_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.BaseNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.BaseNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Dispose_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.BaseNotificationData instance_of_this_method = (com.Phantoms.ActionNotification.Runtime.BaseNotificationData)typeof(com.Phantoms.ActionNotification.Runtime.BaseNotificationData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }


        static object get_NotificationAct_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationAct;
        }

        static StackObject* CopyToStack_NotificationAct_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationAct;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NotificationAct_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationAct = (System.Action)v;
        }

        static StackObject* AssignFromStack_NotificationAct_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @NotificationAct = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationAct = @NotificationAct;
            return ptr_of_this_method;
        }

        static object get_NotificationActWithData_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationActWithData;
        }

        static StackObject* CopyToStack_NotificationActWithData_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationActWithData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NotificationActWithData_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationActWithData = (System.Action<System.Object>)v;
        }

        static StackObject* AssignFromStack_NotificationActWithData_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Object> @NotificationActWithData = (System.Action<System.Object>)typeof(System.Action<System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).NotificationActWithData = @NotificationActWithData;
            return ptr_of_this_method;
        }

        static object get_ActionName_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).ActionName;
        }

        static StackObject* CopyToStack_ActionName_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).ActionName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ActionName_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).ActionName = (System.String)v;
        }

        static StackObject* AssignFromStack_ActionName_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ActionName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).ActionName = @ActionName;
            return ptr_of_this_method;
        }

        // static object get_WorldScale_3(ref object o)
        // {
        //     return ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).WorldScale;
        // }
        //
        // static StackObject* CopyToStack_WorldScale_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        // {
        //     var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).WorldScale;
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static void set_WorldScale_3(ref object o, object v)
        // {
        //     ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).WorldScale = (System.Single)v;
        // }
        //
        // static StackObject* AssignFromStack_WorldScale_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     System.Single @WorldScale = *(float*)&ptr_of_this_method->Value;
        //     ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).WorldScale = @WorldScale;
        //     return ptr_of_this_method;
        // }

        static object get_BaseData_4(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).BaseData;
        }

        static StackObject* CopyToStack_BaseData_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).BaseData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BaseData_4(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).BaseData = (System.String)v;
        }

        static StackObject* AssignFromStack_BaseData_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BaseData = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.Phantoms.ActionNotification.Runtime.BaseNotificationData)o).BaseData = @BaseData;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.BaseNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
