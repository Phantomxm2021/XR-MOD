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
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using XRMODEngineCore.Runtime.Enums;

namespace XRMODEngineSettings.Editor
{
    public class XRMODEnginePreferences
    {
        [SettingsProvider]
        private static SettingsProvider ProjectHelperSettingsProvider()
        {
            return new SettingsProvider("Project/PhantomsXR/XRMODEngineSDKSettings", SettingsScope.Project)
            {
                label = "XR-MOD Engine SDK Settings",
                guiHandler = PreferencesGUI,
                titleBarGuiHandler = DrawTitleBar,
                keywords = new HashSet<string>()
                {
                    "XRMOD",
                    "XRMOD Settings"
                },
            };
        }

        internal static XRMODEngineSettings _XRMOD_ENGINE_SETTINGS;
        internal static string[] _TOOLBAR_NAMES;
        private static int _TOOLBAR_INDEX = 0;
        private static int _TMP_CACHE_TOOLBAR_INDEX = -1;
        private static XRMODEnginePlatformSettings _XRMOD_ENGINE_PLATFORM_SETTINGS;
        private static SerializedObject _SERIALIZED_OBJECT;

        private static List<ISettingsDrawer> _ENVIRONMENT_SETTINGS_DRAWER = new()
        {
            new RuntimeSceneDrawer(),
            new ApiCompatibilityDrawer(),
            new GameObjectTagsLayersDrawer(),
            new InputSystemDrawer(),
            new XRSystemActiveDrawer(),
            new ShadersValidationDrawer(),
            new AndroidMiniSDKVersionDrawer(),
            new AndroidGraphicsDrawer(),
            new ColorSpaceValidationDrawer(),
            new ScriptingBackendValidationDrawer(),
#if HANDHELD_ARMODULE_INSTALL
            new SimulationDrawer()
#endif
        };

        internal static int GetToolbarIndex
        {
            get => EditorPrefs.GetInt(nameof(_TOOLBAR_INDEX), 0);
            set
            {
                if (value == _TOOLBAR_INDEX) return;
                _TOOLBAR_INDEX = value;
                EditorPrefs.SetInt(nameof(_TOOLBAR_INDEX), value);
            }
        }

        private static void PreferencesGUI(string _searchContext)
        {
            if (_XRMOD_ENGINE_SETTINGS == null)
            {
                _XRMOD_ENGINE_SETTINGS =
                    AssetDatabase.LoadAssetAtPath<XRMODEngineSettings>("Assets/XR/XRMODEngineSettings.asset");

                if (_XRMOD_ENGINE_SETTINGS)
                    _XRMOD_ENGINE_SETTINGS.OnValidate();
                else
                {
                    EditorGUILayout.Space();
                    EditorGUILayout.HelpBox(
                        "XR-MOD Engine SDK Settings file not found, Click bottom button to create it!",
                        MessageType.Error);
                    if (GUILayout.Button("Initialize Settings"))
                    {
                        XRMODEngineInitializer.CreateProjectSettings();
                    }

                    return;
                }
            }

            EditorGUI.BeginChangeCheck();

            GUILayout.Label("SDK Settings", EditorStyles.boldLabel);
            _TOOLBAR_NAMES ??= Enum.GetNames(typeof(SDKDeviceType));
            GetToolbarIndex = GUILayout.Toolbar(GetToolbarIndex, _TOOLBAR_NAMES);

            var tmp_PlatformSuffix = GetToolbarIndex == 1 ? $"_{Extensions.GetHandheldARPlatform}" : "";
            var tmp_Suffix = $"UnityStandalone{tmp_PlatformSuffix}";
            if (_XRMOD_ENGINE_PLATFORM_SETTINGS == null
                || !_XRMOD_ENGINE_PLATFORM_SETTINGS.name.Contains(tmp_Suffix)
                || GetToolbarIndex != _TMP_CACHE_TOOLBAR_INDEX)
            {
                _TMP_CACHE_TOOLBAR_INDEX = GetToolbarIndex;
                _XRMOD_ENGINE_PLATFORM_SETTINGS =
                    _XRMOD_ENGINE_SETTINGS.GetPlatformSettings(GetToolbarIndex, tmp_Suffix);
                _SERIALIZED_OBJECT = new SerializedObject(_XRMOD_ENGINE_PLATFORM_SETTINGS);
            }

            EditorGUILayout.BeginHorizontal();
            _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab = (GameObject) EditorGUILayout.ObjectField(
                $"{_TOOLBAR_NAMES[GetToolbarIndex]} Launcher", _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab,
                typeof(GameObject), false);
            if (GUILayout.Button("Default", GUILayout.Width(60)))
            {
                _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab =
                    Resources.Load<GameObject>($"Prefabs/Default{_TOOLBAR_NAMES[GetToolbarIndex]}Launcher");
            }

            EditorGUILayout.EndHorizontal();

            if (_XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab == null)
            {
                EditorGUILayout.HelpBox(
                    "Your XR launcher does not exist and will error out. You can click `Default` button to use our  XR launcher.",
                    MessageType.Error);
            }

            _XRMOD_ENGINE_PLATFORM_SETTINGS.DrawPlatformSettings(_SERIALIZED_OBJECT);
            if (EditorGUI.EndChangeCheck())
            {
                EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS);
                EditorUtility.SetDirty(_XRMOD_ENGINE_PLATFORM_SETTINGS);
                EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS.SDKInformation);

                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            EditorGUILayout.Space();
            GUILayout.Label("Environment Settings", EditorStyles.boldLabel);

#if HANDHELD_ARMODULE_INSTALL
            _XRMOD_ENGINE_SETTINGS.Simulation = EditorGUILayout.Toggle("Simulation", _XRMOD_ENGINE_SETTINGS.Simulation);
#endif

            foreach (ISettingsDrawer tmp_Drawer in _ENVIRONMENT_SETTINGS_DRAWER)
            {
                tmp_Drawer.Draw();
            }
        }

        private static void DrawTitleBar()
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Space();
            if (GUILayout.Button("Apply", GUILayout.Width(60)))
            {
                _XRMOD_ENGINE_SETTINGS.SDKInformation.DeviceLauncher = _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab;
                _XRMOD_ENGINE_SETTINGS.SDKInformation.Version =
                    $"{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.x}.{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.y}.{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.z}";

                _XRMOD_ENGINE_SETTINGS.SDKInformation.currentSDKDeviceType =
                    Enum.Parse<SDKDeviceType>(_TOOLBAR_NAMES[_TOOLBAR_INDEX]);

                PlayerSettings.SetScriptingDefineSymbols(GetNamedTarget(),
                    _XRMOD_ENGINE_PLATFORM_SETTINGS.ScriptingDefineSymbols);

                EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS);
                EditorUtility.SetDirty(_XRMOD_ENGINE_PLATFORM_SETTINGS);
                EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS.SDKInformation);

                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            EditorGUILayout.EndHorizontal();
        }

        private static NamedBuildTarget GetNamedTarget()
        {
#if UNITY_IOS
            return NamedBuildTarget.iOS;
#elif UNITY_ANDROID
            return NamedBuildTarget.Android;
#elif UNITY_WSA
            return NamedBuildTarget.WindowsStoreApps;
#elif UNITY_WEBGL
            return NamedBuildTarget.WebGL;
#else
            return NamedBuildTarget.Unknown;
#endif
        }
    }
}