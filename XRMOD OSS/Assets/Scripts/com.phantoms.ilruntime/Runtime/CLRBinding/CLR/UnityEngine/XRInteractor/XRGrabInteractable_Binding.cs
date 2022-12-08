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
    unsafe class XRGrabInteractable_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable);
            args = new Type[]{};
            method = type.GetMethod("get_attachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_attachTransform_0);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_attachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_attachTransform_1);
            args = new Type[]{};
            method = type.GetMethod("get_useDynamicAttach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useDynamicAttach_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useDynamicAttach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useDynamicAttach_3);
            args = new Type[]{};
            method = type.GetMethod("get_matchAttachPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_matchAttachPosition_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_matchAttachPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_matchAttachPosition_5);
            args = new Type[]{};
            method = type.GetMethod("get_matchAttachRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_matchAttachRotation_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_matchAttachRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_matchAttachRotation_7);
            args = new Type[]{};
            method = type.GetMethod("get_snapToColliderVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_snapToColliderVolume_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_snapToColliderVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_snapToColliderVolume_9);
            args = new Type[]{};
            method = type.GetMethod("get_attachEaseInTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_attachEaseInTime_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_attachEaseInTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_attachEaseInTime_11);
            args = new Type[]{};
            method = type.GetMethod("get_movementType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_movementType_12);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType)};
            method = type.GetMethod("set_movementType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_movementType_13);
            args = new Type[]{};
            method = type.GetMethod("get_velocityDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityDamping_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_velocityDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocityDamping_15);
            args = new Type[]{};
            method = type.GetMethod("get_velocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityScale_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_velocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocityScale_17);
            args = new Type[]{};
            method = type.GetMethod("get_angularVelocityDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularVelocityDamping_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularVelocityDamping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularVelocityDamping_19);
            args = new Type[]{};
            method = type.GetMethod("get_angularVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularVelocityScale_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularVelocityScale_21);
            args = new Type[]{};
            method = type.GetMethod("get_trackPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackPosition_22);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_trackPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackPosition_23);
            args = new Type[]{};
            method = type.GetMethod("get_smoothPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothPosition_24);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_smoothPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothPosition_25);
            args = new Type[]{};
            method = type.GetMethod("get_smoothPositionAmount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothPositionAmount_26);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_smoothPositionAmount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothPositionAmount_27);
            args = new Type[]{};
            method = type.GetMethod("get_tightenPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tightenPosition_28);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_tightenPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tightenPosition_29);
            args = new Type[]{};
            method = type.GetMethod("get_trackRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trackRotation_30);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_trackRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trackRotation_31);
            args = new Type[]{};
            method = type.GetMethod("get_smoothRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothRotation_32);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_smoothRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothRotation_33);
            args = new Type[]{};
            method = type.GetMethod("get_smoothRotationAmount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothRotationAmount_34);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_smoothRotationAmount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothRotationAmount_35);
            args = new Type[]{};
            method = type.GetMethod("get_tightenRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tightenRotation_36);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_tightenRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tightenRotation_37);
            args = new Type[]{};
            method = type.GetMethod("get_throwOnDetach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_throwOnDetach_38);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_throwOnDetach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_throwOnDetach_39);
            args = new Type[]{};
            method = type.GetMethod("get_throwSmoothingDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_throwSmoothingDuration_40);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_throwSmoothingDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_throwSmoothingDuration_41);
            args = new Type[]{};
            method = type.GetMethod("get_throwSmoothingCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_throwSmoothingCurve_42);
            args = new Type[]{typeof(UnityEngine.AnimationCurve)};
            method = type.GetMethod("set_throwSmoothingCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_throwSmoothingCurve_43);
            args = new Type[]{};
            method = type.GetMethod("get_throwVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_throwVelocityScale_44);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_throwVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_throwVelocityScale_45);
            args = new Type[]{};
            method = type.GetMethod("get_throwAngularVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_throwAngularVelocityScale_46);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_throwAngularVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_throwAngularVelocityScale_47);
            args = new Type[]{};
            method = type.GetMethod("get_forceGravityOnDetach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceGravityOnDetach_48);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_forceGravityOnDetach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceGravityOnDetach_49);
            args = new Type[]{};
            method = type.GetMethod("get_retainTransformParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_retainTransformParent_50);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_retainTransformParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_retainTransformParent_51);
            args = new Type[]{};
            method = type.GetMethod("get_attachPointCompatibilityMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_attachPointCompatibilityMode_52);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.AttachPointCompatibilityMode)};
            method = type.GetMethod("set_attachPointCompatibilityMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_attachPointCompatibilityMode_53);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("ProcessInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessInteractable_54);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("GetAttachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachTransform_55);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_attachTransform_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.attachTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_attachTransform_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.attachTransform = value;

            return __ret;
        }

        static StackObject* get_useDynamicAttach_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useDynamicAttach;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useDynamicAttach_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useDynamicAttach = value;

            return __ret;
        }

        static StackObject* get_matchAttachPosition_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.matchAttachPosition;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_matchAttachPosition_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.matchAttachPosition = value;

            return __ret;
        }

        static StackObject* get_matchAttachRotation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.matchAttachRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_matchAttachRotation_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.matchAttachRotation = value;

            return __ret;
        }

        static StackObject* get_snapToColliderVolume_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.snapToColliderVolume;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_snapToColliderVolume_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.snapToColliderVolume = value;

            return __ret;
        }

        static StackObject* get_attachEaseInTime_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.attachEaseInTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_attachEaseInTime_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.attachEaseInTime = value;

            return __ret;
        }

        static StackObject* get_movementType_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.movementType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_movementType_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType @value = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.movementType = value;

            return __ret;
        }

        static StackObject* get_velocityDamping_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocityDamping;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_velocityDamping_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocityDamping = value;

            return __ret;
        }

        static StackObject* get_velocityScale_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_velocityScale_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocityScale = value;

            return __ret;
        }

        static StackObject* get_angularVelocityDamping_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularVelocityDamping;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularVelocityDamping_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularVelocityDamping = value;

            return __ret;
        }

        static StackObject* get_angularVelocityScale_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularVelocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularVelocityScale_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularVelocityScale = value;

            return __ret;
        }

        static StackObject* get_trackPosition_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackPosition;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_trackPosition_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackPosition = value;

            return __ret;
        }

        static StackObject* get_smoothPosition_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothPosition;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_smoothPosition_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothPosition = value;

            return __ret;
        }

        static StackObject* get_smoothPositionAmount_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothPositionAmount;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_smoothPositionAmount_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothPositionAmount = value;

            return __ret;
        }

        static StackObject* get_tightenPosition_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tightenPosition;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_tightenPosition_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tightenPosition = value;

            return __ret;
        }

        static StackObject* get_trackRotation_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trackRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_trackRotation_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trackRotation = value;

            return __ret;
        }

        static StackObject* get_smoothRotation_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_smoothRotation_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothRotation = value;

            return __ret;
        }

        static StackObject* get_smoothRotationAmount_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothRotationAmount;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_smoothRotationAmount_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothRotationAmount = value;

            return __ret;
        }

        static StackObject* get_tightenRotation_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tightenRotation;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_tightenRotation_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tightenRotation = value;

            return __ret;
        }

        static StackObject* get_throwOnDetach_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.throwOnDetach;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_throwOnDetach_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.throwOnDetach = value;

            return __ret;
        }

        static StackObject* get_throwSmoothingDuration_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.throwSmoothingDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_throwSmoothingDuration_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.throwSmoothingDuration = value;

            return __ret;
        }

        static StackObject* get_throwSmoothingCurve_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.throwSmoothingCurve;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_throwSmoothingCurve_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve @value = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.throwSmoothingCurve = value;

            return __ret;
        }

        static StackObject* get_throwVelocityScale_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.throwVelocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_throwVelocityScale_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.throwVelocityScale = value;

            return __ret;
        }

        static StackObject* get_throwAngularVelocityScale_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.throwAngularVelocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_throwAngularVelocityScale_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.throwAngularVelocityScale = value;

            return __ret;
        }

        static StackObject* get_forceGravityOnDetach_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceGravityOnDetach;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_forceGravityOnDetach_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceGravityOnDetach = value;

            return __ret;
        }

        static StackObject* get_retainTransformParent_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.retainTransformParent;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_retainTransformParent_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.retainTransformParent = value;

            return __ret;
        }

        static StackObject* get_attachPointCompatibilityMode_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.attachPointCompatibilityMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_attachPointCompatibilityMode_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.AttachPointCompatibilityMode @value = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.AttachPointCompatibilityMode)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable.AttachPointCompatibilityMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.attachPointCompatibilityMode = value;

            return __ret;
        }

        static StackObject* ProcessInteractable_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessInteractable(@updatePhase);

            return __ret;
        }

        static StackObject* GetAttachTransform_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachTransform(@interactor);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
