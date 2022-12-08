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
    unsafe class TwoHandedGrabMoveProvider_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider);
            args = new Type[]{};
            method = type.GetMethod("get_leftGrabMoveProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftGrabMoveProvider_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider)};
            method = type.GetMethod("set_leftGrabMoveProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_leftGrabMoveProvider_1);
            args = new Type[]{};
            method = type.GetMethod("get_rightGrabMoveProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightGrabMoveProvider_2);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider)};
            method = type.GetMethod("set_rightGrabMoveProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rightGrabMoveProvider_3);
            args = new Type[]{};
            method = type.GetMethod("get_overrideSharedSettingsOnInit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_overrideSharedSettingsOnInit_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_overrideSharedSettingsOnInit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_overrideSharedSettingsOnInit_5);
            args = new Type[]{};
            method = type.GetMethod("get_moveFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_moveFactor_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_moveFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_moveFactor_7);
            args = new Type[]{};
            method = type.GetMethod("get_requireTwoHandsForTranslation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requireTwoHandsForTranslation_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_requireTwoHandsForTranslation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requireTwoHandsForTranslation_9);
            args = new Type[]{};
            method = type.GetMethod("get_enableRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableRotation_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableRotation_11);
            args = new Type[]{};
            method = type.GetMethod("get_enableScaling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableScaling_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableScaling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableScaling_13);
            args = new Type[]{};
            method = type.GetMethod("get_minimumScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minimumScale_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_minimumScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_minimumScale_15);
            args = new Type[]{};
            method = type.GetMethod("get_maximumScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumScale_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maximumScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumScale_17);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_leftGrabMoveProvider_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftGrabMoveProvider;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_leftGrabMoveProvider_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider @value = (UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.leftGrabMoveProvider = value;

            return __ret;
        }

        static StackObject* get_rightGrabMoveProvider_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightGrabMoveProvider;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rightGrabMoveProvider_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider @value = (UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rightGrabMoveProvider = value;

            return __ret;
        }

        static StackObject* get_overrideSharedSettingsOnInit_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.overrideSharedSettingsOnInit;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_overrideSharedSettingsOnInit_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.overrideSharedSettingsOnInit = value;

            return __ret;
        }

        static StackObject* get_moveFactor_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.moveFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_moveFactor_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.moveFactor = value;

            return __ret;
        }

        static StackObject* get_requireTwoHandsForTranslation_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requireTwoHandsForTranslation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_requireTwoHandsForTranslation_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requireTwoHandsForTranslation = value;

            return __ret;
        }

        static StackObject* get_enableRotation_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enableRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableRotation_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enableRotation = value;

            return __ret;
        }

        static StackObject* get_enableScaling_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enableScaling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableScaling_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enableScaling = value;

            return __ret;
        }

        static StackObject* get_minimumScale_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minimumScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_minimumScale_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.minimumScale = value;

            return __ret;
        }

        static StackObject* get_maximumScale_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maximumScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumScale_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maximumScale = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
