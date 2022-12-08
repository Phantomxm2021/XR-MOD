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
    unsafe class InputDevices_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.InputDevices);
            args = new Type[]{typeof(UnityEngine.XR.XRNode)};
            method = type.GetMethod("GetDeviceAtXRNode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDeviceAtXRNode_0);
            args = new Type[]{typeof(UnityEngine.XR.XRNode), typeof(System.Collections.Generic.List<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("GetDevicesAtXRNode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDevicesAtXRNode_1);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("GetDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDevices_2);
            args = new Type[]{typeof(UnityEngine.XR.InputDeviceCharacteristics), typeof(System.Collections.Generic.List<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("GetDevicesWithCharacteristics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDevicesWithCharacteristics_3);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("add_deviceConnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_deviceConnected_4);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("remove_deviceConnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_deviceConnected_5);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("add_deviceDisconnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_deviceDisconnected_6);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("remove_deviceDisconnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_deviceDisconnected_7);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("add_deviceConfigChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_deviceConfigChanged_8);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.InputDevice>)};
            method = type.GetMethod("remove_deviceConfigChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_deviceConfigChanged_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.InputDevices());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.InputDevices[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetDeviceAtXRNode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.XRNode @node = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(@node);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDevicesAtXRNode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.InputDevice> @inputDevices = (System.Collections.Generic.List<UnityEngine.XR.InputDevice>)typeof(System.Collections.Generic.List<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.XRNode @node = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.GetDevicesAtXRNode(@node, @inputDevices);

            return __ret;
        }

        static StackObject* GetDevices_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.InputDevice> @inputDevices = (System.Collections.Generic.List<UnityEngine.XR.InputDevice>)typeof(System.Collections.Generic.List<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.GetDevices(@inputDevices);

            return __ret;
        }

        static StackObject* GetDevicesWithCharacteristics_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.InputDevice> @inputDevices = (System.Collections.Generic.List<UnityEngine.XR.InputDevice>)typeof(System.Collections.Generic.List<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.InputDeviceCharacteristics @desiredCharacteristics = (UnityEngine.XR.InputDeviceCharacteristics)typeof(UnityEngine.XR.InputDeviceCharacteristics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(@desiredCharacteristics, @inputDevices);

            return __ret;
        }

        static StackObject* add_deviceConnected_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.InputDevice> @value = (System.Action<UnityEngine.XR.InputDevice>)typeof(System.Action<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.deviceConnected += value;

            return __ret;
        }

        static StackObject* remove_deviceConnected_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.InputDevice> @value = (System.Action<UnityEngine.XR.InputDevice>)typeof(System.Action<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.deviceConnected -= value;

            return __ret;
        }

        static StackObject* add_deviceDisconnected_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.InputDevice> @value = (System.Action<UnityEngine.XR.InputDevice>)typeof(System.Action<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.deviceDisconnected += value;

            return __ret;
        }

        static StackObject* remove_deviceDisconnected_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.InputDevice> @value = (System.Action<UnityEngine.XR.InputDevice>)typeof(System.Action<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.deviceDisconnected -= value;

            return __ret;
        }

        static StackObject* add_deviceConfigChanged_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.InputDevice> @value = (System.Action<UnityEngine.XR.InputDevice>)typeof(System.Action<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.deviceConfigChanged += value;

            return __ret;
        }

        static StackObject* remove_deviceConfigChanged_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.InputDevice> @value = (System.Action<UnityEngine.XR.InputDevice>)typeof(System.Action<UnityEngine.XR.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.XR.InputDevices.deviceConfigChanged -= value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.InputDevices();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
