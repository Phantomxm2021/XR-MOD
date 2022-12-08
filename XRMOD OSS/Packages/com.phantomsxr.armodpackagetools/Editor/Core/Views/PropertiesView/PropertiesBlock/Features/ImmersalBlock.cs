using System;
using UnityEditor;
using UnityEngine;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class ImmersalBlock : AbstractBlock
    {
        private bool immersalBlockToggle = true;

        private readonly Configures property;

        public ImmersalBlock(Configures _property) : base(_property)
        {
            property = _property;
        }

        public override Rect DrawBlock(Rect _area)
        {
            immersalBlockToggle =
                EditorGUILayout.BeginFoldoutHeaderGroup(immersalBlockToggle, "Immersal Setting", null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();


            if (immersalBlockToggle)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();

                property.AutoStart =
                    EditorGUILayout.Toggle("Enable Localizer", property.AutoStart);
                property.UseFiltering =
                    EditorGUILayout.Toggle("Enable Filter", property.UseFiltering);
                property.ResetOnMapChange = EditorGUILayout.Toggle("ResetOnMapChange", property.ResetOnMapChange);
                if (property.AutoStart)
                {
                    property.BurstMode =
                        EditorGUILayout.Toggle("Burst Mode", property.BurstMode);
                }
                else
                {
                    EditorGUILayout.HelpBox("Localization will not occur when Localizer is not enabled.",MessageType.Warning);
                }

                property.StopLocalizedAfterSuccess =
                    EditorGUILayout.Toggle("Pause Localized After Success", property.StopLocalizedAfterSuccess);

                if (property.StopLocalizedAfterSuccess)
                {
                    EditorGUILayout.HelpBox(
                        "Pause can save performance expenses after the localized is successful," +
                        "but localization will be invalid when APP run in background switch to App resume or focused",
                        MessageType.Warning);
                }

                property.UseServerLocalizer =
                    EditorGUILayout.Toggle("Server Localizer(Beta)", property.UseServerLocalizer);
                if (property.UseServerLocalizer)
                {
                    property.DeveloperToken = EditorGUILayout.TextField("Developer Token", property.DeveloperToken);

                    if (string.IsNullOrEmpty(property.DeveloperToken))
                    {
                        EditorGUILayout.HelpBox(
                            "Using the server localizer must be a Legal Developer Token with Immersal SDK",
                            MessageType.Error);
                    }
                }


                property.LocalizationInterval =
                    EditorGUILayout.Slider("Localization Interval(s)", property.LocalizationInterval, 1, 60);


                EditorGUILayout.EndVertical();
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                Utility.DrawHorizontalDivLine();
            }


            EditorGUILayout.EndFoldoutHeaderGroup();
            return tmp_BlockRect;
        }

        public override bool OnRemoved()
        {
            // property.Maps.Clear();
            return true;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#immersal-setting");
            return false;
        }


        void ShowHeaderContextMenu(Rect _position)
        {
            var tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Reset"), false, () => OnRemoved());
            tmp_Menu.AddItem(new GUIContent(CONST_HELP_BUTTON_TITLE), false, () => OpenReference());
            tmp_Menu.DropDown(_position);
        }
    }
}