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
using System.IO;
using UnityEditor;
using UnityEngine;

namespace XRMODEngineSettings.Editor
{
    public class RuntimeSceneDrawer : AbstractDrawer
    {
        private static readonly string[] ALL_SCENES_NAME = {"Initilizer.unity", "Main.unity", "Clear.unity"};
        private static readonly string SCENES_PATH = $"Packages/com.phantomsxr.foundation/Assets/Scenes/Release";
        private const string SCENE_HELP = "Click 'Fix' Button to setup necessary scenes for your App, please.";


        readonly List<SceneAsset> sceneAssets = new();
        readonly List<EditorBuildSettingsScene> editorBuildSettingsScenes = new();

        public RuntimeSceneDrawer()
        {
            GetScenes();
        }

        public override void Draw()
        {
            DrawUtility.DrawSettingState("Runtime Scenes", SCENE_HELP, CheckScenes(),
                base.CheckedTexture, base.ErrorTexture, AddScenesToBuildSetting);
        }

        private void GetScenes()
        {
            sceneAssets.Clear();

            foreach (string tmp_SceneName in ALL_SCENES_NAME)
            {
                SceneAsset tmp_SceneAsset =
                    AssetDatabase.LoadAssetAtPath<SceneAsset>(Path.Combine(SCENES_PATH, tmp_SceneName));
                if (!tmp_SceneAsset || sceneAssets.Contains(tmp_SceneAsset))
                    continue;
                sceneAssets.Add(tmp_SceneAsset);
            }
        }

        private bool CheckScenes()
        {
            var tmp_CurrentScenesInBuildSetting = EditorBuildSettings.scenes;
            int tmp_MatchedCount = 0;
            if (tmp_CurrentScenesInBuildSetting.Length < sceneAssets.Count)
            {
                return false;
            }

            foreach (var tmp_SceneInBuildSetting in tmp_CurrentScenesInBuildSetting)
            {
                var tmp_SceneInAssetsPath = tmp_SceneInBuildSetting.path;
                var tmp_SceneName = Path.GetFileNameWithoutExtension(tmp_SceneInAssetsPath);
                var tmp_Matched = sceneAssets.Exists(_asset => tmp_SceneName.Equals(_asset.name));

                if (tmp_Matched)
                    tmp_MatchedCount++;
                else
                    tmp_MatchedCount--;
            }
            
            return tmp_MatchedCount >= 2;
        }

        private void AddScenesToBuildSetting()
        {
            editorBuildSettingsScenes.Clear();
            foreach (SceneAsset tmp_SceneAsset in sceneAssets)
            {
                string tmp_SceneAssetPath = AssetDatabase.GetAssetPath(tmp_SceneAsset);
                if (!string.IsNullOrEmpty(tmp_SceneAssetPath))
                {
                    editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(tmp_SceneAssetPath, true));
                }
            }

            EditorBuildSettings.scenes = editorBuildSettingsScenes.ToArray();
        }
    }
}