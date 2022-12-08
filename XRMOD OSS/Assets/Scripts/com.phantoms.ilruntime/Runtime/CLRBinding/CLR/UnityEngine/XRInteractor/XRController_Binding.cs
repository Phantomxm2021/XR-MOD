using System;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif

namespace ILRuntime.Runtime.Generated
{
    unsafe class XRController_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRController);
            args = new Type[]{};
            method = type.GetMethod("get_controllerNode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_controllerNode_0);
            args = new Type[]{typeof(UnityEngine.XR.XRNode)};
            method = type.GetMethod("set_controllerNode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_controllerNode_1);
            args = new Type[]{};
            method = type.GetMethod("get_selectUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectUsage_2);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_selectUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectUsage_3);
            args = new Type[]{};
            method = type.GetMethod("get_activateUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activateUsage_4);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_activateUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_activateUsage_5);
            args = new Type[]{};
            method = type.GetMethod("get_uiPressUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uiPressUsage_6);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_uiPressUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uiPressUsage_7);
            args = new Type[]{};
            method = type.GetMethod("get_axisToPressThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_axisToPressThreshold_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_axisToPressThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_axisToPressThreshold_9);
            args = new Type[]{};
            method = type.GetMethod("get_rotateObjectLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotateObjectLeft_10);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_rotateObjectLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotateObjectLeft_11);
            args = new Type[]{};
            method = type.GetMethod("get_rotateObjectRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotateObjectRight_12);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_rotateObjectRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotateObjectRight_13);
            args = new Type[]{};
            method = type.GetMethod("get_moveObjectIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_moveObjectIn_14);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_moveObjectIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_moveObjectIn_15);
            args = new Type[]{};
            method = type.GetMethod("get_moveObjectOut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_moveObjectOut_16);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)};
            method = type.GetMethod("set_moveObjectOut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_moveObjectOut_17);
            args = new Type[]{};
            method = type.GetMethod("get_poseProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_poseProvider_18);
            args = new Type[]{typeof(UnityEngine.Experimental.XR.Interaction.BasePoseProvider)};
            method = type.GetMethod("set_poseProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_poseProvider_19);
            args = new Type[]{};
            method = type.GetMethod("get_inputDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputDevice_20);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SendHapticImpulse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendHapticImpulse_21);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.XRController());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRController[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_controllerNode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.controllerNode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_controllerNode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.XRNode @value = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.controllerNode = value;

            return __ret;
        }

        static StackObject* get_selectUsage_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_selectUsage_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectUsage = value;

            return __ret;
        }

        static StackObject* get_activateUsage_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.activateUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_activateUsage_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.activateUsage = value;

            return __ret;
        }

        static StackObject* get_uiPressUsage_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uiPressUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_uiPressUsage_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uiPressUsage = value;

            return __ret;
        }

        static StackObject* get_axisToPressThreshold_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.axisToPressThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_axisToPressThreshold_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.axisToPressThreshold = value;

            return __ret;
        }

        static StackObject* get_rotateObjectLeft_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotateObjectLeft;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rotateObjectLeft_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotateObjectLeft = value;

            return __ret;
        }

        static StackObject* get_rotateObjectRight_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotateObjectRight;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rotateObjectRight_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotateObjectRight = value;

            return __ret;
        }

        static StackObject* get_moveObjectIn_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.moveObjectIn;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_moveObjectIn_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.moveObjectIn = value;

            return __ret;
        }

        static StackObject* get_moveObjectOut_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.moveObjectOut;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_moveObjectOut_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button @value = (UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button)typeof(UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.moveObjectOut = value;

            return __ret;
        }

        static StackObject* get_poseProvider_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.poseProvider;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_poseProvider_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.XR.Interaction.BasePoseProvider @value = (UnityEngine.Experimental.XR.Interaction.BasePoseProvider)typeof(UnityEngine.Experimental.XR.Interaction.BasePoseProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.poseProvider = value;

            return __ret;
        }

        static StackObject* get_inputDevice_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inputDevice;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SendHapticImpulse_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @duration = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @amplitude = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.XRController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRController)typeof(UnityEngine.XR.Interaction.Toolkit.XRController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SendHapticImpulse(@amplitude, @duration);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.XRController();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
