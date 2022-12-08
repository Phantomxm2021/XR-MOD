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
    unsafe class XRSocketInteractor_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor);
            args = new Type[]{};
            method = type.GetMethod("get_showInteractableHoverMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_showInteractableHoverMeshes_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_showInteractableHoverMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_showInteractableHoverMeshes_1);
            args = new Type[]{};
            method = type.GetMethod("get_interactableHoverMeshMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactableHoverMeshMaterial_2);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_interactableHoverMeshMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactableHoverMeshMaterial_3);
            args = new Type[]{};
            method = type.GetMethod("get_interactableCantHoverMeshMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactableCantHoverMeshMaterial_4);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_interactableCantHoverMeshMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactableCantHoverMeshMaterial_5);
            args = new Type[]{};
            method = type.GetMethod("get_socketActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_socketActive_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_socketActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_socketActive_7);
            args = new Type[]{};
            method = type.GetMethod("get_interactableHoverScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactableHoverScale_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_interactableHoverScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactableHoverScale_9);
            args = new Type[]{};
            method = type.GetMethod("get_recycleDelayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_recycleDelayTime_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_recycleDelayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_recycleDelayTime_11);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)};
            method = type.GetMethod("ProcessInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessInteractor_12);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)};
            method = type.GetMethod("GetValidTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetValidTargets_13);
            args = new Type[]{};
            method = type.GetMethod("get_isHoverActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isHoverActive_14);
            args = new Type[]{};
            method = type.GetMethod("get_isSelectActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSelectActive_15);
            args = new Type[]{};
            method = type.GetMethod("get_selectedInteractableMovementTypeOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectedInteractableMovementTypeOverride_16);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("CanHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanHover_17);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("CanSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanSelect_18);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_showInteractableHoverMeshes_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.showInteractableHoverMeshes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_showInteractableHoverMeshes_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.showInteractableHoverMeshes = value;

            return __ret;
        }

        static StackObject* get_interactableHoverMeshMaterial_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactableHoverMeshMaterial;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactableHoverMeshMaterial_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableHoverMeshMaterial = value;

            return __ret;
        }

        static StackObject* get_interactableCantHoverMeshMaterial_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactableCantHoverMeshMaterial;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interactableCantHoverMeshMaterial_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableCantHoverMeshMaterial = value;

            return __ret;
        }

        static StackObject* get_socketActive_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.socketActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_socketActive_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.socketActive = value;

            return __ret;
        }

        static StackObject* get_interactableHoverScale_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactableHoverScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_interactableHoverScale_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableHoverScale = value;

            return __ret;
        }

        static StackObject* get_recycleDelayTime_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.recycleDelayTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_recycleDelayTime_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.recycleDelayTime = value;

            return __ret;
        }

        static StackObject* ProcessInteractor_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase @updatePhase = (UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessInteractor(@updatePhase);

            return __ret;
        }

        static StackObject* GetValidTargets_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> @targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetValidTargets(@targets);

            return __ret;
        }

        static StackObject* get_isHoverActive_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isHoverActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isSelectActive_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isSelectActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_selectedInteractableMovementTypeOverride_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectedInteractableMovementTypeOverride;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CanHover_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanHover(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanSelect_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanSelect(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
