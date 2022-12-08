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

namespace XRMODEngineSettings.Editor
{
    public static class DrawUtility
    {
        // static class WizardStyles
        // {
        //     public static readonly GUIStyle COMMAND_BUTTON_STYLE;
        //
        //     static WizardStyles()
        //     {
        //         COMMAND_BUTTON_STYLE = new GUIStyle()
        //         {
        //             fontSize = 16,
        //             alignment = TextAnchor.MiddleCenter,
        //             imagePosition = ImagePosition.ImageAbove,
        //         };
        //     }
        // }

        public static void DrawSettingState(string _title, string _errorHelp, bool _true, Texture _checked,
            Texture _error, Action _fixAction = null,
            Action _drawExtUI = null)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel(_title);
            var tmp_Rect = GUILayoutUtility.GetLastRect();
            tmp_Rect.x += 300;
            tmp_Rect.y -= 8;
            tmp_Rect.width = 32;
            tmp_Rect.height = 32;
            EditorGUI.LabelField(tmp_Rect, new GUIContent(_true ? _checked : _error));
            EditorGUILayout.Space();
            if (!_true)
            {
                _drawExtUI?.Invoke();

                if (GUILayout.Button("Fix", GUILayout.Width(80)))
                {
                    _fixAction?.Invoke();
                }
            }

            EditorGUILayout.EndHorizontal();
            if (!_true)
                EditorGUILayout.HelpBox(_errorHelp, MessageType.Error);
        }
    }
}