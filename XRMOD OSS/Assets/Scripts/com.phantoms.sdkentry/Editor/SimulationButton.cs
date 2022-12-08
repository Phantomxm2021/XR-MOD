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

using SDKEntry.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace com.Phantoms.SDKEntry.Editor
{
    [InitializeOnLoad]
    public class SimulationButton
    {
        private static bool enterTestMode;
        private const string CONST_TEST_MODE_KEY = "TestMode";

        static class ToolbarStyles
        {
            public static readonly GUIStyle CommandButtonStyle;

            static ToolbarStyles()
            {
                CommandButtonStyle = new GUIStyle("Command")
                {
                    fontSize = 16,
                    alignment = TextAnchor.MiddleCenter,
                    imagePosition = ImagePosition.ImageAbove,
                    fontStyle = FontStyle.Bold
                };
            }
        }

        private static Texture2D ICON_TEXTURE_2D;

        static SimulationButton()
        {
            ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
            EditorApplication.playModeStateChanged += CheckAppState;
        }

        private static void LoadBtnIcon()
        {
            ICON_TEXTURE_2D =
                AssetDatabase.LoadAssetAtPath<Texture2D>(
                    "Assets/Scripts/com.phantoms.sdkentry/Editor/Assets/Textures/TestingButton.png");
            Assert.IsNotNull(ICON_TEXTURE_2D);
        }

        static void OnToolbarGUI()
        {
            //GUILayout.FlexibleSpace();
            if (!GUILayout.Button(new GUIContent(ICON_TEXTURE_2D, "For Developing test"),
                    ToolbarStyles.CommandButtonStyle))
            {
                LoadBtnIcon();
                return;
            }

            if (EditorApplication.isPlaying)
            {
                EditorApplication.ExitPlaymode();
                enterTestMode = false;
            }
            else
            {
                EditorApplication.EnterPlaymode();
                enterTestMode = true;
            }

            EditorPrefs.SetBool(CONST_TEST_MODE_KEY, enterTestMode);
        }

        private static void CheckAppState(PlayModeStateChange _state)
        {
            switch (_state)
            {
                case PlayModeStateChange.EnteredEditMode:
                case PlayModeStateChange.EnteredPlayMode:
                    if (EditorPrefs.GetBool(CONST_TEST_MODE_KEY, false))
                        SDKInitialization.Initialize();
                    break;
                case PlayModeStateChange.ExitingEditMode:
                case PlayModeStateChange.ExitingPlayMode:
                    var tmp_SDKEntryPoint = Object.FindObjectOfType<SDKEntryPoint>();
                    if (tmp_SDKEntryPoint)
                        Object.Destroy(tmp_SDKEntryPoint.gameObject);
                    EditorApplication.playModeStateChanged -= CheckAppState;
                    EditorPrefs.SetBool(CONST_TEST_MODE_KEY, false);
                    break;
            }
        }
    }
}