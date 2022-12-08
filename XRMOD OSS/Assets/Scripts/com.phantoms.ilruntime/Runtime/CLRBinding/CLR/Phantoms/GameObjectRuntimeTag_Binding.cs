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
    unsafe class GameObjectRuntimeTag_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DoCompareTag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DoCompareTag_0);

            field = type.GetField("RuntimeTag", flag);
            app.RegisterCLRFieldGetter(field, get_RuntimeTag_0);
            app.RegisterCLRFieldSetter(field, set_RuntimeTag_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_RuntimeTag_0, AssignFromStack_RuntimeTag_0);

            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* DoCompareTag_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_tag = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag instance_of_this_method = (com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag)typeof(com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DoCompareTag(@_tag);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
        
        static object get_RuntimeTag_0(ref object o)
        {
            return ((com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag)o).RuntimeTag;
        }

        static StackObject* CopyToStack_RuntimeTag_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag)o).RuntimeTag;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RuntimeTag_0(ref object o, object v)
        {
            ((com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag)o).RuntimeTag = (System.String)v;
        }

        static StackObject* AssignFromStack_RuntimeTag_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @RuntimeTag = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag)o).RuntimeTag = @RuntimeTag;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ARMODAPI.Runtime.GameObjectRuntimeTag();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
