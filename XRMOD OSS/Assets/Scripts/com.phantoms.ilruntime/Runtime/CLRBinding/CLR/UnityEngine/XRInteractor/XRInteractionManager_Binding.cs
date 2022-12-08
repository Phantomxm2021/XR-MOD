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
    unsafe class XRInteractionManager_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)};
            method = type.GetMethod("add_interactorRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_interactorRegistered_0);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)};
            method = type.GetMethod("remove_interactorRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_interactorRegistered_1);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)};
            method = type.GetMethod("add_interactorUnregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_interactorUnregistered_2);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)};
            method = type.GetMethod("remove_interactorUnregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_interactorUnregistered_3);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)};
            method = type.GetMethod("add_interactableRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_interactableRegistered_4);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)};
            method = type.GetMethod("remove_interactableRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_interactableRegistered_5);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)};
            method = type.GetMethod("add_interactableUnregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_interactableUnregistered_6);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)};
            method = type.GetMethod("remove_interactableUnregistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_interactableUnregistered_7);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("RegisterInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterInteractor_8);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("UnregisterInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnregisterInteractor_9);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable)};
            method = type.GetMethod("RegisterInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterInteractable_10);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable)};
            method = type.GetMethod("UnregisterInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnregisterInteractable_11);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>)};
            method = type.GetMethod("GetRegisteredInteractors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRegisteredInteractors_12);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)};
            method = type.GetMethod("GetRegisteredInteractables", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRegisteredInteractables_13);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("IsRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsRegistered_14);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable)};
            method = type.GetMethod("IsRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsRegistered_15);
            args = new Type[]{typeof(UnityEngine.Collider), typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable).MakeByRefType()};
            method = type.GetMethod("TryGetInteractableForCollider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetInteractableForCollider_16);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor), typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)};
            method = type.GetMethod("GetValidTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetValidTargets_17);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)};
            method = type.GetMethod("CancelInteractorSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CancelInteractorSelection_18);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("CancelInteractableSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CancelInteractableSelection_19);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)};
            method = type.GetMethod("CancelInteractorHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CancelInteractorHover_20);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("CancelInteractableHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CancelInteractableHover_21);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("SelectEnter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectEnter_22);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("SelectExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectExit_23);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)};
            method = type.GetMethod("SelectCancel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectCancel_24);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("HoverEnter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HoverEnter_25);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("HoverExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HoverExit_26);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)};
            method = type.GetMethod("HoverCancel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HoverCancel_27);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.XRInteractionManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRInteractionManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_interactorRegistered_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactorRegistered += value;

            return __ret;
        }

        static StackObject* remove_interactorRegistered_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactorRegistered -= value;

            return __ret;
        }

        static StackObject* add_interactorUnregistered_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactorUnregistered += value;

            return __ret;
        }

        static StackObject* remove_interactorUnregistered_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactorUnregistered -= value;

            return __ret;
        }

        static StackObject* add_interactableRegistered_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableRegistered += value;

            return __ret;
        }

        static StackObject* remove_interactableRegistered_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableRegistered -= value;

            return __ret;
        }

        static StackObject* add_interactableUnregistered_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableUnregistered += value;

            return __ret;
        }

        static StackObject* remove_interactableUnregistered_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactableUnregistered -= value;

            return __ret;
        }

        static StackObject* RegisterInteractor_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterInteractor(@interactor);

            return __ret;
        }

        static StackObject* UnregisterInteractor_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnregisterInteractor(@interactor);

            return __ret;
        }

        static StackObject* RegisterInteractable_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterInteractable(@interactable);

            return __ret;
        }

        static StackObject* UnregisterInteractable_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnregisterInteractable(@interactable);

            return __ret;
        }

        static StackObject* GetRegisteredInteractors_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractor> @results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetRegisteredInteractors(@results);

            return __ret;
        }

        static StackObject* GetRegisteredInteractables_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> @results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetRegisteredInteractables(@results);

            return __ret;
        }

        static StackObject* IsRegistered_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsRegistered(@interactor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsRegistered_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsRegistered(@interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetInteractableForCollider_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractable).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider @interactableCollider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetInteractableForCollider(@interactableCollider, out @interactable);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @interactable;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @interactable;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @interactable);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @interactable;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @interactable);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.Interaction.Toolkit.IXRInteractable[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @interactable;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetValidTargets_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> @targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetValidTargets(@interactor, @targets);

            return __ret;
        }

        static StackObject* CancelInteractorSelection_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CancelInteractorSelection(@interactor);

            return __ret;
        }

        static StackObject* CancelInteractableSelection_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CancelInteractableSelection(@interactable);

            return __ret;
        }

        static StackObject* CancelInteractorHover_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CancelInteractorHover(@interactor);

            return __ret;
        }

        static StackObject* CancelInteractableHover_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CancelInteractableHover(@interactable);

            return __ret;
        }

        static StackObject* SelectEnter_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectEnter(@interactor, @interactable);

            return __ret;
        }

        static StackObject* SelectExit_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectExit(@interactor, @interactable);

            return __ret;
        }

        static StackObject* SelectCancel_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectCancel(@interactor, @interactable);

            return __ret;
        }

        static StackObject* HoverEnter_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.HoverEnter(@interactor, @interactable);

            return __ret;
        }

        static StackObject* HoverExit_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.HoverExit(@interactor, @interactable);

            return __ret;
        }

        static StackObject* HoverCancel_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable @interactable = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRInteractionManager instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.HoverCancel(@interactor, @interactable);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.XRInteractionManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
