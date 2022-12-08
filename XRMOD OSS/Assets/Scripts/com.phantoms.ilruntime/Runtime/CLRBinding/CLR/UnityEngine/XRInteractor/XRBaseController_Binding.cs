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
    unsafe class XRBaseController_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController);
            args = new Type[]{};
            method = type.GetMethod("get_updateTrackingType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateTrackingType_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController.UpdateType)};
            method = type.GetMethod("set_updateTrackingType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateTrackingType_1);
            args = new Type[]{};
            method = type.GetMethod("get_enableInputTracking", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableInputTracking_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableInputTracking", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableInputTracking_3);
            args = new Type[]{};
            method = type.GetMethod("get_enableInputActions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableInputActions_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableInputActions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableInputActions_5);
            args = new Type[]{};
            method = type.GetMethod("get_modelPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_modelPrefab_6);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_modelPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_modelPrefab_7);
            args = new Type[]{};
            method = type.GetMethod("get_modelParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_modelParent_8);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_modelParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_modelParent_9);
            args = new Type[]{};
            method = type.GetMethod("get_model", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_model_10);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_model", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_model_11);
            args = new Type[]{};
            method = type.GetMethod("get_animateModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_animateModel_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_animateModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_animateModel_13);
            args = new Type[]{};
            method = type.GetMethod("get_modelSelectTransition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_modelSelectTransition_14);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_modelSelectTransition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_modelSelectTransition_15);
            args = new Type[]{};
            method = type.GetMethod("get_modelDeSelectTransition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_modelDeSelectTransition_16);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_modelDeSelectTransition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_modelDeSelectTransition_17);
            args = new Type[]{};
            method = type.GetMethod("get_hideControllerModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hideControllerModel_18);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hideControllerModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hideControllerModel_19);
            args = new Type[]{};
            method = type.GetMethod("get_selectInteractionState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectInteractionState_20);
            args = new Type[]{};
            method = type.GetMethod("get_activateInteractionState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activateInteractionState_21);
            args = new Type[]{};
            method = type.GetMethod("get_uiPressInteractionState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uiPressInteractionState_22);
            args = new Type[]{};
            method = type.GetMethod("get_currentControllerState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentControllerState_23);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRControllerState)};
            method = type.GetMethod("set_currentControllerState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_currentControllerState_24);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SendHapticImpulse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendHapticImpulse_25);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRBaseController[s]);


        }


        static StackObject* get_updateTrackingType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.updateTrackingType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_updateTrackingType_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController.UpdateType @value = (UnityEngine.XR.Interaction.Toolkit.XRBaseController.UpdateType)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController.UpdateType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.updateTrackingType = value;

            return __ret;
        }

        static StackObject* get_enableInputTracking_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enableInputTracking;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableInputTracking_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enableInputTracking = value;

            return __ret;
        }

        static StackObject* get_enableInputActions_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enableInputActions;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableInputActions_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enableInputActions = value;

            return __ret;
        }

        static StackObject* get_modelPrefab_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.modelPrefab;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_modelPrefab_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.modelPrefab = value;

            return __ret;
        }

        static StackObject* get_modelParent_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.modelParent;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_modelParent_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.modelParent = value;

            return __ret;
        }

        static StackObject* get_model_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.model;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_model_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.model = value;

            return __ret;
        }

        static StackObject* get_animateModel_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.animateModel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_animateModel_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.animateModel = value;

            return __ret;
        }

        static StackObject* get_modelSelectTransition_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.modelSelectTransition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_modelSelectTransition_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.modelSelectTransition = value;

            return __ret;
        }

        static StackObject* get_modelDeSelectTransition_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.modelDeSelectTransition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_modelDeSelectTransition_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.modelDeSelectTransition = value;

            return __ret;
        }

        static StackObject* get_hideControllerModel_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hideControllerModel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hideControllerModel_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hideControllerModel = value;

            return __ret;
        }

        static StackObject* get_selectInteractionState_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectInteractionState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activateInteractionState_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.activateInteractionState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_uiPressInteractionState_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uiPressInteractionState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_currentControllerState_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentControllerState;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_currentControllerState_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRControllerState @value = (UnityEngine.XR.Interaction.Toolkit.XRControllerState)typeof(UnityEngine.XR.Interaction.Toolkit.XRControllerState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.currentControllerState = value;

            return __ret;
        }

        static StackObject* SendHapticImpulse_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @duration = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @amplitude = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRBaseController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRBaseController)typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SendHapticImpulse(@amplitude, @duration);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
