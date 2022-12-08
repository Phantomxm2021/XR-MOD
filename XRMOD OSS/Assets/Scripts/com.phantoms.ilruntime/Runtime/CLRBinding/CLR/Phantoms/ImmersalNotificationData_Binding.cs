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
    unsafe class ImmersalNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData);

            field = type.GetField("MapId", flag);
            app.RegisterCLRFieldGetter(field, get_MapId_0);
            app.RegisterCLRFieldSetter(field, set_MapId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MapId_0, AssignFromStack_MapId_0);
            field = type.GetField("LocalizerPose", flag);
            app.RegisterCLRFieldGetter(field, get_LocalizerPose_1);
            app.RegisterCLRFieldSetter(field, set_LocalizerPose_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalizerPose_1, AssignFromStack_LocalizerPose_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_MapId_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).MapId;
        }

        static StackObject* CopyToStack_MapId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).MapId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MapId_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).MapId = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MapId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MapId = ptr_of_this_method->Value;
            ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).MapId = @MapId;
            return ptr_of_this_method;
        }

        static object get_LocalizerPose_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).LocalizerPose;
        }

        static StackObject* CopyToStack_LocalizerPose_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).LocalizerPose;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalizerPose_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).LocalizerPose = (com.Phantoms.ActionNotification.Runtime.LocalizerPose)v;
        }

        static StackObject* AssignFromStack_LocalizerPose_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.LocalizerPose @LocalizerPose = (com.Phantoms.ActionNotification.Runtime.LocalizerPose)typeof(com.Phantoms.ActionNotification.Runtime.LocalizerPose).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData)o).LocalizerPose = @LocalizerPose;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.ImmersalNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
