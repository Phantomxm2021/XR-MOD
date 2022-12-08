// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Linq;
using System.Reflection;
using com.Phantoms.ILRuntime.Runtime.CodeHook;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using UnityEngine.Assertions;
using Extension = ILRuntime.CLR.Utils.Extensions;

namespace com.Phantoms.ILRuntime.Runtime
{
    public static class Utility
    {
        /// <summary>
        /// Checkout the GameObject and the type in the IL
        /// </summary>
        /// <param name="_instance"></param>
        /// <param name="_ins"></param>
        /// <param name="_returnType"></param>
        public static void CheckoutIlTypeInstance(object _instance, out GameObject _ins, out ILType _returnType)
        {
            _returnType = null;
            switch (_instance)
            {
                case GameObject tmp_Instance:
                    _ins = tmp_Instance;
                    break;
                case ILTypeInstance tmp_Instance:
                    _returnType = tmp_Instance.Type;
                    _ins = FindGameFromILTypeInstance(tmp_Instance);
                    Assert.IsNotNull(_ins);
                    break;
                default:
                    _ins = (_instance as Component)?.gameObject;
                    break;
            }
        }

        /// <summary>
        /// find ilrt gameObject
        /// </summary>
        /// <param name="_instance"></param>
        /// <returns>GameObject</returns>
        public static GameObject FindGameFromILTypeInstance(ILTypeInstance _instance)
        {
            var tmp_ReturnType = _instance.Type;
            if (tmp_ReturnType.ReflectionType == typeof(MonoBehaviour))
            {
                var tmp_PropertyInfo = tmp_ReturnType.ReflectionType.GetProperty("gameObject");
                if (tmp_PropertyInfo != null)
                    return tmp_PropertyInfo.GetValue((_instance as ILTypeInstance).CLRInstance) as GameObject;
            }
            else if (tmp_ReturnType.ReflectionType.IsSubclassOf(typeof(MonoBehaviour)))
            {
                if (tmp_ReturnType.ReflectionType.BaseType == null) return null;
                var tmp_PropertyInfo = tmp_ReturnType.ReflectionType.BaseType.GetProperty("gameObject");
                if (tmp_PropertyInfo != null)
                    return tmp_PropertyInfo.GetValue((_instance as ILTypeInstance).CLRInstance) as GameObject;
            }

            return null;
        }


        /// <summary>
        /// SendMessage
        /// </summary>
        /// <param name="_appDomain"></param>
        /// <param name="_go"></param>
        /// <param name="_methodName"></param>
        /// <param name="_value"></param>
        /// <param name="_option"></param>
        public static bool SendMessageWithILTypeInstance(AppDomain _appDomain, GameObject _go, string _methodName,
            object _value = null,
            SendMessageOptions _option = SendMessageOptions.RequireReceiver)
        {
            bool tmp_Found = false;

            var tmp_ClrInstances = _go.GetComponents<CrossBindingAdaptorType>();
            foreach (var tmp_ClrInstance in tmp_ClrInstances)
            {
                if (tmp_ClrInstance.ILInstance == null) continue;
                IType tmp_T = tmp_ClrInstance.ILInstance.Type;
                if (_value == null)
                {
                    IMethod tmp_M = tmp_T.GetMethod(_methodName, 0);
                    if (tmp_M == null) continue;
                    _appDomain.Invoke(tmp_M, tmp_ClrInstance.ILInstance, null);
                    tmp_Found = true;
                }
                else
                {
                    IMethod m = tmp_T.GetMethod(_methodName, 1);
                    if (m == null) continue;
                    _appDomain.Invoke(m, tmp_ClrInstance.ILInstance, _value);
                    tmp_Found = true;
                }
            }

            return tmp_Found;
        }

        /// <summary>
        /// Instantiate GameObject
        /// </summary>
        /// <param name="_gameObjectInMemory">GameObject of prefab</param>
        /// <param name="_instancedGameObject">GameObject of instanced in the scene</param>
        /// <param name="_domain">Script domain</param>
        /// <param name="_type"></param>
        /// <returns>Object</returns>
        public static object Instantiate(GameObject _gameObjectInMemory, GameObject _instancedGameObject,
            AppDomain _domain, IType _type = null)
        {
            // Remove (Clone) suffix after game-object has been instantiated.
            _instancedGameObject.name = _instancedGameObject.name.Replace("(Clone)", string.Empty);

            // Check if our game object uses custom scripts (e.g.MonoBehaviour scripts).
            if (_instancedGameObject.GetComponentsInChildren<CrossBindingAdaptorType>(true).Length == 0)
            {
                // Check if our game object uses MonoBinder
                if (_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).Length > 0)
                {
                    BinderManager.DoBind(_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).ToList());
                }

