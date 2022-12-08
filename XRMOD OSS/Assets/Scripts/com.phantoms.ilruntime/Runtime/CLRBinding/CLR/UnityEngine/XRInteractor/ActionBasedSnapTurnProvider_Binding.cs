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
    unsafe class ActionBasedSnapTurnProvider_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider);
            args = new Type[]{};
            method = type.GetMethod("get_leftHandSnapTurnAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftHandSnapTurnAction_0);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_leftHandSnapTurnAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_leftHandSnapTurnAction_1);
            args = new Type[]{};
            method = type.GetMethod("get_rightHandSnapTurnAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightHandSnapTurnAction_2);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_rightHandSnapTurnAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rightHandSnapTurnAction_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_leftHandSnapTurnAction_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftHandSnapTurnAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_leftHandSnapTurnAction_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.leftHandSnapTurnAction = value;

            return __ret;
        }

        static StackObject* get_rightHandSnapTurnAction_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightHandSnapTurnAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rightHandSnapTurnAction_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rightHandSnapTurnAction = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
