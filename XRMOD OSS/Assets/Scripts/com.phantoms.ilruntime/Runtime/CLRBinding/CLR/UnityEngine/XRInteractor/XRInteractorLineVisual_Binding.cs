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
    unsafe class XRInteractorLineVisual_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual);
            args = new Type[]{};
            method = type.GetMethod("get_lineWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lineWidth_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lineWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lineWidth_1);
            args = new Type[]{};
            method = type.GetMethod("get_overrideInteractorLineLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_overrideInteractorLineLength_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_overrideInteractorLineLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_overrideInteractorLineLength_3);
            args = new Type[]{};
            method = type.GetMethod("get_lineLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lineLength_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lineLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lineLength_5);
            args = new Type[]{};
            method = type.GetMethod("get_widthCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_widthCurve_6);
            args = new Type[]{typeof(UnityEngine.AnimationCurve)};
            method = type.GetMethod("set_widthCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_widthCurve_7);
            args = new Type[]{};
            method = type.GetMethod("get_validColorGradient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_validColorGradient_8);
            args = new Type[]{typeof(UnityEngine.Gradient)};
            method = type.GetMethod("set_validColorGradient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_validColorGradient_9);
            args = new Type[]{};
            method = type.GetMethod("get_invalidColorGradient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_invalidColorGradient_10);
            args = new Type[]{typeof(UnityEngine.Gradient)};
            method = type.GetMethod("set_invalidColorGradient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_invalidColorGradient_11);
            args = new Type[]{};
            method = type.GetMethod("get_smoothMovement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothMovement_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_smoothMovement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothMovement_13);
            args = new Type[]{};
            method = type.GetMethod("get_followTightness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_followTightness_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_followTightness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_followTightness_15);
            args = new Type[]{};
            method = type.GetMethod("get_snapThresholdDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_snapThresholdDistance_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_snapThresholdDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_snapThresholdDistance_17);
            args = new Type[]{};
            method = type.GetMethod("get_reticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reticle_18);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_reticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reticle_19);
            args = new Type[]{};
            method = type.GetMethod("get_stopLineAtFirstRaycastHit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stopLineAtFirstRaycastHit_20);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_stopLineAtFirstRaycastHit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stopLineAtFirstRaycastHit_21);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("AttachCustomReticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AttachCustomReticle_22);
            args = new Type[]{};
            method = type.GetMethod("RemoveCustomReticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveCustomReticle_23);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_lineWidth_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lineWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lineWidth_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lineWidth = value;

            return __ret;
        }

        static StackObject* get_overrideInteractorLineLength_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.overrideInteractorLineLength;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_overrideInteractorLineLength_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.overrideInteractorLineLength = value;

            return __ret;
        }

        static StackObject* get_lineLength_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lineLength;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lineLength_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lineLength = value;

            return __ret;
        }

        static StackObject* get_widthCurve_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.widthCurve;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_widthCurve_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve @value = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.widthCurve = value;

            return __ret;
        }

        static StackObject* get_validColorGradient_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.validColorGradient;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_validColorGradient_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Gradient @value = (UnityEngine.Gradient)typeof(UnityEngine.Gradient).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.validColorGradient = value;

            return __ret;
        }

        static StackObject* get_invalidColorGradient_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.invalidColorGradient;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_invalidColorGradient_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Gradient @value = (UnityEngine.Gradient)typeof(UnityEngine.Gradient).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.invalidColorGradient = value;

            return __ret;
        }

        static StackObject* get_smoothMovement_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothMovement;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_smoothMovement_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothMovement = value;

            return __ret;
        }

        static StackObject* get_followTightness_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.followTightness;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_followTightness_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.followTightness = value;

            return __ret;
        }

        static StackObject* get_snapThresholdDistance_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.snapThresholdDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_snapThresholdDistance_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.snapThresholdDistance = value;

            return __ret;
        }

        static StackObject* get_reticle_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reticle;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_reticle_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reticle = value;

            return __ret;
        }

        static StackObject* get_stopLineAtFirstRaycastHit_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stopLineAtFirstRaycastHit;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_stopLineAtFirstRaycastHit_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stopLineAtFirstRaycastHit = value;

            return __ret;
        }

        static StackObject* AttachCustomReticle_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @reticleInstance = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AttachCustomReticle(@reticleInstance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RemoveCustomReticle_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RemoveCustomReticle();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.XRInteractorLineVisual();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
