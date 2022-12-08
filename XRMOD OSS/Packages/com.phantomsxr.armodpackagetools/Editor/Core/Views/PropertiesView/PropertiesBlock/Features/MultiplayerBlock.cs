using UnityEditor;
using UnityEngine;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class MultiplayerBlock : AbstractBlock
    {
        private Configures configures;
        private bool foldoutState = true;

        public MultiplayerBlock()
        {
        }

        public MultiplayerBlock(Configures _configures) : base(_configures)
        {
            configures = _configures;
        }

        public override Rect DrawBlock(Rect _area)
        {
            foldoutState =
                EditorGUILayout.BeginFoldoutHeaderGroup(foldoutState, "Multiplayer Feature", null,
                    ShowHeaderContextMenu);
            var tmp_BlockRect = GUILayoutUtility.GetLastRect();
            if (foldoutState)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(15f);
                EditorGUILayout.BeginVertical();
                configures.Multiplayer =
                    EditorGUILayout.Toggle("Multiplayer", configures.Multiplayer);

                configures.DisplayPing =
                    EditorGUILayout.Toggle("DisplayPing", configures.DisplayPing);
                
                configures.Discovery =
                    EditorGUILayout.Toggle("Discovery", configures.Discovery);
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
            configures.Multiplayer = false;
            return true;
        }

        public override bool OpenReference()
        {
            Application.OpenURL($"{CONST_HELP_BASE_URL}features#multiplayer-feature");
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