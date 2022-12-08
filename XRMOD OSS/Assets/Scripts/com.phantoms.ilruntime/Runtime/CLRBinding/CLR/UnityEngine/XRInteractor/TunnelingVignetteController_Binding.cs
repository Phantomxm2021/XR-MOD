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
    unsafe class TunnelingVignetteController_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController);
            args = new Type[]{};
            method = type.GetMethod("get_defaultParameters", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultParameters_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.VignetteParameters)};
            method = type.GetMethod("set_defaultParameters", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultParameters_1);
            args = new Type[]{};
            method = type.GetMethod("get_currentParameters", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentParameters_2);
            args = new Type[]{};
            method = type.GetMethod("get_locomotionVignetteProviders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_locomotionVignetteProviders_3);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.LocomotionVignetteProvider>)};
            method = type.GetMethod("set_locomotionVignetteProviders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_locomotionVignetteProviders_4);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider)};
            method = type.GetMethod("BeginTunnelingVignette", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginTunnelingVignette_5);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider)};
            method = type.GetMethod("EndTunnelingVignette", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndTunnelingVignette_6);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_defaultParameters_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.defaultParameters;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_defaultParameters_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.VignetteParameters @value = (UnityEngine.XR.Interaction.Toolkit.VignetteParameters)typeof(UnityEngine.XR.Interaction.Toolkit.VignetteParameters).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.defaultParameters = value;

            return __ret;
        }

        static StackObject* get_currentParameters_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentParameters;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_locomotionVignetteProviders_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.locomotionVignetteProviders;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_locomotionVignetteProviders_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.LocomotionVignetteProvider> @value = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.LocomotionVignetteProvider>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.LocomotionVignetteProvider>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.locomotionVignetteProviders = value;

            return __ret;
        }

        static StackObject* BeginTunnelingVignette_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider @provider = (UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider)typeof(UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BeginTunnelingVignette(@provider);

            return __ret;
        }

        static StackObject* EndTunnelingVignette_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider @provider = (UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider)typeof(UnityEngine.XR.Interaction.Toolkit.ITunnelingVignetteProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController)typeof(UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EndTunnelingVignette(@provider);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
