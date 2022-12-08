// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantomsxr.ProjectHelper.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using SDKEntry.Runtime;
using SDKEntry.Runtime.Models;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime.Enums;
using XRMODEngineSettings.Editor;

namespace com.Phantoms.ProjectHelper.Editor
{
    public enum BuildSDKType
    {
        NativeLibrary,
        UnityStandalone,
    }

    public class ProjectHelperPreferences
    {
        public class Settings
        {
            public Settings()
            {
                try
                {
                    BuildSDKType = Enum.Parse<BuildSDKType>(EditorPrefs.GetString(nameof(BuildSDKType),
                        nameof(BuildSDKType.NativeLibrary)));
                }
                catch (Exception)
                {
                    EditorPrefs.DeleteKey(nameof(BuildSDKType));
                }
            }

            public BuildSDKType BuildSDKType;

            public void Save()
            {
                EditorPrefs.SetString(nameof(BuildSDKType), BuildSDKType.ToString());
                EditorUtility.SetDirty(_SDK_BUILD_SETTINGS);
                _SERIALIZED_OBJECT.ApplyModifiedProperties();
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        private static Settings _INSTANCE = null;
        private static SerializedObject _SERIALIZED_OBJECT;
        private static long _EXPIRATION_TIME = 1;

        private static Settings Instance
        {
            get
            {
                _INSTANCE ??= new Settings();
                return _INSTANCE;
            }
        }

        [SettingsProvider]
        public static SettingsProvider ProjectHelperSettingsProvider()
        {
            return new SettingsProvider("Project/PhantomsXR/BuildSDKSettings", SettingsScope.Project)
            {
                label = "Export SDK Settings(Dev)",
                guiHandler = PreferencesGUI,
                keywords = new HashSet<string>() { "Build", "OnPostprocessBuild" },
                titleBarGuiHandler = DrawTitleBar
            };
        }

        private static string _WORKSPACE_DICT = Path.Combine("Assets/Scripts/com.phantoms.projecthelper", "Editor/");

        private static string[] _TOOLBAR_NAMES;
        private static int _TOOLBAR_INDEX;
        private static int _TMP_TOOLBAR_INDEX_ID = -1;

        private static int GetToolbarIndex
        {
            get => EditorPrefs.GetInt(nameof(_TOOLBAR_INDEX), 0);
            set
            {
                if (value == _TOOLBAR_INDEX) return;
                _TOOLBAR_INDEX = value;
                EditorPrefs.SetInt(nameof(_TOOLBAR_INDEX), value);
            }
        }

        private static BuildSettingsScriptableObject _SDK_BUILD_SETTINGS;
        private static XRMODEnginePlatformSettings _XRMOD_ENGINE_PLATFORM_SETTINGS;


        private static void PreferencesGUI(string _str)
        {
            EditorGUI.BeginChangeCheck();
            if (MakeSureData()) return;

            var tmp_Suffix = GetToolbarIndex == 1
                ? $"{Instance.BuildSDKType}_{Extensions.GetHandheldARPlatform}"
                : Instance.BuildSDKType.ToString();

            if (_XRMOD_ENGINE_PLATFORM_SETTINGS == null || _XRMOD_ENGINE_PLATFORM_SETTINGS.name != tmp_Suffix)
            {
                if (_SDK_BUILD_SETTINGS.XrmodEngineSettings == null)
                {
                    EditorGUILayout.HelpBox(
                        "Your SDK has been not initialized, go to Project Setting -> XR-MOD Engine SDK Settings initialize it.",
                        MessageType.Error);
                    return;
                }

                _XRMOD_ENGINE_PLATFORM_SETTINGS =
                    _SDK_BUILD_SETTINGS.XrmodEngineSettings.GetPlatformSettings(GetToolbarIndex, tmp_Suffix);
            }

            _TOOLBAR_NAMES ??= Enum.GetNames(typeof(SDKDeviceType));

            Instance.BuildSDKType =
                (BuildSDKType)EditorGUILayout.EnumPopup("Build SDK Type", Instance.BuildSDKType);


            DrawProjectExportComponent("SDK Export Path", ref _SDK_BUILD_SETTINGS.ExportPath);

            DrawLicenseArea();

            EditorGUILayout.Space();

            GUILayout.Label("Device Settings", "BoldLabel");
            EditorGUILayout.Space(2);
            GetToolbarIndex = GUILayout.Toolbar(GetToolbarIndex, _TOOLBAR_NAMES);

            _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab = (GameObject)EditorGUILayout.ObjectField(
                $"{_TOOLBAR_NAMES[GetToolbarIndex]} Launcher", _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab,
                typeof(GameObject), false);
            if (GetToolbarIndex != _TMP_TOOLBAR_INDEX_ID)
            {
                _TMP_TOOLBAR_INDEX_ID = GetToolbarIndex;
                //Refresh the suffix to get asset
                tmp_Suffix = GetToolbarIndex == 1
                    ? $"{Instance.BuildSDKType}_{Extensions.GetHandheldARPlatform}"
                    : Instance.BuildSDKType.ToString();
                var tmp_PlatformSettings =
                    _SDK_BUILD_SETTINGS.XrmodEngineSettings.GetPlatformSettings(GetToolbarIndex, tmp_Suffix);

                if (tmp_PlatformSettings)
                    _SERIALIZED_OBJECT = new SerializedObject(tmp_PlatformSettings);
            }

            _XRMOD_ENGINE_PLATFORM_SETTINGS.DrawPlatformSettings(_SERIALIZED_OBJECT);

            if (!EditorGUI.EndChangeCheck()) return;
            Instance.Save();
        }

        private static bool MakeSureData()
        {
            if (_SDK_BUILD_SETTINGS == null)
            {
                var tmp_SDKBuildSettingsFile = Path.Combine(_WORKSPACE_DICT, "Settings/SDKBuildSettings.asset");
                _SDK_BUILD_SETTINGS =
                    AssetDatabase.LoadAssetAtPath<BuildSettingsScriptableObject>(tmp_SDKBuildSettingsFile);
                if (_SDK_BUILD_SETTINGS == null)
                {
                    EditorGUILayout.HelpBox("SDK Build Settings file not found, Click bottom button to create it!",
                        MessageType.Error);
                    if (!GUILayout.Button("Initialize Settings")) return true;
                    var tmp_BuildSettings = ScriptableObject.CreateInstance<BuildSettingsScriptableObject>();
                    _SDK_BUILD_SETTINGS = tmp_BuildSettings;
                    AssetDatabase.CreateAsset(tmp_BuildSettings, tmp_SDKBuildSettingsFile);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();

                    return true;
                }
            }
            else
            {
                _SDK_BUILD_SETTINGS.OnValidate();
            }

            return false;
        }

        private static void DrawLicenseArea()
        {
            EditorGUILayout.PrefixLabel(new GUIContent("License For Offline",
                "If you are using offline mode, you must copy this license to your dashboard token."));
            if (string.IsNullOrEmpty(_SDK_BUILD_SETTINGS.License))
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("License Expiration Time(ms)", GUILayout.Width(200));
                _EXPIRATION_TIME = EditorGUILayout.LongField(_EXPIRATION_TIME);
                if (GUILayout.Button("Generate License", GUILayout.Width(130)))
                {
                    JsonWebToken.JsonSerializer = new LitJsonSerializer();
                    var tmp_Payload = new OfflineLicense()
                    {
                        name = SystemInfo.deviceName,
                        expiration_time = DateTimeOffset.UtcNow.AddMilliseconds(_EXPIRATION_TIME)
                            .ToUnixTimeMilliseconds()
                    };

                    _SDK_BUILD_SETTINGS.License = JsonWebToken.Encode(tmp_Payload, SDKEntryPointModel.CONST_SECRET_KEY,
                        JwtHashAlgorithm.HS256);
                }

                EditorGUILayout.EndHorizontal();
            }
            else
            {
                _SDK_BUILD_SETTINGS.License =
                    EditorGUILayout.TextArea(_SDK_BUILD_SETTINGS.License, EditorStyles.textArea);
            }
        }

