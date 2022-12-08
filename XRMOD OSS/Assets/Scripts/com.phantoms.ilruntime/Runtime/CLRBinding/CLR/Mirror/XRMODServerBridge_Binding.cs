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
    unsafe class XRMODServerBridge_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices);
            args = new Type[] { };
            method = type.GetMethod("GetBridge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBridge_0);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("RegisterPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterPrefab_1);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetNetworkPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNetworkPrefab_2);
            args = new Type[]
            {
                typeof(System.String), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion),
                typeof(System.Boolean)
            };
            method = type.GetMethod("SpawnPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnPrefab_3);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("SpawnPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnPrefab_4);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("SpawnPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnPlayer_5);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("UnSpawnNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnSpawnNetworkObject_6);
            args = new Type[] { };
            method = type.GetMethod("GetLocalPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalPlayer_7);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(Mirror.NetworkConnection)};
            method = type.GetMethod("SpawnSync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SpawnSync_8);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("NetworkObjectDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NetworkObjectDestroy_9);
            args = new Type[] {typeof(Mirror.NetworkIdentity), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("AssignClientAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AssignClientAuthority_10);
            args = new Type[] { };
            method = type.GetMethod("StartHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartHost_11);
            args = new Type[] { };
            method = type.GetMethod("StartAsAServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartAsAServer_12);
            args = new Type[] {typeof(System.String), typeof(System.String)};
            method = type.GetMethod("ConnectToServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConnectToServer_13);
            args = new Type[] { };
            method = type.GetMethod("ConnectToServerByDiscovery", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConnectToServerByDiscovery_14);
            args = new Type[] { };
            method = type.GetMethod("Disconnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Disconnected_15);
            args = new Type[] { };
            method = type.GetMethod("GetLocalIP", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalIP_16);
            args = new Type[] { };
            method = type.GetMethod("GetLocalNetworkConnection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalNetworkConnection_17);
            args = new Type[] { };
            method = type.GetMethod("UsedOnlyForAOTCodeGeneration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UsedOnlyForAOTCodeGeneration_18);

            field = type.GetField("SpawnCallback", flag);
            app.RegisterCLRFieldGetter(field, get_SpawnCallback_0);
            app.RegisterCLRFieldSetter(field, set_SpawnCallback_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpawnCallback_0, AssignFromStack_SpawnCallback_0);
            field = type.GetField("OnServerFoundCallback", flag);
            // app.RegisterCLRFieldGetter(field, get_OnServerFoundCallback_1);
            // app.RegisterCLRFieldSetter(field, set_OnServerFoundCallback_1);
            // app.RegisterCLRFieldBinding(field, CopyToStack_OnServerFoundCallback_1,
            //     AssignFromStack_OnServerFoundCallback_1);


            app.RegisterCLRCreateArrayInstance(type,
                s => new com.PhantomsXR.MirrorExtension.Runtime.XRMODServices[s]);
        }

        static StackObject* GetBridge_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = com.PhantomsXR.MirrorExtension.Runtime.XRMODServices.GetBridge();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterPrefab_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_needToRegisterPrefab =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterPrefab(@_needToRegisterPrefab);

            return __ret;
        }

        static StackObject* GetNetworkPrefab_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_prefabName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkPrefab(@_prefabName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SpawnPrefab_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_worldPos = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @_prefabName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SpawnPrefab(@_prefabName, @_position, @_rotation, @_worldPos);

            return __ret;
        }

        static StackObject* SpawnPrefab_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_prefabName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SpawnPrefab(@_prefabName);

            return __ret;
        }

        static StackObject* SpawnPlayer_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_prefabName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SpawnPlayer(@_prefabName);

            return __ret;
        }

        static StackObject* UnSpawnNetworkObject_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_entity = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnSpawnNetworkObject(@_entity);

            return __ret;
        }

        static StackObject* GetLocalPlayer_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalPlayer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SpawnSync_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkConnection @_connection =
                (Mirror.NetworkConnection) typeof(Mirror.NetworkConnection).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_gameObject = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SpawnSync(@_gameObject, @_connection);

            return __ret;
        }

        static StackObject* NetworkObjectDestroy_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_gameObject = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NetworkObjectDestroy(@_gameObject);

            return __ret;
        }

        static StackObject* AssignClientAuthority_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_connection = (Mirror.NetworkIdentity) typeof(Mirror.NetworkIdentity).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Mirror.NetworkIdentity @_assignedObject =
                (Mirror.NetworkIdentity) typeof(Mirror.NetworkIdentity).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AssignClientAuthority(@_assignedObject, @_connection);

            return __ret;
        }

        static StackObject* StartHost_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartHost();

            return __ret;
        }

        static StackObject* StartAsAServer_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartAsAServer();

            return __ret;
        }

        static StackObject* ConnectToServer_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_port = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_iPAddress = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ConnectToServer(@_iPAddress, @_port);

            return __ret;
        }

        static StackObject* ConnectToServerByDiscovery_14(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ConnectToServerByDiscovery();

            return __ret;
        }

        static StackObject* Disconnected_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Disconnected();

            return __ret;
        }

        static StackObject* GetLocalIP_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalIP();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLocalNetworkConnection_17(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalNetworkConnection();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UsedOnlyForAOTCodeGeneration_18(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.PhantomsXR.MirrorExtension.Runtime.XRMODServices instance_of_this_method =
                (com.PhantomsXR.MirrorExtension.Runtime.XRMODServices)
                typeof(com.PhantomsXR.MirrorExtension.Runtime.XRMODServices).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UsedOnlyForAOTCodeGeneration();

            return __ret;
        }


        static object get_SpawnCallback_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).SpawnCallback;
        }

        static StackObject* CopyToStack_SpawnCallback_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).SpawnCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SpawnCallback_0(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).SpawnCallback =
                (System.Action<UnityEngine.GameObject>) v;
        }

        static StackObject* AssignFromStack_SpawnCallback_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.GameObject> @SpawnCallback =
                (System.Action<UnityEngine.GameObject>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).SpawnCallback = @SpawnCallback;
            return ptr_of_this_method;
        }

        // static object get_OnServerFoundCallback_1(ref object o)
        // {
        //     return ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).OnServerFoundCallback;
        // }
        //
        // static StackObject* CopyToStack_OnServerFoundCallback_1(ref object o, ILIntepreter __intp, StackObject* __ret,
        //     AutoList __mStack)
        // {
        //     var result_of_this_method =
        //         ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).OnServerFoundCallback;
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static void set_OnServerFoundCallback_1(ref object o, object v)
        // {
        //     ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).OnServerFoundCallback =
        //         (System.Action<Mirror.Discovery.ServerResponse>) v;
        // }

        // static StackObject* AssignFromStack_OnServerFoundCallback_1(ref object o, ILIntepreter __intp,
        //     StackObject* ptr_of_this_method, AutoList __mStack)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     System.Action<Mirror.Discovery.ServerResponse> @OnServerFoundCallback =
        //         (System.Action<Mirror.Discovery.ServerResponse>) typeof(System.Action<Mirror.Discovery.ServerResponse>)
        //             .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
        //                 (CLR.Utils.Extensions.TypeFlags) 8);
        //     ((com.PhantomsXR.MirrorExtension.Runtime.XRMODServices) o).OnServerFoundCallback =
        //         @OnServerFoundCallback;
        //     return ptr_of_this_method;
        // }
    }
}