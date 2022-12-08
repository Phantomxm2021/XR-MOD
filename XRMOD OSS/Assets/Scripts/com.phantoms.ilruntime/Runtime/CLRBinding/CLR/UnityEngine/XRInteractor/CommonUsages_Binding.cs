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
    unsafe class CommonUsages_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.CommonUsages);

            field = type.GetField("isTracked", flag);
            app.RegisterCLRFieldGetter(field, get_isTracked_0);
            app.RegisterCLRFieldSetter(field, set_isTracked_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_isTracked_0, AssignFromStack_isTracked_0);
            field = type.GetField("primaryButton", flag);
            app.RegisterCLRFieldGetter(field, get_primaryButton_1);
            app.RegisterCLRFieldSetter(field, set_primaryButton_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_primaryButton_1, AssignFromStack_primaryButton_1);
            field = type.GetField("primaryTouch", flag);
            app.RegisterCLRFieldGetter(field, get_primaryTouch_2);
            app.RegisterCLRFieldSetter(field, set_primaryTouch_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_primaryTouch_2, AssignFromStack_primaryTouch_2);
            field = type.GetField("secondaryButton", flag);
            app.RegisterCLRFieldGetter(field, get_secondaryButton_3);
            app.RegisterCLRFieldSetter(field, set_secondaryButton_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_secondaryButton_3, AssignFromStack_secondaryButton_3);
            field = type.GetField("secondaryTouch", flag);
            app.RegisterCLRFieldGetter(field, get_secondaryTouch_4);
            app.RegisterCLRFieldSetter(field, set_secondaryTouch_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_secondaryTouch_4, AssignFromStack_secondaryTouch_4);
            field = type.GetField("gripButton", flag);
            app.RegisterCLRFieldGetter(field, get_gripButton_5);
            app.RegisterCLRFieldSetter(field, set_gripButton_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_gripButton_5, AssignFromStack_gripButton_5);
            field = type.GetField("triggerButton", flag);
            app.RegisterCLRFieldGetter(field, get_triggerButton_6);
            app.RegisterCLRFieldSetter(field, set_triggerButton_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_triggerButton_6, AssignFromStack_triggerButton_6);
            field = type.GetField("menuButton", flag);
            app.RegisterCLRFieldGetter(field, get_menuButton_7);
            app.RegisterCLRFieldSetter(field, set_menuButton_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_menuButton_7, AssignFromStack_menuButton_7);
            field = type.GetField("primary2DAxisClick", flag);
            app.RegisterCLRFieldGetter(field, get_primary2DAxisClick_8);
            app.RegisterCLRFieldSetter(field, set_primary2DAxisClick_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_primary2DAxisClick_8, AssignFromStack_primary2DAxisClick_8);
            field = type.GetField("primary2DAxisTouch", flag);
            app.RegisterCLRFieldGetter(field, get_primary2DAxisTouch_9);
            app.RegisterCLRFieldSetter(field, set_primary2DAxisTouch_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_primary2DAxisTouch_9, AssignFromStack_primary2DAxisTouch_9);
            field = type.GetField("secondary2DAxisClick", flag);
            app.RegisterCLRFieldGetter(field, get_secondary2DAxisClick_10);
            app.RegisterCLRFieldSetter(field, set_secondary2DAxisClick_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_secondary2DAxisClick_10, AssignFromStack_secondary2DAxisClick_10);
            field = type.GetField("secondary2DAxisTouch", flag);
            app.RegisterCLRFieldGetter(field, get_secondary2DAxisTouch_11);
            app.RegisterCLRFieldSetter(field, set_secondary2DAxisTouch_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_secondary2DAxisTouch_11, AssignFromStack_secondary2DAxisTouch_11);
            field = type.GetField("userPresence", flag);
            app.RegisterCLRFieldGetter(field, get_userPresence_12);
            app.RegisterCLRFieldSetter(field, set_userPresence_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_userPresence_12, AssignFromStack_userPresence_12);
            field = type.GetField("trackingState", flag);
            app.RegisterCLRFieldGetter(field, get_trackingState_13);
            app.RegisterCLRFieldSetter(field, set_trackingState_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_trackingState_13, AssignFromStack_trackingState_13);
            field = type.GetField("batteryLevel", flag);
            app.RegisterCLRFieldGetter(field, get_batteryLevel_14);
            app.RegisterCLRFieldSetter(field, set_batteryLevel_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_batteryLevel_14, AssignFromStack_batteryLevel_14);
            field = type.GetField("trigger", flag);
            app.RegisterCLRFieldGetter(field, get_trigger_15);
            app.RegisterCLRFieldSetter(field, set_trigger_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_trigger_15, AssignFromStack_trigger_15);
            field = type.GetField("grip", flag);
            app.RegisterCLRFieldGetter(field, get_grip_16);
            app.RegisterCLRFieldSetter(field, set_grip_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_grip_16, AssignFromStack_grip_16);
            field = type.GetField("primary2DAxis", flag);
            app.RegisterCLRFieldGetter(field, get_primary2DAxis_17);
            app.RegisterCLRFieldSetter(field, set_primary2DAxis_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_primary2DAxis_17, AssignFromStack_primary2DAxis_17);
            field = type.GetField("secondary2DAxis", flag);
            app.RegisterCLRFieldGetter(field, get_secondary2DAxis_18);
            app.RegisterCLRFieldSetter(field, set_secondary2DAxis_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_secondary2DAxis_18, AssignFromStack_secondary2DAxis_18);
            field = type.GetField("devicePosition", flag);
            app.RegisterCLRFieldGetter(field, get_devicePosition_19);
            app.RegisterCLRFieldSetter(field, set_devicePosition_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_devicePosition_19, AssignFromStack_devicePosition_19);
            field = type.GetField("leftEyePosition", flag);
            app.RegisterCLRFieldGetter(field, get_leftEyePosition_20);
            app.RegisterCLRFieldSetter(field, set_leftEyePosition_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftEyePosition_20, AssignFromStack_leftEyePosition_20);
            field = type.GetField("rightEyePosition", flag);
            app.RegisterCLRFieldGetter(field, get_rightEyePosition_21);
            app.RegisterCLRFieldSetter(field, set_rightEyePosition_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightEyePosition_21, AssignFromStack_rightEyePosition_21);
            field = type.GetField("centerEyePosition", flag);
            app.RegisterCLRFieldGetter(field, get_centerEyePosition_22);
            app.RegisterCLRFieldSetter(field, set_centerEyePosition_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_centerEyePosition_22, AssignFromStack_centerEyePosition_22);
            field = type.GetField("colorCameraPosition", flag);
            app.RegisterCLRFieldGetter(field, get_colorCameraPosition_23);
            app.RegisterCLRFieldSetter(field, set_colorCameraPosition_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorCameraPosition_23, AssignFromStack_colorCameraPosition_23);
            field = type.GetField("deviceVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_deviceVelocity_24);
            app.RegisterCLRFieldSetter(field, set_deviceVelocity_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceVelocity_24, AssignFromStack_deviceVelocity_24);
            field = type.GetField("deviceAngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_deviceAngularVelocity_25);
            app.RegisterCLRFieldSetter(field, set_deviceAngularVelocity_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceAngularVelocity_25, AssignFromStack_deviceAngularVelocity_25);
            field = type.GetField("leftEyeVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_leftEyeVelocity_26);
            app.RegisterCLRFieldSetter(field, set_leftEyeVelocity_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftEyeVelocity_26, AssignFromStack_leftEyeVelocity_26);
            field = type.GetField("leftEyeAngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_leftEyeAngularVelocity_27);
            app.RegisterCLRFieldSetter(field, set_leftEyeAngularVelocity_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftEyeAngularVelocity_27, AssignFromStack_leftEyeAngularVelocity_27);
            field = type.GetField("rightEyeVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_rightEyeVelocity_28);
            app.RegisterCLRFieldSetter(field, set_rightEyeVelocity_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightEyeVelocity_28, AssignFromStack_rightEyeVelocity_28);
            field = type.GetField("rightEyeAngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_rightEyeAngularVelocity_29);
            app.RegisterCLRFieldSetter(field, set_rightEyeAngularVelocity_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightEyeAngularVelocity_29, AssignFromStack_rightEyeAngularVelocity_29);
            field = type.GetField("centerEyeVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_centerEyeVelocity_30);
            app.RegisterCLRFieldSetter(field, set_centerEyeVelocity_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_centerEyeVelocity_30, AssignFromStack_centerEyeVelocity_30);
            field = type.GetField("centerEyeAngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_centerEyeAngularVelocity_31);
            app.RegisterCLRFieldSetter(field, set_centerEyeAngularVelocity_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_centerEyeAngularVelocity_31, AssignFromStack_centerEyeAngularVelocity_31);
            field = type.GetField("colorCameraVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_colorCameraVelocity_32);
            app.RegisterCLRFieldSetter(field, set_colorCameraVelocity_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorCameraVelocity_32, AssignFromStack_colorCameraVelocity_32);
            field = type.GetField("colorCameraAngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_colorCameraAngularVelocity_33);
            app.RegisterCLRFieldSetter(field, set_colorCameraAngularVelocity_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorCameraAngularVelocity_33, AssignFromStack_colorCameraAngularVelocity_33);
            field = type.GetField("deviceAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_deviceAcceleration_34);
            app.RegisterCLRFieldSetter(field, set_deviceAcceleration_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceAcceleration_34, AssignFromStack_deviceAcceleration_34);
            field = type.GetField("deviceAngularAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_deviceAngularAcceleration_35);
            app.RegisterCLRFieldSetter(field, set_deviceAngularAcceleration_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceAngularAcceleration_35, AssignFromStack_deviceAngularAcceleration_35);
            field = type.GetField("leftEyeAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_leftEyeAcceleration_36);
            app.RegisterCLRFieldSetter(field, set_leftEyeAcceleration_36);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftEyeAcceleration_36, AssignFromStack_leftEyeAcceleration_36);
            field = type.GetField("leftEyeAngularAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_leftEyeAngularAcceleration_37);
            app.RegisterCLRFieldSetter(field, set_leftEyeAngularAcceleration_37);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftEyeAngularAcceleration_37, AssignFromStack_leftEyeAngularAcceleration_37);
            field = type.GetField("rightEyeAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_rightEyeAcceleration_38);
            app.RegisterCLRFieldSetter(field, set_rightEyeAcceleration_38);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightEyeAcceleration_38, AssignFromStack_rightEyeAcceleration_38);
            field = type.GetField("rightEyeAngularAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_rightEyeAngularAcceleration_39);
            app.RegisterCLRFieldSetter(field, set_rightEyeAngularAcceleration_39);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightEyeAngularAcceleration_39, AssignFromStack_rightEyeAngularAcceleration_39);
            field = type.GetField("centerEyeAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_centerEyeAcceleration_40);
            app.RegisterCLRFieldSetter(field, set_centerEyeAcceleration_40);
            app.RegisterCLRFieldBinding(field, CopyToStack_centerEyeAcceleration_40, AssignFromStack_centerEyeAcceleration_40);
            field = type.GetField("centerEyeAngularAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_centerEyeAngularAcceleration_41);
            app.RegisterCLRFieldSetter(field, set_centerEyeAngularAcceleration_41);
            app.RegisterCLRFieldBinding(field, CopyToStack_centerEyeAngularAcceleration_41, AssignFromStack_centerEyeAngularAcceleration_41);
            field = type.GetField("colorCameraAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_colorCameraAcceleration_42);
            app.RegisterCLRFieldSetter(field, set_colorCameraAcceleration_42);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorCameraAcceleration_42, AssignFromStack_colorCameraAcceleration_42);
            field = type.GetField("colorCameraAngularAcceleration", flag);
            app.RegisterCLRFieldGetter(field, get_colorCameraAngularAcceleration_43);
            app.RegisterCLRFieldSetter(field, set_colorCameraAngularAcceleration_43);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorCameraAngularAcceleration_43, AssignFromStack_colorCameraAngularAcceleration_43);
            field = type.GetField("deviceRotation", flag);
            app.RegisterCLRFieldGetter(field, get_deviceRotation_44);
            app.RegisterCLRFieldSetter(field, set_deviceRotation_44);
            app.RegisterCLRFieldBinding(field, CopyToStack_deviceRotation_44, AssignFromStack_deviceRotation_44);
            field = type.GetField("leftEyeRotation", flag);
            app.RegisterCLRFieldGetter(field, get_leftEyeRotation_45);
            app.RegisterCLRFieldSetter(field, set_leftEyeRotation_45);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftEyeRotation_45, AssignFromStack_leftEyeRotation_45);
            field = type.GetField("rightEyeRotation", flag);
            app.RegisterCLRFieldGetter(field, get_rightEyeRotation_46);
            app.RegisterCLRFieldSetter(field, set_rightEyeRotation_46);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightEyeRotation_46, AssignFromStack_rightEyeRotation_46);
            field = type.GetField("centerEyeRotation", flag);
            app.RegisterCLRFieldGetter(field, get_centerEyeRotation_47);
            app.RegisterCLRFieldSetter(field, set_centerEyeRotation_47);
            app.RegisterCLRFieldBinding(field, CopyToStack_centerEyeRotation_47, AssignFromStack_centerEyeRotation_47);
            field = type.GetField("colorCameraRotation", flag);
            app.RegisterCLRFieldGetter(field, get_colorCameraRotation_48);
            app.RegisterCLRFieldSetter(field, set_colorCameraRotation_48);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorCameraRotation_48, AssignFromStack_colorCameraRotation_48);
            field = type.GetField("handData", flag);
            app.RegisterCLRFieldGetter(field, get_handData_49);
            app.RegisterCLRFieldSetter(field, set_handData_49);
            app.RegisterCLRFieldBinding(field, CopyToStack_handData_49, AssignFromStack_handData_49);
            field = type.GetField("eyesData", flag);
            app.RegisterCLRFieldGetter(field, get_eyesData_50);
            app.RegisterCLRFieldSetter(field, set_eyesData_50);
            app.RegisterCLRFieldBinding(field, CopyToStack_eyesData_50, AssignFromStack_eyesData_50);




        }



        static object get_isTracked_0(ref object o)
        {
            return UnityEngine.XR.CommonUsages.isTracked;
        }

        static StackObject* CopyToStack_isTracked_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.isTracked;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_isTracked_0(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.isTracked = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_isTracked_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @isTracked = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.isTracked = @isTracked;
            return ptr_of_this_method;
        }

        static object get_primaryButton_1(ref object o)
        {
            return UnityEngine.XR.CommonUsages.primaryButton;
        }

        static StackObject* CopyToStack_primaryButton_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.primaryButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_primaryButton_1(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.primaryButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_primaryButton_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @primaryButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.primaryButton = @primaryButton;
            return ptr_of_this_method;
        }

        static object get_primaryTouch_2(ref object o)
        {
            return UnityEngine.XR.CommonUsages.primaryTouch;
        }

        static StackObject* CopyToStack_primaryTouch_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.primaryTouch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_primaryTouch_2(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.primaryTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_primaryTouch_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @primaryTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.primaryTouch = @primaryTouch;
            return ptr_of_this_method;
        }

        static object get_secondaryButton_3(ref object o)
        {
            return UnityEngine.XR.CommonUsages.secondaryButton;
        }

        static StackObject* CopyToStack_secondaryButton_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.secondaryButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_secondaryButton_3(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.secondaryButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_secondaryButton_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @secondaryButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.secondaryButton = @secondaryButton;
            return ptr_of_this_method;
        }

        static object get_secondaryTouch_4(ref object o)
        {
            return UnityEngine.XR.CommonUsages.secondaryTouch;
        }

        static StackObject* CopyToStack_secondaryTouch_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.secondaryTouch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_secondaryTouch_4(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.secondaryTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_secondaryTouch_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @secondaryTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.secondaryTouch = @secondaryTouch;
            return ptr_of_this_method;
        }

        static object get_gripButton_5(ref object o)
        {
            return UnityEngine.XR.CommonUsages.gripButton;
        }

        static StackObject* CopyToStack_gripButton_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.gripButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_gripButton_5(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.gripButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_gripButton_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @gripButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.gripButton = @gripButton;
            return ptr_of_this_method;
        }

        static object get_triggerButton_6(ref object o)
        {
            return UnityEngine.XR.CommonUsages.triggerButton;
        }

        static StackObject* CopyToStack_triggerButton_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.triggerButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_triggerButton_6(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.triggerButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_triggerButton_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @triggerButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.triggerButton = @triggerButton;
            return ptr_of_this_method;
        }

        static object get_menuButton_7(ref object o)
        {
            return UnityEngine.XR.CommonUsages.menuButton;
        }

        static StackObject* CopyToStack_menuButton_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.menuButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_menuButton_7(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.menuButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_menuButton_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @menuButton = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.menuButton = @menuButton;
            return ptr_of_this_method;
        }

        static object get_primary2DAxisClick_8(ref object o)
        {
            return UnityEngine.XR.CommonUsages.primary2DAxisClick;
        }

        static StackObject* CopyToStack_primary2DAxisClick_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.primary2DAxisClick;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_primary2DAxisClick_8(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.primary2DAxisClick = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_primary2DAxisClick_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @primary2DAxisClick = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.primary2DAxisClick = @primary2DAxisClick;
            return ptr_of_this_method;
        }

        static object get_primary2DAxisTouch_9(ref object o)
        {
            return UnityEngine.XR.CommonUsages.primary2DAxisTouch;
        }

        static StackObject* CopyToStack_primary2DAxisTouch_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.primary2DAxisTouch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_primary2DAxisTouch_9(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.primary2DAxisTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_primary2DAxisTouch_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @primary2DAxisTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.primary2DAxisTouch = @primary2DAxisTouch;
            return ptr_of_this_method;
        }

        static object get_secondary2DAxisClick_10(ref object o)
        {
            return UnityEngine.XR.CommonUsages.secondary2DAxisClick;
        }

        static StackObject* CopyToStack_secondary2DAxisClick_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.secondary2DAxisClick;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_secondary2DAxisClick_10(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.secondary2DAxisClick = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_secondary2DAxisClick_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @secondary2DAxisClick = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.secondary2DAxisClick = @secondary2DAxisClick;
            return ptr_of_this_method;
        }

        static object get_secondary2DAxisTouch_11(ref object o)
        {
            return UnityEngine.XR.CommonUsages.secondary2DAxisTouch;
        }

        static StackObject* CopyToStack_secondary2DAxisTouch_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.secondary2DAxisTouch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_secondary2DAxisTouch_11(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.secondary2DAxisTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_secondary2DAxisTouch_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @secondary2DAxisTouch = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.secondary2DAxisTouch = @secondary2DAxisTouch;
            return ptr_of_this_method;
        }

        static object get_userPresence_12(ref object o)
        {
            return UnityEngine.XR.CommonUsages.userPresence;
        }

        static StackObject* CopyToStack_userPresence_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.userPresence;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_userPresence_12(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.userPresence = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_userPresence_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Boolean> @userPresence = (UnityEngine.XR.InputFeatureUsage<System.Boolean>)typeof(UnityEngine.XR.InputFeatureUsage<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.userPresence = @userPresence;
            return ptr_of_this_method;
        }

        static object get_trackingState_13(ref object o)
        {
            return UnityEngine.XR.CommonUsages.trackingState;
        }

        static StackObject* CopyToStack_trackingState_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.trackingState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_trackingState_13(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.trackingState = (UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState>)v;
        }

        static StackObject* AssignFromStack_trackingState_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState> @trackingState = (UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.trackingState = @trackingState;
            return ptr_of_this_method;
        }

        static object get_batteryLevel_14(ref object o)
        {
            return UnityEngine.XR.CommonUsages.batteryLevel;
        }

        static StackObject* CopyToStack_batteryLevel_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.batteryLevel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_batteryLevel_14(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.batteryLevel = (UnityEngine.XR.InputFeatureUsage<System.Single>)v;
        }

        static StackObject* AssignFromStack_batteryLevel_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Single> @batteryLevel = (UnityEngine.XR.InputFeatureUsage<System.Single>)typeof(UnityEngine.XR.InputFeatureUsage<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.batteryLevel = @batteryLevel;
            return ptr_of_this_method;
        }

        static object get_trigger_15(ref object o)
        {
            return UnityEngine.XR.CommonUsages.trigger;
        }

        static StackObject* CopyToStack_trigger_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.trigger;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_trigger_15(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.trigger = (UnityEngine.XR.InputFeatureUsage<System.Single>)v;
        }

        static StackObject* AssignFromStack_trigger_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Single> @trigger = (UnityEngine.XR.InputFeatureUsage<System.Single>)typeof(UnityEngine.XR.InputFeatureUsage<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.trigger = @trigger;
            return ptr_of_this_method;
        }

        static object get_grip_16(ref object o)
        {
            return UnityEngine.XR.CommonUsages.grip;
        }

        static StackObject* CopyToStack_grip_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.grip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_grip_16(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.grip = (UnityEngine.XR.InputFeatureUsage<System.Single>)v;
        }

        static StackObject* AssignFromStack_grip_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<System.Single> @grip = (UnityEngine.XR.InputFeatureUsage<System.Single>)typeof(UnityEngine.XR.InputFeatureUsage<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.grip = @grip;
            return ptr_of_this_method;
        }

        static object get_primary2DAxis_17(ref object o)
        {
            return UnityEngine.XR.CommonUsages.primary2DAxis;
        }

        static StackObject* CopyToStack_primary2DAxis_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.primary2DAxis;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_primary2DAxis_17(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.primary2DAxis = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2>)v;
        }

        static StackObject* AssignFromStack_primary2DAxis_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> @primary2DAxis = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.primary2DAxis = @primary2DAxis;
            return ptr_of_this_method;
        }

        static object get_secondary2DAxis_18(ref object o)
        {
            return UnityEngine.XR.CommonUsages.secondary2DAxis;
        }

        static StackObject* CopyToStack_secondary2DAxis_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.secondary2DAxis;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_secondary2DAxis_18(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.secondary2DAxis = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2>)v;
        }

        static StackObject* AssignFromStack_secondary2DAxis_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> @secondary2DAxis = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.secondary2DAxis = @secondary2DAxis;
            return ptr_of_this_method;
        }

        static object get_devicePosition_19(ref object o)
        {
            return UnityEngine.XR.CommonUsages.devicePosition;
        }

        static StackObject* CopyToStack_devicePosition_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.devicePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_devicePosition_19(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.devicePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_devicePosition_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @devicePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.devicePosition = @devicePosition;
            return ptr_of_this_method;
        }

        static object get_leftEyePosition_20(ref object o)
        {
            return UnityEngine.XR.CommonUsages.leftEyePosition;
        }

        static StackObject* CopyToStack_leftEyePosition_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.leftEyePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftEyePosition_20(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.leftEyePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_leftEyePosition_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @leftEyePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.leftEyePosition = @leftEyePosition;
            return ptr_of_this_method;
        }

        static object get_rightEyePosition_21(ref object o)
        {
            return UnityEngine.XR.CommonUsages.rightEyePosition;
        }

        static StackObject* CopyToStack_rightEyePosition_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.rightEyePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightEyePosition_21(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.rightEyePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_rightEyePosition_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @rightEyePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.rightEyePosition = @rightEyePosition;
            return ptr_of_this_method;
        }

        static object get_centerEyePosition_22(ref object o)
        {
            return UnityEngine.XR.CommonUsages.centerEyePosition;
        }

        static StackObject* CopyToStack_centerEyePosition_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.centerEyePosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_centerEyePosition_22(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.centerEyePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_centerEyePosition_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @centerEyePosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.centerEyePosition = @centerEyePosition;
            return ptr_of_this_method;
        }

        static object get_colorCameraPosition_23(ref object o)
        {
            return UnityEngine.XR.CommonUsages.colorCameraPosition;
        }

        static StackObject* CopyToStack_colorCameraPosition_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.colorCameraPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_colorCameraPosition_23(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.colorCameraPosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_colorCameraPosition_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @colorCameraPosition = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.colorCameraPosition = @colorCameraPosition;
            return ptr_of_this_method;
        }

        static object get_deviceVelocity_24(ref object o)
        {
            return UnityEngine.XR.CommonUsages.deviceVelocity;
        }

        static StackObject* CopyToStack_deviceVelocity_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.deviceVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceVelocity_24(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.deviceVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_deviceVelocity_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @deviceVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.deviceVelocity = @deviceVelocity;
            return ptr_of_this_method;
        }

        static object get_deviceAngularVelocity_25(ref object o)
        {
            return UnityEngine.XR.CommonUsages.deviceAngularVelocity;
        }

        static StackObject* CopyToStack_deviceAngularVelocity_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.deviceAngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceAngularVelocity_25(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.deviceAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_deviceAngularVelocity_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @deviceAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.deviceAngularVelocity = @deviceAngularVelocity;
            return ptr_of_this_method;
        }

        static object get_leftEyeVelocity_26(ref object o)
        {
            return UnityEngine.XR.CommonUsages.leftEyeVelocity;
        }

        static StackObject* CopyToStack_leftEyeVelocity_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.leftEyeVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftEyeVelocity_26(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.leftEyeVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_leftEyeVelocity_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @leftEyeVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.leftEyeVelocity = @leftEyeVelocity;
            return ptr_of_this_method;
        }

        static object get_leftEyeAngularVelocity_27(ref object o)
        {
            return UnityEngine.XR.CommonUsages.leftEyeAngularVelocity;
        }

        static StackObject* CopyToStack_leftEyeAngularVelocity_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.leftEyeAngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftEyeAngularVelocity_27(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.leftEyeAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_leftEyeAngularVelocity_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @leftEyeAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.leftEyeAngularVelocity = @leftEyeAngularVelocity;
            return ptr_of_this_method;
        }

        static object get_rightEyeVelocity_28(ref object o)
        {
            return UnityEngine.XR.CommonUsages.rightEyeVelocity;
        }

        static StackObject* CopyToStack_rightEyeVelocity_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.rightEyeVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightEyeVelocity_28(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.rightEyeVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_rightEyeVelocity_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @rightEyeVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.rightEyeVelocity = @rightEyeVelocity;
            return ptr_of_this_method;
        }

        static object get_rightEyeAngularVelocity_29(ref object o)
        {
            return UnityEngine.XR.CommonUsages.rightEyeAngularVelocity;
        }

        static StackObject* CopyToStack_rightEyeAngularVelocity_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.rightEyeAngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightEyeAngularVelocity_29(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.rightEyeAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_rightEyeAngularVelocity_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @rightEyeAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.rightEyeAngularVelocity = @rightEyeAngularVelocity;
            return ptr_of_this_method;
        }

        static object get_centerEyeVelocity_30(ref object o)
        {
            return UnityEngine.XR.CommonUsages.centerEyeVelocity;
        }

        static StackObject* CopyToStack_centerEyeVelocity_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.centerEyeVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_centerEyeVelocity_30(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.centerEyeVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_centerEyeVelocity_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @centerEyeVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.centerEyeVelocity = @centerEyeVelocity;
            return ptr_of_this_method;
        }

        static object get_centerEyeAngularVelocity_31(ref object o)
        {
            return UnityEngine.XR.CommonUsages.centerEyeAngularVelocity;
        }

        static StackObject* CopyToStack_centerEyeAngularVelocity_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.centerEyeAngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_centerEyeAngularVelocity_31(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.centerEyeAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_centerEyeAngularVelocity_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @centerEyeAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.centerEyeAngularVelocity = @centerEyeAngularVelocity;
            return ptr_of_this_method;
        }

        static object get_colorCameraVelocity_32(ref object o)
        {
            return UnityEngine.XR.CommonUsages.colorCameraVelocity;
        }

        static StackObject* CopyToStack_colorCameraVelocity_32(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.colorCameraVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_colorCameraVelocity_32(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.colorCameraVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_colorCameraVelocity_32(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @colorCameraVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.colorCameraVelocity = @colorCameraVelocity;
            return ptr_of_this_method;
        }

        static object get_colorCameraAngularVelocity_33(ref object o)
        {
            return UnityEngine.XR.CommonUsages.colorCameraAngularVelocity;
        }

        static StackObject* CopyToStack_colorCameraAngularVelocity_33(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.colorCameraAngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_colorCameraAngularVelocity_33(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.colorCameraAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_colorCameraAngularVelocity_33(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @colorCameraAngularVelocity = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.colorCameraAngularVelocity = @colorCameraAngularVelocity;
            return ptr_of_this_method;
        }

        static object get_deviceAcceleration_34(ref object o)
        {
            return UnityEngine.XR.CommonUsages.deviceAcceleration;
        }

        static StackObject* CopyToStack_deviceAcceleration_34(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.deviceAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceAcceleration_34(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.deviceAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_deviceAcceleration_34(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @deviceAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.deviceAcceleration = @deviceAcceleration;
            return ptr_of_this_method;
        }

        static object get_deviceAngularAcceleration_35(ref object o)
        {
            return UnityEngine.XR.CommonUsages.deviceAngularAcceleration;
        }

        static StackObject* CopyToStack_deviceAngularAcceleration_35(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.deviceAngularAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceAngularAcceleration_35(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.deviceAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_deviceAngularAcceleration_35(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @deviceAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.deviceAngularAcceleration = @deviceAngularAcceleration;
            return ptr_of_this_method;
        }

        static object get_leftEyeAcceleration_36(ref object o)
        {
            return UnityEngine.XR.CommonUsages.leftEyeAcceleration;
        }

        static StackObject* CopyToStack_leftEyeAcceleration_36(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.leftEyeAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftEyeAcceleration_36(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.leftEyeAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_leftEyeAcceleration_36(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @leftEyeAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.leftEyeAcceleration = @leftEyeAcceleration;
            return ptr_of_this_method;
        }

        static object get_leftEyeAngularAcceleration_37(ref object o)
        {
            return UnityEngine.XR.CommonUsages.leftEyeAngularAcceleration;
        }

        static StackObject* CopyToStack_leftEyeAngularAcceleration_37(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.leftEyeAngularAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftEyeAngularAcceleration_37(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.leftEyeAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_leftEyeAngularAcceleration_37(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @leftEyeAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.leftEyeAngularAcceleration = @leftEyeAngularAcceleration;
            return ptr_of_this_method;
        }

        static object get_rightEyeAcceleration_38(ref object o)
        {
            return UnityEngine.XR.CommonUsages.rightEyeAcceleration;
        }

        static StackObject* CopyToStack_rightEyeAcceleration_38(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.rightEyeAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightEyeAcceleration_38(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.rightEyeAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_rightEyeAcceleration_38(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @rightEyeAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.rightEyeAcceleration = @rightEyeAcceleration;
            return ptr_of_this_method;
        }

        static object get_rightEyeAngularAcceleration_39(ref object o)
        {
            return UnityEngine.XR.CommonUsages.rightEyeAngularAcceleration;
        }

        static StackObject* CopyToStack_rightEyeAngularAcceleration_39(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.rightEyeAngularAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightEyeAngularAcceleration_39(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.rightEyeAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_rightEyeAngularAcceleration_39(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @rightEyeAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.rightEyeAngularAcceleration = @rightEyeAngularAcceleration;
            return ptr_of_this_method;
        }

        static object get_centerEyeAcceleration_40(ref object o)
        {
            return UnityEngine.XR.CommonUsages.centerEyeAcceleration;
        }

        static StackObject* CopyToStack_centerEyeAcceleration_40(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.centerEyeAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_centerEyeAcceleration_40(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.centerEyeAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_centerEyeAcceleration_40(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @centerEyeAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.centerEyeAcceleration = @centerEyeAcceleration;
            return ptr_of_this_method;
        }

        static object get_centerEyeAngularAcceleration_41(ref object o)
        {
            return UnityEngine.XR.CommonUsages.centerEyeAngularAcceleration;
        }

        static StackObject* CopyToStack_centerEyeAngularAcceleration_41(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.centerEyeAngularAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_centerEyeAngularAcceleration_41(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.centerEyeAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_centerEyeAngularAcceleration_41(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @centerEyeAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.centerEyeAngularAcceleration = @centerEyeAngularAcceleration;
            return ptr_of_this_method;
        }

        static object get_colorCameraAcceleration_42(ref object o)
        {
            return UnityEngine.XR.CommonUsages.colorCameraAcceleration;
        }

        static StackObject* CopyToStack_colorCameraAcceleration_42(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.colorCameraAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_colorCameraAcceleration_42(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.colorCameraAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_colorCameraAcceleration_42(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @colorCameraAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.colorCameraAcceleration = @colorCameraAcceleration;
            return ptr_of_this_method;
        }

        static object get_colorCameraAngularAcceleration_43(ref object o)
        {
            return UnityEngine.XR.CommonUsages.colorCameraAngularAcceleration;
        }

        static StackObject* CopyToStack_colorCameraAngularAcceleration_43(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.colorCameraAngularAcceleration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_colorCameraAngularAcceleration_43(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.colorCameraAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)v;
        }

        static StackObject* AssignFromStack_colorCameraAngularAcceleration_43(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> @colorCameraAngularAcceleration = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.colorCameraAngularAcceleration = @colorCameraAngularAcceleration;
            return ptr_of_this_method;
        }

        static object get_deviceRotation_44(ref object o)
        {
            return UnityEngine.XR.CommonUsages.deviceRotation;
        }

        static StackObject* CopyToStack_deviceRotation_44(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.deviceRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_deviceRotation_44(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.deviceRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)v;
        }

        static StackObject* AssignFromStack_deviceRotation_44(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> @deviceRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.deviceRotation = @deviceRotation;
            return ptr_of_this_method;
        }

        static object get_leftEyeRotation_45(ref object o)
        {
            return UnityEngine.XR.CommonUsages.leftEyeRotation;
        }

        static StackObject* CopyToStack_leftEyeRotation_45(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.leftEyeRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftEyeRotation_45(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.leftEyeRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)v;
        }

        static StackObject* AssignFromStack_leftEyeRotation_45(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> @leftEyeRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.leftEyeRotation = @leftEyeRotation;
            return ptr_of_this_method;
        }

        static object get_rightEyeRotation_46(ref object o)
        {
            return UnityEngine.XR.CommonUsages.rightEyeRotation;
        }

        static StackObject* CopyToStack_rightEyeRotation_46(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.rightEyeRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightEyeRotation_46(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.rightEyeRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)v;
        }

        static StackObject* AssignFromStack_rightEyeRotation_46(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> @rightEyeRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.rightEyeRotation = @rightEyeRotation;
            return ptr_of_this_method;
        }

        static object get_centerEyeRotation_47(ref object o)
        {
            return UnityEngine.XR.CommonUsages.centerEyeRotation;
        }

        static StackObject* CopyToStack_centerEyeRotation_47(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.centerEyeRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_centerEyeRotation_47(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.centerEyeRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)v;
        }

        static StackObject* AssignFromStack_centerEyeRotation_47(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> @centerEyeRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.centerEyeRotation = @centerEyeRotation;
            return ptr_of_this_method;
        }

        static object get_colorCameraRotation_48(ref object o)
        {
            return UnityEngine.XR.CommonUsages.colorCameraRotation;
        }

        static StackObject* CopyToStack_colorCameraRotation_48(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.colorCameraRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_colorCameraRotation_48(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.colorCameraRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)v;
        }

        static StackObject* AssignFromStack_colorCameraRotation_48(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> @colorCameraRotation = (UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.colorCameraRotation = @colorCameraRotation;
            return ptr_of_this_method;
        }

        static object get_handData_49(ref object o)
        {
            return UnityEngine.XR.CommonUsages.handData;
        }

        static StackObject* CopyToStack_handData_49(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.handData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_handData_49(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.handData = (UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Hand>)v;
        }

        static StackObject* AssignFromStack_handData_49(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Hand> @handData = (UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Hand>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Hand>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.handData = @handData;
            return ptr_of_this_method;
        }

        static object get_eyesData_50(ref object o)
        {
            return UnityEngine.XR.CommonUsages.eyesData;
        }

        static StackObject* CopyToStack_eyesData_50(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.CommonUsages.eyesData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_eyesData_50(ref object o, object v)
        {
            UnityEngine.XR.CommonUsages.eyesData = (UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Eyes>)v;
        }

        static StackObject* AssignFromStack_eyesData_50(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Eyes> @eyesData = (UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Eyes>)typeof(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Eyes>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.XR.CommonUsages.eyesData = @eyesData;
            return ptr_of_this_method;
        }




    }
}
