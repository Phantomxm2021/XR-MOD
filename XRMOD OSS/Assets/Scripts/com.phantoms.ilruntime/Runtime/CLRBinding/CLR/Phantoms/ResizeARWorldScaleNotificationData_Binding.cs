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
    unsafe class ResizeARWorldScaleNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData);

            field = type.GetField("WorldScale", flag);
            app.RegisterCLRFieldGetter(field, get_WorldScale_0);
            app.RegisterCLRFieldSetter(field, set_WorldScale_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_WorldScale_0, AssignFromStack_WorldScale_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_WorldScale_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData)o).WorldScale;
        }

        static StackObject* CopyToStack_WorldScale_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData)o).WorldScale;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_WorldScale_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData)o).WorldScale = (System.Single)v;
        }

        static StackObject* AssignFromStack_WorldScale_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @WorldScale = *(float*)&ptr_of_this_method->Value;
            ((com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData)o).WorldScale = @WorldScale;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.ResizeARWorldScaleNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
