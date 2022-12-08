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

using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace XRMODEngineSettings.Editor
{
    public class GameObjectTagsLayersDrawer : AbstractDrawer
    {
        private const string _CONST_TAGS_AND_LAYERS_HELP = "The project default tags and layers must to set.";

        private static readonly string[] _TAGS =
            {"UICamera", "ARSessionOrigin", "ARSession", "Enemy", "Item", "Projectile", "NPC", "Fx"};

        private static readonly Dictionary<int, string> _LAYERS = new()
        {
            {6, "Enemy"},
            {7, "Player"},
            {10, "Item"},
            {11, "NPC"},
            {12, "Projectile"},
            {13, "Other"},
#if PICO_INSTALL || QUEST_INSTALL
            {14, "Teleport"},
            {15, "Grab"},
#endif
        };

        public override void Draw()
        {
            DrawUtility.DrawSettingState("Tags & Layers", _CONST_TAGS_AND_LAYERS_HELP, CheckTagsAndLayers(),
                CheckedTexture,
                ErrorTexture,
                FixTagsAndLayers);
        }

        private bool CheckTagsAndLayers()
        {
            var tmp_Tags = UnityEditorInternal.InternalEditorUtility.tags.ToList();
            var tmp_Layers = UnityEditorInternal.InternalEditorUtility.layers.ToList();
            int tmp_PassPercent = _TAGS.Length + _LAYERS.Count;
            foreach (string tmp_Tag in _TAGS)
            {
                if (tmp_Tags.Contains(tmp_Tag))
                {
                    tmp_PassPercent--;
                }
            }

            foreach (KeyValuePair<int, string> tmp_Element in _LAYERS)
            {
                if (tmp_Layers.Contains(tmp_Element.Value))
                {
                    tmp_PassPercent--;
                }
            }

            return tmp_PassPercent == 0;
        }

        private void FixTagsAndLayers()
        {
            var tmp_Tags = UnityEditorInternal.InternalEditorUtility.tags.ToList();
            var tmp_Layers = UnityEditorInternal.InternalEditorUtility.layers.ToList();

            foreach (string tmp_Tag in _TAGS)
            {
                if (tmp_Tags.Contains(tmp_Tag))
                {
                    continue;
                }

                UnityEditorInternal.InternalEditorUtility.AddTag(tmp_Tag);
            }


            //Modify layers
            var tmp_TagManager =
                new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
            SerializedProperty tmp_SerializedLayers = tmp_TagManager.FindProperty("layers");

            if (tmp_SerializedLayers == null || !tmp_SerializedLayers.isArray) return;

            foreach (var tmp_Element in _LAYERS)
            {
                if (tmp_Layers.Contains(tmp_Element.Value))
                {
                    continue;
                }

                SerializedProperty tmp_LayerProperties = tmp_SerializedLayers.GetArrayElementAtIndex(tmp_Element.Key);
                tmp_LayerProperties.stringValue = tmp_Element.Value;
            }

            tmp_TagManager.ApplyModifiedProperties();
        }
    }
}