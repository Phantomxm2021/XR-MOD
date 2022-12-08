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
    unsafe class ARTranslationInteractable_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable);
            args = new Type[]{};
            method = type.GetMethod("get_objectGestureTranslationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_objectGestureTranslationMode_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.AR.GestureTransformationUtility.GestureTranslationMode)};
            method = type.GetMethod("set_objectGestureTranslationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_objectGestureTranslationMode_1);
            args = new Type[]{};
            method = type.GetMethod("get_maxTranslationDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxTranslationDistance_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxTranslationDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxTranslationDistance_3);
            args = new Type[]{};
            method = type.GetMethod("get_fallbackLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fallbackLayerMask_4);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_fallbackLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fallbackLayerMask_5);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("ProcessInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessInteractable_6);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_objectGestureTranslationMode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.objectGestureTranslationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_objectGestureTranslationMode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.AR.GestureTransformationUtility.GestureTranslationMode @value = (UnityEngine.XR.Interaction.Toolkit.AR.GestureTransformationUtility.GestureTranslationMode)typeof(UnityEngine.XR.Interaction.Toolkit.AR.GestureTransformationUtility.GestureTranslationMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.objectGestureTranslationMode = value;

            return __ret;
        }

        static StackObject* get_maxTranslationDistance_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxTranslationDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxTranslationDistance_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxTranslationDistance = value;

            return __ret;
        }

        static StackObject* get_fallbackLayerMask_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fallbackLayerMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_fallbackLayerMask_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fallbackLayerMask = value;

            return __ret;
        }

        static StackObject* ProcessInteractable_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessInteractable(@updatePhase);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.AR.ARTranslationInteractable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
