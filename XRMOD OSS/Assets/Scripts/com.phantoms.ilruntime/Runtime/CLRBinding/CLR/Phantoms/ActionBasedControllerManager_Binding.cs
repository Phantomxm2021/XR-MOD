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
    unsafe class ActionBasedControllerManager_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager);
            args = new Type[]{};
            method = type.GetMethod("get_smoothMotionEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothMotionEnabled_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_smoothMotionEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothMotionEnabled_1);
            args = new Type[]{};
            method = type.GetMethod("get_smoothTurnEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothTurnEnabled_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_smoothTurnEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothTurnEnabled_3);

            field = type.GetField("k_UpdateOrder", flag);
            app.RegisterCLRFieldGetter(field, get_k_UpdateOrder_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_k_UpdateOrder_0, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager());
            app.RegisterCLRCreateArrayInstance(type, s => new com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_smoothMotionEnabled_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager)typeof(com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothMotionEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_smoothMotionEnabled_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager)typeof(com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothMotionEnabled = value;

            return __ret;
        }

        static StackObject* get_smoothTurnEnabled_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager)typeof(com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothTurnEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_smoothTurnEnabled_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager instance_of_this_method = (com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager)typeof(com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothTurnEnabled = value;

            return __ret;
        }


        static object get_k_UpdateOrder_0(ref object o)
        {
            return com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager.k_UpdateOrder;
        }

        static StackObject* CopyToStack_k_UpdateOrder_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager.k_UpdateOrder;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.phantoms.BaseFeatures.Runtime.ActionBasedControllerManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
