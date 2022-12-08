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
    unsafe class XRBaseTargetFilter_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter);
            args = new Type[]{};
            method = type.GetMethod("get_canProcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_canProcess_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("Link", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Link_1);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor)};
            method = type.GetMethod("Unlink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unlink_2);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor), typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>), typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)};
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_3);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter[s]);


        }


        static StackObject* get_canProcess_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.canProcess;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Link_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Link(@interactor);

            return __ret;
        }

        static StackObject* Unlink_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Unlink(@interactor);

            return __ret;
        }

        static StackObject* Process_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> @results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> @targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.IXRInteractor @interactor = (UnityEngine.XR.Interaction.Toolkit.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Process(@interactor, @targets, @results);

            return __ret;
        }





    }
}
