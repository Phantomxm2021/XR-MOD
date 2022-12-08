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
    unsafe class LoadObjectNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData);

            field = type.GetField("ProjectName", flag);
            app.RegisterCLRFieldGetter(field, get_ProjectName_0);
            app.RegisterCLRFieldSetter(field, set_ProjectName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProjectName_0, AssignFromStack_ProjectName_0);
            field = type.GetField("LoadObjectName", flag);
            app.RegisterCLRFieldGetter(field, get_LoadObjectName_1);
            app.RegisterCLRFieldSetter(field, set_LoadObjectName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_LoadObjectName_1, AssignFromStack_LoadObjectName_1);
            field = type.GetField("LoadObjectType", flag);
            app.RegisterCLRFieldGetter(field, get_LoadObjectType_2);
            app.RegisterCLRFieldSetter(field, set_LoadObjectType_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_LoadObjectType_2, AssignFromStack_LoadObjectType_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_ProjectName_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).ProjectName;
        }

        static StackObject* CopyToStack_ProjectName_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).ProjectName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ProjectName_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).ProjectName = (System.String)v;
        }

        static StackObject* AssignFromStack_ProjectName_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ProjectName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).ProjectName = @ProjectName;
            return ptr_of_this_method;
        }

        static object get_LoadObjectName_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectName;
        }

        static StackObject* CopyToStack_LoadObjectName_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectName;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LoadObjectName_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectName = (System.Collections.Generic.List<System.String>)v;
        }

        static StackObject* AssignFromStack_LoadObjectName_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<System.String> @LoadObjectName = (System.Collections.Generic.List<System.String>)typeof(System.Collections.Generic.List<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectName = @LoadObjectName;
            return ptr_of_this_method;
        }

        static object get_LoadObjectType_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectType;
        }

        static StackObject* CopyToStack_LoadObjectType_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectType;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LoadObjectType_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectType = (System.Type)v;
        }

        static StackObject* AssignFromStack_LoadObjectType_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Type @LoadObjectType = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData)o).LoadObjectType = @LoadObjectType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.LoadObjectNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
