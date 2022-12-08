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
    unsafe class LocomotionProvider_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)};
            method = type.GetMethod("add_beginLocomotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_beginLocomotion_0);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)};
            method = type.GetMethod("remove_beginLocomotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_beginLocomotion_1);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)};
            method = type.GetMethod("add_endLocomotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_endLocomotion_2);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)};
            method = type.GetMethod("remove_endLocomotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_endLocomotion_3);
            args = new Type[]{};
            method = type.GetMethod("get_system", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_system_4);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionSystem)};
            method = type.GetMethod("set_system", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_system_5);
            args = new Type[]{};
            method = type.GetMethod("get_locomotionPhase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_locomotionPhase_6);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)};
            method = type.GetMethod("add_startLocomotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_startLocomotion_7);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)};
            method = type.GetMethod("remove_startLocomotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_startLocomotion_8);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.LocomotionProvider[s]);


        }


        static StackObject* add_beginLocomotion_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.beginLocomotion += value;

            return __ret;
        }

        static StackObject* remove_beginLocomotion_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.beginLocomotion -= value;

            return __ret;
        }

        static StackObject* add_endLocomotion_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endLocomotion += value;

            return __ret;
        }

        static StackObject* remove_endLocomotion_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endLocomotion -= value;

            return __ret;
        }

        static StackObject* get_system_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.system;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_system_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.LocomotionSystem @value = (UnityEngine.XR.Interaction.Toolkit.LocomotionSystem)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.system = value;

            return __ret;
        }

        static StackObject* get_locomotionPhase_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.locomotionPhase;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_startLocomotion_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.beginLocomotion += value;

            return __ret;
        }

        static StackObject* remove_startLocomotion_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem> @value = (System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.LocomotionSystem>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.LocomotionProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.LocomotionProvider)typeof(UnityEngine.XR.Interaction.Toolkit.LocomotionProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.beginLocomotion -= value;

            return __ret;
        }





    }
}
