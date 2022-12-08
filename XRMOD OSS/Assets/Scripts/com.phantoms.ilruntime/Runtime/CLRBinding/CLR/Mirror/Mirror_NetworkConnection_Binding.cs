using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
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
    unsafe class Mirror_NetworkConnection_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Mirror.NetworkConnection);
            args = new Type[] { };
            method = type.GetMethod("get_address", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_address_0);
            args = new Type[] { };
            method = type.GetMethod("get_identity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_identity_1);
            args = new Type[] { };
            method = type.GetMethod("get_remoteTimeStamp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_remoteTimeStamp_2);
            args = new Type[] { };
            method = type.GetMethod("Disconnect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Disconnect_3);
            args = new Type[] { };
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_4);

            field = type.GetField("LocalConnectionId", flag);
            app.RegisterCLRFieldGetter(field, get_LocalConnectionId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalConnectionId_0, null);
            field = type.GetField("connectionId", flag);
            app.RegisterCLRFieldGetter(field, get_connectionId_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_connectionId_1, null);
            field = type.GetField("isAuthenticated", flag);
            app.RegisterCLRFieldGetter(field, get_isAuthenticated_2);
            app.RegisterCLRFieldSetter(field, set_isAuthenticated_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_isAuthenticated_2, AssignFromStack_isAuthenticated_2);
            field = type.GetField("authenticationData", flag);
            app.RegisterCLRFieldGetter(field, get_authenticationData_3);
            app.RegisterCLRFieldSetter(field, set_authenticationData_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_authenticationData_3, AssignFromStack_authenticationData_3);
            field = type.GetField("isReady", flag);
            app.RegisterCLRFieldGetter(field, get_isReady_4);
            app.RegisterCLRFieldSetter(field, set_isReady_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_isReady_4, AssignFromStack_isReady_4);
            field = type.GetField("lastMessageTime", flag);
            app.RegisterCLRFieldGetter(field, get_lastMessageTime_5);
            app.RegisterCLRFieldSetter(field, set_lastMessageTime_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_lastMessageTime_5, AssignFromStack_lastMessageTime_5);
            field = type.GetField("clientOwnedObjects", flag);
            app.RegisterCLRFieldGetter(field, get_clientOwnedObjects_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_clientOwnedObjects_6, null);


            app.RegisterCLRCreateArrayInstance(type, s => new Mirror.NetworkConnection[s]);
        }


        static StackObject* get_address_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkConnection instance_of_this_method =
                (Mirror.NetworkConnection)typeof(Mirror.NetworkConnection).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.address;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_identity_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkConnection instance_of_this_method =
                (Mirror.NetworkConnection)typeof(Mirror.NetworkConnection).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.identity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_remoteTimeStamp_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkConnection instance_of_this_method =
                (Mirror.NetworkConnection)typeof(Mirror.NetworkConnection).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.remoteTimeStamp;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Disconnect_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkConnection instance_of_this_method =
                (Mirror.NetworkConnection)typeof(Mirror.NetworkConnection).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Disconnect();

            return __ret;
        }

        static StackObject* ToString_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkConnection instance_of_this_method =
                (Mirror.NetworkConnection)typeof(Mirror.NetworkConnection).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_LocalConnectionId_0(ref object o)
        {
            return Mirror.NetworkConnection.LocalConnectionId;
        }

        static StackObject* CopyToStack_LocalConnectionId_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = Mirror.NetworkConnection.LocalConnectionId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_connectionId_1(ref object o)
        {
            return ((Mirror.NetworkConnection)o).connectionId;
        }

        static StackObject* CopyToStack_connectionId_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Mirror.NetworkConnection)o).connectionId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_isAuthenticated_2(ref object o)
        {
            return ((Mirror.NetworkConnection)o).isAuthenticated;
        }

        static StackObject* CopyToStack_isAuthenticated_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Mirror.NetworkConnection)o).isAuthenticated;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_isAuthenticated_2(ref object o, object v)
        {
            ((Mirror.NetworkConnection)o).isAuthenticated = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_isAuthenticated_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @isAuthenticated = ptr_of_this_method->Value == 1;
            ((Mirror.NetworkConnection)o).isAuthenticated = @isAuthenticated;
            return ptr_of_this_method;
        }

        static object get_authenticationData_3(ref object o)
        {
            return ((Mirror.NetworkConnection)o).authenticationData;
        }

        static StackObject* CopyToStack_authenticationData_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Mirror.NetworkConnection)o).authenticationData;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance, true);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }

        static void set_authenticationData_3(ref object o, object v)
        {
            ((Mirror.NetworkConnection)o).authenticationData = (System.Object)v;
        }

        static StackObject* AssignFromStack_authenticationData_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Object @authenticationData =
                (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            ((Mirror.NetworkConnection)o).authenticationData = @authenticationData;
            return ptr_of_this_method;
        }

        static object get_isReady_4(ref object o)
        {
            return ((Mirror.NetworkConnection)o).isReady;
        }

        static StackObject* CopyToStack_isReady_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Mirror.NetworkConnection)o).isReady;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_isReady_4(ref object o, object v)
        {
            ((Mirror.NetworkConnection)o).isReady = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_isReady_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @isReady = ptr_of_this_method->Value == 1;
            ((Mirror.NetworkConnection)o).isReady = @isReady;
            return ptr_of_this_method;
        }

        static object get_lastMessageTime_5(ref object o)
        {
            return ((Mirror.NetworkConnection)o).lastMessageTime;
        }

        static StackObject* CopyToStack_lastMessageTime_5(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Mirror.NetworkConnection)o).lastMessageTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_lastMessageTime_5(ref object o, object v)
        {
            ((Mirror.NetworkConnection)o).lastMessageTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_lastMessageTime_5(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @lastMessageTime = *(float*)&ptr_of_this_method->Value;
            ((Mirror.NetworkConnection)o).lastMessageTime = @lastMessageTime;
            return ptr_of_this_method;
        }

        static object get_clientOwnedObjects_6(ref object o)
        {
            return ((Mirror.NetworkConnection)o).clientOwnedObjects;
        }

        static StackObject* CopyToStack_clientOwnedObjects_6(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Mirror.NetworkConnection)o).clientOwnedObjects;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}