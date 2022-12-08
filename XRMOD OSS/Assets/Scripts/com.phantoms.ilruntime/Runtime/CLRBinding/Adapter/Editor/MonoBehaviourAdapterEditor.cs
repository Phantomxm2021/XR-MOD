using System;
using System.Collections.Generic;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime.Intepreter;
using UnityEditor;
using UnityEngine;

namespace com.Phantoms.ILRuntime.Editor
{
    [CustomEditor(typeof(MonoBehaviourAdapter.Adapter), true)]
    public class MonoBehaviourAdapterEditor : UnityEditor.Editor
    {
        private Dictionary<Type, bool> foldouts = new Dictionary<Type, bool>();

        public override void OnInspectorGUI()
        {
            MonoBehaviourAdapter.Adapter tmp_Clr = target as MonoBehaviourAdapter.Adapter;
            serializedObject.Update();
            if (tmp_Clr != null)
            {
                var tmp_Instance = tmp_Clr.ILInstance;
                if (tmp_Instance != null)
                {
                    EditorGUILayout.LabelField("Script", tmp_Clr.ILInstance.Type.FullName);

                    //All fields
                    foreach (var tmp_I in tmp_Instance.Type.FieldMapping)
                    {
                        var tmp_FieldName = tmp_I.Key;
                        var tmp_Type = tmp_Instance.Type.FieldTypes[tmp_I.Value];
                        var tmp_CType = tmp_Type.TypeForCLR;

                        if (tmp_CType.IsPrimitive)
                        {
                            if (tmp_CType == typeof(float))
                            {
                                tmp_Instance[tmp_I.Value] =
                                    EditorGUILayout.FloatField(tmp_FieldName, (float) tmp_Instance[tmp_I.Value]);
                            }
                            else if (tmp_CType == typeof(int))
                            {
                                tmp_Instance[tmp_I.Value] =
                                    EditorGUILayout.IntField(tmp_FieldName, (int) tmp_Instance[tmp_I.Value]);
                            }
                            else if (tmp_CType == typeof(string))
                            {
                                tmp_Instance[tmp_I.Value] =
                                    EditorGUILayout.TextField(tmp_FieldName, (string) tmp_Instance[tmp_I.Value]);
                            }
                        }
                        else if (tmp_CType.IsArray)
                        {
                            if (tmp_CType == typeof(Transform[]))
                            {
                                DrawList<Transform>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(GameObject[]))
                            {
                                DrawList<GameObject>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(MonoBehaviour[]))
                            {
                                DrawList<MonoBehaviour>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            // else if (tmp_CType == typeof(Color[]))
                            // {
                            //     DrawList<Color32>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            //
                            // }
                            else if (tmp_CType == typeof(Sprite[]))
                            {
                                DrawList<Sprite>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(AnimationClip[]))
                            {
                                DrawList<AnimationClip>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(Texture[]))
                            {
                                DrawList<Texture>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(Material[]))
                            {
                                DrawList<Material>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(Shader[]))
                            {
                                DrawList<Shader>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                        }
                        else if (tmp_CType.IsGenericType)
                        {
                            if (tmp_CType == typeof(List<GameObject>))
                            {
                                DrawList<GameObject>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(List<Transform>))
                            {
                                DrawList<Transform>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                            else if (tmp_CType == typeof(List<Component>))
                            {
                                DrawList<Component>(tmp_CType, tmp_Instance, tmp_I, tmp_FieldName);
                            }
                        }
                        else if (tmp_Type.IsEnum)
                        {
                            tmp_Instance[tmp_I.Value] =
                                EditorGUILayout.TextField($"[Enum]{tmp_FieldName}", (string) tmp_Instance[tmp_I.Value]);
                        }
                        else
                        {
                            object tmp_Obj = tmp_Instance[tmp_I.Value];
                            if (typeof(UnityEngine.Object).IsAssignableFrom(tmp_CType))
                            {
                                //Unity's type
                                var tmp_Res = EditorGUILayout.ObjectField(tmp_FieldName, tmp_Obj as UnityEngine.Object,
                                    tmp_CType, true);
                                tmp_Instance[tmp_I.Value] = tmp_Res;
                            }
                            else
                            {
                                //other
                                EditorGUILayout.LabelField(tmp_FieldName,
                                    tmp_Obj != null ? tmp_Obj.ToString() : "(null)");
                            }
                        }
                    }
                }
            }

            serializedObject.ApplyModifiedProperties();
        }

        private void DrawList<T>(Type _cType, ILTypeInstance _instance, KeyValuePair<string, int> _dataIndex,
            string _fieldName) where T : UnityEngine.Object
        {
            if (!foldouts.ContainsKey(_cType))
                foldouts.Add(_cType, false);
            var tmp_InstanceGOList = _instance[_dataIndex.Value] as List<T>;
            foldouts[_cType] =
                EditorGUILayout.BeginFoldoutHeaderGroup(foldouts[_cType], _fieldName);
            if (foldouts[_cType])
            {
                for (int tmp_Idx = 0; tmp_Idx < tmp_InstanceGOList.Count; tmp_Idx++)
                {
                    tmp_InstanceGOList[tmp_Idx] = (T) EditorGUILayout.ObjectField(
                        new GUIContent(tmp_Idx.ToString()),
                        tmp_InstanceGOList[tmp_Idx], typeof(T), false);
                }
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
        }
    }
}