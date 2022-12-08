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
    unsafe class NetworkPropertiesSync_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync);
            args = new Type[]{};
            method = type.GetMethod("get_GetHealth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetHealth_0);
            args = new Type[]{};
            method = type.GetMethod("get_GetObjectLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetObjectLevel_1);
            args = new Type[]{};
            method = type.GetMethod("get_GetObjectName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetObjectName_2);
            args = new Type[]{};
            method = type.GetMethod("get_GetCustomProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetCustomProperties_3);
            args = new Type[]{typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdSubtractHealth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdSubtractHealth_4);
            args = new Type[]{typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdAddHealth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdAddHealth_5);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdSetObjectName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdSetObjectName_6);
            args = new Type[]{typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdLevelUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdLevelUp_7);
            args = new Type[]{typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdDegradeLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdDegradeLevel_8);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdUpdateCustomProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdUpdateCustomProperties_9);
            
            field = type.GetField("HealthSyncedCallback", flag);
            app.RegisterCLRFieldGetter(field, get_OnHealthChange_0);
            app.RegisterCLRFieldSetter(field, set_OnHealthChange_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_HealthSyncedCallback_0, AssignFromStack_HealthSyncedCallback_0);
            field = type.GetField("ObjectLevelSyncedCallback", flag);
            app.RegisterCLRFieldGetter(field, get_OnObjectLevelChange_1);
            app.RegisterCLRFieldSetter(field, set_OnObjectLevelChange_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnObjectLevelChange_1, AssignFromStack_ObjectLevelSyncedCallback_1);
            field = type.GetField("ObjectNameSyncedCallback", flag);
            app.RegisterCLRFieldGetter(field, get_OnObjectNameChange_2);
            app.RegisterCLRFieldSetter(field, set_OnObjectNameChange_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnObjectNameChange_2, AssignFromStack_ObjectNameSyncedCallback_2);
            field = type.GetField("CustomPropertiesSyncedCallback", flag);
            app.RegisterCLRFieldGetter(field, get_CustomPropertiesSyncedCallback_3);
            app.RegisterCLRFieldSetter(field, set_CustomPropertiesSyncedCallback_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_CustomPropertiesSyncedCallback_3, AssignFromStack_CustomPropertiesSyncedCallback_3);
            field = type.GetField("Sender", flag);
            app.RegisterCLRFieldGetter(field, get_Sender_4);
            app.RegisterCLRFieldSetter(field, set_Sender_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Sender_4, AssignFromStack_Sender_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_GetHealth_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetHealth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_GetObjectLevel_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetObjectLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_GetObjectName_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetObjectName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GetCustomProperties_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCustomProperties;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CmdSubtractHealth_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_newValue = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdSubtractHealth(@_newValue, @_sender);

            return __ret;
        }

        static StackObject* CmdAddHealth_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_newValue = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdAddHealth(@_newValue, @_sender);

            return __ret;
        }

        static StackObject* CmdSetObjectName_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdSetObjectName(@_name, @_sender);

            return __ret;
        }

        static StackObject* CmdLevelUp_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_additionLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdLevelUp(@_additionLevel, @_sender);

            return __ret;
        }

        static StackObject* CmdDegradeLevel_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_level = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdDegradeLevel(@_level, @_sender);

            return __ret;
        }

        static StackObject* CmdUpdateCustomProperties_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_customProperties = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdUpdateCustomProperties(@_customProperties, @_sender);

            return __ret;
        }

        static object get_OnHealthChange_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).HealthSyncedCallback;
        }

        static StackObject* CopyToStack_HealthSyncedCallback_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).HealthSyncedCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnHealthChange_0(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).HealthSyncedCallback = (System.Action<System.Single, Mirror.NetworkIdentity>)v;
        }

        static StackObject* AssignFromStack_HealthSyncedCallback_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Single, Mirror.NetworkIdentity> @HealthSyncedCallback = (System.Action<System.Single, Mirror.NetworkIdentity>)typeof(System.Action<System.Single, Mirror.NetworkIdentity>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).HealthSyncedCallback = @HealthSyncedCallback;
            return ptr_of_this_method;
        }

        static object get_OnObjectLevelChange_1(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectLevelSyncedCallback;
        }

        static StackObject* CopyToStack_OnObjectLevelChange_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectLevelSyncedCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnObjectLevelChange_1(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectLevelSyncedCallback = (System.Action<System.Int32, Mirror.NetworkIdentity>)v;
        }

        static StackObject* AssignFromStack_ObjectLevelSyncedCallback_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Int32, Mirror.NetworkIdentity> @ObjectLevelSyncedCallback = (System.Action<System.Int32, Mirror.NetworkIdentity>)typeof(System.Action<System.Int32, Mirror.NetworkIdentity>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectLevelSyncedCallback = @ObjectLevelSyncedCallback;
            return ptr_of_this_method;
        }

        static object get_OnObjectNameChange_2(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectNameSyncedCallback;
        }

        static StackObject* CopyToStack_OnObjectNameChange_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectNameSyncedCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnObjectNameChange_2(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectNameSyncedCallback = (System.Action<System.String, Mirror.NetworkIdentity>)v;
        }

        static StackObject* AssignFromStack_ObjectNameSyncedCallback_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String, Mirror.NetworkIdentity> @ObjectNameSyncedCallback = (System.Action<System.String, Mirror.NetworkIdentity>)typeof(System.Action<System.String, Mirror.NetworkIdentity>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).ObjectNameSyncedCallback = @ObjectNameSyncedCallback;
            return ptr_of_this_method;
        }

        static object get_CustomPropertiesSyncedCallback_3(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).CustomPropertiesSyncedCallback;
        }

        static StackObject* CopyToStack_CustomPropertiesSyncedCallback_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).CustomPropertiesSyncedCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CustomPropertiesSyncedCallback_3(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).CustomPropertiesSyncedCallback = (System.Action<System.String, Mirror.NetworkIdentity>)v;
        }

        static StackObject* AssignFromStack_CustomPropertiesSyncedCallback_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String, Mirror.NetworkIdentity> @CustomPropertiesSyncedCallback = (System.Action<System.String, Mirror.NetworkIdentity>)typeof(System.Action<System.String, Mirror.NetworkIdentity>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).CustomPropertiesSyncedCallback = @CustomPropertiesSyncedCallback;
            return ptr_of_this_method;
        }

        static object get_Sender_4(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).Sender;
        }

        static StackObject* CopyToStack_Sender_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).Sender;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Sender_4(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).Sender = (Mirror.NetworkIdentity)v;
        }

        static StackObject* AssignFromStack_Sender_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Mirror.NetworkIdentity @Sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync)o).Sender = @Sender;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.PhantomsXR.MirrorExtension.Runtime.NetworkPropertiesSync();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
