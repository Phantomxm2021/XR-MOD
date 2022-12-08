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

using System;
using System.Collections.Generic;
using System.IO;
using com.Phantoms.ActionNotification.Runtime;
using UnityEditor;
using UnityEditor.Build.Pipeline;
using UnityEditor.SceneManagement;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class BuildView : VisualElement
    {
        private static ProjectDetailCacheData projectDetailCacheData;
        private ProjectModel projectModel;

        private const string CONST_BUILD_PLATFORM_NAME = "Build Platform";
        private const string CONST_BUILD_GROUP_NAME = "Platform Group";
        private const string CONST_COMPRESSION_TYPE_NAME = "Compression Type";
        private const string CONST_ERROR_TITLE = "ERROR";

        public new class UxmlFactory : UxmlFactory<BuildView, VisualElement.UxmlTraits>
        {
        }

        public BuildView()
        {
            style.width = resolvedStyle.width;

            if (InitData())
            {
                InitElements();
            }
        }

        private void InitElements()
        {
            BuildPlatformEnumList();
            MakeHorizontalButtonList();
            ActionNotificationCenter.DefaultCenter.AddObserver(_data => { UpdateData(); },
                nameof(EditingProjectCommand));
        }

        private void BuildPlatformEnumList()
        {
            var tmp_BuildPlatformEnumField =
                new EnumField(CONST_BUILD_PLATFORM_NAME, projectDetailCacheData.BuildSettingData.BuildTarget)
                    {name = "buildtarget"};
            var tmp_PlatformGroupEnumField =
                new EnumField(CONST_BUILD_GROUP_NAME, projectDetailCacheData.BuildSettingData.BuildTargetGroup)
                    {name = "buildtargetgroup"};
            var tmp_CompressionTypeEnumField = new EnumField(CONST_COMPRESSION_TYPE_NAME,
                projectDetailCacheData.BuildSettingData.BuildCompression) {name = "compressiontype"};

            Add(tmp_BuildPlatformEnumField);
            Add(tmp_PlatformGroupEnumField);
            Add(tmp_CompressionTypeEnumField);


            tmp_BuildPlatformEnumField.RegisterCallback<ChangeEvent<Enum>>(_evt =>
            {
                if (Enum.TryParse(_evt.newValue.ToString(), out BuildTarget tmp_Result))
                {
                    projectDetailCacheData.BuildSettingData.BuildTarget = tmp_Result;
                }
            });

            tmp_PlatformGroupEnumField.RegisterCallback<ChangeEvent<Enum>>(_evt =>
            {
                if (Enum.TryParse(_evt.newValue.ToString(), out BuildTargetGroup tmp_Result))
                {
                    projectDetailCacheData.BuildSettingData.BuildTargetGroup = tmp_Result;
                }
            });

            tmp_CompressionTypeEnumField.RegisterCallback<ChangeEvent<Enum>>(_evt =>
            {
                if (Enum.TryParse(_evt.newValue.ToString(), out BuildCompressionType tmp_Result))
                {
                    projectDetailCacheData.BuildSettingData.BuildCompression = tmp_Result;
                }
            });
        }

        private void MakeHorizontalButtonList()
        {
            var tmp_BuildButton = new Button(() =>
            {
                if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                {
                    EditorUtility.SetDirty(projectDetailCacheData.Configures);
                    EditorUtility.SetDirty(projectDetailCacheData.BuildSettingData);
                    AssetDatabase.SaveAssets();
                    ExecuteBuildAssetBundle();
                }
            }) {text = "Build AR-Experience", name = "builbutton"};
            tmp_BuildButton.AddToClassList("horizontal-button");

            var tmp_ShowInFileBrowser = new Button(() =>
            {
                var tmp_Path = Path.Combine(Application.dataPath.Replace("Assets", ""),
                    $"ServerData/{projectDetailCacheData.BuildSettingData.BuildTarget.ToString().ToLower()}" +
                    $"/{projectModel.DisplayName.ToLower()}/{projectModel.DisplayName.ToLower()}.arexperience");
                if (File.Exists(tmp_Path))
                    EditorUtility.RevealInFinder(tmp_Path);
                else
                    EditorUtility.DisplayDialog(CONST_ERROR_TITLE, "You haven't built an AR-Experience", "Ok");
            }) {text = "Show in file browser", name = "showbutton"};
            tmp_ShowInFileBrowser.AddToClassList("horizontal-button");


            var tmp_RefreshAppDomainButton = new Button(() =>
            {
                if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                {
                    RefreshAppDomain();
                }
            }) {text = "Refresh AppDomain", name = "refreshappdomain"};
            tmp_RefreshAppDomainButton.AddToClassList("horizontal-button");

            var tmp_HorizontalVisualElement = new VisualElement();
            tmp_HorizontalVisualElement.style.flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Row);
            tmp_HorizontalVisualElement.Add(tmp_BuildButton);
            tmp_HorizontalVisualElement.Add(tmp_ShowInFileBrowser);
            tmp_HorizontalVisualElement.Add(tmp_RefreshAppDomainButton);
            Add(tmp_HorizontalVisualElement);
        }

        private bool InitData()
        {
            var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (!tmp_EditingProjectData) return false;
            projectModel = tmp_EditingProjectData.Project;
            projectDetailCacheData = tmp_EditingProjectData.DetailCacheData;
            return true;
        }

        private void UpdateData()
        {
            InitData();

            //Reset data
            var tmp_BuildTarget = this.Q<EnumField>("buildtarget");
            if (tmp_BuildTarget != null)
                tmp_BuildTarget.value = projectDetailCacheData.BuildSettingData.BuildTarget;

            var tmp_BuildGroup = this.Q<EnumField>("buildtargetgroup");
            if (tmp_BuildGroup != null)
                tmp_BuildGroup.value = projectDetailCacheData.BuildSettingData.BuildTargetGroup;

            var tmp_BuildCompression = this.Q<EnumField>("compressiontype");
            if (tmp_BuildCompression != null)
                tmp_BuildCompression.value = projectDetailCacheData.BuildSettingData.BuildCompression;
        }

        public static void RefreshAppDomain()
        {
            string tmp_ProjectAutoGenerationPath =
                Path.Combine(projectDetailCacheData.GetProjectPath(), "AutomaticGenerated");
            if (!Directory.Exists(tmp_ProjectAutoGenerationPath))
                Directory.CreateDirectory(tmp_ProjectAutoGenerationPath);
            if (string.IsNullOrEmpty(projectDetailCacheData.Configures.DomainName)) return;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                new DirectoryInfo(projectDetailCacheData.GetProjectPath()).Name);

            Utility.CopyFileToProject($"{tmp_SourceFilePath}.runtime.dll", tmp_ProjectAutoGenerationPath,
                "bytes");
            Utility.CopyFileToProject($"{tmp_SourceFilePath}.runtime.pdb",
                tmp_ProjectAutoGenerationPath, "bytes");
        }

        private void ExecuteBuildAssetBundle()
        {
            List<string> tmp_AddressableName = new List<string>();
            List<string> tmp_BundlePath = new List<string>();


            string tmp_ProjectAutoGenerationPath =
                Path.Combine(projectDetailCacheData.GetProjectPath(), "AutomaticGenerated");
            if (!Directory.Exists(tmp_ProjectAutoGenerationPath))
                Directory.CreateDirectory(tmp_ProjectAutoGenerationPath);
            // ReSharper disable once InconsistentNaming
            var tmp_ARPropertyJsonFilePath = Path.Combine(tmp_ProjectAutoGenerationPath, "ARProperty.json");
            File.WriteAllText(tmp_ARPropertyJsonFilePath, JsonUtility.ToJson(projectDetailCacheData.Configures));

            // if (!string.IsNullOrEmpty(projectDetailCacheData.Configures.DomainName))
            if (projectDetailCacheData.Configures.ProgrammableType == ProgrammableType.CSharp)
            {
                var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                    new DirectoryInfo(projectDetailCacheData.GetProjectPath()).Name);

                string tmp_DllAssetPath =
                    Utility.CopyFileToProject($"{tmp_SourceFilePath}.runtime.dll", tmp_ProjectAutoGenerationPath,
                        "bytes");
                string tmp_PdbAssetPath = Utility.CopyFileToProject($"{tmp_SourceFilePath}.runtime.pdb",
                    tmp_ProjectAutoGenerationPath, "bytes");

                //Not allowed to be empty
                if (string.IsNullOrEmpty(tmp_DllAssetPath) || string.IsNullOrEmpty(tmp_PdbAssetPath))
                    return;

                var tmp_RenameDllFileToLower = Path.GetFileName(tmp_DllAssetPath).Replace(".bytes", "").ToLower();
                var tmp_RenamePdbFileToLower = Path.GetFileName(tmp_PdbAssetPath).Replace(".bytes", "").ToLower();
                tmp_AddressableName.Add(tmp_RenameDllFileToLower);
                tmp_AddressableName.Add(tmp_RenamePdbFileToLower);
                tmp_BundlePath.Add(tmp_DllAssetPath);
                tmp_BundlePath.Add(tmp_PdbAssetPath);
            }

            tmp_AddressableName.Add(Path.GetFileNameWithoutExtension(tmp_ARPropertyJsonFilePath));
            tmp_BundlePath.Add(Utility.ShortenPath(tmp_ARPropertyJsonFilePath));


            foreach (var tmp_ContentData in projectDetailCacheData.Contents)
            {
                if (string.IsNullOrEmpty(tmp_ContentData.AssetPathInUnity)) continue;
                if (string.IsNullOrEmpty(tmp_ContentData.DisplayName)) continue;

                tmp_AddressableName.Add(Path.GetFileName(tmp_ContentData.DisplayName));
                tmp_BundlePath.Add(tmp_ContentData.AssetPathInUnity);
            }

            var tmp_SavedBundlePath = Path.Combine(Application.dataPath.Replace("Assets", "ServerData"),
                projectDetailCacheData.BuildSettingData.BuildTarget.ToString().ToLower());
            tmp_SavedBundlePath = Path.Combine(tmp_SavedBundlePath, projectModel.DisplayName.ToLower());

            if (!Directory.Exists(tmp_SavedBundlePath))
                Directory.CreateDirectory(tmp_SavedBundlePath);

            BuildCompression tmp_BuildCompression = BuildCompression.LZ4;
            switch (projectDetailCacheData.BuildSettingData.BuildCompression)
            {
                case BuildCompressionType.Uncompressed:
                    tmp_BuildCompression = BuildCompression.Uncompressed;
                    break;
                case BuildCompressionType.LZ4:
                    tmp_BuildCompression = BuildCompression.LZ4;
                    break;
                case BuildCompressionType.LZMA:
                    tmp_BuildCompression = BuildCompression.LZMA;
                    break;
                case BuildCompressionType.UncompressedRuntime:
                    tmp_BuildCompression = BuildCompression.UncompressedRuntime;
                    break;
                case BuildCompressionType.LZ4Runtime:
                    tmp_BuildCompression = BuildCompression.LZ4Runtime;
                    break;
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            var tmp_StateCode = BundlePacker.ScriptableBuildPipeline(projectModel.DisplayName.ToLower(),
                tmp_AddressableName,
                tmp_BundlePath,
                projectDetailCacheData.BuildSettingData.BuildTarget,
                projectDetailCacheData.BuildSettingData.BuildTargetGroup,
                tmp_BuildCompression,
                tmp_SavedBundlePath
            );

            if (tmp_StateCode == ReturnCode.UnsavedChanges)
            {
                EditorUtility.DisplayDialog("ERROR", "Your Scene was changed,But you not saved changes", "OK");
            }

            AssetDatabase.Refresh();
            GUIUtility.ExitGUI();
        }
    }
}