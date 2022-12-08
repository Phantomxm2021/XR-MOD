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
    unsafe class BaseTeleportationInteractable_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable);
            args = new Type[]{};
            method = type.GetMethod("get_teleportationProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_teleportationProvider_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.TeleportationProvider)};
            method = type.GetMethod("set_teleportationProvider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_teleportationProvider_1);
            args = new Type[]{};
            method = type.GetMethod("get_matchOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_matchOrientation_2);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.MatchOrientation)};
            method = type.GetMethod("set_matchOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_matchOrientation_3);
            args = new Type[]{};
            method = type.GetMethod("get_teleportTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_teleportTrigger_4);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable.TeleportTrigger)};
            method = type.GetMethod("set_teleportTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_teleportTrigger_5);
            args = new Type[]{};
            method = type.GetMethod("get_teleporting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_teleporting_6);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.TeleportingEvent)};
            method = type.GetMethod("set_teleporting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_teleporting_7);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable[s]);


        }


        static StackObject* get_teleportationProvider_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.teleportationProvider;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_teleportationProvider_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TeleportationProvider @value = (UnityEngine.XR.Interaction.Toolkit.TeleportationProvider)typeof(UnityEngine.XR.Interaction.Toolkit.TeleportationProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.teleportationProvider = value;

            return __ret;
        }

        static StackObject* get_matchOrientation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.matchOrientation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_matchOrientation_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.MatchOrientation @value = (UnityEngine.XR.Interaction.Toolkit.MatchOrientation)typeof(UnityEngine.XR.Interaction.Toolkit.MatchOrientation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.matchOrientation = value;

            return __ret;
        }

        static StackObject* get_teleportTrigger_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.teleportTrigger;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_teleportTrigger_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable.TeleportTrigger @value = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable.TeleportTrigger)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable.TeleportTrigger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.teleportTrigger = value;

            return __ret;
        }

        static StackObject* get_teleporting_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.teleporting;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_teleporting_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TeleportingEvent @value = (UnityEngine.XR.Interaction.Toolkit.TeleportingEvent)typeof(UnityEngine.XR.Interaction.Toolkit.TeleportingEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.BaseTeleportationInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.teleporting = value;

            return __ret;
        }





    }
}
