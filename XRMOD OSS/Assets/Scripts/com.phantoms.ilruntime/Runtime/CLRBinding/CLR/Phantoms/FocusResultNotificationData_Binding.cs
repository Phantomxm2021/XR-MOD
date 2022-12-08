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
    unsafe class FocusResultNotificationData_Binding
    {
         public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData);

            field = type.GetField("size", flag);
            app.RegisterCLRFieldGetter(field, get_size_0);
            app.RegisterCLRFieldSetter(field, set_size_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_size_0, AssignFromStack_size_0);
            field = type.GetField("FocusPos", flag);
            app.RegisterCLRFieldGetter(field, get_FocusPos_1);
            app.RegisterCLRFieldSetter(field, set_FocusPos_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FocusPos_1, AssignFromStack_FocusPos_1);
            field = type.GetField("FocusRot", flag);
            app.RegisterCLRFieldGetter(field, get_FocusRot_2);
            app.RegisterCLRFieldSetter(field, set_FocusRot_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_FocusRot_2, AssignFromStack_FocusRot_2);
            field = type.GetField("FocusState", flag);
            app.RegisterCLRFieldGetter(field, get_FocusState_3);
            app.RegisterCLRFieldSetter(field, set_FocusState_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_FocusState_3, AssignFromStack_FocusState_3);
            field = type.GetField("PlaneAlignment", flag);
            app.RegisterCLRFieldGetter(field, get_PlaneAlignment_4);
            app.RegisterCLRFieldSetter(field, set_PlaneAlignment_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlaneAlignment_4, AssignFromStack_PlaneAlignment_4);
            field = type.GetField("PlaneClassification", flag);
            app.RegisterCLRFieldGetter(field, get_PlaneClassification_5);
            app.RegisterCLRFieldSetter(field, set_PlaneClassification_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlaneClassification_5, AssignFromStack_PlaneClassification_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_size_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).size;
        }

        static StackObject* CopyToStack_size_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).size;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_size_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).size = (UnityEngine.Vector2)v;
        }

        static StackObject* AssignFromStack_size_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector2 @size = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).size = @size;
            return ptr_of_this_method;
        }

        static object get_FocusPos_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusPos;
        }

        static StackObject* CopyToStack_FocusPos_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusPos;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FocusPos_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusPos = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_FocusPos_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @FocusPos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusPos = @FocusPos;
            return ptr_of_this_method;
        }

        static object get_FocusRot_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusRot;
        }

        static StackObject* CopyToStack_FocusRot_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusRot;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FocusRot_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusRot = (UnityEngine.Quaternion)v;
        }

        static StackObject* AssignFromStack_FocusRot_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @FocusRot = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusRot = @FocusRot;
            return ptr_of_this_method;
        }

        static object get_FocusState_3(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusState;
        }

        static StackObject* CopyToStack_FocusState_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FocusState_3(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusState = (com.Phantoms.ActionNotification.Runtime.FindingType)v;
        }

        static StackObject* AssignFromStack_FocusState_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.FindingType @FocusState = (com.Phantoms.ActionNotification.Runtime.FindingType)typeof(com.Phantoms.ActionNotification.Runtime.FindingType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).FocusState = @FocusState;
            return ptr_of_this_method;
        }

        static object get_PlaneAlignment_4(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneAlignment;
        }

        static StackObject* CopyToStack_PlaneAlignment_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneAlignment;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlaneAlignment_4(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneAlignment = (com.Phantoms.ActionNotification.Runtime.PlaneAlignment)v;
        }

        static StackObject* AssignFromStack_PlaneAlignment_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.PlaneAlignment @PlaneAlignment = (com.Phantoms.ActionNotification.Runtime.PlaneAlignment)typeof(com.Phantoms.ActionNotification.Runtime.PlaneAlignment).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneAlignment = @PlaneAlignment;
            return ptr_of_this_method;
        }

        static object get_PlaneClassification_5(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneClassification;
        }

        static StackObject* CopyToStack_PlaneClassification_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneClassification;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlaneClassification_5(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneClassification = (com.Phantoms.ActionNotification.Runtime.PlaneClassification)v;
        }

        static StackObject* AssignFromStack_PlaneClassification_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.PlaneClassification @PlaneClassification = (com.Phantoms.ActionNotification.Runtime.PlaneClassification)typeof(com.Phantoms.ActionNotification.Runtime.PlaneClassification).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData)o).PlaneClassification = @PlaneClassification;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.FocusResultNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
