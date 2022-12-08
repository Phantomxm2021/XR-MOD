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
    unsafe class XRBaseControllerInteractor_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor);
            args = new Type[]{};
            method = type.GetMethod("get_selectActionTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectActionTrigger_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor.InputTriggerType)};
            method = type.GetMethod("set_selectActionTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectActionTrigger_1);
            args = new Type[]{};
            method = type.GetMethod("get_hideControllerOnSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hideControllerOnSelect_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hideControllerOnSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hideControllerOnSelect_3);
            args = new Type[]{};
            method = type.GetMethod("get_allowHoveredActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowHoveredActivate_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_allowHoveredActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowHoveredActivate_5);
            args = new Type[]{};
            method = type.GetMethod("get_playAudioClipOnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playAudioClipOnSelectEntered_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playAudioClipOnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playAudioClipOnSelectEntered_7);
            args = new Type[]{};
            method = type.GetMethod("get_audioClipForOnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_audioClipForOnSelectEntered_8);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("set_audioClipForOnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_audioClipForOnSelectEntered_9);
            args = new Type[]{};
            method = type.GetMethod("get_playAudioClipOnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playAudioClipOnSelectExited_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playAudioClipOnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playAudioClipOnSelectExited_11);
            args = new Type[]{};
            method = type.GetMethod("get_audioClipForOnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_audioClipForOnSelectExited_12);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("set_audioClipForOnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_audioClipForOnSelectExited_13);
            args = new Type[]{};
            method = type.GetMethod("get_playAudioClipOnSelectCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playAudioClipOnSelectCanceled_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playAudioClipOnSelectCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playAudioClipOnSelectCanceled_15);
            args = new Type[]{};
            method = type.GetMethod("get_audioClipForOnSelectCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_audioClipForOnSelectCanceled_16);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("set_audioClipForOnSelectCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_audioClipForOnSelectCanceled_17);
            args = new Type[]{};
            method = type.GetMethod("get_playAudioClipOnHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playAudioClipOnHoverEntered_18);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playAudioClipOnHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playAudioClipOnHoverEntered_19);
            args = new Type[]{};
            method = type.GetMethod("get_audioClipForOnHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_audioClipForOnHoverEntered_20);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("set_audioClipForOnHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_audioClipForOnHoverEntered_21);
            args = new Type[]{};
            method = type.GetMethod("get_playAudioClipOnHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playAudioClipOnHoverExited_22);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playAudioClipOnHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playAudioClipOnHoverExited_23);
            args = new Type[]{};
            method = type.GetMethod("get_audioClipForOnHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_audioClipForOnHoverExited_24);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("set_audioClipForOnHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_audioClipForOnHoverExited_25);
            args = new Type[]{};
            method = type.GetMethod("get_playAudioClipOnHoverCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playAudioClipOnHoverCanceled_26);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playAudioClipOnHoverCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playAudioClipOnHoverCanceled_27);
            args = new Type[]{};
            method = type.GetMethod("get_audioClipForOnHoverCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_audioClipForOnHoverCanceled_28);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("set_audioClipForOnHoverCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_audioClipForOnHoverCanceled_29);
            args = new Type[]{};
            method = type.GetMethod("get_playHapticsOnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playHapticsOnSelectEntered_30);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playHapticsOnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playHapticsOnSelectEntered_31);
            args = new Type[]{};
            method = type.GetMethod("get_hapticSelectEnterIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticSelectEnterIntensity_32);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticSelectEnterIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticSelectEnterIntensity_33);
            args = new Type[]{};
            method = type.GetMethod("get_hapticSelectEnterDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticSelectEnterDuration_34);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticSelectEnterDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticSelectEnterDuration_35);
            args = new Type[]{};
            method = type.GetMethod("get_playHapticsOnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playHapticsOnSelectExited_36);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playHapticsOnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playHapticsOnSelectExited_37);
            args = new Type[]{};
            method = type.GetMethod("get_hapticSelectExitIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticSelectExitIntensity_38);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticSelectExitIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticSelectExitIntensity_39);
            args = new Type[]{};
            method = type.GetMethod("get_hapticSelectExitDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticSelectExitDuration_40);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticSelectExitDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticSelectExitDuration_41);
            args = new Type[]{};
            method = type.GetMethod("get_playHapticsOnSelectCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playHapticsOnSelectCanceled_42);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playHapticsOnSelectCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playHapticsOnSelectCanceled_43);
            args = new Type[]{};
            method = type.GetMethod("get_hapticSelectCancelIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticSelectCancelIntensity_44);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticSelectCancelIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticSelectCancelIntensity_45);
            args = new Type[]{};
            method = type.GetMethod("get_hapticSelectCancelDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticSelectCancelDuration_46);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticSelectCancelDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticSelectCancelDuration_47);
            args = new Type[]{};
            method = type.GetMethod("get_playHapticsOnHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playHapticsOnHoverEntered_48);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playHapticsOnHoverEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playHapticsOnHoverEntered_49);
            args = new Type[]{};
            method = type.GetMethod("get_hapticHoverEnterIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticHoverEnterIntensity_50);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticHoverEnterIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticHoverEnterIntensity_51);
            args = new Type[]{};
            method = type.GetMethod("get_hapticHoverEnterDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticHoverEnterDuration_52);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticHoverEnterDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticHoverEnterDuration_53);
            args = new Type[]{};
            method = type.GetMethod("get_playHapticsOnHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playHapticsOnHoverExited_54);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playHapticsOnHoverExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playHapticsOnHoverExited_55);
            args = new Type[]{};
            method = type.GetMethod("get_hapticHoverExitIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticHoverExitIntensity_56);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticHoverExitIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticHoverExitIntensity_57);
            args = new Type[]{};
            method = type.GetMethod("get_hapticHoverExitDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticHoverExitDuration_58);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticHoverExitDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticHoverExitDuration_59);
            args = new Type[]{};
            method = type.GetMethod("get_playHapticsOnHoverCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playHapticsOnHoverCanceled_60);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_playHapticsOnHoverCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playHapticsOnHoverCanceled_61);
            args = new Type[]{};
            method = type.GetMethod("get_hapticHoverCancelIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticHoverCancelIntensity_62);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticHoverCancelIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticHoverCancelIntensity_63);
            args = new Type[]{};
            method = type.GetMethod("get_hapticHoverCancelDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hapticHoverCancelDuration_64);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hapticHoverCancelDuration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hapticHoverCancelDuration_65);
            args = new Type[]{};
            method = type.GetMethod("get_allowActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowActivate_66);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_allowActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowActivate_67);
            args = new Type[]{};
            method = type.GetMethod("get_xrController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_xrController_68);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController)};
            method = type.GetMethod("set_xrController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_xrController_69);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("PreprocessInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PreprocessInteractor_70);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("ProcessInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessInteractor_71);
            args = new Type[]{};
            method = type.GetMethod("get_isSelectActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSelectActive_72);
            args = new Type[]{};
            method = type.GetMethod("get_shouldActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shouldActivate_73);
            args = new Type[]{};
            method = type.GetMethod("get_shouldDeactivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shouldDeactivate_74);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRActivateInteractable>)};
            method = type.GetMethod("GetActivateTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetActivateTargets_75);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SendHapticImpulse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendHapticImpulse_76);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor[s]);


        }


        static StackObject* get_selectActionTrigger_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectActionTrigger;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectActionTrigger_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor.InputTriggerType @value = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor.InputTriggerType)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor.InputTriggerType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectActionTrigger = value;

            return __ret;
        }

        static StackObject* get_hideControllerOnSelect_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hideControllerOnSelect;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hideControllerOnSelect_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hideControllerOnSelect = value;

            return __ret;
        }

        static StackObject* get_allowHoveredActivate_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowHoveredActivate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowHoveredActivate_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowHoveredActivate = value;

            return __ret;
        }

        static StackObject* get_playAudioClipOnSelectEntered_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playAudioClipOnSelectEntered;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playAudioClipOnSelectEntered_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playAudioClipOnSelectEntered = value;

            return __ret;
        }

        static StackObject* get_audioClipForOnSelectEntered_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.audioClipForOnSelectEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_audioClipForOnSelectEntered_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @value = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.audioClipForOnSelectEntered = value;

            return __ret;
        }

        static StackObject* get_playAudioClipOnSelectExited_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playAudioClipOnSelectExited;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playAudioClipOnSelectExited_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playAudioClipOnSelectExited = value;

            return __ret;
        }

        static StackObject* get_audioClipForOnSelectExited_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.audioClipForOnSelectExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_audioClipForOnSelectExited_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @value = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.audioClipForOnSelectExited = value;

            return __ret;
        }

        static StackObject* get_playAudioClipOnSelectCanceled_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playAudioClipOnSelectCanceled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playAudioClipOnSelectCanceled_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playAudioClipOnSelectCanceled = value;

            return __ret;
        }

        static StackObject* get_audioClipForOnSelectCanceled_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.audioClipForOnSelectCanceled;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_audioClipForOnSelectCanceled_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @value = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.audioClipForOnSelectCanceled = value;

            return __ret;
        }

        static StackObject* get_playAudioClipOnHoverEntered_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playAudioClipOnHoverEntered;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playAudioClipOnHoverEntered_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playAudioClipOnHoverEntered = value;

            return __ret;
        }

        static StackObject* get_audioClipForOnHoverEntered_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.audioClipForOnHoverEntered;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_audioClipForOnHoverEntered_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @value = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.audioClipForOnHoverEntered = value;

            return __ret;
        }

        static StackObject* get_playAudioClipOnHoverExited_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playAudioClipOnHoverExited;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playAudioClipOnHoverExited_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playAudioClipOnHoverExited = value;

            return __ret;
        }

        static StackObject* get_audioClipForOnHoverExited_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.audioClipForOnHoverExited;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_audioClipForOnHoverExited_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @value = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.audioClipForOnHoverExited = value;

            return __ret;
        }

        static StackObject* get_playAudioClipOnHoverCanceled_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playAudioClipOnHoverCanceled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playAudioClipOnHoverCanceled_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playAudioClipOnHoverCanceled = value;

            return __ret;
        }

        static StackObject* get_audioClipForOnHoverCanceled_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.audioClipForOnHoverCanceled;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_audioClipForOnHoverCanceled_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @value = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.audioClipForOnHoverCanceled = value;

            return __ret;
        }

        static StackObject* get_playHapticsOnSelectEntered_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playHapticsOnSelectEntered;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playHapticsOnSelectEntered_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playHapticsOnSelectEntered = value;

            return __ret;
        }

        static StackObject* get_hapticSelectEnterIntensity_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticSelectEnterIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticSelectEnterIntensity_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticSelectEnterIntensity = value;

            return __ret;
        }

        static StackObject* get_hapticSelectEnterDuration_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticSelectEnterDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticSelectEnterDuration_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticSelectEnterDuration = value;

            return __ret;
        }

        static StackObject* get_playHapticsOnSelectExited_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playHapticsOnSelectExited;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playHapticsOnSelectExited_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playHapticsOnSelectExited = value;

            return __ret;
        }

        static StackObject* get_hapticSelectExitIntensity_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticSelectExitIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticSelectExitIntensity_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticSelectExitIntensity = value;

            return __ret;
        }

        static StackObject* get_hapticSelectExitDuration_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticSelectExitDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticSelectExitDuration_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticSelectExitDuration = value;

            return __ret;
        }

        static StackObject* get_playHapticsOnSelectCanceled_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playHapticsOnSelectCanceled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playHapticsOnSelectCanceled_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playHapticsOnSelectCanceled = value;

            return __ret;
        }

        static StackObject* get_hapticSelectCancelIntensity_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticSelectCancelIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticSelectCancelIntensity_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticSelectCancelIntensity = value;

            return __ret;
        }

        static StackObject* get_hapticSelectCancelDuration_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticSelectCancelDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticSelectCancelDuration_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticSelectCancelDuration = value;

            return __ret;
        }

        static StackObject* get_playHapticsOnHoverEntered_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playHapticsOnHoverEntered;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playHapticsOnHoverEntered_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playHapticsOnHoverEntered = value;

            return __ret;
        }

        static StackObject* get_hapticHoverEnterIntensity_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticHoverEnterIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticHoverEnterIntensity_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticHoverEnterIntensity = value;

            return __ret;
        }

        static StackObject* get_hapticHoverEnterDuration_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticHoverEnterDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticHoverEnterDuration_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticHoverEnterDuration = value;

            return __ret;
        }

        static StackObject* get_playHapticsOnHoverExited_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playHapticsOnHoverExited;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playHapticsOnHoverExited_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playHapticsOnHoverExited = value;

            return __ret;
        }

        static StackObject* get_hapticHoverExitIntensity_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticHoverExitIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticHoverExitIntensity_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticHoverExitIntensity = value;

            return __ret;
        }

        static StackObject* get_hapticHoverExitDuration_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticHoverExitDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticHoverExitDuration_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticHoverExitDuration = value;

            return __ret;
        }

        static StackObject* get_playHapticsOnHoverCanceled_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playHapticsOnHoverCanceled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_playHapticsOnHoverCanceled_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playHapticsOnHoverCanceled = value;

            return __ret;
        }

        static StackObject* get_hapticHoverCancelIntensity_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticHoverCancelIntensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticHoverCancelIntensity_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticHoverCancelIntensity = value;

            return __ret;
        }

        static StackObject* get_hapticHoverCancelDuration_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hapticHoverCancelDuration;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hapticHoverCancelDuration_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hapticHoverCancelDuration = value;

            return __ret;
        }

        static StackObject* get_allowActivate_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowActivate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowActivate_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowActivate = value;

            return __ret;
        }

        static StackObject* get_xrController_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.xrController;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_xrController_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController @value = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.xrController = value;

            return __ret;
        }

        static StackObject* PreprocessInteractor_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PreprocessInteractor(@updatePhase);

            return __ret;
        }

        static StackObject* ProcessInteractor_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessInteractor(@updatePhase);

            return __ret;
        }

        static StackObject* get_isSelectActive_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isSelectActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_shouldActivate_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shouldActivate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_shouldDeactivate_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shouldDeactivate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetActivateTargets_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRActivateInteractable> @targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRActivateInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRActivateInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetActivateTargets(@targets);

            return __ret;
        }

        static StackObject* SendHapticImpulse_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @duration = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @amplitude = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseControllerInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SendHapticImpulse(@amplitude, @duration);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