                return _instancedGameObject;
            }

            bool tmp_NeedClassBind = false;

            // Remove all MonoBinder after binding
            foreach (var tmp_Transform in _instancedGameObject.GetComponentsInChildren<Transform>())
            {
                var tmp_MonoBinder = tmp_Transform.GetComponent<MonoBinder>();
                if (tmp_MonoBinder != null && tmp_Transform.GetComponent<CrossBindingAdaptorType>() != null)
                {
                    Object.DestroyImmediate(tmp_MonoBinder);
                }
            }


            if (_gameObjectInMemory.GetComponentsInChildren<MonoBinder>(true).Length > 0)
            {
                tmp_NeedClassBind = true;
            }

            var tmp_ClrInstances = _instancedGameObject.GetComponentsInChildren<CrossBindingAdaptorType>(true);
            var tmp_ClrMemoryInstances = _gameObjectInMemory.GetComponentsInChildren<CrossBindingAdaptorType>(true);

            ILTypeInstance tmp_Result = null;
            for (int tmp_Idx = 0; tmp_Idx < tmp_ClrInstances.Length; tmp_Idx++)
            {
                var tmp_ClrInstance = tmp_ClrInstances[tmp_Idx];
                var tmp_ClrMemoryInstance = tmp_ClrMemoryInstances[tmp_Idx];

                ILTypeInstance tmp_ILInstance = tmp_ClrMemoryInstance.ILInstance.Clone();

                var tmp_TypeInMemoryObject = tmp_ClrMemoryInstance.GetType();
                if (tmp_ILInstance.Type == _type && tmp_Result == null)
                {
                    tmp_Result = tmp_ILInstance;
                }

                if (tmp_ClrMemoryInstance is MonoBehaviourAdapter.Adapter tmp_Adaptor)
                {
                    tmp_Adaptor.Reset();
                    tmp_Adaptor.ILInstance = tmp_ILInstance;
                    tmp_Adaptor.AppDomain = _domain;
                }
                else
                {
                    var tmp_IlInstance = tmp_TypeInMemoryObject.GetField("instance",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    var tmp_AppDomain = tmp_TypeInMemoryObject.GetField("appdomain",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                    tmp_IlInstance?.SetValue(tmp_ClrInstance, tmp_ILInstance);
                    tmp_AppDomain?.SetValue(tmp_ClrInstance, _domain);
                }

                if (tmp_ClrMemoryInstance.ILInstance.CLRInstance == tmp_ClrMemoryInstance)
                {
                    tmp_ILInstance.CLRInstance = tmp_ClrInstance;
                }
                else
                {
                    tmp_ILInstance.CLRInstance = tmp_ILInstance;
                }


                var tmp_AwakeMethod =
                    (tmp_ClrInstance.GetType() != null ? tmp_ClrInstance.GetType() : tmp_TypeInMemoryObject).GetMethod(
                        "Awake",
                        BindingFlags.Default | BindingFlags.Public
                                             | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                             BindingFlags.NonPublic | BindingFlags.Static);
                if (tmp_AwakeMethod != null)
                {
                    tmp_AwakeMethod.Invoke(tmp_ClrInstance, null);
                }

                if (tmp_NeedClassBind)
                {
                    BinderManager.DoBind();
                }
                else
                {
                    if (_instancedGameObject.GetComponentInChildren<MonoBinder>(true))
                    {
                        BinderManager.DoBind(_instancedGameObject.GetComponentsInChildren<MonoBinder>(true).ToList());
                    }
                }
            }

            if (_type != null)
            {
                return tmp_Result;
            }

            return _instancedGameObject;
        }


        public static void InvokeConstructor(ILTypeInstance _instance, IType _ilType)
        {
            var tmp_Method = _ilType.GetConstructor(Extension.EmptyParamList);
            if (tmp_Method != null && _instance != null)
            {
                CodesHook.GetAppDomain.Invoke(tmp_Method, _instance, null);
            }
        }
    }
}