// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEditor;
using UnityEngine;
using XRMODEngineCore.Runtime.Enums;

namespace XRMODEngineSettings.Editor
{
    public static class Extensions
    {
        public static XRMODEnginePlatformSettings GetPlatformSettings(this XRMODEngineSettings _settings,
            int _devicesId, string _suffix = "UnityStandalone")
        {
            var tmp_SettingName = $"{(SDKDeviceType) _devicesId}{_suffix}";

            if (_settings == null)
                _settings =
                    AssetDatabase.LoadAssetAtPath<XRMODEngineSettings>("Assets/XR/XRMODEngineSettings.asset");
            var tmp_PlatformSettings = _settings.PlatformSettingValue.Find(_platformSettings =>
                _platformSettings.name.Contains(tmp_SettingName));
            return tmp_PlatformSettings;
        }


        public static void DrawPlatformSettings(this XRMODEnginePlatformSettings _platformSettings,
            SerializedObject _serialized)
        {
            var tmp_Tooltips =
                "Given a version number MAJOR.MINOR.PATCH, increment the:" 
                + "\n1.MAJOR version when you make incompatible API changes,"
                + "\n2.MINOR version when you add functionality in a backwards compatible manner, and"
                + "\n3.PATCH version when you make backwards compatible bug fixes."
                + "\nAdditional labels for pre-release and build metadata are available as extensions to the MAJOR.MINOR.PATCH format.";
            // _platformSettings.Version = EditorGUILayout.TextField("SDK Version", _platformSettings.Version);
            _platformSettings.Version = EditorGUILayout.Vector3IntField(new GUIContent("SDK Version", tmp_Tooltips),
                _platformSettings.Version);
            var tmp_SerializedProperty = _serialized.FindProperty("ScriptingDefineSymbols");
            if (tmp_SerializedProperty == null) return;
            EditorGUILayout.PropertyField(tmp_SerializedProperty, new GUIContent("Scripting Define Symbols"), true);

            _serialized.ApplyModifiedProperties();
        }


        public static String GetHandheldARPlatform
        {
            get
            {
#if UNITY_IOS
                return "iOS";
#elif UNITY_ANDROID
                return "Android";
#else
                return "";
#endif
            }
        }
    }
}