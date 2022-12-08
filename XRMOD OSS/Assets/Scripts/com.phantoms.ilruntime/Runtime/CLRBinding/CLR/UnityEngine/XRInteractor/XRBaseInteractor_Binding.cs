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
    unsafe class XRBaseInteractor_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)};
            method = type.GetMethod("add_registered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_registered_0);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)};
            method = type.GetMethod("remove_registered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_registered_1);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)};
            method = type.GetMethod("add_unregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_unregistered_2);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)};
            method = type.GetMethod("remove_unregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_unregistered_3);
            args = new Type[]{};
            method = type.GetMethod("get_interactionManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionManager_4);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)};
            method = type.GetMethod("set_interactionManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionManager_5);
            args = new Type[]{};
            method = type.GetMethod("get_interactionLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionLayers_6);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask)};
            method = type.GetMethod("set_interactionLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionLayers_7);
            args = new Type[]{};
            method = type.GetMethod("get_attachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_attachTransform_8);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_attachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_attachTransform_9);
            args = new Type[]{};
            method = type.GetMethod("get_keepSelectedTargetValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_keepSelectedTargetValid_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_keepSelectedTargetValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_keepSelectedTargetValid_11);
            args = new Type[]{};
            method = type.GetMethod("get_startingSelectedInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startingSelectedInteractable_12);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)};
            method = type.GetMethod("set_startingSelectedInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startingSelectedInteractable_13);
            args = new Type[]{};
            method = type.GetMethod("get_startingTargetFilter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startingTargetFilter_14);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)};
            method = type.GetMethod("set_startingTargetFilter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startingTargetFilter_15);
            args = new Type[]{};
            method = type.GetMethod("get_hoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hoverEntered_16);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)};
            method = type.GetMethod("set_hoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hoverEntered_17);
            args = new Type[]{};
            method = type.GetMethod("get_hoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hoverExited_18);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)};
            method = type.GetMethod("set_hoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hoverExited_19);
            args = new Type[]{};
            method = type.GetMethod("get_selectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectEntered_20);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)};
            method = type.GetMethod("set_selectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectEntered_21);
            args = new Type[]{};
            method = type.GetMethod("get_selectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectExited_22);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)};
            method = type.GetMethod("set_selectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectExited_23);
            args = new Type[]{};
            method = type.GetMethod("get_targetFilter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetFilter_24);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.IXRTargetFilter)};
            method = type.GetMethod("set_targetFilter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetFilter_25);
            args = new Type[]{};
            method = type.GetMethod("get_allowHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowHover_26);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_allowHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowHover_27);
            args = new Type[]{};
            method = type.GetMethod("get_allowSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowSelect_28);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_allowSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowSelect_29);
            args = new Type[]{};
            method = type.GetMethod("get_isPerformingManualInteraction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPerformingManualInteraction_30);
            args = new Type[]{};
            method = type.GetMethod("get_interactablesHovered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactablesHovered_31);
            args = new Type[]{};
            method = type.GetMethod("get_hasHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasHover_32);
            args = new Type[]{};
            method = type.GetMethod("get_interactablesSelected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactablesSelected_33);
            args = new Type[]{};
            method = type.GetMethod("get_firstInteractableSelected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_firstInteractableSelected_34);
            args = new Type[]{};
            method = type.GetMethod("get_hasSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasSelection_35);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable)};
            method = type.GetMethod("GetAttachTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachTransform_36);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("GetAttachPoseOnSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachPoseOnSelect_37);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("GetLocalAttachPoseOnSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalAttachPoseOnSelect_38);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)};
            method = type.GetMethod("GetValidTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetValidTargets_39);
            args = new Type[]{};
            method = type.GetMethod("get_isHoverActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isHoverActive_40);
            args = new Type[]{};
            method = type.GetMethod("get_isSelectActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSelectActive_41);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("CanHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanHover_42);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("CanSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanSelect_43);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("IsHovering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsHovering_44);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("IsSelecting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSelecting_45);
            args = new Type[]{};
            method = type.GetMethod("get_selectedInteractableMovementTypeOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectedInteractableMovementTypeOverride_46);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("PreprocessInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PreprocessInteractor_47);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("ProcessInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessInteractor_48);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("StartManualInteraction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartManualInteraction_49);
            args = new Type[]{};
            method = type.GetMethod("EndManualInteraction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndManualInteraction_50);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor[s]);


        }


        static StackObject* add_registered_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.unregistered -= value;

            return __ret;
        }

        static StackObject* get_interactionManager_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactionManager_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager @value = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionManager = value;

            return __ret;
        }

        static StackObject* get_interactionLayers_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionLayers;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactionLayers_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask @value = (UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask)typeof(UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionLayers = value;

            return __ret;
        }

        static StackObject* get_attachTransform_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.attachTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_attachTransform_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.attachTransform = value;

            return __ret;
        }

        static StackObject* get_keepSelectedTargetValid_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.keepSelectedTargetValid;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_keepSelectedTargetValid_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.keepSelectedTargetValid = value;

            return __ret;
        }

        static StackObject* get_startingSelectedInteractable_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startingSelectedInteractable;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startingSelectedInteractable_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable @value = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startingSelectedInteractable = value;

            return __ret;
        }

        static StackObject* get_startingTargetFilter_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startingTargetFilter;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startingTargetFilter_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter @value = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startingTargetFilter = value;

            return __ret;
        }

        static StackObject* get_hoverEntered_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hoverEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_hoverEntered_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent @value = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hoverEntered = value;

            return __ret;
        }

        static StackObject* get_hoverExited_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hoverExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_hoverExited_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.HoverExitEvent @value = (UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hoverExited = value;

            return __ret;
        }

        static StackObject* get_selectEntered_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectEntered_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent @value = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectEntered = value;

            return __ret;
        }

        static StackObject* get_selectExited_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectExited_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectExitEvent @value = (UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectExited = value;

            return __ret;
        }

        static StackObject* get_targetFilter_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetFilter;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_targetFilter_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Filtering.IXRTargetFilter @value = (UnityEngine.XR.Interaction.Toolkit.Filtering.IXRTargetFilter)typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.IXRTargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.targetFilter = value;

            return __ret;
        }

        static StackObject* get_allowHover_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowHover;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowHover_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowHover = value;

            return __ret;
        }

        static StackObject* get_allowSelect_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowSelect;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowSelect_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowSelect = value;

            return __ret;
        }

        static StackObject* get_isPerformingManualInteraction_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isPerformingManualInteraction;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_interactablesHovered_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactablesHovered;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasHover_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasHover;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_interactablesSelected_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactablesSelected;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_firstInteractableSelected_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.firstInteractableSelected;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasSelection_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasSelection;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetAttachTransform_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachTransform(@interactable);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAttachPoseOnSelect_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachPoseOnSelect(@interactable);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLocalAttachPoseOnSelect_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalAttachPoseOnSelect(@interactable);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetValidTargets_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> @targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetValidTargets(@targets);

            return __ret;
        }

        static StackObject* get_isHoverActive_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isHoverActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isSelectActive_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isSelectActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanHover_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanHover(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanSelect_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanSelect(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsHovering_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsHovering(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsSelecting_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSelecting(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_selectedInteractableMovementTypeOverride_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectedInteractableMovementTypeOverride;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* PreprocessInteractor_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PreprocessInteractor(@updatePhase);

            return __ret;
        }

        static StackObject* ProcessInteractor_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessInteractor(@updatePhase);

            return __ret;
        }

        static StackObject* StartManualInteraction_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartManualInteraction(@interactable);

            return __ret;
        }

        static StackObject* EndManualInteraction_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EndManualInteraction();

            return __ret;
        }





    }
}