        private static void DrawProjectExportComponent(string _pathName, ref string _exportPath)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.TextField(_pathName, _exportPath);
            if (GUILayout.Button("Browser", GUILayout.Width(60)))
            {
                var tmp_Path = EditorUtility.SaveFolderPanel("Set SDK Export Path", "",
                    $"{EditorUserBuildSettings.activeBuildTarget}-SDK");
                if (string.IsNullOrEmpty(tmp_Path)) return;
                _exportPath = tmp_Path;
                EditorUserBuildSettings.SetBuildLocation(EditorUserBuildSettings.activeBuildTarget, tmp_Path);
            }

            EditorGUILayout.EndHorizontal();
        }

        private static void DrawTitleBar()
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Space();
            if (GUILayout.Button("Apply", GUILayout.Width(60)))
            {
                Assert.IsNotNull(_SDK_BUILD_SETTINGS.XrmodEngineSettings);
                Assert.IsNotNull(_XRMOD_ENGINE_PLATFORM_SETTINGS);
                _SDK_BUILD_SETTINGS.XrmodEngineSettings.SDKInformation.DeviceLauncher =
                    _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab;

                _SDK_BUILD_SETTINGS.XrmodEngineSettings.SDKInformation.Version =
                    $"{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.x}.{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.y}.{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.z}";

                _SDK_BUILD_SETTINGS.XrmodEngineSettings.SDKInformation.currentSDKDeviceType =
                    Enum.Parse<SDKDeviceType>(_TOOLBAR_NAMES[_TOOLBAR_INDEX]);

                var tmp_DestScriptingDefineSymbols = _XRMOD_ENGINE_PLATFORM_SETTINGS.ScriptingDefineSymbols;
                PlayerSettings.SetScriptingDefineSymbols(GetNamedTarget(), tmp_DestScriptingDefineSymbols);

                _SERIALIZED_OBJECT.ApplyModifiedProperties();
                new SerializedObject(_SDK_BUILD_SETTINGS.XrmodEngineSettings).ApplyModifiedProperties();
                new SerializedObject(_SDK_BUILD_SETTINGS.XrmodEngineSettings.SDKInformation).ApplyModifiedProperties();

                EditorUtility.SetDirty(_SDK_BUILD_SETTINGS);
                EditorUtility.SetDirty(_SDK_BUILD_SETTINGS.XrmodEngineSettings);
                EditorUtility.SetDirty(_SDK_BUILD_SETTINGS.XrmodEngineSettings.SDKInformation);
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
#else
            return NamedBuildTarget.Standalone;
#endif
        }
    }
}