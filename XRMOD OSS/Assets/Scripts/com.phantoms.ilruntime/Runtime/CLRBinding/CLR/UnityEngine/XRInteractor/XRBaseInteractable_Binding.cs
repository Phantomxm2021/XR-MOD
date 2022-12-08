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
    unsafe class XRBaseInteractable_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)};
            method = type.GetMethod("add_registered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_registered_0);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)};
            method = type.GetMethod("remove_registered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_registered_1);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)};
            method = type.GetMethod("add_unregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_unregistered_2);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)};
            method = type.GetMethod("remove_unregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_unregistered_3);
            args = new Type[]{};
            method = type.GetMethod("get_getDistanceOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_getDistanceOverride_4);
            args = new Type[]{typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.IXRInteractable, UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>)};
            method = type.GetMethod("set_getDistanceOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_getDistanceOverride_5);
            args = new Type[]{};
            method = type.GetMethod("get_interactionManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionManager_6);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)};
            method = type.GetMethod("set_interactionManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionManager_7);
            args = new Type[]{};
            method = type.GetMethod("get_colliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colliders_8);
            args = new Type[]{};
            method = type.GetMethod("get_interactionLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionLayers_9);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask)};
            method = type.GetMethod("set_interactionLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionLayers_10);
            args = new Type[]{};
            method = type.GetMethod("get_distanceCalculationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_distanceCalculationMode_11);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.DistanceCalculationMode)};
            method = type.GetMethod("set_distanceCalculationMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_distanceCalculationMode_12);
            args = new Type[]{};
            method = type.GetMethod("get_selectMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectMode_13);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InteractableSelectMode)};
            method = type.GetMethod("set_selectMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectMode_14);
            args = new Type[]{};
            method = type.GetMethod("get_customReticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customReticle_15);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_customReticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_customReticle_16);
            args = new Type[]{};
            method = type.GetMethod("get_firstHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_firstHoverEntered_17);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)};
            method = type.GetMethod("set_firstHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_firstHoverEntered_18);
            args = new Type[]{};
            method = type.GetMethod("get_lastHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lastHoverExited_19);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)};
            method = type.GetMethod("set_lastHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lastHoverExited_20);
            args = new Type[]{};
            method = type.GetMethod("get_hoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hoverEntered_21);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)};
            method = type.GetMethod("set_hoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hoverEntered_22);
            args = new Type[]{};
            method = type.GetMethod("get_hoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hoverExited_23);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)};
            method = type.GetMethod("set_hoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hoverExited_24);
            args = new Type[]{};
            method = type.GetMethod("get_firstSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_firstSelectEntered_25);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)};
            method = type.GetMethod("set_firstSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_firstSelectEntered_26);
            args = new Type[]{};
            method = type.GetMethod("get_lastSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lastSelectExited_27);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)};
            method = type.GetMethod("set_lastSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lastSelectExited_28);
            args = new Type[]{};
            method = type.GetMethod("get_selectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectEntered_29);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)};
            method = type.GetMethod("set_selectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectEntered_30);
            args = new Type[]{};
            method = type.GetMethod("get_selectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectExited_31);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)};
            method = type.GetMethod("set_selectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectExited_32);
            args = new Type[]{};
            method = type.GetMethod("get_activated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activated_33);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.ActivateEvent)};
            method = type.GetMethod("set_activated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_activated_34);
            args = new Type[]{};
            method = type.GetMethod("get_deactivated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deactivated_35);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.DeactivateEvent)};
            method = type.GetMethod("set_deactivated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_deactivated_36);
            args = new Type[]{};
            method = type.GetMethod("get_interactorsHovering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactorsHovering_37);
            args = new Type[]{};
            method = type.GetMethod("get_isHovered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isHovered_38);
            args = new Type[]{};
            method = type.GetMethod("get_interactorsSelecting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactorsSelecting_39);
            args = new Type[]{};
            method = type.GetMethod("get_firstInteractorSelecting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_firstInteractorSelecting_40);
            args = new Type[]{};
            method = type.GetMethod("get_isSelected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSelected_41);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("GetAttachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachTransform_42);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)};
            method = type.GetMethod("GetAttachPoseOnSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachPoseOnSelect_43);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)};
            method = type.GetMethod("GetLocalAttachPoseOnSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalAttachPoseOnSelect_44);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("GetDistanceSqrToInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDistanceSqrToInteractor_45);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("GetDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDistance_46);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)};
            method = type.GetMethod("IsHoverableBy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsHoverableBy_47);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)};
            method = type.GetMethod("IsSelectableBy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSelectableBy_48);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("AttachCustomReticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AttachCustomReticle_49);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("RemoveCustomReticle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveCustomReticle_50);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("ProcessInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessInteractable_51);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable[s]);


        }


        static StackObject* add_registered_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.registered += value;

            return __ret;
        }

        static StackObject* remove_registered_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.registered -= value;

            return __ret;
        }

        static StackObject* add_unregistered_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.unregistered += value;

            return __ret;
        }

        static StackObject* remove_unregistered_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.unregistered -= value;

            return __ret;
        }

        static StackObject* get_getDistanceOverride_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.getDistanceOverride;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_getDistanceOverride_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<UnityEngine.XR.Interaction.Toolkit.IXRInteractable, UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo> @value = (System.Func<UnityEngine.XR.Interaction.Toolkit.IXRInteractable, UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>)typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.IXRInteractable, UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.getDistanceOverride = value;

            return __ret;
        }

        static StackObject* get_interactionManager_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactionManager_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager @value = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionManager = value;

            return __ret;
        }

        static StackObject* get_colliders_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colliders;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_interactionLayers_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionLayers;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactionLayers_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask @value = (UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask)typeof(UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionLayers = value;

            return __ret;
        }

        static StackObject* get_distanceCalculationMode_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.distanceCalculationMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_distanceCalculationMode_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.DistanceCalculationMode @value = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.DistanceCalculationMode)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.DistanceCalculationMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.distanceCalculationMode = value;

            return __ret;
        }

        static StackObject* get_selectMode_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectMode_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InteractableSelectMode @value = (UnityEngine.XR.Interaction.Toolkit.InteractableSelectMode)typeof(UnityEngine.XR.Interaction.Toolkit.InteractableSelectMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectMode = value;

            return __ret;
        }

        static StackObject* get_customReticle_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customReticle;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_customReticle_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.customReticle = value;

            return __ret;
        }

        static StackObject* get_firstHoverEntered_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.firstHoverEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_firstHoverEntered_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent @value = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.firstHoverEntered = value;

            return __ret;
        }

        static StackObject* get_lastHoverExited_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lastHoverExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lastHoverExited_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.HoverExitEvent @value = (UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lastHoverExited = value;

            return __ret;
        }

        static StackObject* get_hoverEntered_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hoverEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_hoverEntered_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent @value = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hoverEntered = value;

            return __ret;
        }

        static StackObject* get_hoverExited_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hoverExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_hoverExited_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.HoverExitEvent @value = (UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hoverExited = value;

            return __ret;
        }

        static StackObject* get_firstSelectEntered_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.firstSelectEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_firstSelectEntered_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent @value = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.firstSelectEntered = value;

            return __ret;
        }

        static StackObject* get_lastSelectExited_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lastSelectExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lastSelectExited_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectExitEvent @value = (UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lastSelectExited = value;

            return __ret;
        }

        static StackObject* get_selectEntered_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectEntered_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent @value = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectEntered = value;

            return __ret;
        }

        static StackObject* get_selectExited_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectExited_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectExitEvent @value = (UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectExited = value;

            return __ret;
        }

        static StackObject* get_activated_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.activated;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_activated_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.ActivateEvent @value = (UnityEngine.XR.Interaction.Toolkit.ActivateEvent)typeof(UnityEngine.XR.Interaction.Toolkit.ActivateEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.activated = value;

            return __ret;
        }

        static StackObject* get_deactivated_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.deactivated;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_deactivated_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.DeactivateEvent @value = (UnityEngine.XR.Interaction.Toolkit.DeactivateEvent)typeof(UnityEngine.XR.Interaction.Toolkit.DeactivateEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.deactivated = value;

            return __ret;
        }

        static StackObject* get_interactorsHovering_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactorsHovering;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isHovered_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isHovered;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_interactorsSelecting_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactorsSelecting;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_firstInteractorSelecting_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.firstInteractorSelecting;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isSelected_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isSelected;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetAttachTransform_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachTransform(@interactor);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAttachPoseOnSelect_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachPoseOnSelect(@interactor);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLocalAttachPoseOnSelect_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalAttachPoseOnSelect(@interactor);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDistanceSqrToInteractor_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDistanceSqrToInteractor(@interactor);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetDistance_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDistance(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsHoverableBy_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsHoverableBy(@interactor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsSelectableBy_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSelectableBy(@interactor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* AttachCustomReticle_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AttachCustomReticle(@interactor);

            return __ret;
        }

        static StackObject* RemoveCustomReticle_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveCustomReticle(@interactor);

            return __ret;
        }

        static StackObject* ProcessInteractable_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessInteractable(@updatePhase);

            return __ret;
        }





    }
}
