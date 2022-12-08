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
    unsafe class MultiplayerConnectionResponseData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData);

            field = type.GetField("NetworkConnection", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkConnection_0);
            app.RegisterCLRFieldSetter(field, set_NetworkConnection_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkConnection_0, AssignFromStack_NetworkConnection_0);
            field = type.GetField("ErrorCode", flag);
            app.RegisterCLRFieldGetter(field, get_ErrorCode_1);
            app.RegisterCLRFieldSetter(field, set_ErrorCode_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ErrorCode_1, AssignFromStack_ErrorCode_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_NetworkConnection_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).NetworkConnection;
        }

        static StackObject* CopyToStack_NetworkConnection_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).NetworkConnection;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkConnection_0(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).NetworkConnection = (Mirror.NetworkConnection)v;
        }

        static StackObject* AssignFromStack_NetworkConnection_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Mirror.NetworkConnection @NetworkConnection = (Mirror.NetworkConnection)typeof(Mirror.NetworkConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).NetworkConnection = @NetworkConnection;
            return ptr_of_this_method;
        }

        static object get_ErrorCode_1(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).ErrorCode;
        }

        static StackObject* CopyToStack_ErrorCode_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).ErrorCode;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ErrorCode_1(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).ErrorCode = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ErrorCode_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ErrorCode = ptr_of_this_method->Value;
            ((com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData)o).ErrorCode = @ErrorCode;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.PhantomsXR.MirrorExtension.Runtime.MultiplayerConnectionResponseData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
