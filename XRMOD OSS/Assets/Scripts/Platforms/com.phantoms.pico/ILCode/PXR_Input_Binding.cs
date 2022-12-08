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
    unsafe class PXR_Input_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.XR.PXR.PXR_Input);
            args = new Type[]{};
            method = type.GetMethod("GetDominantHand", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDominantHand_0);
            args = new Type[]{typeof(Unity.XR.PXR.PXR_Input.Controller)};
            method = type.GetMethod("SetDominantHand", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDominantHand_1);
            args = new Type[]{typeof(System.Single), typeof(System.Int32), typeof(Unity.XR.PXR.PXR_Input.Controller)};
            method = type.GetMethod("SetControllerVibration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetControllerVibration_2);
            args = new Type[]{};
            method = type.GetMethod("GetControllerDeviceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetControllerDeviceType_3);
            args = new Type[]{typeof(Unity.XR.PXR.PXR_Input.Controller)};
            method = type.GetMethod("IsControllerConnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsControllerConnected_4);
            args = new Type[]{typeof(Unity.XR.PXR.PXR_Input.Controller), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetControllerOriginOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetControllerOriginOffset_5);
            args = new Type[]{typeof(Unity.XR.PXR.PXR_Input.Controller), typeof(System.Double)};
            method = type.GetMethod("GetControllerPredictRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetControllerPredictRotation_6);
            args = new Type[]{typeof(Unity.XR.PXR.PXR_Input.Controller), typeof(System.Double)};
            method = type.GetMethod("GetControllerPredictPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetControllerPredictPosition_7);
            args = new Type[]{typeof(System.UInt32), typeof(System.Int32), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("SetControllerVibrationEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetControllerVibrationEvent_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StopControllerVCMotor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StopControllerVCMotor_9);
            args = new Type[]{typeof(System.String), typeof(Unity.XR.PXR.PXR_Input.VibrateController)};
            method = type.GetMethod("StartControllerVCMotor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartControllerVCMotor_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("SetControllerAmp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetControllerAmp_11);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(Unity.XR.PXR.PXR_Input.VibrateController), typeof(Unity.XR.PXR.PXR_Input.ChannelFlip), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("StartVibrateBySharem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartVibrateBySharem_12);
            args = new Type[]{typeof(System.Single[]), typeof(Unity.XR.PXR.PXR_Input.VibrateController), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(Unity.XR.PXR.PXR_Input.ChannelFlip), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("StartVibrateBySharem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartVibrateBySharem_13);
            args = new Type[]{typeof(UnityEngine.AudioClip), typeof(Unity.XR.PXR.PXR_Input.VibrateController), typeof(Unity.XR.PXR.PXR_Input.ChannelFlip), typeof(Unity.XR.PXR.PXR_Input.CacheConfig), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("SaveVibrateByCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveVibrateByCache_14);
            args = new Type[]{typeof(System.Single[]), typeof(Unity.XR.PXR.PXR_Input.VibrateController), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(Unity.XR.PXR.PXR_Input.ChannelFlip), typeof(Unity.XR.PXR.PXR_Input.CacheConfig), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("SaveVibrateByCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveVibrateByCache_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartVibrateByCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartVibrateByCache_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ClearVibrateByCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearVibrateByCache_17);
            args = new Type[]{typeof(System.Boolean), typeof(Unity.XR.PXR.PxrControllerKeyMap)};
            method = type.GetMethod("SetControllerEnableKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetControllerEnableKey_18);
            args = new Type[]{typeof(UnityEngine.TextAsset), typeof(System.Int32).MakeByRefType(), typeof(Unity.XR.PXR.PXR_Input.VibrateController), typeof(Unity.XR.PXR.PXR_Input.ChannelFlip), typeof(System.Single)};
            method = type.GetMethod("StartVibrateByPHF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartVibrateByPHF_19);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("PauseVibrate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PauseVibrate_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ResumeVibrate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResumeVibrate_21);
            args = new Type[]{typeof(System.Int32), typeof(Unity.XR.PXR.PXR_Input.VibrateController), typeof(Unity.XR.PXR.PXR_Input.ChannelFlip), typeof(System.Single)};
            method = type.GetMethod("UpdateVibrateParams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateVibrateParams_22);





        }


        static StackObject* GetDominantHand_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.GetDominantHand();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetDominantHand_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.PXR_Input.Controller @controller = (Unity.XR.PXR.PXR_Input.Controller)typeof(Unity.XR.PXR.PXR_Input.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            Unity.XR.PXR.PXR_Input.SetDominantHand(@controller);

            return __ret;
        }

        static StackObject* SetControllerVibration_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.PXR_Input.Controller @controller = (Unity.XR.PXR.PXR_Input.Controller)typeof(Unity.XR.PXR.PXR_Input.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @time = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @strength = *(float*)&ptr_of_this_method->Value;


            Unity.XR.PXR.PXR_Input.SetControllerVibration(@strength, @time, @controller);

            return __ret;
        }

        static StackObject* GetControllerDeviceType_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.GetControllerDeviceType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsControllerConnected_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.PXR_Input.Controller @controller = (Unity.XR.PXR.PXR_Input.Controller)typeof(Unity.XR.PXR.PXR_Input.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.IsControllerConnected(@controller);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetControllerOriginOffset_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @offset = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.Controller @controller = (Unity.XR.PXR.PXR_Input.Controller)typeof(Unity.XR.PXR.PXR_Input.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            Unity.XR.PXR.PXR_Input.SetControllerOriginOffset(@controller, @offset);

            return __ret;
        }

        static StackObject* GetControllerPredictRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @predictTime = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.Controller @controller = (Unity.XR.PXR.PXR_Input.Controller)typeof(Unity.XR.PXR.PXR_Input.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.GetControllerPredictRotation(@controller, @predictTime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetControllerPredictPosition_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @predictTime = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.Controller @controller = (Unity.XR.PXR.PXR_Input.Controller)typeof(Unity.XR.PXR.PXR_Input.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.GetControllerPredictPosition(@controller, @predictTime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetControllerVibrationEvent_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @time = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @strength = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @frequency = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.UInt32 @hand = (uint)ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.SetControllerVibrationEvent(@hand, @frequency, @strength, @time);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StopControllerVCMotor_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.StopControllerVCMotor(@sourceId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StartControllerVCMotor_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @file = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.StartControllerVCMotor(@file, @vibrateController);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetControllerAmp_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @mode = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.SetControllerAmp(@mode);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StartVibrateBySharem_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.ChannelFlip @channelFlip = (Unity.XR.PXR.PXR_Input.ChannelFlip)typeof(Unity.XR.PXR.PXR_Input.ChannelFlip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.AudioClip @audioClip = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.StartVibrateBySharem(@audioClip, @vibrateController, @channelFlip, ref @sourceId);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @sourceId;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @sourceId);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @sourceId);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @sourceId;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StartVibrateBySharem_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.ChannelFlip @channelFlip = (Unity.XR.PXR.PXR_Input.ChannelFlip)typeof(Unity.XR.PXR.PXR_Input.ChannelFlip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @channelMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @frequency = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @buffersize = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Single[] @data = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.StartVibrateBySharem(@data, @vibrateController, @buffersize, @frequency, @channelMask, @channelFlip, ref @sourceId);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @sourceId;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @sourceId);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @sourceId);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @sourceId;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SaveVibrateByCache_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.CacheConfig @cacheConfig = (Unity.XR.PXR.PXR_Input.CacheConfig)typeof(Unity.XR.PXR.PXR_Input.CacheConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.XR.PXR.PXR_Input.ChannelFlip @channelFlip = (Unity.XR.PXR.PXR_Input.ChannelFlip)typeof(Unity.XR.PXR.PXR_Input.ChannelFlip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.AudioClip @audioClip = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.SaveVibrateByCache(@audioClip, @vibrateController, @channelFlip, @cacheConfig, ref @sourceId);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @sourceId;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @sourceId);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @sourceId);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @sourceId;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SaveVibrateByCache_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.CacheConfig @cacheConfig = (Unity.XR.PXR.PXR_Input.CacheConfig)typeof(Unity.XR.PXR.PXR_Input.CacheConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.XR.PXR.PXR_Input.ChannelFlip @channelFlip = (Unity.XR.PXR.PXR_Input.ChannelFlip)typeof(Unity.XR.PXR.PXR_Input.ChannelFlip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @channelMask = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @frequency = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @buffersize = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Single[] @data = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.SaveVibrateByCache(@data, @vibrateController, @buffersize, @frequency, @channelMask, @channelFlip, @cacheConfig, ref @sourceId);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @sourceId;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @sourceId);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @sourceId);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @sourceId;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StartVibrateByCache_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.StartVibrateByCache(@sourceId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ClearVibrateByCache_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.ClearVibrateByCache(@sourceId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetControllerEnableKey_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.PxrControllerKeyMap @Key = (Unity.XR.PXR.PxrControllerKeyMap)typeof(Unity.XR.PXR.PxrControllerKeyMap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @isEnable = ptr_of_this_method->Value == 1;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.SetControllerEnableKey(@isEnable, @Key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StartVibrateByPHF_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @amp = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.ChannelFlip @channelFlip = (Unity.XR.PXR.PXR_Input.ChannelFlip)typeof(Unity.XR.PXR.PXR_Input.ChannelFlip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @sourceId = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.TextAsset @phfText = (UnityEngine.TextAsset)typeof(UnityEngine.TextAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = Unity.XR.PXR.PXR_Input.StartVibrateByPHF(@phfText, ref @sourceId, @vibrateController, @channelFlip, @amp);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @sourceId;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @sourceId);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @sourceId;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @sourceId);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @sourceId;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* PauseVibrate_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.PauseVibrate(@sourceId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ResumeVibrate_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sourceId = ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.ResumeVibrate(@sourceId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* UpdateVibrateParams_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @amp = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PXR_Input.ChannelFlip @channelFlip = (Unity.XR.PXR.PXR_Input.ChannelFlip)typeof(Unity.XR.PXR.PXR_Input.ChannelFlip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.XR.PXR.PXR_Input.VibrateController @vibrateController = (Unity.XR.PXR.PXR_Input.VibrateController)typeof(Unity.XR.PXR.PXR_Input.VibrateController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @sourceId = ptr_of_this_method->Value;


            var result_of_this_method = Unity.XR.PXR.PXR_Input.UpdateVibrateParams(@sourceId, @vibrateController, @channelFlip, @amp);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}
