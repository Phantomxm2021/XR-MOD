// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Linq;
using System.Reflection;
using com.phantoms.ilruntime.Runtime.CodeHook.Runtime.CLRMethodRegister;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Generated;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace com.Phantoms.ILRuntime.Runtime
{
    public class RegisterClrMethodRedirection : IRegister
    {
        public unsafe void Register(AppDomain _appDomain)
        {
            //CLRMethodRedirection._APP_DOMAIN = _appDomain;

            // Type[] args;
            // BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
            //                     BindingFlags.DeclaredOnly;
            //
            //
            // Type gameObjectType = typeof(GameObject);
            // Type componentType = typeof(Component);

            //注册send message
            // args = new Type[] {typeof(System.String)};
            // var SendMessageMethod_1 = gameObjectType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod_1, CLRMethodRedirection.SendMessage_1);
            // args = new Type[] {typeof(System.String), typeof(System.Object)};
            // var SendMessageMethod_2 = gameObjectType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod_2, CLRMethodRedirection.SendMessage_2);
            // args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageMethod_3 = gameObjectType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod_3, CLRMethodRedirection.SendMessage_3);
            // args = new Type[] {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageMethod_4 = gameObjectType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod_4, CLRMethodRedirection.SendMessage_4);

            //注册send message upwards
            // args = new Type[] {typeof(System.String)};
            // var SendMessageUpwardsMethod_1 = gameObjectType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod_1,
            //     CLRMethodRedirection.SendMessageUpwards_1);
            // args = new Type[] {typeof(System.String), typeof(System.Object)};
            // var SendMessageUpwardsMethod_2 = gameObjectType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod_2,
            //     CLRMethodRedirection.SendMessageUpwards_2);
            // args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageUpwardsMethod_3 = gameObjectType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod_3,
            //     CLRMethodRedirection.SendMessageUpwards_3);
            // args = new Type[] {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageUpwardsMethod_4 = gameObjectType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod_4,
            //     CLRMethodRedirection.SendMessageUpwards_4);

            //注册BroadcastMessage
            // args = new Type[] {typeof(System.String)};
            // var BroadcastMessageMethod_1 = gameObjectType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod_1, CLRMethodRedirection.BroadcastMessage_1);
            // args = new Type[] {typeof(System.String), typeof(System.Object)};
            // var BroadcastMessageMethod_2 = gameObjectType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod_2, CLRMethodRedirection.BroadcastMessage_2);
            // args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            // var BroadcastMessageMethod_3 = gameObjectType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod_3, CLRMethodRedirection.BroadcastMessage_3);
            // args = new Type[] {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            // var BroadcastMessageMethod_4 = gameObjectType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod_4, CLRMethodRedirection.BroadcastMessage_4);

            //注册send message 4 component
            // args = new Type[] {typeof(System.String)};
            // var SendMessageMethod4ComponentType_1 = componentType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod4ComponentType_1,
            //     CLRMethodRedirection.SendMessage_1);
            // args = new Type[] {typeof(System.String), typeof(System.Object)};
            // var SendMessageMethod4ComponentType_2 = componentType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod4ComponentType_2,
            //     CLRMethodRedirection.SendMessage_2);
            // args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageMethod4ComponentType_3 = componentType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod4ComponentType_3,
            //     CLRMethodRedirection.SendMessage_3);
            // args = new Type[] {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageMethod4ComponentType_4 = componentType.GetMethod("SendMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageMethod4ComponentType_4,
            //     CLRMethodRedirection.SendMessage_4);

            //注册send message upwards 4 component
            // args = new Type[] {typeof(System.String)};
            // var SendMessageUpwardsMethod4ComponentType_1 =
            //     componentType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod4ComponentType_1,
            //     CLRMethodRedirection.SendMessageUpwards_1);
            // args = new Type[] {typeof(System.String), typeof(System.Object)};
            // var SendMessageUpwardsMethod4ComponentType_2 =
            //     componentType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod4ComponentType_2,
            //     CLRMethodRedirection.SendMessageUpwards_2);
            // args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageUpwardsMethod4ComponentType_3 =
            //     componentType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod4ComponentType_3,
            //     CLRMethodRedirection.SendMessageUpwards_3);
            // args = new Type[] {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            // var SendMessageUpwardsMethod4ComponentType_4 =
            //     componentType.GetMethod("SendMessageUpwards", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(SendMessageUpwardsMethod4ComponentType_4,
            //     CLRMethodRedirection.SendMessageUpwards_4);

            //注册BroadcastMessage 4 component
            // args = new Type[] {typeof(System.String)};
            // var BroadcastMessageMethod4ComponentType_1 =
            //     componentType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod4ComponentType_1,
            //     CLRMethodRedirection.BroadcastMessage_1);
            // args = new Type[] {typeof(System.String), typeof(System.Object)};
            // var BroadcastMessageMethod4ComponentType_2 =
            //     componentType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod4ComponentType_2,
            //     CLRMethodRedirection.BroadcastMessage_2);
            // args = new Type[] {typeof(System.String), typeof(UnityEngine.SendMessageOptions)};
            // var BroadcastMessageMethod4ComponentType_3 =
            //     componentType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod4ComponentType_3,
            //     CLRMethodRedirection.BroadcastMessage_3);
            // args = new Type[] {typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions)};
            // var BroadcastMessageMethod4ComponentType_4 =
            //     componentType.GetMethod("BroadcastMessage", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(BroadcastMessageMethod4ComponentType_4,
            //     CLRMethodRedirection.BroadcastMessage_4);

            //注册3种Log
            // Type debugType = typeof(Debug);
            // var logMethod = debugType.GetMethod("Log", new[] {typeof(object)});
            // _appDomain.RegisterCLRMethodRedirection(logMethod, CLRMethodRedirection.Log);
            // var logWarningMethod = debugType.GetMethod("LogWarning", new[] {typeof(object)});
            // _appDomain.RegisterCLRMethodRedirection(logWarningMethod, CLRMethodRedirection.LogWarning);
            // var logErrorMethod = debugType.GetMethod("LogError", new[] {typeof(object)});
            // _appDomain.RegisterCLRMethodRedirection(logErrorMethod, CLRMethodRedirection.LogError);


            //注册Instantiate
            // var objectType = typeof(UnityEngine.Object);
            // var instantiateMethod = objectType.GetMethod("Instantiate", flag, null, args, null);
            // var allMethods = objectType.GetMethods().ToList().FindAll(f => f.Name == "Instantiate");
            // //GameObject的方便点，不需要再去Get类型
            // args = new[] {typeof(GameObject)};
            // foreach (var m in allMethods)
            // {
            //     if (m.MatchGenericParameters(args, typeof(GameObject), typeof(GameObject)))
            //     {
            //         instantiateMethod = m.MakeGenericMethod(args);
            //         _appDomain.RegisterCLRMethodRedirection(instantiateMethod, CLRMethodRedirection.Instantiate_7);
            //     }
            //     else if (m.MatchGenericParameters(args, typeof(GameObject), typeof(GameObject),
            //                  typeof(Transform)))
            //     {
            //         instantiateMethod = m.MakeGenericMethod(args);
            //         _appDomain.RegisterCLRMethodRedirection(instantiateMethod, CLRMethodRedirection.Instantiate_8);
            //     }
            //     else if (m.MatchGenericParameters(args, typeof(GameObject), typeof(GameObject),
            //                  typeof(Transform), typeof(System.Boolean)))
            //     {
            //         instantiateMethod = m.MakeGenericMethod(args);
            //         _appDomain.RegisterCLRMethodRedirection(instantiateMethod, CLRMethodRedirection.Instantiate_9);
            //     }
            //     else if (m.MatchGenericParameters(args, typeof(GameObject), typeof(GameObject),
            //                  typeof(Vector3), typeof(Quaternion)))
            //     {
            //         instantiateMethod = m.MakeGenericMethod(args);
            //         _appDomain.RegisterCLRMethodRedirection(instantiateMethod, CLRMethodRedirection.Instantiate_10);
            //     }
            //     else if (m.MatchGenericParameters(args, typeof(GameObject), typeof(GameObject),
            //                  typeof(Vector3), typeof(Quaternion), typeof(Transform)))
            //     {
            //         instantiateMethod = m.MakeGenericMethod(args);
            //         _appDomain.RegisterCLRMethodRedirection(instantiateMethod, CLRMethodRedirection.Instantiate_11);
            //     }
            // }
            //
            // //其他的需要复杂一点的
            // foreach (var m in allMethods)
            // {
            //     var allParams = m.GetParameters();
            //     if (allParams.Length == 1)
            //     {
            //         _appDomain.RegisterCLRMethodRedirection(m, CLRMethodRedirection.Instantiate_12);
            //     }
            //     else if (allParams.Length == 2)
            //     {
            //         _appDomain.RegisterCLRMethodRedirection(m, CLRMethodRedirection.Instantiate_13);
            //     }
            //     else if (allParams.Length == 3 &&
            //              allParams[1].ParameterType == typeof(Transform) &&
            //              allParams[2].ParameterType == typeof(Boolean))
            //     {
            //         _appDomain.RegisterCLRMethodRedirection(m, CLRMethodRedirection.Instantiate_14);
            //     }
            //     else if (allParams.Length == 3 &&
            //              allParams[1].ParameterType == typeof(Vector3) &&
            //              allParams[2].ParameterType == typeof(Quaternion))
            //     {
            //         _appDomain.RegisterCLRMethodRedirection(m, CLRMethodRedirection.Instantiate_15);
            //     }
            //     else if (allParams.Length == 4 &&
            //              allParams[1].ParameterType == typeof(Vector3) &&
            //              allParams[2].ParameterType == typeof(Quaternion) &&
            //              allParams[3].ParameterType == typeof(Transform))
            //     {
            //         _appDomain.RegisterCLRMethodRedirection(m, CLRMethodRedirection.Instantiate_16);
            //     }
            //     else
            //     {
            //         _appDomain.RegisterCLRMethodRedirection(m, CLRMethodRedirection.Instantiate_17);
            //     }
            // }

            //注册Invoke
            // Type monoType = typeof(UnityEngine.MonoBehaviour);
            // args = new Type[] {typeof(System.String), typeof(System.Single)};
            // var invokeMethod = monoType.GetMethod("Invoke", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(invokeMethod, CLRMethodRedirection.Invoke_1);


            // Type networkSererType = typeof(NetworkServer);
            // var networkServerMethods = networkSererType.GetMethods().ToList().FindAll(i => i.Name == "SpawnObject");
            // foreach (var tmp_NetworkServerMethod in networkServerMethods)
            // {
            //     _appDomain.RegisterCLRMethodRedirection(tmp_NetworkServerMethod, CLRMethodRedirection.Instantiate);
            // }


            //注册InvokeRepeating
            // args = new Type[] {typeof(System.String), typeof(System.Single), typeof(System.Single)};
            // var invokeRepeatingMethod = monoType.GetMethod("InvokeRepeating", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(invokeRepeatingMethod, CLRMethodRedirection.InvokeRepeating_2);
            //
            // //注册CancelInvoke
            // args = new Type[] { };
            // var cancelInvokeMethod = monoType.GetMethod("CancelInvoke", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(cancelInvokeMethod, CLRMethodRedirection.CancelInvoke_3);
            // args = new Type[] {typeof(System.String)};
            // cancelInvokeMethod = monoType.GetMethod("CancelInvoke", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(cancelInvokeMethod, CLRMethodRedirection.CancelInvoke_4);
            //
            //
            // args = new Type[] { };
            // var isInvokingMethod = monoType.GetMethod("IsInvoking", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(isInvokingMethod, CLRMethodRedirection.IsInvoking_5);
            // args = new Type[] {typeof(System.String)};
            // isInvokingMethod = monoType.GetMethod("IsInvoking", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(isInvokingMethod, CLRMethodRedirection.IsInvoking_6);


            // var addComponentMethod = gameObjectType.GetMethods().ToList()
            //     .Find(i => i.Name == "AddComponent" && i.GetGenericArguments().Length == 1);
            // _appDomain.RegisterCLRMethodRedirection(addComponentMethod, CLRMethodRedirection.AddComponent);


            // var getComponentMethod = gameObjectType.GetMethods().ToList()
            //     .Find(i => i.Name == "GetComponent" && i.GetGenericArguments().Length == 1);
            // _appDomain.RegisterCLRMethodRedirection(getComponentMethod, CLRMethodRedirection.GetComponent);
            //
            //
            // var getComponentMethod1 = componentType.GetMethods().ToList()
            //     .Find(i => i.Name == "GetComponent" && i.GetGenericArguments().Length == 1);
            // _appDomain.RegisterCLRMethodRedirection(getComponentMethod1, CLRMethodRedirection.GetComponent);


            // objectType = typeof(UnityEngine.Object);
            // var findObjectOfType = objectType.GetMethods().ToList()
            //     .Find(i => i.Name == "FindObjectOfType" && i.GetGenericArguments().Length == 1);
            // _appDomain.RegisterCLRMethodRedirection(findObjectOfType, CLRMethodRedirection.FindObjectOfType);

            // Type apiType = typeof(com.Phantoms.ARMODAPI.Runtime.API);
            // var loadAssetOfType = apiType.GetMethods().ToList()
            //     .Find(_i => _i.Name == "LoadAsset" && _i.GetGenericArguments().Length == 1);
            // _appDomain.RegisterCLRMethodRedirection(loadAssetOfType, CLRMethodRedirection.LoadAssetOfType);
            //
            //
            // args = new Type[] {typeof(System.String), typeof(System.String)};
            // var method = apiType.GetMethod("LoadAssetAsync", flag, null, args, null);
            // _appDomain.RegisterCLRMethodRedirection(method, CLRMethodRedirection.LoadAssetOfTypeAsync);

            new AddComponentClrMethodRegister().Register(_appDomain);
            new GetComponentClrMethodRegister().Register(_appDomain);
            new DebugClrMethodRegister().Register(_appDomain);
            new FindObjectOfTypeClrMethodRegister().Register(_appDomain);
            new InstantiateClrMethodRegister().Register(_appDomain);
            new SendMessageClrMethodRegister().Register(_appDomain);
            new SendMessageUpwardsClrMethodRegister().Register(_appDomain);
            new BroadcastMessageClrMethodRegister().Register(_appDomain);
            new InvokeClrMethodRegister().Register(_appDomain);
            new ARMODAPIClrMethodRegister().Register(_appDomain);
            
            LitJson.JsonMapper.RegisterILRuntimeCLRRedirection(_appDomain);
        }
    }
}