// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace XRMODEngineSettings.Editor
{
    public class ShadersValidationDrawer : AbstractDrawer
    {
        private SerializedProperty alwaysIncludedShadersProperty;
        private SerializedProperty preloadedShadersProperty;
        private SerializedObject graphicsObject;
        private const string PLATFORM_HELP = "Missing essential Shader will not allow to use some functions correctly.";

        private const string _CONST_POINT_CLOUD = "Shaders/pointCloud";
        private const string _CONST_SHADER_COLLECTION = "glTFShaderVariants";
        public ShadersValidationDrawer()
        {
            GetGraphicsSettings(out graphicsObject);
            preloadedShadersProperty = GetPreloadShadersProperty();
            alwaysIncludedShadersProperty = GetAlwaysIncludedShadersProperty();
        }

        public override void Draw()
        {
            DrawUtility.DrawSettingState("Essential Shaders", PLATFORM_HELP, ShadersValidation(), CheckedTexture, ErrorTexture,
                FixError);
        }

        private void FixError()
        {
            if (!IsShaderExist(_CONST_POINT_CLOUD))
            {
                var tmp_Idx = alwaysIncludedShadersProperty.arraySize;
                alwaysIncludedShadersProperty.InsertArrayElementAtIndex(tmp_Idx);
                var tmp_ArrayElem = alwaysIncludedShadersProperty.GetArrayElementAtIndex(tmp_Idx);
                tmp_ArrayElem.objectReferenceValue = GetShader(_CONST_POINT_CLOUD);
                graphicsObject.ApplyModifiedProperties();
            }

            // if (!IsPreloadedShaderExist(_CONST_SHADER_COLLECTION))
            // {
            //     var tmp_ShaderVariantCollection = Resources.Load<ShaderVariantCollection>(_CONST_SHADER_COLLECTION);
            //     var tmp_Idx = preloadedShadersProperty.arraySize;
            //     preloadedShadersProperty.InsertArrayElementAtIndex(tmp_Idx);
            //     var tmp_ArrayElem = preloadedShadersProperty.GetArrayElementAtIndex(tmp_Idx);
            //     tmp_ArrayElem.objectReferenceValue = tmp_ShaderVariantCollection;
            //     graphicsObject.ApplyModifiedProperties();
            // }
        }

        private bool ShadersValidation()
        {
            bool tmp_PointCloudShaderExist = IsShaderExist(_CONST_POINT_CLOUD);

            // bool tmp_IsPreloadedShaderExist = IsPreloadedShaderExist(_CONST_SHADER_COLLECTION);
            return tmp_PointCloudShaderExist;
        }

        private SerializedProperty GetPreloadShadersProperty()
        {
            return graphicsObject?.FindProperty("m_PreloadedShaders");
        }

        private void GetGraphicsSettings(out SerializedObject _serializedObject)
        {
            var tmp_GraphicsSettingsObj =
                AssetDatabase.LoadAssetAtPath<GraphicsSettings>("ProjectSettings/GraphicsSettings.asset");
            _serializedObject = new SerializedObject(tmp_GraphicsSettingsObj);
        }

        private SerializedProperty GetAlwaysIncludedShadersProperty()
        {
            return graphicsObject.FindProperty("m_AlwaysIncludedShaders");
        }

        private Shader GetShader(string _shaderName) => Resources.Load<Shader>(_shaderName);

        private bool IsShaderExist(string _shaderName)
        {
            var tmp_Shader = GetShader(_shaderName);
            for (int i = 0; i < alwaysIncludedShadersProperty.arraySize; ++i)
            {
                var arrayElem = alwaysIncludedShadersProperty.GetArrayElementAtIndex(i);
                if (tmp_Shader != arrayElem.objectReferenceValue) continue;
                return true;
            }

            return false;
        }

        private bool IsPreloadedShaderExist(string _shaderCollectionName)
        {
            var tmp_ShaderVariantCollection = Resources.Load<ShaderVariantCollection>(_shaderCollectionName);
            for (int tmp_Idx = 0; tmp_Idx < preloadedShadersProperty.arraySize; tmp_Idx++)
            {
                var tmp_ArrayElem = preloadedShadersProperty.GetArrayElementAtIndex(tmp_Idx);
                if (tmp_ArrayElem.objectReferenceValue != tmp_ShaderVariantCollection) continue;
                return true;
            }

            return false;
        }
    }
}