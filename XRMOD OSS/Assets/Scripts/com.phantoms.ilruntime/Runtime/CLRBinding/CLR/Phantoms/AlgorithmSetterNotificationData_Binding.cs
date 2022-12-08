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
    unsafe class AlgorithmSetterNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData);

            field = type.GetField("AlgorithmState", flag);
            app.RegisterCLRFieldGetter(field, get_AlgorithmState_0);
            app.RegisterCLRFieldSetter(field, set_AlgorithmState_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlgorithmState_0, AssignFromStack_AlgorithmState_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_AlgorithmState_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData)o).AlgorithmState;
        }

        static StackObject* CopyToStack_AlgorithmState_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData)o).AlgorithmState;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AlgorithmState_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData)o).AlgorithmState = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AlgorithmState_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AlgorithmState = ptr_of_this_method->Value == 1;
            ((com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData)o).AlgorithmState = @AlgorithmState;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.AlgorithmSetterNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
