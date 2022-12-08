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
    unsafe class NetworkAttributes_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerStringSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerStringSender_0);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerFloatSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerFloatSender_1);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerIntSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerIntSender_2);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerBoolSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerBoolSender_3);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerVector3Sender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerVector3Sender_4);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerQuaternionSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerQuaternionSender_5);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerSender_6);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerGameObjectSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerGameObjectSender_7);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerTransformDataSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerTransformDataSender_8);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientSender_9);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientStringSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientStringSender_10);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientFloatSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientFloatSender_11);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientIntSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientIntSender_12);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientBoolSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientBoolSender_13);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientVector3Sender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientVector3Sender_14);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientQuaternionSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientQuaternionSender_15);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientGameObjectSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientGameObjectSender_16);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientTransformDataSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientTransformDataSender_17);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_18);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_19);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_20);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_21);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_22);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_23);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_24);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_25);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ServerCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ServerCallbackSender_26);
            args = new Type[]{typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackSender_27);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackStringSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackStringSender_28);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackFloatSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackFloatSender_29);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackIntSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackIntSender_30);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackBoolSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackBoolSender_31);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector3), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackVector3Sender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackVector3Sender_32);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Quaternion), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackQuaternionSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackQuaternionSender_33);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GameObject), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackGameObjectSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackGameObjectSender_34);
            args = new Type[]{typeof(System.String), typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData), typeof(Mirror.NetworkIdentity)};
            method = type.GetMethod("ClientCallbackTransformDataSender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClientCallbackTransformDataSender_35);

            field = type.GetField("ServerAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerAction_0);
            app.RegisterCLRFieldSetter(field, set_ServerAction_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerAction_0, AssignFromStack_ServerAction_0);
            field = type.GetField("ServerStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerStringAction_1);
            app.RegisterCLRFieldSetter(field, set_ServerStringAction_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerStringAction_1, AssignFromStack_ServerStringAction_1);
            field = type.GetField("ServerFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerFloatAction_2);
            app.RegisterCLRFieldSetter(field, set_ServerFloatAction_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerFloatAction_2, AssignFromStack_ServerFloatAction_2);
            field = type.GetField("ServerIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerIntAction_3);
            app.RegisterCLRFieldSetter(field, set_ServerIntAction_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerIntAction_3, AssignFromStack_ServerIntAction_3);
            field = type.GetField("ServerBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerBoolAction_4);
            app.RegisterCLRFieldSetter(field, set_ServerBoolAction_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerBoolAction_4, AssignFromStack_ServerBoolAction_4);
            field = type.GetField("ServerVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_ServerVector3Action_5);
            app.RegisterCLRFieldSetter(field, set_ServerVector3Action_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerVector3Action_5, AssignFromStack_ServerVector3Action_5);
            field = type.GetField("ServerQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerQuaternionAction_6);
            app.RegisterCLRFieldSetter(field, set_ServerQuaternionAction_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerQuaternionAction_6, AssignFromStack_ServerQuaternionAction_6);
            field = type.GetField("ServerGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerGameObjectAction_7);
            app.RegisterCLRFieldSetter(field, set_ServerGameObjectAction_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerGameObjectAction_7, AssignFromStack_ServerGameObjectAction_7);
            field = type.GetField("ServerTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerTransformDataAction_8);
            app.RegisterCLRFieldSetter(field, set_ServerTransformDataAction_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerTransformDataAction_8, AssignFromStack_ServerTransformDataAction_8);
            field = type.GetField("ClientStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientStringAction_9);
            app.RegisterCLRFieldSetter(field, set_ClientStringAction_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientStringAction_9, AssignFromStack_ClientStringAction_9);
            field = type.GetField("ClientFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientFloatAction_10);
            app.RegisterCLRFieldSetter(field, set_ClientFloatAction_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientFloatAction_10, AssignFromStack_ClientFloatAction_10);
            field = type.GetField("ClientIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientIntAction_11);
            app.RegisterCLRFieldSetter(field, set_ClientIntAction_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientIntAction_11, AssignFromStack_ClientIntAction_11);
            field = type.GetField("ClientBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientBoolAction_12);
            app.RegisterCLRFieldSetter(field, set_ClientBoolAction_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientBoolAction_12, AssignFromStack_ClientBoolAction_12);
            field = type.GetField("ClientVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_ClientVector3Action_13);
            app.RegisterCLRFieldSetter(field, set_ClientVector3Action_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientVector3Action_13, AssignFromStack_ClientVector3Action_13);
            field = type.GetField("ClientQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientQuaternionAction_14);
            app.RegisterCLRFieldSetter(field, set_ClientQuaternionAction_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientQuaternionAction_14, AssignFromStack_ClientQuaternionAction_14);
            field = type.GetField("ClientGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientGameObjectAction_15);
            app.RegisterCLRFieldSetter(field, set_ClientGameObjectAction_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientGameObjectAction_15, AssignFromStack_ClientGameObjectAction_15);
            field = type.GetField("ClientTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientTransformDataAction_16);
            app.RegisterCLRFieldSetter(field, set_ClientTransformDataAction_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientTransformDataAction_16, AssignFromStack_ClientTransformDataAction_16);
            field = type.GetField("ClientAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientAction_17);
            app.RegisterCLRFieldSetter(field, set_ClientAction_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientAction_17, AssignFromStack_ClientAction_17);
            field = type.GetField("ServerCallbackStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackStringAction_18);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackStringAction_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackStringAction_18, AssignFromStack_ServerCallbackStringAction_18);
            field = type.GetField("ServerCallbackFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackFloatAction_19);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackFloatAction_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackFloatAction_19, AssignFromStack_ServerCallbackFloatAction_19);
            field = type.GetField("ServerCallbackIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackIntAction_20);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackIntAction_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackIntAction_20, AssignFromStack_ServerCallbackIntAction_20);
            field = type.GetField("ServerCallbackBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackBoolAction_21);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackBoolAction_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackBoolAction_21, AssignFromStack_ServerCallbackBoolAction_21);
            field = type.GetField("ServerCallbackVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackVector3Action_22);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackVector3Action_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackVector3Action_22, AssignFromStack_ServerCallbackVector3Action_22);
            field = type.GetField("ServerCallbackQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackQuaternionAction_23);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackQuaternionAction_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackQuaternionAction_23, AssignFromStack_ServerCallbackQuaternionAction_23);
            field = type.GetField("ServerCallbackGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackGameObjectAction_24);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackGameObjectAction_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackGameObjectAction_24, AssignFromStack_ServerCallbackGameObjectAction_24);
            field = type.GetField("ServerCallbackTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackTransformDataAction_25);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackTransformDataAction_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackTransformDataAction_25, AssignFromStack_ServerCallbackTransformDataAction_25);
            field = type.GetField("ServerCallbackAction", flag);
            app.RegisterCLRFieldGetter(field, get_ServerCallbackAction_26);
            app.RegisterCLRFieldSetter(field, set_ServerCallbackAction_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerCallbackAction_26, AssignFromStack_ServerCallbackAction_26);
            field = type.GetField("ClientCallbackStringAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackStringAction_27);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackStringAction_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackStringAction_27, AssignFromStack_ClientCallbackStringAction_27);
            field = type.GetField("ClientCallbackFloatAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackFloatAction_28);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackFloatAction_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackFloatAction_28, AssignFromStack_ClientCallbackFloatAction_28);
            field = type.GetField("ClientCallbackIntAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackIntAction_29);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackIntAction_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackIntAction_29, AssignFromStack_ClientCallbackIntAction_29);
            field = type.GetField("ClientCallbackBoolAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackBoolAction_30);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackBoolAction_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackBoolAction_30, AssignFromStack_ClientCallbackBoolAction_30);
            field = type.GetField("ClientCallbackVector3Action", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackVector3Action_31);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackVector3Action_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackVector3Action_31, AssignFromStack_ClientCallbackVector3Action_31);
            field = type.GetField("ClientCallbackQuaternionAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackQuaternionAction_32);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackQuaternionAction_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackQuaternionAction_32, AssignFromStack_ClientCallbackQuaternionAction_32);
            field = type.GetField("ClientCallbackGameObjectAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackGameObjectAction_33);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackGameObjectAction_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackGameObjectAction_33, AssignFromStack_ClientCallbackGameObjectAction_33);
            field = type.GetField("ClientCallbackTransformDataAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackTransformDataAction_34);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackTransformDataAction_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackTransformDataAction_34, AssignFromStack_ClientCallbackTransformDataAction_34);
            field = type.GetField("ClientCallbackAction", flag);
            app.RegisterCLRFieldGetter(field, get_ClientCallbackAction_35);
            app.RegisterCLRFieldSetter(field, set_ClientCallbackAction_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientCallbackAction_35, AssignFromStack_ClientCallbackAction_35);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* ServerStringSender_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerStringSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerFloatSender_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerFloatSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerIntSender_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerIntSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerBoolSender_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerBoolSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerVector3Sender_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerVector3Sender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerQuaternionSender_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerQuaternionSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerSender_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* ServerGameObjectSender_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerGameObjectSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerTransformDataSender_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerTransformDataSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientSender_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* ClientStringSender_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientStringSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientFloatSender_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientFloatSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientIntSender_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientIntSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientBoolSender_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientBoolSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientVector3Sender_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientVector3Sender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientQuaternionSender_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientQuaternionSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientGameObjectSender_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientGameObjectSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientTransformDataSender_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientTransformDataSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ServerCallbackSender_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ServerCallbackSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackSender_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackSender(@_eventName, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackStringSender_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackStringSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackFloatSender_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackFloatSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackIntSender_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackIntSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackBoolSender_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackBoolSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackVector3Sender_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackVector3Sender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackQuaternionSender_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackQuaternionSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackGameObjectSender_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackGameObjectSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }

        static StackObject* ClientCallbackTransformDataSender_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks instance_of_this_method = (com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)typeof(com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClientCallbackTransformDataSender(@_eventName, @_parameter, @_sender);

            return __ret;
        }


        static object get_ServerAction_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerAction;
        }

        static StackObject* CopyToStack_ServerAction_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerAction_0(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerAction_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @ServerAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerAction = @ServerAction;
            return ptr_of_this_method;
        }

        static object get_ServerStringAction_1(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerStringAction;
        }

        static StackObject* CopyToStack_ServerStringAction_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerStringAction_1(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerStringAction_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @ServerStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerStringAction = @ServerStringAction;
            return ptr_of_this_method;
        }

        static object get_ServerFloatAction_2(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerFloatAction;
        }

        static StackObject* CopyToStack_ServerFloatAction_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerFloatAction_2(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerFloatAction_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @ServerFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerFloatAction = @ServerFloatAction;
            return ptr_of_this_method;
        }

        static object get_ServerIntAction_3(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerIntAction;
        }

        static StackObject* CopyToStack_ServerIntAction_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerIntAction_3(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerIntAction_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @ServerIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerIntAction = @ServerIntAction;
            return ptr_of_this_method;
        }

        static object get_ServerBoolAction_4(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerBoolAction;
        }

        static StackObject* CopyToStack_ServerBoolAction_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerBoolAction_4(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerBoolAction_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @ServerBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerBoolAction = @ServerBoolAction;
            return ptr_of_this_method;
        }

        static object get_ServerVector3Action_5(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerVector3Action;
        }

        static StackObject* CopyToStack_ServerVector3Action_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerVector3Action_5(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerVector3Action_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @ServerVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerVector3Action = @ServerVector3Action;
            return ptr_of_this_method;
        }

        static object get_ServerQuaternionAction_6(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerQuaternionAction;
        }

        static StackObject* CopyToStack_ServerQuaternionAction_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerQuaternionAction_6(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerQuaternionAction_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @ServerQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerQuaternionAction = @ServerQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_ServerGameObjectAction_7(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerGameObjectAction;
        }

        static StackObject* CopyToStack_ServerGameObjectAction_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerGameObjectAction_7(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerGameObjectAction_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @ServerGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerGameObjectAction = @ServerGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_ServerTransformDataAction_8(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerTransformDataAction;
        }

        static StackObject* CopyToStack_ServerTransformDataAction_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerTransformDataAction_8(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerTransformDataAction_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @ServerTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerTransformDataAction = @ServerTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_ClientStringAction_9(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientStringAction;
        }

        static StackObject* CopyToStack_ClientStringAction_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientStringAction_9(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientStringAction_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @ClientStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientStringAction = @ClientStringAction;
            return ptr_of_this_method;
        }

        static object get_ClientFloatAction_10(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientFloatAction;
        }

        static StackObject* CopyToStack_ClientFloatAction_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientFloatAction_10(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientFloatAction_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @ClientFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientFloatAction = @ClientFloatAction;
            return ptr_of_this_method;
        }

        static object get_ClientIntAction_11(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientIntAction;
        }

        static StackObject* CopyToStack_ClientIntAction_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientIntAction_11(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientIntAction_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @ClientIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientIntAction = @ClientIntAction;
            return ptr_of_this_method;
        }

        static object get_ClientBoolAction_12(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientBoolAction;
        }

        static StackObject* CopyToStack_ClientBoolAction_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientBoolAction_12(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientBoolAction_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @ClientBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientBoolAction = @ClientBoolAction;
            return ptr_of_this_method;
        }

        static object get_ClientVector3Action_13(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientVector3Action;
        }

        static StackObject* CopyToStack_ClientVector3Action_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientVector3Action_13(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientVector3Action_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @ClientVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientVector3Action = @ClientVector3Action;
            return ptr_of_this_method;
        }

        static object get_ClientQuaternionAction_14(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientQuaternionAction;
        }

        static StackObject* CopyToStack_ClientQuaternionAction_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientQuaternionAction_14(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientQuaternionAction_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @ClientQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientQuaternionAction = @ClientQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_ClientGameObjectAction_15(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientGameObjectAction;
        }

        static StackObject* CopyToStack_ClientGameObjectAction_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientGameObjectAction_15(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientGameObjectAction_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @ClientGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientGameObjectAction = @ClientGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_ClientTransformDataAction_16(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientTransformDataAction;
        }

        static StackObject* CopyToStack_ClientTransformDataAction_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientTransformDataAction_16(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientTransformDataAction_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @ClientTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientTransformDataAction = @ClientTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_ClientAction_17(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientAction;
        }

        static StackObject* CopyToStack_ClientAction_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientAction_17(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientAction_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @ClientAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientAction = @ClientAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackStringAction_18(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackStringAction;
        }

        static StackObject* CopyToStack_ServerCallbackStringAction_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackStringAction_18(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackStringAction_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @ServerCallbackStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackStringAction = @ServerCallbackStringAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackFloatAction_19(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackFloatAction;
        }

        static StackObject* CopyToStack_ServerCallbackFloatAction_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackFloatAction_19(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackFloatAction_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @ServerCallbackFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackFloatAction = @ServerCallbackFloatAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackIntAction_20(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackIntAction;
        }

        static StackObject* CopyToStack_ServerCallbackIntAction_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackIntAction_20(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackIntAction_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @ServerCallbackIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackIntAction = @ServerCallbackIntAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackBoolAction_21(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackBoolAction;
        }

        static StackObject* CopyToStack_ServerCallbackBoolAction_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackBoolAction_21(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackBoolAction_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @ServerCallbackBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackBoolAction = @ServerCallbackBoolAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackVector3Action_22(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackVector3Action;
        }

        static StackObject* CopyToStack_ServerCallbackVector3Action_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackVector3Action_22(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackVector3Action_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @ServerCallbackVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackVector3Action = @ServerCallbackVector3Action;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackQuaternionAction_23(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackQuaternionAction;
        }

        static StackObject* CopyToStack_ServerCallbackQuaternionAction_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackQuaternionAction_23(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackQuaternionAction_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @ServerCallbackQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackQuaternionAction = @ServerCallbackQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackGameObjectAction_24(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackGameObjectAction;
        }

        static StackObject* CopyToStack_ServerCallbackGameObjectAction_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackGameObjectAction_24(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackGameObjectAction_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @ServerCallbackGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackGameObjectAction = @ServerCallbackGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackTransformDataAction_25(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackTransformDataAction;
        }

        static StackObject* CopyToStack_ServerCallbackTransformDataAction_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackTransformDataAction_25(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackTransformDataAction_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @ServerCallbackTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackTransformDataAction = @ServerCallbackTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_ServerCallbackAction_26(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackAction;
        }

        static StackObject* CopyToStack_ServerCallbackAction_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ServerCallbackAction_26(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ServerCallbackAction_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @ServerCallbackAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ServerCallbackAction = @ServerCallbackAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackStringAction_27(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackStringAction;
        }

        static StackObject* CopyToStack_ClientCallbackStringAction_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackStringAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackStringAction_27(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackStringAction_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>> @ClientCallbackStringAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.String, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackStringAction = @ClientCallbackStringAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackFloatAction_28(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackFloatAction;
        }

        static StackObject* CopyToStack_ClientCallbackFloatAction_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackFloatAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackFloatAction_28(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackFloatAction_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>> @ClientCallbackFloatAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Single, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackFloatAction = @ClientCallbackFloatAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackIntAction_29(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackIntAction;
        }

        static StackObject* CopyToStack_ClientCallbackIntAction_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackIntAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackIntAction_29(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackIntAction_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>> @ClientCallbackIntAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Int32, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackIntAction = @ClientCallbackIntAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackBoolAction_30(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackBoolAction;
        }

        static StackObject* CopyToStack_ClientCallbackBoolAction_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackBoolAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackBoolAction_30(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackBoolAction_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>> @ClientCallbackBoolAction = (System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<System.Boolean, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackBoolAction = @ClientCallbackBoolAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackVector3Action_31(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackVector3Action;
        }

        static StackObject* CopyToStack_ClientCallbackVector3Action_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackVector3Action;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackVector3Action_31(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackVector3Action_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>> @ClientCallbackVector3Action = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Vector3, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackVector3Action = @ClientCallbackVector3Action;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackQuaternionAction_32(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackQuaternionAction;
        }

        static StackObject* CopyToStack_ClientCallbackQuaternionAction_32(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackQuaternionAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackQuaternionAction_32(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackQuaternionAction_32(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>> @ClientCallbackQuaternionAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.Quaternion, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackQuaternionAction = @ClientCallbackQuaternionAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackGameObjectAction_33(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackGameObjectAction;
        }

        static StackObject* CopyToStack_ClientCallbackGameObjectAction_33(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackGameObjectAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackGameObjectAction_33(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackGameObjectAction_33(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>> @ClientCallbackGameObjectAction = (System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<UnityEngine.GameObject, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackGameObjectAction = @ClientCallbackGameObjectAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackTransformDataAction_34(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackTransformDataAction;
        }

        static StackObject* CopyToStack_ClientCallbackTransformDataAction_34(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackTransformDataAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackTransformDataAction_34(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackTransformDataAction_34(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>> @ClientCallbackTransformDataAction = (System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<com.PhantomsXR.MirrorExtension.Runtime.TransformData, Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackTransformDataAction = @ClientCallbackTransformDataAction;
            return ptr_of_this_method;
        }

        static object get_ClientCallbackAction_35(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackAction;
        }

        static StackObject* CopyToStack_ClientCallbackAction_35(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackAction;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientCallbackAction_35(ref object o, object v)
        {
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)v;
        }

        static StackObject* AssignFromStack_ClientCallbackAction_35(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>> @ClientCallbackAction = (System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Action<Mirror.NetworkIdentity>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks)o).ClientCallbackAction = @ClientCallbackAction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.PhantomsXR.MirrorExtension.Runtime.NetworkingCallbacks();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
