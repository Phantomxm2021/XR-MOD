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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ILRuntime.Runtime.CodeHook;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.Video;
using XRMODEngineCore.Runtime;
using Assert = UnityEngine.Assertions.Assert;

namespace com.Phantoms.Runtime.Editor
{
    [CustomEditor(typeof(MonoBinder)), CanEditMultipleObjects]
    public class MonoBinderEditor : UnityEditor.Editor
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RunInEditor()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(ModifyTemplateScript, "ModifyTemplateMonoBinder");
        }

        //private static Malee.List.ReorderableList BINDERS;
        private static MonoBehaviour TARGET_MONO;
        private static MonoBinder _MONO_BINDER;

        private static readonly Type[] _UNITY_TYPE =
        {
            typeof(GameObject), typeof(Texture2D), typeof(MonoBehaviour), typeof(Color), typeof(Transform),
            typeof(MeshRenderer), typeof(AudioClip), typeof(AnimationClip), typeof(AudioMixer), typeof(ComputeShader),
            typeof(Font), typeof(Material), typeof(Mesh), typeof(PhysicMaterial), typeof(Shader), typeof(Sprite),
            typeof(Texture), typeof(TextAsset), typeof(SpriteAtlas), typeof(VideoClip)
        };


        private static readonly Type[] _NUM_TYPE = new[]
        {
            typeof(byte), typeof(sbyte), typeof(short), typeof(ushort), typeof(int), typeof(uint),
            typeof(long), typeof(ulong), typeof(float), typeof(decimal), typeof(double)
        };

        [CustomEditor(typeof(MonoBehaviour), true), CanEditMultipleObjects]
        public class MonoBehaviourEditor : UnityEditor.Editor
        {
            public override void OnInspectorGUI()
            {
                base.OnInspectorGUI();

                EditorGUILayout.Space();
                if (target is not XRMODBehaviour tmp_Behaviour) return;
                var tmp_Target =tmp_Behaviour.gameObject;
                if (!GUILayout.Button("Covert To MonoBinder")) return;
                TARGET_MONO = ((MonoBehaviour) target);
                if (!EditorUtility.DisplayDialog("Convert to MonoBinder",
                        "Convert to MonoBinder will remove this script! Are you sure?", "Ok", "Cancel")) return;
                if (!tmp_Target) return;
                if (!tmp_Target.TryGetComponent(out MonoBinder tmp_MonoBinder))
                {
                    tmp_MonoBinder = tmp_Target.AddComponent<MonoBinder>();
                }

                var tmp_MonoType = ((MonoBehaviour) target).GetType();
                tmp_MonoBinder.ScriptList ??= Array.Empty<MonoData>();

                var tmp_MonoScripts = new MonoData[tmp_MonoBinder.ScriptList.Length + 1];
                bool tmp_ValidScripts =
                    tmp_MonoBinder.ScriptList.Any(_data => _data.ClassName.Equals(tmp_MonoType.Name));
                if (tmp_ValidScripts)
                {
                    EditorUtility.DisplayDialog("Error", $"Script {tmp_MonoType.Name} is invalid!", "OK");
                    return;
                }

                tmp_MonoBinder.ScriptList.CopyTo(tmp_MonoScripts, 0);
                tmp_MonoScripts[^1] = new MonoData()
                {
                    ClassName = tmp_MonoType.Name,
                    ClassNamespace = tmp_MonoType.Namespace
                };
                tmp_MonoBinder.ScriptList = tmp_MonoScripts;
                GrabFieldsType(tmp_MonoBinder);
                if (TARGET_MONO)
                    TARGET_MONO.enabled = false;
                TARGET_MONO = null;
            }
        }

        private void OnEnable()
        {
            _MONO_BINDER = target as MonoBinder;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            serializedObject.Update();

            GUILayout.Space(5);
            EditorGUILayout.BeginHorizontal();
            // if (GUILayout.Button("Re-Binding", "miniButtonLeft"))
            // {
            //     GrabFieldsType(target as MonoBinder);
            // }

            TARGET_MONO = EditorGUILayout.ObjectField(TARGET_MONO, typeof(MonoBehaviour), true) as MonoBehaviour;

            EditorGUI.BeginDisabledGroup(TARGET_MONO == null);
            if (GUILayout.Button("Refresh", "miniButtonRight"))
            {
                Refresh(target as MonoBinder);
            }

            EditorGUI.EndDisabledGroup();

            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("Clean", "miniButton"))
            {
                foreach (MonoData tmp_MonoData in (target as MonoBinder).ScriptList)
                {
                    tmp_MonoData.Fields.Clear();
                }
            }

            serializedObject.ApplyModifiedProperties();
        }

        private void Refresh(MonoBinder _instance)
        {
            // foreach (MonoData tmp_MonoData in _instance.ScriptList)
            // {
            //     // var tmp_SortedFields = tmp_MonoData.Fields.OrderBy(_field => _field.FieldName);
            //     // MonoData tmp_FieldList = new MonoData();
            //     // foreach (MonoField tmp_Field in tmp_SortedFields)
            //     // {
            //     //     tmp_FieldList.Fields.Add(tmp_Field);
            //     // }
            //     // tmp_MonoData.Fields = tmp_FieldList.Fields;
            // }
            GrabFieldsType(_instance);

            EditorUtility.ClearProgressBar();
            if (TARGET_MONO)
                AssetDatabase.SaveAssetIfDirty(TARGET_MONO);
        }

        private static async void GrabFieldsType(MonoBinder _monoBinder, bool _auto = false)
        {
            try
            {
                if (TARGET_MONO == null || !TARGET_MONO.enabled) return;

                foreach (MonoData tmp_MonoData in _monoBinder.ScriptList)
                {
                    var tmp_FullNamespace = $"{tmp_MonoData.ClassNamespace}.{tmp_MonoData.ClassName}";
                    if (tmp_FullNamespace != (TARGET_MONO.GetType().FullName)) continue;
                    tmp_MonoData.Fields.Clear();

                    Type tmp_Type;
                    if (_auto)
                    {
                        string tmp_ClassFullName = $"{tmp_MonoData.ClassNamespace}.{tmp_MonoData.ClassName}";

                        var tmp_Path = Application.dataPath.Replace("Assets",
                            $"Library/ScriptAssemblies/{tmp_MonoData.ClassNamespace}.Runtime.dll");
                        Assembly tmp_Assembly = Assembly.LoadFile(tmp_Path);
                        tmp_Type = tmp_Assembly.GetType(tmp_ClassFullName);
                    }
                    else
                    {
                        tmp_Type = TARGET_MONO.GetType(); //tmp_Assembly.GetType(tmp_ClassFullName);
                    }

                    if (tmp_Type == null)
                    {
                        EditorUtility.DisplayDialog("Error", $"Can not load assembly", "Ok");
                        return;
                    }


                    var tmp_ExperienceInstance = _auto ? Activator.CreateInstance(tmp_Type) : TARGET_MONO;

                    var tmp_AllFields = tmp_MonoData.Fields.Select(_monoField => _monoField.FieldName).ToList();

                    var tmp_Members = new List<MemberInfo>();

                    tmp_Members.AddRange(tmp_Type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance |
                                                            BindingFlags.Public));
                    foreach (MemberInfo tmp_Info in tmp_Members)
                    {
                        EditorUtility.DisplayProgressBar("Auto binding",
                            $"Auto binding {tmp_Type.Name}.{tmp_Info.Name}({tmp_Members.ToList().IndexOf(tmp_Info)}/{tmp_Members.Count})",
                            tmp_Members.ToList().IndexOf(tmp_Info) / (float) tmp_Members.Count);

                        if (!tmp_AllFields.Contains(tmp_Info.Name))
                        {
                            MonoField tmp_MonoField = new MonoField();

                            string tmp_FieldName = tmp_Info.Name;
                            tmp_MonoField.FieldName = tmp_FieldName;

                            Type tmp_PropertyType = (tmp_Info is PropertyInfo)
                                ? ((PropertyInfo) tmp_Info).PropertyType
                                : ((FieldInfo) tmp_Info).FieldType;

                            SetMonoFieldType(tmp_MonoField, tmp_PropertyType);
                            CopyDataToMonoField(ref tmp_MonoField, tmp_Info, tmp_ExperienceInstance);
                            tmp_MonoData.Fields.Add(tmp_MonoField);
                        }

                        await Task.Delay(10);
                    }

                    await Task.Delay(50);
                    EditorUtility.ClearProgressBar();
                }

                if (TARGET_MONO)
                    TARGET_MONO.enabled = false;


                EditorUtility.SetDirty(_MONO_BINDER);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            catch (Exception tmp_E)
            {
                Debug.LogError(tmp_E.ToString());
                EditorUtility.ClearProgressBar();
            }
        }

        private static void SetMonoFieldType(MonoField _monoField, Type _type)
        {
            if (_type == typeof(GameObject))
            {
                _monoField.FieldType = MonoField.FieldTypeEnum.GameObject;
            }
            else if (_type == typeof(Component) || _type.IsSubclassOf(typeof(MonoBehaviour)))
            {
                _monoField.FieldType = MonoField.FieldTypeEnum.UnityComponent;
            }
            else if (_type.IsSubclassOf(typeof(UnityEngine.Object)))
            {
                // if (UNITY_TYPE.Contains(_type) && _type != typeof(GameObject))
                // {
                //     _monoField.FieldType = MonoField.FieldTypeEnum.ARExperienceResource;
                // }
                // else
                // {
                //     _monoField.FieldType = MonoField.FieldTypeEnum.UnityComponent;
                // }
                _monoField.FieldType = MonoField.FieldTypeEnum.UnityComponent;
            }
            else
            {
                if (_NUM_TYPE.Contains(_type))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Number;
                }
                else if (_type == typeof(string))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.String;
                }
                else if (_type == typeof(bool))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Bool;
                }
                else if (_type.IsEnum)
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Enum;
                }
                else if (_type.IsGenericType)
                {
                    var tmp_GenericType = _type.GenericTypeArguments[0];
                    if (_UNITY_TYPE.Contains(tmp_GenericType))
                    {
                        _monoField.FieldType = MonoField.FieldTypeEnum.UnityObjects;
                    }
                    else if (_NUM_TYPE.Contains(tmp_GenericType) || tmp_GenericType == typeof(string))
                    {
                        _monoField.FieldType = MonoField.FieldTypeEnum.Primitives;
                    }
                    else
                    {
                        _monoField.FieldType = MonoField.FieldTypeEnum.NotSupported;
                    }
                }
                else if (_type == typeof(Vector2))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Vector2;
                }
                else if (_type == typeof(Vector3))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Vector3;
                }
                else if (_type == typeof(Vector4))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Vector4;
                }
                else if (_type == typeof(Quaternion))
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.Quaternion;
                }
                else
                {
                    _monoField.FieldType = MonoField.FieldTypeEnum.NotSupported;
                }
            }
        }

        private static void CopyDataToMonoField(ref MonoField _monoField, MemberInfo _info, object _instance)
        {
            object tmp_Value;
            var tmp_Type = (_info is PropertyInfo tmp_PropertyInfo)
                ? tmp_PropertyInfo.PropertyType
                : ((FieldInfo) _info).FieldType;
            if (_instance == null)
            {
                tmp_Value = tmp_Type.IsValueType ? Activator.CreateInstance(tmp_Type) : null;
            }
            else
            {
                if (_info is PropertyInfo tmp_Info)
                {
                    tmp_Value = tmp_Info.GetValue(_instance);
                }
                else
                {
                    tmp_Value = ((FieldInfo) _info).GetValue(_instance);
                }


                if (tmp_Value is GameObject tmp_GameObject)
                {
                    var tmp_PathStr = AssetDatabase.GetAssetPath(tmp_GameObject);
                    if (!string.IsNullOrEmpty(tmp_PathStr))
                    {
                        tmp_Value = tmp_GameObject.name;
                        _monoField.FieldType = MonoField.FieldTypeEnum.ARExperienceResource;
                    }
                }
            }

            DataInput(ref _monoField, tmp_Type, tmp_Value, _instance);
        }

        private static void DataInput(ref MonoField _monoField, Type _type, object _value, object _instance)
        {
            if (_type == typeof(object)) return;
            if (_value == null || _value is Exception) return;


            if (_NUM_TYPE.Contains(_value.GetType())
                || _value is string || _value is bool)
            {
                string tmp_Value = _value.ToString();
                if (tmp_Value.ToLower().Equals("null")) return;
                _monoField.Value = _value.ToString();
            }
            else if (_value is Enum)
            {
                _monoField.Value = $"{(int) (_value)}";
            }
            else if (_value is Vector2 tmp_Vector2)
            {
                _monoField.Value = tmp_Vector2.Serializer();
            }
            else if (_value is Vector3 tmp_Vector3)
            {
                _monoField.Value = tmp_Vector3.Serializer();
            }
            else if (_value is Vector4 tmp_Vector4)
            {
                _monoField.Value = tmp_Vector4.Serializer();
            }
            else if (_value is Quaternion tmp_Quaternion)
            {
                _monoField.Value = tmp_Quaternion.Serializer();
            }
            else
            {
                if (_value is GameObject tmp_GameObject)
                    _monoField.GameObject = tmp_GameObject;
                else if (_value is Component tmp_Component)
                {
                    if (_value.ToString().ToLower().Equals("null")) return;
                    _monoField.GameObject = tmp_Component?.gameObject;
                }
            }


            if (!_type.IsGenericType) return;
            var tmp_GenericType = _type.GenericTypeArguments[0];
            if (tmp_GenericType == typeof(string))
                _monoField.Value = MakePrimitiveGenericData<string>(_value);
            else if (tmp_GenericType == typeof(int))
                _monoField.Value = MakePrimitiveGenericData<int>(_value);
            else if (tmp_GenericType == typeof(bool))
                _monoField.Value = MakePrimitiveGenericData<bool>(_value);
            else if (tmp_GenericType == typeof(float))
                _monoField.Value = MakePrimitiveGenericData<float>(_value);
            else if (tmp_GenericType == typeof(GameObject))
                _monoField.GameObjects = _value as List<GameObject>;
            else if (tmp_GenericType == typeof(Transform))
                _monoField.Transforms = _value as List<Transform>;
            else if (tmp_GenericType == typeof(Texture2D))
                _monoField.Textures = _value as List<Texture2D>;
            else if (tmp_GenericType == typeof(AudioClip))
                _monoField.AudioClips = _value as List<AudioClip>;
            else if (tmp_GenericType == typeof(Shader))
                _monoField.Shaders = _value as List<Shader>;
            else if (tmp_GenericType == typeof(Sprite))
                _monoField.Sprites = _value as List<Sprite>;
            else if (tmp_GenericType == typeof(Material))
                _monoField.Materials = _value as List<Material>;
            else if (tmp_GenericType == typeof(MonoBehaviour))
                _monoField.MonoBehaviours = _value as List<MonoBehaviour>;
            else if (tmp_GenericType == typeof(Color))
                _monoField.Colors = _value as List<Color>;
            else if (tmp_GenericType == typeof(MeshRenderer))
                _monoField.MeshRenderers = _value as List<MeshRenderer>;
            else if (tmp_GenericType == typeof(Mesh))
                _monoField.Meshes = _value as List<Mesh>;
            else if (tmp_GenericType == typeof(VideoClip))
                _monoField.VideoClips = _value as List<VideoClip>;
            else if (tmp_GenericType == typeof(AnimationClip))
                _monoField.AnimationClips = _value as List<AnimationClip>;
            else if (tmp_GenericType == typeof(Collider))
                _monoField.Colliders = _value as List<Collider>;
        }

        private static string MakePrimitiveGenericData<T>(object _value)
        {
            var tmp_SystemObject = new GenericPrimitiveObject<T>
            {
                List = _value as List<T>,
                ListType = typeof(List<T>)
            };

            return JsonUtility.ToJson(tmp_SystemObject);
        }

        private static void ModifyTemplateScript(BaseNotificationData _data)
        {
            //Get all monoBinder scripts from prefab,
            //then change the script's field of namespace to specify project name
            var tmp_Data = _data.BaseData.Split('|'); //Path|ProjectName
            var tmp_PrefabPath = tmp_Data[0];
            if (Directory.Exists(tmp_PrefabPath))
            {
                var tmp_Files =
                    Directory.GetFiles(Path.Combine(Application.dataPath.Replace("Assets", ""), tmp_PrefabPath),
                        "*.prefab", SearchOption.TopDirectoryOnly);
                foreach (string tmp_File in tmp_Files)
                {
                    var tmp_Prefab = AssetDatabase.LoadAssetAtPath<GameObject>(ShortenPath(tmp_File));

                    List<MonoBinder> tmp_MonoBinders = new List<MonoBinder>();
                    tmp_MonoBinders.AddRange(tmp_Prefab.GetComponents<MonoBinder>());
                    tmp_MonoBinders.AddRange(tmp_Prefab.GetComponentsInChildren<MonoBinder>());

                    foreach (MonoBinder tmp_MonoBinder in tmp_MonoBinders)
                    {
                        foreach (MonoData tmp_MonoData in tmp_MonoBinder.ScriptList)
                        {
                            tmp_MonoData.ClassNamespace = tmp_Data[1];
                        }
                    }
                }
            }
        }

        private static string ShortenPath(string _fullPath)
        {
            int tmp_SubStringStartPos = _fullPath.IndexOf("Assets", StringComparison.Ordinal);
            return _fullPath.Substring(tmp_SubStringStartPos, _fullPath.Length - tmp_SubStringStartPos);
        }
    }
}