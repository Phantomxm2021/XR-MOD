using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class BaseMultiplayerData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData);

            field = type.GetField("NetworkStatus", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkStatus_0);
            app.RegisterCLRFieldSetter(field, set_NetworkStatus_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkStatus_0, AssignFromStack_NetworkStatus_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_NetworkStatus_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData)o).NetworkStatus;
        }

        static StackObject* CopyToStack_NetworkStatus_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData)o).NetworkStatus;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkStatus_0(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData)o).NetworkStatus = (com.PhantomsXR.MirrorExtension.Runtime.NetworkStatus)v;
        }

        static StackObject* AssignFromStack_NetworkStatus_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.PhantomsXR.MirrorExtension.Runtime.NetworkStatus @NetworkStatus = (com.PhantomsXR.MirrorExtension.Runtime.NetworkStatus)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkStatus).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData)o).NetworkStatus = @NetworkStatus;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.PhantomsXR.MirrorExtension.Runtime.BaseMultiplayerData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
