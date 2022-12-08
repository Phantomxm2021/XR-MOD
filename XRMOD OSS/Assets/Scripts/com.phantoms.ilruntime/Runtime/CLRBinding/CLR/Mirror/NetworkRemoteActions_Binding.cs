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
    unsafe class NetworkRemoteActions_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdSender_0);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdStringSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdStringSender_1);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdVector3Sender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdVector3Sender_2);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdQuaternionSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdQuaternionSender_3);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdFloatSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdFloatSender_4);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdBoolSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdBoolSender_5);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdIntSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdIntSender_6);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdGameObjectSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdGameObjectSender_7);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("CmdTransformDataSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CmdTransformDataSender_8);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcSender_9);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcStringSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcStringSender_10);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcFloatSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcFloatSender_11);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcIntSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcIntSender_12);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcBoolSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcBoolSender_13);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcVector3Sender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcVector3Sender_14);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcQuaternionSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcQuaternionSender_15);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcGameObjectSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcGameObjectSender_16);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("TargetRpcTransformDataSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TargetRpcTransformDataSender_17);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcSender_18);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcStringSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcStringSender_19);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcFloatSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcFloatSender_20);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcIntSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcIntSender_21);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcBoolSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcBoolSender_22);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcVector3Sender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcVector3Sender_23);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcQuaternionSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcQuaternionSender_24);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcGameObjectSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcGameObjectSender_25);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("RpcClientRpcTransformDataSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RpcClientRpcTransformDataSender_26);

            field = type.GetField("CmdStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdStringAction_0);
            app.RegisterCLRFieldSetter(field, set_CmdStringAction_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdStringAction_0, AssignFromStack_CmdStringAction_0);
            field = type.GetField("CmdFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdFloatAction_1);
            app.RegisterCLRFieldSetter(field, set_CmdFloatAction_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdFloatAction_1, AssignFromStack_CmdFloatAction_1);
            field = type.GetField("CmdIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdIntAction_2);
            app.RegisterCLRFieldSetter(field, set_CmdIntAction_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdIntAction_2, AssignFromStack_CmdIntAction_2);
            field = type.GetField("CmdBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdBoolAction_3);
            app.RegisterCLRFieldSetter(field, set_CmdBoolAction_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdBoolAction_3, AssignFromStack_CmdBoolAction_3);
            field = type.GetField("CmdVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_CmdVector3Action_4);
            app.RegisterCLRFieldSetter(field, set_CmdVector3Action_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdVector3Action_4, AssignFromStack_CmdVector3Action_4);
            field = type.GetField("CmdQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdQuaternionAction_5);
            app.RegisterCLRFieldSetter(field, set_CmdQuaternionAction_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdQuaternionAction_5, AssignFromStack_CmdQuaternionAction_5);
            field = type.GetField("CmdGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdGameObjectAction_6);
            app.RegisterCLRFieldSetter(field, set_CmdGameObjectAction_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdGameObjectAction_6, AssignFromStack_CmdGameObjectAction_6);
            field = type.GetField("CmdTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdTransformDataAction_7);
            app.RegisterCLRFieldSetter(field, set_CmdTransformDataAction_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdTransformDataAction_7, AssignFromStack_CmdTransformDataAction_7);
            field = type.GetField("CmdAction", flag);
            app.RegisterCLRFieldGetter(field, get_CmdAction_8);
            app.RegisterCLRFieldSetter(field, set_CmdAction_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_CmdAction_8, AssignFromStack_CmdAction_8);
            field = type.GetField("TargetRpcStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcStringAction_9);
            app.RegisterCLRFieldSetter(field, set_TargetRpcStringAction_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcStringAction_9, AssignFromStack_TargetRpcStringAction_9);
            field = type.GetField("TargetRpcFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcFloatAction_10);
            app.RegisterCLRFieldSetter(field, set_TargetRpcFloatAction_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcFloatAction_10, AssignFromStack_TargetRpcFloatAction_10);
            field = type.GetField("TargetRpcIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcIntAction_11);
            app.RegisterCLRFieldSetter(field, set_TargetRpcIntAction_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcIntAction_11, AssignFromStack_TargetRpcIntAction_11);
            field = type.GetField("TargetRpcBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcBoolAction_12);
            app.RegisterCLRFieldSetter(field, set_TargetRpcBoolAction_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcBoolAction_12, AssignFromStack_TargetRpcBoolAction_12);
            field = type.GetField("TargetRpcVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcVector3Action_13);
            app.RegisterCLRFieldSetter(field, set_TargetRpcVector3Action_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcVector3Action_13, AssignFromStack_TargetRpcVector3Action_13);
            field = type.GetField("TargetRpcQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcQuaternionAction_14);
            app.RegisterCLRFieldSetter(field, set_TargetRpcQuaternionAction_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcQuaternionAction_14, AssignFromStack_TargetRpcQuaternionAction_14);
            field = type.GetField("TargetRpcGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcGameObjectAction_15);
            app.RegisterCLRFieldSetter(field, set_TargetRpcGameObjectAction_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcGameObjectAction_15, AssignFromStack_TargetRpcGameObjectAction_15);
            field = type.GetField("TargetRpcTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcTransformDataAction_16);
            app.RegisterCLRFieldSetter(field, set_TargetRpcTransformDataAction_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcTransformDataAction_16, AssignFromStack_TargetRpcTransformDataAction_16);
            field = type.GetField("TargetRpcAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRpcAction_17);
            app.RegisterCLRFieldSetter(field, set_TargetRpcAction_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRpcAction_17, AssignFromStack_TargetRpcAction_17);
            field = type.GetField("ClientRpcStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcStringAction_18);
            app.RegisterCLRFieldSetter(field, set_ClientRpcStringAction_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcStringAction_18, AssignFromStack_ClientRpcStringAction_18);
            field = type.GetField("ClientRpcFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcFloatAction_19);
            app.RegisterCLRFieldSetter(field, set_ClientRpcFloatAction_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcFloatAction_19, AssignFromStack_ClientRpcFloatAction_19);
            field = type.GetField("ClientRpcIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcIntAction_20);
            app.RegisterCLRFieldSetter(field, set_ClientRpcIntAction_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcIntAction_20, AssignFromStack_ClientRpcIntAction_20);
            field = type.GetField("ClientRpcBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcBoolAction_21);
            app.RegisterCLRFieldSetter(field, set_ClientRpcBoolAction_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcBoolAction_21, AssignFromStack_ClientRpcBoolAction_21);
            field = type.GetField("ClientRpcVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcVector3Action_22);
            app.RegisterCLRFieldSetter(field, set_ClientRpcVector3Action_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcVector3Action_22, AssignFromStack_ClientRpcVector3Action_22);
            field = type.GetField("ClientRpcQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcQuaternionAction_23);
            app.RegisterCLRFieldSetter(field, set_ClientRpcQuaternionAction_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcQuaternionAction_23, AssignFromStack_ClientRpcQuaternionAction_23);
            field = type.GetField("ClientRpcGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcGameObjectAction_24);
            app.RegisterCLRFieldSetter(field, set_ClientRpcGameObjectAction_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcGameObjectAction_24, AssignFromStack_ClientRpcGameObjectAction_24);
            field = type.GetField("ClientRpcTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcTransformDataAction_25);
            app.RegisterCLRFieldSetter(field, set_ClientRpcTransformDataAction_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcTransformDataAction_25, AssignFromStack_ClientRpcTransformDataAction_25);
            field = type.GetField("ClientRpcAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientRpcAction_26);
            app.RegisterCLRFieldSetter(field, set_ClientRpcAction_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientRpcAction_26, AssignFromStack_ClientRpcAction_26);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* CmdSender_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* CmdStringSender_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_parameter = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdStringSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdVector3Sender_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_parameter = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdVector3Sender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdQuaternionSender_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @_parameter = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdQuaternionSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdFloatSender_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @_parameter = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdFloatSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdBoolSender_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_parameter = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdBoolSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdIntSender_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_parameter = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdIntSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdGameObjectSender_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_parameter = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdGameObjectSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* CmdTransformDataSender_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.TransformData @_parameter = (com.PhantomsXR.MirrorExtension.Runtime.TransformData)typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CmdTransformDataSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcSender_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcStringSender_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_parameter = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcStringSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcFloatSender_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @_parameter = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcFloatSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcIntSender_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_parameter = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcIntSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcBoolSender_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_parameter = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcBoolSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcVector3Sender_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_parameter = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcVector3Sender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcQuaternionSender_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @_parameter = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcQuaternionSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcGameObjectSender_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_parameter = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcGameObjectSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* TargetRpcTransformDataSender_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.TransformData @_parameter = (com.PhantomsXR.MirrorExtension.Runtime.TransformData)typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TargetRpcTransformDataSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcSender_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcStringSender_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_parameter = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcStringSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcFloatSender_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @_parameter = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcFloatSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcIntSender_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_parameter = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcIntSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcBoolSender_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_parameter = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcBoolSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcVector3Sender_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_parameter = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcVector3Sender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcQuaternionSender_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @_parameter = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcQuaternionSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcGameObjectSender_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_parameter = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcGameObjectSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* RpcClientRpcTransformDataSender_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Mirror.NetworkIdentity @_sender = (Mirror.NetworkIdentity)typeof(Mirror.NetworkIdentity).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.PhantomsXR.MirrorExtension.Runtime.TransformData @_parameter = (com.PhantomsXR.MirrorExtension.Runtime.TransformData)typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_eventName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RpcClientRpcTransformDataSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }


        static object get_CmdStringAction_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdStringAction;
        }

        static StackObject* CopyToStack_CmdStringAction_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdStringAction_0(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdStringAction_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @CmdStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdStringAction = @CmdStringAction;
            return ptr_of_this_method;
        }

        static object get_CmdFloatAction_1(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdFloatAction;
        }

        static StackObject* CopyToStack_CmdFloatAction_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdFloatAction_1(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdFloatAction_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @CmdFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdFloatAction = @CmdFloatAction;
            return ptr_of_this_method;
        }

        static object get_CmdIntAction_2(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdIntAction;
        }

        static StackObject* CopyToStack_CmdIntAction_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdIntAction_2(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdIntAction_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @CmdIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdIntAction = @CmdIntAction;
            return ptr_of_this_method;
        }

        static object get_CmdBoolAction_3(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdBoolAction;
        }

        static StackObject* CopyToStack_CmdBoolAction_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdBoolAction_3(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdBoolAction_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @CmdBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdBoolAction = @CmdBoolAction;
            return ptr_of_this_method;
        }

        static object get_CmdVector3Action_4(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdVector3Action;
        }

        static StackObject* CopyToStack_CmdVector3Action_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdVector3Action_4(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdVector3Action_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @CmdVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdVector3Action = @CmdVector3Action;
            return ptr_of_this_method;
        }

        static object get_CmdQuaternionAction_5(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdQuaternionAction;
        }

        static StackObject* CopyToStack_CmdQuaternionAction_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdQuaternionAction_5(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdQuaternionAction_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @CmdQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdQuaternionAction = @CmdQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_CmdGameObjectAction_6(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdGameObjectAction;
        }

        static StackObject* CopyToStack_CmdGameObjectAction_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdGameObjectAction_6(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdGameObjectAction_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @CmdGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdGameObjectAction = @CmdGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_CmdTransformDataAction_7(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdTransformDataAction;
        }

        static StackObject* CopyToStack_CmdTransformDataAction_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdTransformDataAction_7(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdTransformDataAction_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @CmdTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdTransformDataAction = @CmdTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_CmdAction_8(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdAction;
        }

        static StackObject* CopyToStack_CmdAction_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CmdAction_8(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_CmdAction_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @CmdAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).CmdAction = @CmdAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcStringAction_9(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcStringAction;
        }

        static StackObject* CopyToStack_TargetRpcStringAction_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcStringAction_9(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcStringAction_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @TargetRpcStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcStringAction = @TargetRpcStringAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcFloatAction_10(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcFloatAction;
        }

        static StackObject* CopyToStack_TargetRpcFloatAction_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcFloatAction_10(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcFloatAction_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @TargetRpcFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcFloatAction = @TargetRpcFloatAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcIntAction_11(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcIntAction;
        }

        static StackObject* CopyToStack_TargetRpcIntAction_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcIntAction_11(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcIntAction_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @TargetRpcIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcIntAction = @TargetRpcIntAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcBoolAction_12(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcBoolAction;
        }

        static StackObject* CopyToStack_TargetRpcBoolAction_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcBoolAction_12(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcBoolAction_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @TargetRpcBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcBoolAction = @TargetRpcBoolAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcVector3Action_13(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcVector3Action;
        }

        static StackObject* CopyToStack_TargetRpcVector3Action_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcVector3Action_13(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcVector3Action_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @TargetRpcVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcVector3Action = @TargetRpcVector3Action;
            return ptr_of_this_method;
        }

        static object get_TargetRpcQuaternionAction_14(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcQuaternionAction;
        }

        static StackObject* CopyToStack_TargetRpcQuaternionAction_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcQuaternionAction_14(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcQuaternionAction_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @TargetRpcQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcQuaternionAction = @TargetRpcQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcGameObjectAction_15(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcGameObjectAction;
        }

        static StackObject* CopyToStack_TargetRpcGameObjectAction_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcGameObjectAction_15(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcGameObjectAction_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @TargetRpcGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcGameObjectAction = @TargetRpcGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcTransformDataAction_16(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcTransformDataAction;
        }

        static StackObject* CopyToStack_TargetRpcTransformDataAction_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcTransformDataAction_16(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcTransformDataAction_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @TargetRpcTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcTransformDataAction = @TargetRpcTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_TargetRpcAction_17(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcAction;
        }

        static StackObject* CopyToStack_TargetRpcAction_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRpcAction_17(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_TargetRpcAction_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @TargetRpcAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).TargetRpcAction = @TargetRpcAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcStringAction_18(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcStringAction;
        }

        static StackObject* CopyToStack_ClientRpcStringAction_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcStringAction_18(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcStringAction_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @ClientRpcStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcStringAction = @ClientRpcStringAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcFloatAction_19(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcFloatAction;
        }

        static StackObject* CopyToStack_ClientRpcFloatAction_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcFloatAction_19(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcFloatAction_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @ClientRpcFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcFloatAction = @ClientRpcFloatAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcIntAction_20(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcIntAction;
        }

        static StackObject* CopyToStack_ClientRpcIntAction_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcIntAction_20(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcIntAction_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @ClientRpcIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcIntAction = @ClientRpcIntAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcBoolAction_21(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcBoolAction;
        }

        static StackObject* CopyToStack_ClientRpcBoolAction_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcBoolAction_21(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcBoolAction_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @ClientRpcBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcBoolAction = @ClientRpcBoolAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcVector3Action_22(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcVector3Action;
        }

        static StackObject* CopyToStack_ClientRpcVector3Action_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcVector3Action_22(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcVector3Action_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @ClientRpcVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcVector3Action = @ClientRpcVector3Action;
            return ptr_of_this_method;
        }

        static object get_ClientRpcQuaternionAction_23(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcQuaternionAction;
        }

        static StackObject* CopyToStack_ClientRpcQuaternionAction_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcQuaternionAction_23(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcQuaternionAction_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @ClientRpcQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcQuaternionAction = @ClientRpcQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcGameObjectAction_24(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcGameObjectAction;
        }

        static StackObject* CopyToStack_ClientRpcGameObjectAction_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcGameObjectAction_24(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcGameObjectAction_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @ClientRpcGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcGameObjectAction = @ClientRpcGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcTransformDataAction_25(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcTransformDataAction;
        }

        static StackObject* CopyToStack_ClientRpcTransformDataAction_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcTransformDataAction_25(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcTransformDataAction_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @ClientRpcTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcTransformDataAction = @ClientRpcTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_ClientRpcAction_26(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcAction;
        }

        static StackObject* CopyToStack_ClientRpcAction_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientRpcAction_26(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientRpcAction_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @ClientRpcAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions)o).ClientRpcAction = @ClientRpcAction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.PhantomsXR.MirrorExtension.Runtime.NetworkRemoteActions();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
