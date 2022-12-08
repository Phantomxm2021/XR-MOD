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
    unsafe class TransformNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.TransformNotificationData);

            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_0);
            app.RegisterCLRFieldSetter(field, set_Position_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_0, AssignFromStack_Position_0);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_1);
            app.RegisterCLRFieldSetter(field, set_Rotation_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_1, AssignFromStack_Rotation_1);
            field = type.GetField("Scale", flag);
            app.RegisterCLRFieldGetter(field, get_Scale_2);
            app.RegisterCLRFieldSetter(field, set_Scale_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Scale_2, AssignFromStack_Scale_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.TransformNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.TransformNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Position_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Position;
        }

        static StackObject* CopyToStack_Position_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Position = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Position_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Position = @Position;
            return ptr_of_this_method;
        }

        static object get_Rotation_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Rotation_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Rotation = (UnityEngine.Quaternion)v;
        }

        static StackObject* AssignFromStack_Rotation_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @Rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Rotation = @Rotation;
            return ptr_of_this_method;
        }

        static object get_Scale_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Scale;
        }

        static StackObject* CopyToStack_Scale_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Scale;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Scale_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Scale = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Scale_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Scale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.TransformNotificationData)o).Scale = @Scale;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.TransformNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
