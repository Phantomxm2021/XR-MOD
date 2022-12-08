using System.Diagnostics;
// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using SDKEntry.Runtime;
using UnityEditor;
using UnityEngine;
using XRMODEngineCore.Runtime.Enums;

namespace XRMODEngineSettings.Editor
{
    public class XRMODEngineInitializer
    {
        private const string _CONST_PACKAGE_PATH = "Packages/com.phantomsxr.xrmodenginesettings";

        private static string[] SDKTypeSuffix = new[]
        {
            "NativeLibrary",
            "UnityStandalone"
        };

        private static string[] HandheldPlatform = new[]{
            "Android",
            "iOS"
        };

        public static void CreateProjectSettings()
        {
            var tmp_Settings = ScriptableObject.CreateInstance<XRMODEngineSettings>();
            tmp_Settings.SDKInformation = Resources.Load<SDKInformation>(nameof(SDKInformation));
            AssetDatabase.CreateAsset(tmp_Settings, "Assets/XR/XRMODEngineSettings.asset");
            AssetDatabase.Refresh();

            var tmp_AllDevices = Enum.GetNames(typeof(SDKDeviceType));
            foreach (string tmp_Device in tmp_AllDevices)
            {
                foreach (string tmp_SdkTypeName in SDKTypeSuffix)
                {
                    string tmp_PlatformSettingName = string.Empty;
                    if (tmp_Device == "HandheldAR")
                    {
                        foreach (string tmp_HandheldPlatform in HandheldPlatform)
                        {
                            tmp_PlatformSettingName = $"{tmp_Device}{tmp_SdkTypeName}_{tmp_HandheldPlatform}";
                            CreateAndCachePlatformSettings(tmp_PlatformSettingName, tmp_Settings);
                        }
                    }
                    else
                    {
                        tmp_PlatformSettingName = $"{tmp_Device}{tmp_SdkTypeName}";
                        CreateAndCachePlatformSettings(tmp_PlatformSettingName, tmp_Settings);
                    }


                }
            }

            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();
            EditorUtility.SetDirty(tmp_Settings);
        }

        private static void CreateAndCachePlatformSettings(string _platformSettingName, XRMODEngineSettings _settings)
        {
            var tmp_PlatformSettings = CreatePlatformSettings(_platformSettingName);
            AssetDatabase.AddObjectToAsset(tmp_PlatformSettings, _settings);
            _settings.PlatformSettingValue.Add(tmp_PlatformSettings);
            _settings.RuntimePlatformKey.Add(_platformSettingName);
        }

        private static XRMODEnginePlatformSettings CreatePlatformSettings(string _settingsName)
        {
            var tmp_PlatformSettings = ScriptableObject.CreateInstance<XRMODEnginePlatformSettings>();
            tmp_PlatformSettings.name = _settingsName;

            var tmp_FilePath = Path.Combine(_CONST_PACKAGE_PATH,
                $"Editor/Assets/DefinesJson/{tmp_PlatformSettings.name}.json");
            var tmp_JsonText = AssetDatabase.LoadAssetAtPath<TextAsset>(tmp_FilePath);
            var tmp_Defines = JsonUtility.FromJson<DefinesJson>(tmp_JsonText.text).Json;
            tmp_PlatformSettings.ScriptingDefineSymbols = tmp_Defines;

            return tmp_PlatformSettings;
        }


        public class DefinesJson
        {
            public string[] Json = new string[] { };
        }
    }
}