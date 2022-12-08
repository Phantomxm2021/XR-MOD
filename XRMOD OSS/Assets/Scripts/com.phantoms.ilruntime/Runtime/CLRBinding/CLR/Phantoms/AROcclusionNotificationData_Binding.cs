using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class AROcclusionNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData);

            field = type.GetField("OcclusionDataType", flag);
            app.RegisterCLRFieldGetter(field, get_OcclusionDataType_0);
            app.RegisterCLRFieldSetter(field, set_OcclusionDataType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OcclusionDataType_0, AssignFromStack_OcclusionDataType_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_OcclusionDataType_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData)o).OcclusionDataType;
        }

        static StackObject* CopyToStack_OcclusionDataType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData)o).OcclusionDataType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OcclusionDataType_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData)o).OcclusionDataType = (com.Phantoms.ActionNotification.Runtime.OcclusionDataType)v;
        }

        static StackObject* AssignFromStack_OcclusionDataType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.OcclusionDataType @OcclusionDataType = (com.Phantoms.ActionNotification.Runtime.OcclusionDataType)typeof(com.Phantoms.ActionNotification.Runtime.OcclusionDataType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData)o).OcclusionDataType = @OcclusionDataType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
