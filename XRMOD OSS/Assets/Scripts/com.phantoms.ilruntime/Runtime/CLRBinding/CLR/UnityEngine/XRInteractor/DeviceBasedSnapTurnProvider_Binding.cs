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
    unsafe class DeviceBasedSnapTurnProvider_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider);
            args = new Type[]{};
            method = type.GetMethod("get_turnUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_turnUsage_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider.InputAxes)};
            method = type.GetMethod("set_turnUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_turnUsage_1);
            args = new Type[]{};
            method = type.GetMethod("get_controllers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_controllers_2);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.XRBaseController>)};
            method = type.GetMethod("set_controllers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_controllers_3);
            args = new Type[]{};
            method = type.GetMethod("get_deadZone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deadZone_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_deadZone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_deadZone_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_turnUsage_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.turnUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_turnUsage_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider.InputAxes @value = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider.InputAxes)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider.InputAxes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.turnUsage = value;

            return __ret;
        }

        static StackObject* get_controllers_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.controllers;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_controllers_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.XRBaseController> @value = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.XRBaseController>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.XRBaseController>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.controllers = value;

            return __ret;
        }

        static StackObject* get_deadZone_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.deadZone;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_deadZone_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider)typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.deadZone = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
