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
    unsafe class ARRaycastNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData);

            field = type.GetField("EstimatedDistance", flag);
            app.RegisterCLRFieldGetter(field, get_EstimatedDistance_0);
            app.RegisterCLRFieldSetter(field, set_EstimatedDistance_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_EstimatedDistance_0, AssignFromStack_EstimatedDistance_0);
            field = type.GetField("ScreenPoint", flag);
            app.RegisterCLRFieldGetter(field, get_ScreenPoint_1);
            app.RegisterCLRFieldSetter(field, set_ScreenPoint_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ScreenPoint_1, AssignFromStack_ScreenPoint_1);
            // field = type.GetField("OperateType", flag);
            // app.RegisterCLRFieldGetter(field, get_OperateType_2);
            // app.RegisterCLRFieldSetter(field, set_OperateType_2);
            // app.RegisterCLRFieldBinding(field, CopyToStack_OperateType_2, AssignFromStack_OperateType_2);
            field = type.GetField("TrackableType", flag);
            app.RegisterCLRFieldGetter(field, get_TrackableType_3);
            app.RegisterCLRFieldSetter(field, set_TrackableType_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_TrackableType_3, AssignFromStack_TrackableType_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_EstimatedDistance_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).EstimatedDistance;
        }

        static StackObject* CopyToStack_EstimatedDistance_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).EstimatedDistance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_EstimatedDistance_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).EstimatedDistance = (System.Single)v;
        }

        static StackObject* AssignFromStack_EstimatedDistance_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @EstimatedDistance = *(float*)&ptr_of_this_method->Value;
            ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).EstimatedDistance = @EstimatedDistance;
            return ptr_of_this_method;
        }

        static object get_ScreenPoint_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).ScreenPoint;
        }

        static StackObject* CopyToStack_ScreenPoint_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).ScreenPoint;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ScreenPoint_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).ScreenPoint = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_ScreenPoint_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @ScreenPoint = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).ScreenPoint = @ScreenPoint;
            return ptr_of_this_method;
        }

        // static object get_OperateType_2(ref object o)
        // {
        //     return ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).OperateType;
        // }

        // static StackObject* CopyToStack_OperateType_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        // {
        //     var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).OperateType;
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static void set_OperateType_2(ref object o, object v)
        // {
        //     ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).OperateType = (com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData.OperateTypeEnum)v;
        // }
        //
        // static StackObject* AssignFromStack_OperateType_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData.OperateTypeEnum @OperateType = (com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData.OperateTypeEnum)typeof(com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData.OperateTypeEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).OperateType = @OperateType;
        //     return ptr_of_this_method;
        // }

        static object get_TrackableType_3(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).TrackableType;
        }

        static StackObject* CopyToStack_TrackableType_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).TrackableType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TrackableType_3(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).TrackableType = (com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum)v;
        }

        static StackObject* AssignFromStack_TrackableType_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum @TrackableType = (com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum)typeof(com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData)o).TrackableType = @TrackableType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.ARRaycastNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
