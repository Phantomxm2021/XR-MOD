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
    unsafe class UnityEngine_Input_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Input);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAxis_0);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetAxisRaw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAxisRaw_1);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetButton_2);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetButtonDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetButtonDown_3);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetButtonUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetButtonUp_4);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("GetMouseButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMouseButton_5);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("GetMouseButtonDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMouseButtonDown_6);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("GetMouseButtonUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMouseButtonUp_7);
            args = new Type[] { };
            method = type.GetMethod("ResetInputAxes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetInputAxes_8);
            args = new Type[] { };
            method = type.GetMethod("GetJoystickNames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJoystickNames_10);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("GetTouch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTouch_11);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("GetAccelerationEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAccelerationEvent_12);
            args = new Type[] {typeof(UnityEngine.KeyCode)};
            method = type.GetMethod("GetKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKey_13);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKey_14);
            args = new Type[] {typeof(UnityEngine.KeyCode)};
            method = type.GetMethod("GetKeyUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKeyUp_15);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetKeyUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKeyUp_16);
            args = new Type[] {typeof(UnityEngine.KeyCode)};
            method = type.GetMethod("GetKeyDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKeyDown_17);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetKeyDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKeyDown_18);
            args = new Type[] { };
            method = type.GetMethod("get_simulateMouseWithTouches", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_simulateMouseWithTouches_19);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_simulateMouseWithTouches", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_simulateMouseWithTouches_20);
            args = new Type[] { };
            method = type.GetMethod("get_anyKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anyKey_21);
            args = new Type[] { };
            method = type.GetMethod("get_anyKeyDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anyKeyDown_22);
            args = new Type[] { };
            method = type.GetMethod("get_inputString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputString_23);
            args = new Type[] { };
            method = type.GetMethod("get_mousePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mousePosition_24);
            args = new Type[] { };
            method = type.GetMethod("get_mouseScrollDelta", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mouseScrollDelta_25);
            args = new Type[] { };
            method = type.GetMethod("get_imeCompositionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_imeCompositionMode_26);
            args = new Type[] {typeof(UnityEngine.IMECompositionMode)};
            method = type.GetMethod("set_imeCompositionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_imeCompositionMode_27);
            args = new Type[] { };
            method = type.GetMethod("get_compositionString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_compositionString_28);
            args = new Type[] { };
            method = type.GetMethod("get_imeIsSelected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_imeIsSelected_29);
            args = new Type[] { };
            method = type.GetMethod("get_compositionCursorPos", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_compositionCursorPos_30);
            args = new Type[] {typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_compositionCursorPos", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_compositionCursorPos_31);
            args = new Type[] { };
            method = type.GetMethod("get_mousePresent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mousePresent_32);
            args = new Type[] { };
            method = type.GetMethod("get_touchCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchCount_33);
            args = new Type[] { };
            method = type.GetMethod("get_touchPressureSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchPressureSupported_34);
            args = new Type[] { };
            method = type.GetMethod("get_stylusTouchSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stylusTouchSupported_35);
            args = new Type[] { };
            method = type.GetMethod("get_touchSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchSupported_36);
            args = new Type[] { };
            method = type.GetMethod("get_multiTouchEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_multiTouchEnabled_37);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_multiTouchEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_multiTouchEnabled_38);
            args = new Type[] { };
            method = type.GetMethod("get_deviceOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deviceOrientation_39);
            args = new Type[] { };
            method = type.GetMethod("get_acceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_acceleration_40);
            args = new Type[] { };
            method = type.GetMethod("get_compensateSensors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_compensateSensors_41);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_compensateSensors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_compensateSensors_42);
            args = new Type[] { };
            method = type.GetMethod("get_accelerationEventCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_accelerationEventCount_43);
            args = new Type[] { };
            method = type.GetMethod("get_backButtonLeavesApp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backButtonLeavesApp_44);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_backButtonLeavesApp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backButtonLeavesApp_45);
            args = new Type[] { };
            method = type.GetMethod("get_location", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_location_46);
            args = new Type[] { };
            method = type.GetMethod("get_compass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_compass_47);
            args = new Type[] { };
            method = type.GetMethod("get_gyro", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gyro_48);
            args = new Type[] { };
            method = type.GetMethod("get_touches", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touches_49);
            args = new Type[] { };
            method = type.GetMethod("get_accelerationEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_accelerationEvents_50);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Input());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Input[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* GetAxis_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @axisName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetAxis(@axisName);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAxisRaw_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @axisName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetAxisRaw(@axisName);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetButton_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @buttonName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetButton(@buttonName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetButtonDown_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @buttonName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetButtonDown(@buttonName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetButtonUp_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @buttonName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetButtonUp(@buttonName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetMouseButton_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @button = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Input.GetMouseButton(@button);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetMouseButtonDown_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @button = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Input.GetMouseButtonDown(@button);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetMouseButtonUp_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @button = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Input.GetMouseButtonUp(@button);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ResetInputAxes_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Input.ResetInputAxes();

            return __ret;
        }


        static StackObject* GetJoystickNames_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.GetJoystickNames();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetTouch_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Input.GetTouch(@index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAccelerationEvent_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Input.GetAccelerationEvent(@index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetKey_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.KeyCode @key =
                (UnityEngine.KeyCode) typeof(UnityEngine.KeyCode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetKey(@key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetKey_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetKey(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetKeyUp_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.KeyCode @key =
                (UnityEngine.KeyCode) typeof(UnityEngine.KeyCode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetKeyUp(@key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetKeyUp_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetKeyUp(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetKeyDown_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.KeyCode @key =
                (UnityEngine.KeyCode) typeof(UnityEngine.KeyCode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetKeyDown(@key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetKeyDown_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Input.GetKeyDown(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_simulateMouseWithTouches_19(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.simulateMouseWithTouches;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_simulateMouseWithTouches_20(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Input.simulateMouseWithTouches = value;

            return __ret;
        }

        static StackObject* get_anyKey_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.anyKey;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_anyKeyDown_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.anyKeyDown;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_inputString_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.inputString;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_mousePosition_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.mousePosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_mouseScrollDelta_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.mouseScrollDelta;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_imeCompositionMode_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.imeCompositionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_imeCompositionMode_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.IMECompositionMode @value =
                (UnityEngine.IMECompositionMode) typeof(UnityEngine.IMECompositionMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Input.imeCompositionMode = value;

            return __ret;
        }

        static StackObject* get_compositionString_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.compositionString;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_imeIsSelected_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.imeIsSelected;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_compositionCursorPos_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.compositionCursorPos;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_compositionCursorPos_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value =
                (UnityEngine.Vector2) typeof(UnityEngine.Vector2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Input.compositionCursorPos = value;

            return __ret;
        }

        static StackObject* get_mousePresent_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.mousePresent;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_touchCount_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.touchCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_touchPressureSupported_34(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.touchPressureSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_stylusTouchSupported_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.stylusTouchSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_touchSupported_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.touchSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_multiTouchEnabled_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.multiTouchEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_multiTouchEnabled_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Input.multiTouchEnabled = value;

            return __ret;
        }

        static StackObject* get_deviceOrientation_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.deviceOrientation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_acceleration_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.acceleration;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_compensateSensors_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.compensateSensors;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_compensateSensors_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Input.compensateSensors = value;

            return __ret;
        }

        static StackObject* get_accelerationEventCount_43(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.accelerationEventCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_backButtonLeavesApp_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.backButtonLeavesApp;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_backButtonLeavesApp_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Input.backButtonLeavesApp = value;

            return __ret;
        }

        static StackObject* get_location_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.location;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_compass_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.compass;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_gyro_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.gyro;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_touches_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.touches;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_accelerationEvents_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Input.accelerationEvents;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Input();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}