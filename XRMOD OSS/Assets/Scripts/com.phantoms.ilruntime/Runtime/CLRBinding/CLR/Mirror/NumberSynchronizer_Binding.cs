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
    unsafe class NumberSynchronizer_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer);
            args = new Type[]{};
            method = type.GetMethod("get_GetSynchronousValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetSynchronousValue_0);
            args = new Type[]{typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdModifyValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdModifyValue_1);
            args = new Type[]{typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcSynchronizingValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcSynchronizingValue_2);
            args = new Type[]{typeof(System.Action<System.Single, Mirror.NetworkIdentity>)};
            method = type.GetMethod("RegisterValueSyncedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterValueSyncedCallback_3);
            args = new Type[]{};
            method = type.GetMethod("UnRegisterValueSyncedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnRegisterValueSyncedCallback_4);



            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_GetSynchronousValue_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer)typeof(com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSynchronousValue;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CmdModifyValue_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @_newValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer)typeof(com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdModifyValue(@_newValue, @_sender);

            return __ret;
        }

        static StackObject* RpcSynchronizingValue_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @_syncedValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer)typeof(com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcSynchronizingValue(@_syncedValue, @_sender);

            return __ret;
        }

        static StackObject* RegisterValueSyncedCallback_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single, Mirror.NetworkIdentity> @_callback = (System.Action<System.Single, Mirror.NetworkIdentity>)typeof(System.Action<System.Single, Mirror.NetworkIdentity>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer)typeof(com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterValueSyncedCallback(@_callback);

            return __ret;
        }

        static StackObject* UnRegisterValueSyncedCallback_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer)typeof(com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnRegisterValueSyncedCallback();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.PhantomsXR.MirrorExtension.Runtime.NumberSynchronizer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
