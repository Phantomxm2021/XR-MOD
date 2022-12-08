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
    unsafe class AnchorNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.AnchorNotificationData);

            field = type.GetField("StickType", flag);
            app.RegisterCLRFieldGetter(field, get_StickType_0);
            app.RegisterCLRFieldSetter(field, set_StickType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_StickType_0, AssignFromStack_StickType_0);
            field = type.GetField("TrackableType", flag);
            app.RegisterCLRFieldGetter(field, get_TrackableType_1);
            app.RegisterCLRFieldSetter(field, set_TrackableType_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_TrackableType_1, AssignFromStack_TrackableType_1);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_2);
            app.RegisterCLRFieldSetter(field, set_Position_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_2, AssignFromStack_Position_2);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_3);
            app.RegisterCLRFieldSetter(field, set_Rotation_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_3, AssignFromStack_Rotation_3);
            field = type.GetField("Offset", flag);
            app.RegisterCLRFieldGetter(field, get_Offset_4);
            app.RegisterCLRFieldSetter(field, set_Offset_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Offset_4, AssignFromStack_Offset_4);
            field = type.GetField("AnchorPrefab", flag);
            app.RegisterCLRFieldGetter(field, get_ControllerTargetNode_5);
            app.RegisterCLRFieldSetter(field, set_ControllerTargetNode_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ControllerTargetNode_5, AssignFromStack_ControllerTargetNode_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.AnchorNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.AnchorNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_StickType_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).StickType;
        }

        static StackObject* CopyToStack_StickType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).StickType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StickType_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).StickType = (com.Phantoms.ActionNotification.Runtime.AnchorNotificationData.StickTypeEnum)v;
        }

        static StackObject* AssignFromStack_StickType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.AnchorNotificationData.StickTypeEnum @StickType = (com.Phantoms.ActionNotification.Runtime.AnchorNotificationData.StickTypeEnum)typeof(com.Phantoms.ActionNotification.Runtime.AnchorNotificationData.StickTypeEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).StickType = @StickType;
            return ptr_of_this_method;
        }

        static object get_TrackableType_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).TrackableType;
        }

        static StackObject* CopyToStack_TrackableType_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).TrackableType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TrackableType_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).TrackableType = (com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum)v;
        }

        static StackObject* AssignFromStack_TrackableType_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum @TrackableType = (com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum)typeof(com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).TrackableType = @TrackableType;
            return ptr_of_this_method;
        }

        static object get_Position_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Position;
        }

        static StackObject* CopyToStack_Position_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Position = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Position_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Position = @Position;
            return ptr_of_this_method;
        }

        static object get_Rotation_3(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Rotation_3(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Rotation = (UnityEngine.Quaternion)v;
        }

        static StackObject* AssignFromStack_Rotation_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @Rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Rotation = @Rotation;
            return ptr_of_this_method;
        }

        static object get_Offset_4(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Offset;
        }

        static StackObject* CopyToStack_Offset_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Offset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Offset_4(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Offset = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Offset_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Offset = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).Offset = @Offset;
            return ptr_of_this_method;
        }

        static object get_ControllerTargetNode_5(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).AnchorPrefab;
        }

        static StackObject* CopyToStack_ControllerTargetNode_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).AnchorPrefab;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ControllerTargetNode_5(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).AnchorPrefab = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_ControllerTargetNode_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @ControllerTargetNode = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)o).AnchorPrefab = @ControllerTargetNode;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.AnchorNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
