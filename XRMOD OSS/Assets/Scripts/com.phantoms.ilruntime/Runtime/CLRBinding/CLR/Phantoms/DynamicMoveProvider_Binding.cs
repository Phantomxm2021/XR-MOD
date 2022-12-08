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
    unsafe class DynamicMoveProvider_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider);
            args = new Type[]{};
            method = type.GetMethod("get_headTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_headTransform_0);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_headTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_headTransform_1);
            args = new Type[]{};
            method = type.GetMethod("get_leftControllerTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftControllerTransform_2);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_leftControllerTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_leftControllerTransform_3);
            args = new Type[]{};
            method = type.GetMethod("get_rightControllerTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightControllerTransform_4);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_rightControllerTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rightControllerTransform_5);
            args = new Type[]{};
            method = type.GetMethod("get_leftHandMovementDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftHandMovementDirection_6);
            args = new Type[]{typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection)};
            method = type.GetMethod("set_leftHandMovementDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_leftHandMovementDirection_7);
            args = new Type[]{};
            method = type.GetMethod("get_rightHandMovementDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightHandMovementDirection_8);
            args = new Type[]{typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection)};
            method = type.GetMethod("set_rightHandMovementDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rightHandMovementDirection_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider());
            app.RegisterCLRCreateArrayInstance(type, s => new com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_headTransform_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.headTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_headTransform_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.headTransform = value;

            return __ret;
        }

        static StackObject* get_leftControllerTransform_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftControllerTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_leftControllerTransform_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.leftControllerTransform = value;

            return __ret;
        }

        static StackObject* get_rightControllerTransform_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightControllerTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rightControllerTransform_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rightControllerTransform = value;

            return __ret;
        }

        static StackObject* get_leftHandMovementDirection_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftHandMovementDirection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_leftHandMovementDirection_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection @value = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.leftHandMovementDirection = value;

            return __ret;
        }

        static StackObject* get_rightHandMovementDirection_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightHandMovementDirection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rightHandMovementDirection_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection @value = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider.MovementDirection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider)typeof(com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rightHandMovementDirection = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.phantoms.BaseFeatures.Runtime.DynamicMoveProvider();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
