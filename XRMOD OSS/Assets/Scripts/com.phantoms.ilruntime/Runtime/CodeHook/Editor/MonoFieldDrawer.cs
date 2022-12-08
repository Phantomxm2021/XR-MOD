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

using com.Phantoms.ILRuntime.Runtime.CodeHook;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace com.Phantoms.Runtime.Editor
{
    //[CustomPropertyDrawer(typeof(MonoField))]
    public class MonoFieldDrawer : PropertyDrawer
    {
        // private bool display;
        float foldoutLabelHeight(GUIContent _label)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.String, _label);
        }

        public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
        {
            EditorGUI.BeginProperty(_position, _label, _property);
            Rect tmp_FoldoutPosition = _position;
            tmp_FoldoutPosition.height = foldoutLabelHeight(_label);
            _property.isExpanded = EditorGUI.Foldout(tmp_FoldoutPosition, _property.isExpanded, _label, true);

            if (_property.isExpanded)
            {
                var tmp_FieldNameRect = new Rect(_position.x, _position.y + tmp_FoldoutPosition.height, _position.width,
                    _position.height);
                EditorGUI.PropertyField(tmp_FieldNameRect, _property.FindPropertyRelative("FieldName"),GUIContent.none);
            }

            EditorGUI.EndProperty();
        }

        // public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
        // {
        //     base.OnGUI(_position,_property,_label);
        //     // Rect tmp_R1 = _position;
        //     // tmp_R1.width = 120;
        //     //
        //     // Rect tmp_R2 = _position;
        //     // tmp_R2.xMin = tmp_R1.xMax + 10;
        //     // tmp_R2.width = 120;
        //     //
        //     // Rect tmp_R3 = _position;
        //     // tmp_R3.xMin = tmp_R2.xMax + 10;
        //     //
        //     // if (!string.IsNullOrEmpty(_property.FindPropertyRelative("Value").stringValue))
        //     // {
        //     //     if (EditorGUI.Foldout(tmp_R1, false, _label))
        //     //     {
        //     //         EditorGUI.PropertyField(tmp_R1, _property.FindPropertyRelative("FieldName"), GUIContent.none);
        //     //         EditorGUI.PropertyField(tmp_R2, _property.FindPropertyRelative("FieldType"), GUIContent.none);
        //     //     }
        //     // }
        //
        //     // // EditorGUI.BeginProperty(position, label, property);
        //     // EditorGUI.PropertyField(tmp_R1, _property.FindPropertyRelative("FieldName"), GUIContent.none);
        //     // EditorGUI.PropertyField(tmp_R2, _property.FindPropertyRelative("FieldType"), GUIContent.none);
        //     // switch ((MonoField.FieldTypeEnum)_property.FindPropertyRelative("FieldType").enumValueIndex)
        //     // {
        //     //     case MonoField.FieldTypeEnum.Number:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("Value"), GUIContent.none);
        //     //         break;
        //     //     case MonoField.FieldTypeEnum.String:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("Value"), GUIContent.none);
        //     //         break;
        //     //     case MonoField.FieldTypeEnum.Bool:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("Value"), GUIContent.none);
        //     //         break;
        //     //     case MonoField.FieldTypeEnum.GameObject:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("GameObject"), GUIContent.none);
        //     //         break;
        //     //     case MonoField.FieldTypeEnum.UnityComponent:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("Value"), GUIContent.none);
        //     //         break;
        //     //     case MonoField.FieldTypeEnum.ARExperienceResource:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("Value"), GUIContent.none);
        //     //         break;
        //     //     case MonoField.FieldTypeEnum.Enum:
        //     //         EditorGUI.PropertyField(tmp_R3, _property.FindPropertyRelative("Value"), GUIContent.none);
        //     //         break;
        //     //     // case MonoField.FieldTypeEnum.UnityObjects:
        //     //     //     EditorGUI.PropertyField(r3, property.FindPropertyRelative("UnityObjects"), new GUIContent(property.displayName),true);
        //     //     //     break;
        //     //     // case MonoField.FieldTypeEnum.Primitives: 
        //     //     //     EditorGUI.PropertyField(r3, property.FindPropertyRelative("Primitives"), new GUIContent(property.displayName),true);
        //     //     //     break;
        //     //     case MonoField.FieldTypeEnum.NotSupported:
        //     //         break;
        //     // }
        //
        //     // EditorGUI.EndProperty();
        // }

        static class Style
        {
            internal const string PAGE_INFO_FORMAT = "{0} / {1}";

            internal static GUIContent iconToolbarPlus;
            internal static GUIContent iconToolbarPlusMore;
            internal static GUIContent iconToolbarMinus;
            internal static GUIContent iconPagePrev;
            internal static GUIContent iconPageNext;
            internal static GUIContent iconPagePopup;

            internal static GUIStyle paginationText;
            internal static GUIStyle pageSizeTextField;
            internal static GUIStyle draggingHandle;
            internal static GUIStyle headerBackground;
            internal static GUIStyle footerBackground;
            internal static GUIStyle paginationHeader;
            internal static GUIStyle boxBackground;
            internal static GUIStyle preButton;
            internal static GUIStyle preButtonStretch;
            internal static GUIStyle elementBackground;
            internal static GUIStyle verticalLabel;
            internal static GUIContent expandButton;
            internal static GUIContent collapseButton;
            internal static GUIContent sortAscending;
            internal static GUIContent sortDescending;

            internal static GUIContent listIcon;

            static Style()
            {
                iconToolbarPlus = EditorGUIUtility.IconContent("Toolbar Plus", "Add to list");
                iconToolbarPlusMore = EditorGUIUtility.IconContent("Toolbar Plus More", "Choose to add to list");
                iconToolbarMinus = EditorGUIUtility.IconContent("Toolbar Minus", "Remove selection from list");
                iconPagePrev = EditorGUIUtility.IconContent("Animation.PrevKey", "Previous page");
                iconPageNext = EditorGUIUtility.IconContent("Animation.NextKey", "Next page");

#if UNITY_2018_3_OR_NEWER
                iconPagePopup = EditorGUIUtility.IconContent("PopupCurveEditorDropDown", "Select page");
#else
				iconPagePopup = EditorGUIUtility.IconContent("MiniPopupNoBg", "Select page");
#endif
                paginationText = new GUIStyle();
                paginationText.margin = new RectOffset(2, 2, 0, 0);
                paginationText.fontSize = EditorStyles.miniTextField.fontSize;
                paginationText.font = EditorStyles.miniFont;
                paginationText.normal.textColor = EditorStyles.miniTextField.normal.textColor;
                paginationText.alignment = TextAnchor.MiddleLeft;
                paginationText.clipping = TextClipping.Clip;

#if UNITY_2019_3_OR_NEWER
                pageSizeTextField = new GUIStyle("RL Background");
#else
				pageSizeTextField = new GUIStyle("RL Footer");
				pageSizeTextField.overflow = new RectOffset(0, 0, -2, -3);
				pageSizeTextField.contentOffset = new Vector2(0, -1);
#endif
                pageSizeTextField.alignment = TextAnchor.MiddleLeft;
                pageSizeTextField.clipping = TextClipping.Clip;
                pageSizeTextField.fixedHeight = 0;
                pageSizeTextField.padding = new RectOffset(3, 0, 0, 0);
                pageSizeTextField.font = EditorStyles.miniFont;
                pageSizeTextField.fontSize = EditorStyles.miniTextField.fontSize;
                pageSizeTextField.fontStyle = FontStyle.Normal;
                pageSizeTextField.wordWrap = false;

                draggingHandle = new GUIStyle("RL DragHandle");
                headerBackground = new GUIStyle("RL Header");
                footerBackground = new GUIStyle("RL Footer");

#if UNITY_2019_3_OR_NEWER
                paginationHeader = new GUIStyle("TimeRulerBackground");
                paginationHeader.fixedHeight = 0;
#else
				paginationHeader = new GUIStyle("RL Element");
				paginationHeader.border = new RectOffset(2, 3, 2, 3);
#endif
                elementBackground = new GUIStyle("RL Element");
                elementBackground.border = new RectOffset(2, 3, 2, 3);
                verticalLabel = new GUIStyle(EditorStyles.label);
                verticalLabel.alignment = TextAnchor.UpperLeft;
                verticalLabel.contentOffset = new Vector2(10, 3);
                boxBackground = new GUIStyle("RL Background");
                boxBackground.border = new RectOffset(6, 3, 3, 6);

#if UNITY_2019_3_OR_NEWER
                preButton = new GUIStyle("RL FooterButton");
#else
				preButton = new GUIStyle("RL FooterButton");
				preButton.contentOffset = new Vector2(0, -4);
#endif
                preButtonStretch = new GUIStyle("RL FooterButton");
                preButtonStretch.fixedHeight = 0;
                preButtonStretch.stretchHeight = true;

                expandButton = EditorGUIUtility.IconContent("winbtn_win_max");
                expandButton.tooltip = "Expand All Elements";

                collapseButton = EditorGUIUtility.IconContent("winbtn_win_min");
                collapseButton.tooltip = "Collapse All Elements";

                sortAscending = EditorGUIUtility.IconContent("align_vertically_bottom");
                sortAscending.tooltip = "Sort Ascending";

                sortDescending = EditorGUIUtility.IconContent("align_vertically_top");
                sortDescending.tooltip = "Sort Descending";

                listIcon = EditorGUIUtility.IconContent("align_horizontally_right");
            }
        }
    }
}