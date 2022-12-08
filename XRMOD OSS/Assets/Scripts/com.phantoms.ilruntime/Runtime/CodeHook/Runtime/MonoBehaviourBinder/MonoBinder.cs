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
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Reflection;
using System.Threading.Tasks;
using ILRuntime.Reflection;
using UnityEngine.Assertions;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using com.Phantoms.ARMODPackageTools.Runtime;
using com.Phantoms.ILRuntime.Runtime.CodeHook.ICommand;
using XRMODEngineCore.Runtime;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
using Extension = ILRuntime.CLR.Utils.Extensions;
using Object = UnityEngine.Object;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook
{
    public class MonoBinder : MonoBehaviour
    {
        public MonoData[] ScriptList;

        private const BindingFlags AllBindingFlags = BindingFlags.Public | BindingFlags.NonPublic |
                                                     BindingFlags.Instance | BindingFlags.Static |
                                                     BindingFlags.FlattenHierarchy | BindingFlags.Default;

        public async Task SetValues(MonoData _data)
        {
            string tmp_ClassPath =
                $"{_data.ClassNamespace + (string.IsNullOrEmpty(_data.ClassName) ? "" : ".")}{_data.ClassName}";
            //CodesHook.GetAppDomain.LoadedTypes.TryGetValue(tmp_ClassPath, out var tmp_Type);
            Type tmp_Type = _data.ClassType;
            //Get real type
            //var tmp_ReflectionType = tmp_Type?.ReflectionType;

            //Can not direct accessing the MonoBehaviour, Because they are difference of the type.
            //So we need accessing the `CrossBindingAdaptorType` first.
            // var tmp_ClrInstance = gameObject.GetComponents<CrossBindingAdaptorType>()
            //     .Last(_clr => _clr.ILInstance.Type == tmp_Type as ILType);
            var tmp_ClrInstance = _data.ClrInstance;
            Assert.IsNotNull(tmp_ClrInstance, $"{_data.ClassName}");
            //if (!_data.AutoPaddingData) return;
            _data.BoundData = false;
            var tmp_Fields = _data.Fields.ToArray();
            foreach (MonoField tmp_Field in tmp_Fields)
            {
                if (tmp_Field.FieldType == MonoField.FieldTypeEnum.NotSupported) continue;
                object tmp_Obj = null;
                // try
                // {
                switch (tmp_Field.FieldType)
                {
                    case MonoField.FieldTypeEnum.Number:
                        tmp_Obj = FillInNumberFields(tmp_Type, tmp_Field, _data);
                        break;
                    case MonoField.FieldTypeEnum.String:
                        tmp_Obj = tmp_Field.Value;
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Bool:
                        tmp_Obj = tmp_Field.Value.ToLower() == "true";
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.GameObject:
                        tmp_Obj = FillInGameObjectFields(tmp_Type, tmp_Field, _data);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.UnityComponent:
                        if (FillInUnityComponent(_data, tmp_Field, tmp_Type, tmp_ClassPath,
                                out tmp_Obj)) continue;
                        break;
                    case MonoField.FieldTypeEnum.ARExperienceResource:
                        //Loading the ar experience resource in ar experience package.
                        tmp_Obj = await BasePackageLoaderUtility.LoadAssetFromPackage<UnityEngine.Object>(
                            CodesHook.GetProjectName, tmp_Field.Value);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Enum:
                        tmp_Obj = int.Parse(tmp_Field.Value);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Vector2:
                        if (tmp_Field.Value == null) continue;
                        tmp_Obj = JsonUtility.FromJson<Vector2>(tmp_Field.Value);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Vector3:
                        if (tmp_Field.Value == null) continue;
                        tmp_Obj = JsonUtility.FromJson<Vector3>(tmp_Field.Value);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Vector4:
                        if (tmp_Field.Value == null) continue;
                        tmp_Obj = JsonUtility.FromJson<Vector4>(tmp_Field.Value);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Quaternion:
                        if (tmp_Field.Value == null) continue;
                        tmp_Obj = JsonUtility.FromJson<Quaternion>(tmp_Field.Value);
                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.Primitives:
                        if (tmp_Field.Value == null) continue;
                        // ReSharper disable once ConvertTypeCheckToNullCheck
                        if (tmp_Field.Value is string)
                            tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<string>>(tmp_Field.Value);
#pragma warning disable CS0184
                        else if (tmp_Field.Value is int)
#pragma warning restore CS0184
                            tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<int>>(tmp_Field.Value);
#pragma warning disable CS0184
                        else if (tmp_Field.Value is bool)
#pragma warning disable CS0184
                            tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<bool>>(tmp_Field.Value);
#pragma warning disable CS0184
                        else if (tmp_Field.Value is float)
#pragma warning disable CS0184
                            tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<float>>(tmp_Field.Value);

                        _data.BoundData = true;
                        break;
                    case MonoField.FieldTypeEnum.UnityObjects:
                        if (tmp_Field.GameObjects is {Count: > 0})
                            tmp_Obj = tmp_Field.GameObjects;
                        else if (tmp_Field.Transforms is {Count: > 0})
                            tmp_Obj = tmp_Field.Transforms;
                        else if (tmp_Field.Textures is {Count: > 0})
                            tmp_Obj = tmp_Field.Textures;
                        else if (tmp_Field.AnimationClips is {Count: > 0})
                            tmp_Obj = tmp_Field.AnimationClips;
                        else if (tmp_Field.Shaders is {Count: > 0})
                            tmp_Obj = tmp_Field.Shaders;
                        else if (tmp_Field.Shaders is {Count: > 0})
                            tmp_Obj = tmp_Field.Shaders;
                        else if (tmp_Field.Materials is {Count: > 0})
                            tmp_Obj = tmp_Field.Materials;
                        else if (tmp_Field.MonoBehaviours is {Count: > 0})
                            tmp_Obj = tmp_Field.MonoBehaviours;
                        else if (tmp_Field.Colors is {Count: > 0})
                            tmp_Obj = tmp_Field.Colors;
                        else if (tmp_Field.MeshRenderers is {Count: > 0})
                            tmp_Obj = tmp_Field.MeshRenderers;
                        else if (tmp_Field.Meshes is {Count: > 0})
                            tmp_Obj = tmp_Field.Meshes;
                        else if (tmp_Field.VideoClips is {Count: > 0})
                            tmp_Obj = tmp_Field.VideoClips;
                        else if (tmp_Field.AnimationClips is {Count: > 0})
                            tmp_Obj = tmp_Field.AnimationClips;
                        _data.BoundData = true;
                        break;

                    case MonoField.FieldTypeEnum.NotSupported:
                        break;
                }
                // }
                // catch (Exception tmp_Exception)
                // {
                //     Debug.LogError(
                //         $"Auto binding {name} was error:{tmp_ClassPath}.{tmp_Field.FieldName} assignment error:{tmp_Exception.Message}  - Skipped!");
                // }


                if (_data.BoundData)
                {
                    var tmp_FieldInfo = tmp_Type.GetField(tmp_Field.FieldName,
                        BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                        BindingFlags.Static);
                    if (tmp_FieldInfo != null)
                    {
                        // try
                        // {
                        if (tmp_Obj != null)
                        {
                            tmp_FieldInfo.SetValue(tmp_ClrInstance.ILInstance, tmp_Obj);
                        }
                        // }
                        // catch (Exception tmp_Exception)
                        // {
                        //     Debug.LogError(
                        //         $"Auto binding {name} was error:{tmp_ClassPath}.{tmp_Field.FieldName} assignment error:{tmp_Exception.Message} - Skipped");
                        // }
                    }
                    else
                    {
                        var tmp_PropertyInfo = tmp_Type.GetProperty(tmp_Field.FieldName,
                            BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                            BindingFlags.Static);
                        if (tmp_PropertyInfo != null)
                        {
                            tmp_PropertyInfo.SetValue(tmp_ClrInstance.ILInstance, tmp_Obj);
                        }
                        else
                        {
                            Debug.LogError(
                                $"Auto binding {name} was error:{tmp_ClassPath}.{tmp_Field.FieldName} assignment error:{tmp_Field.FieldName} not exist - Skipped");
                        }
                    }
                }
            }
        }

        public void AddRuntimeClass(MonoData _data)
        {
            string tmp_ClassPath =
                $"{_data.ClassNamespace + (string.IsNullOrEmpty(_data.ClassName) ? string.Empty : ".")}{_data.ClassName}";
            if (!CodesHook.GetAppDomain.LoadedTypes.TryGetValue(tmp_ClassPath, out var tmp_Type))
            {
                Debug.LogError($"Auto binding {name} was error:{tmp_ClassPath} not exist - Skipped");
                return;
            }

            Type tmp_ReflectionType = tmp_Type.ReflectionType;
            _data.ClassType = tmp_ReflectionType;
            Type tmp_BaseType = tmp_ReflectionType.BaseType.BaseType is ILRuntimeWrapperType tmp_WrapperType
                ? tmp_WrapperType.RealType
                : tmp_ReflectionType.BaseType;
            Type tmp_MonoType = typeof(MonoBehaviour);
            bool tmp_IsMono = tmp_ReflectionType.IsSubclassOf(tmp_MonoType) ||
                              (tmp_BaseType != null && tmp_BaseType.IsSubclassOf(tmp_MonoType));
            bool tmp_NeedAdapter = tmp_BaseType != null &&
                                   tmp_BaseType.GetInterfaces().Contains(typeof(CrossBindingAdaptorType));
            ILTypeInstance tmp_ILInstance = tmp_IsMono
                ? new ILTypeInstance(tmp_Type as ILType, false)
                : CodesHook.GetAppDomain.Instantiate(tmp_ClassPath);
            tmp_ILInstance.CLRInstance = tmp_ILInstance;

            object tmp_Res = default;
            //Use this after generating adapters for cross-domain inheritance after multiple inheritance of the main project
            if (tmp_NeedAdapter
                && tmp_IsMono
                && tmp_BaseType.FullName != typeof(MonoBehaviourAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(UIMonoBehaviourAdaptor.Adapter).FullName
                && tmp_BaseType.FullName != typeof(XRBaseInteractableAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(XRBaseInteractorAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(XRGrabInteractableAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(TeleportationProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(LocomotionProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(GrabMoveProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(DeviceBasedSnapTurnProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(DeviceBasedContinuousTurnProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(DeviceBasedContinuousMoveProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(ConstrainedMoveProviderAdapter.Adapter).FullName
                && tmp_BaseType.FullName != typeof(ActionBasedContinuousMoveProviderAdapter.Adapter).FullName)
            {
                Type tmp_AdapterType = Type.GetType(tmp_BaseType?.FullName ?? String.Empty);
                if (tmp_AdapterType == null)
                {
                    Debug.LogError($"{tmp_Type.FullName} need to generate adapter.");
                    return;
                }

                //Reflection
                var tmp_AdapterInstance = gameObject.AddComponent(tmp_AdapterType) as XRMODBehaviour;
                var tmp_ClrIlInstance = tmp_ReflectionType
                    .GetFields(AllBindingFlags)
                    .First(f => f.Name == "instance" && f.FieldType == typeof(ILTypeInstance));

                var tmp_ClrAppDomain = tmp_ReflectionType.GetFields(AllBindingFlags)
                    .First(f => f.Name == "appdomain" && f.FieldType == typeof(AppDomain));
                if (tmp_AdapterInstance is not null)
                {
                    tmp_AdapterInstance.enabled = false;
                    tmp_ClrIlInstance?.SetValue(tmp_AdapterInstance, tmp_ILInstance);
                    tmp_ClrAppDomain?.SetValue(tmp_AdapterInstance, CodesHook.GetAppDomain);
                    tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                    _data.ClrInstance = (CrossBindingAdaptorType) tmp_AdapterInstance;
                    tmp_Res = _data.ClrInstance.ILInstance;
                }
            }
            else
            {
                MonoBehaviourAdapter.Adapter tmp_AdapterInstance = null;
                if (tmp_BaseType.FullName == typeof(MonoBehaviourAdapter.Adapter).FullName)
                {
                    //Directly inherit Mono, use this for multi-layer inheritance Mono,
                    //non-mono inheritance, or those that don’t need inheritance. Use this.
                    new InitMonoBehaviourAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(UIMonoBehaviourAdaptor.Adapter).FullName)
                {
                    new InitUIMonoBehaviourAdaptor(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(XRBaseInteractableAdapter.Adapter).FullName)
                {
                    new InitXRBaseInteractableAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(XRBaseInteractorAdapter.Adapter).FullName)
                {
                    new InitXRBaseInteractorAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(XRGrabInteractableAdapter.Adapter).FullName)
                {
                    new InitXRGrabInteractableAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(TeleportationProviderAdapter.Adapter).FullName)
                {
                    new InitTeleportationProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(LocomotionProviderAdapter.Adapter).FullName)
                {
                    new InitLocomotionProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(GrabMoveProviderAdapter.Adapter).FullName)
                {
                    new InitGrabMoveProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(DeviceBasedSnapTurnProviderAdapter.Adapter).FullName)
                {
                    new InitDeviceBasedSnapTurnProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(DeviceBasedContinuousTurnProviderAdapter.Adapter).FullName)
                {
                    new InitDeviceBasedContinuousTurnProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type)
                        .Execute();
                }
                else if (tmp_BaseType.FullName == typeof(DeviceBasedContinuousMoveProviderAdapter.Adapter).FullName)
                {
                    new InitDeviceBasedContinuousMoveProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type)
                        .Execute();
                }
                else if (tmp_BaseType.FullName == typeof(ConstrainedMoveProviderAdapter.Adapter).FullName)
                {
                    new InitConstrainedMoveProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type).Execute();
                }
                else if (tmp_BaseType.FullName == typeof(ActionBasedContinuousMoveProviderAdapter.Adapter).FullName)
                {
                    new InitActionBasedContinuousMoveProviderAdapter(gameObject, tmp_ILInstance, _data, tmp_Type)
                        .Execute();
                }


                // if (tmp_AdapterInstance)
                // {
                //     tmp_AdapterInstance.enabled = false;
                //     tmp_AdapterInstance.ILInstance = tmp_ILInstance;
                //     tmp_AdapterInstance.AppDomain = CodesHook.GetAppDomain;
                //     tmp_ILInstance.CLRInstance = tmp_AdapterInstance;
                //     _data.ClrInstance = tmp_AdapterInstance;
                //     _data.Added = true;
                //     tmp_Res = _data.ClrInstance.ILInstance;
                // }
            }

            // if (!tmp_IsMono) return;
            // var m = tmp_Type.GetConstructor(Extension.EmptyParamList);
            // if (m != null && tmp_Res != null)
            // {
            //     CodesHook.GetAppDomain.Invoke(m, tmp_ILInstance, null);
            // }
        }

        public void Active(MonoData _data)
        {
            string tmp_FullClassName =
                $"{_data.ClassNamespace + (_data.ClassNamespace == "" ? "" : ".")}{_data.ClassName}";
            IType tmp_LoadedType = CodesHook.GetAppDomain.LoadedTypes[tmp_FullClassName];
            Type tmp_ReflectionType = tmp_LoadedType.ReflectionType;
            var tmp_ClrInstance = gameObject.GetComponents<CrossBindingAdaptorType>()
                .Last(_clr => _clr.ILInstance.Type == tmp_LoadedType as ILType);

            if (_data.BoundData == false && _data.Fields != null && _data.Fields.Count > 0)
            {
                Debug.LogError(
                    $"GameObject:{name} Auto binding Error:{tmp_FullClassName} binding failed, But activated.");
            }


            //不管是啥类型，直接invoke这个awake方法
            var tmp_AwakeMethod = tmp_ClrInstance.GetType().GetMethod("Awake",
                BindingFlags.Default | BindingFlags.Public
                                     | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                     BindingFlags.NonPublic | BindingFlags.Static);
            if (tmp_AwakeMethod == null)
            {
                tmp_AwakeMethod = tmp_ReflectionType.GetMethod("Awake",
                    BindingFlags.Default | BindingFlags.Public
                                         | BindingFlags.Instance | BindingFlags.FlattenHierarchy |
                                         BindingFlags.NonPublic | BindingFlags.Static);
            }
            else
            {
                tmp_AwakeMethod.Invoke(tmp_ClrInstance, null);
                _data.Activated = true;
            }


            if (tmp_AwakeMethod == null)
            {
                Debug.LogError($"{tmp_ReflectionType.FullName} activate must be have Awake method in the script!");
            }
            else if (!_data.Activated)
            {
                tmp_AwakeMethod.Invoke(tmp_ReflectionType, null);
            }

            //Mono类型能设置enabled
            if (tmp_ClrInstance.GetType().IsSubclassOf(typeof(MonoBehaviour)))
            {
                ((MonoBehaviour) tmp_ClrInstance).enabled = true;
            }


            _data.Activated = true;


            Remove();
        }

        private void Remove()
        {
            Destroy(this);
        }


        private bool FillInUnityComponent(MonoData _data, MonoField _field, Type _reflectionType, string _classPath,
            out object _obj)
        {
            _obj = null;
            GameObject tmp_GO = _field.GameObject;

            if (string.IsNullOrEmpty(_field.Value) && tmp_GO == null) return true;
            if (tmp_GO == null)
                tmp_GO = FillInGameObjectFields(_reflectionType, _field, _data);

            if (tmp_GO == null)
                return true;

            var tmp_FieldInfo = _reflectionType?.GetField(_field.FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                BindingFlags.Static);
            if (tmp_FieldInfo != null)
            {
                string tmp_FieldTypeName = tmp_FieldInfo.FieldType.Name;
                if (tmp_FieldInfo.FieldType is ILRuntimeType)
                {
                    var tmp_Components = tmp_GO.GetComponents<CrossBindingAdaptorType>();
                    foreach (CrossBindingAdaptorType tmp_CrossBindingAdaptorType in tmp_Components)
                    {
                        if (tmp_CrossBindingAdaptorType.ILInstance.Type.Name == tmp_FieldTypeName)
                        {
                            _obj = tmp_CrossBindingAdaptorType.ILInstance;
                            _data.BoundData = true;
                            break;
                        }
                    }
                }
                else
                {
                    var tmp_Component = tmp_GO.GetComponents<Component>().ToList()
                        .Find(_component =>
                            _component.GetType().ToString().Contains(tmp_FieldTypeName));
                    if (tmp_Component)
                    {
                        _obj = tmp_Component;
                        _data.BoundData = true;
                    }
                }
            }
            else
            {
                var tmp_PropertyInfo = _reflectionType?.GetProperty(_field.FieldName,
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                    BindingFlags.Static);

                if (tmp_PropertyInfo != null)
                {
                    string tmp_PropertyTypeName = tmp_PropertyInfo.PropertyType.Name;
                    if (tmp_PropertyInfo.PropertyType is ILRuntimeType)
                    {
                        var tmp_Components = tmp_GO.GetComponents<CrossBindingAdaptorType>();
                        foreach (CrossBindingAdaptorType tmp_CrossBindingAdaptorType in
                                 tmp_Components)
                        {
                            if (tmp_CrossBindingAdaptorType.ILInstance.Type.Name !=
                                tmp_PropertyTypeName) continue;
                            _obj = tmp_CrossBindingAdaptorType.ILInstance;
                            _data.BoundData = true;
                            break;
                        }
                    }
                    else
                    {
                        var tmp_Component = tmp_GO.GetComponents<Component>().ToList()
                            .Find(_component =>
                                _component.GetType().ToString().Contains(tmp_PropertyTypeName));
                        if (tmp_Component)
                        {
                            _obj = tmp_Component;
                            _data.BoundData = true;
                        }
                    }
                }
                else
                {
                    Debug.LogError(
                        $"Auto binding {name} was error:{_classPath}.{_field.FieldName} assignment error:{_field.FieldName} was not exist!");
                }
            }

            return false;
        }

        private GameObject FillInGameObjectFields(Type _reflectionType, MonoField _field, MonoData _data)
        {
            GameObject tmp_GO = _field.GameObject;
            if (_field.Value.ToLower().Equals("null") && tmp_GO == null) return null;
            if (tmp_GO == null)
            {
                try
                {
                    tmp_GO = _field.Value == "$(this)" ? gameObject : GameObject.Find(_field.FieldName);
                    if (tmp_GO == null) // Find the parent object
                    {
                        tmp_GO = FindSubGameObject(_field);
                        return tmp_GO;
                    }
                }
                catch (Exception tmp_Exception) // If an null exception is raised, find the parent object
                {
                    tmp_GO = FindSubGameObject(_field);
                    if (tmp_GO == null)
                    {
                        Debug.LogError(tmp_Exception.Message);
                        return tmp_GO;
                    }
                }

                _data.BoundData = true;
            }

            return tmp_GO;
        }

        private object FillInNumberFields(Type _reflectionType, MonoField _field, MonoData _data)
        {
            object tmp_Obj = null;
            var tmp_FieldType = _reflectionType.GetField(_field.FieldName,
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                    BindingFlags.Static)
                ?.FieldType ?? _reflectionType.GetProperty(_field.FieldName,
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                    BindingFlags.Static)
                ?.PropertyType;

            Assert.IsNotNull(tmp_FieldType);

            if (tmp_FieldType.FullName == typeof(SByte).FullName)
            {
                tmp_Obj = SByte.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Byte).FullName)
            {
                tmp_Obj = Byte.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Int16).FullName)
            {
                tmp_Obj = Int16.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Int32).FullName)
            {
                tmp_Obj = Int32.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Int64).FullName)
            {
                tmp_Obj = Int64.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(UInt16).FullName)
            {
                tmp_Obj = UInt16.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(UInt32).FullName)
            {
                tmp_Obj = UInt32.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(UInt64).FullName)
            {
                tmp_Obj = UInt64.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Single).FullName)
            {
                tmp_Obj = Single.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Decimal).FullName)
            {
                tmp_Obj = Decimal.Parse(_field.Value);
                _data.BoundData = true;
            }
            else if (tmp_FieldType.FullName == typeof(Double).FullName)
            {
                tmp_Obj = Double.Parse(_field.Value);
                _data.BoundData = true;
            }

            return tmp_Obj;
        }


        private GameObject FindSubGameObject(MonoField _field)
        {
            if (_field.Value.Contains("/"))
            {
                try
                {
                    var tmp_Parent =
                        GameObject.Find(_field.Value.Substring(0, _field.Value.IndexOf("/", StringComparison.Ordinal)));
                    var tmp_Child =
                        tmp_Parent.transform.Find(
                            _field.Value.Substring(_field.Value.IndexOf("/", StringComparison.Ordinal) + 1)).gameObject;
                    return tmp_Child;
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(
                        $"Auto binding {name} was error:{_field.Value} not exist or hidden,can not to find - Skipped\n{tmp_Exception.Message}");
                }
            }
            else
            {
                Debug.LogError(
                    $"Auto binding {name} was error:{_field.Value} not exist or hidden,can not to find - Skipped");
            }

            return null;
        }
    }
}