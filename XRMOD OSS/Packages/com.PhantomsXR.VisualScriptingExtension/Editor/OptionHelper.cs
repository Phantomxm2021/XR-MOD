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
using System.IO;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using NUnit.Framework;
using TMPro;
//using Unity.Barracuda;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    public static class OptionHelper
    {
        private const string CONST_VSE_RUNTIME = "com.PhantomsXR.VisualScriptingExtension.Runtime";
        private const string CONST_API_RUNTIME = "com.Phantoms.ARMODAPI.Runtime";
        private const string CONST_MIRROR_RUNTIME = "Mirror";
        private const string CONST_ACTION_NOTIFICATION_RUNTIME = "com.Phantoms.ActionNotification.Runtime";

        private const string CONST_MIRROR_EXTENSTION_RUNTIME = "com.PhantomsXR.MirrorExtension.Runtime";

        private const string CONST_VISUAL_SCRIPTING_PATH = "Library/PackageCache/com.unity.visualscripting@1.7.7";

        private const string CONST_VISUAL_SCRIPTING_AOTCOMMENTSTUB_PATH =
            "Editor/VisualScripting.Core/Platforms/AotPreBuilder.cs";

        private const string CONST_PACKAGES_FOLDER_PATH = "Packages/com.unity.visualscripting@1.7.7";

        private const string CONST_UNITY_TEXT_MESH_PRO_RUNTIME = "Unity.TextMeshPro";

        private const string CONST_UNITY_BARRACUDA_RUNTIME = "Unity.Barracuda";
        // private const string CONST_OPTOIN_INITIALIZED = "Option Initialization";
        // private static bool Initialized = false;


        [MenuItem("Tools/Visual Scripting/Init AR-MOD")]
        static async void LaunchOptionHelper()
        {
            //TODO:Copy Visual scripting package to Packages folder for editing
            if (!Directory.Exists(CONST_PACKAGES_FOLDER_PATH))
            {
                var tmp_ProjectRoot = Application.dataPath.Replace("Assets", "");
                var tmp_VisualScriptingPath = Path.Combine(tmp_ProjectRoot, CONST_VISUAL_SCRIPTING_PATH);
                var tmp_DestPath = Path.Combine(tmp_ProjectRoot, CONST_PACKAGES_FOLDER_PATH);
                if (!Directory.Exists(tmp_DestPath))
                    Directory.CreateDirectory(tmp_DestPath);

                CopyEntireFolder(tmp_VisualScriptingPath, tmp_DestPath, true);

                //TODO:Replace the AotCommentStub.cs file
                var tmp_AotCommentStubFilePath =
                    Path.Combine(CONST_PACKAGES_FOLDER_PATH, CONST_VISUAL_SCRIPTING_AOTCOMMENTSTUB_PATH);
                String tmp_AotCommentStubFileTxtPath =
                    "Packages/com.PhantomsXR.VisualScriptingExtension/Editor/EditorResources/AotPreBuilder.cs.txt";

                File.Copy(tmp_AotCommentStubFileTxtPath, tmp_AotCommentStubFilePath, true);

                AssetDatabase.RefreshSettings();
                AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
                AssetDatabase.SaveAssets();
            }


            // Initialized = EditorPrefs.GetBool(CONST_OPTOIN_INITIALIZED);
            // if (Initialized) return;
            //Add assemblies
            Assert.IsNotEmpty(BoltCore.Configuration);
            Assert.IsNotEmpty(BoltCore.Configuration.assemblyOptions);
            if (!BoltCore.Configuration.assemblyOptions.Contains(new LooseAssemblyName(CONST_VSE_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_VSE_RUNTIME));
            if (!BoltCore.Configuration.assemblyOptions.Contains(new LooseAssemblyName(CONST_API_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_API_RUNTIME));

            if (!BoltCore.Configuration.assemblyOptions.Contains(new LooseAssemblyName(CONST_MIRROR_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_MIRROR_RUNTIME));

            if (!BoltCore.Configuration.assemblyOptions.Contains(
                new LooseAssemblyName(CONST_MIRROR_EXTENSTION_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_MIRROR_EXTENSTION_RUNTIME));

            if (!BoltCore.Configuration.assemblyOptions.Contains(
                new LooseAssemblyName(CONST_ACTION_NOTIFICATION_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_ACTION_NOTIFICATION_RUNTIME));

            if (!BoltCore.Configuration.assemblyOptions.Contains(
                new LooseAssemblyName(CONST_UNITY_TEXT_MESH_PRO_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_UNITY_TEXT_MESH_PRO_RUNTIME));

            if (!BoltCore.Configuration.assemblyOptions.Contains(new LooseAssemblyName(CONST_UNITY_BARRACUDA_RUNTIME)))
                BoltCore.Configuration.assemblyOptions.Add(new LooseAssemblyName(CONST_UNITY_BARRACUDA_RUNTIME));
            
            //Action notification enum
            if (!BoltCore.Configuration.typeOptions.Contains(typeof(ARAlgorithmOperator)))
                BoltCore.Configuration.typeOptions.Add(typeof(ARAlgorithmOperator));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(AnchorNotificationData.StickTypeEnum)))
                BoltCore.Configuration.typeOptions.Add(typeof(AnchorNotificationData.StickTypeEnum));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TrackableTypeEnum)))
                BoltCore.Configuration.typeOptions.Add(typeof(TrackableTypeEnum));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(ImmersalNotificationData.ImmersalEventTypes)))
                BoltCore.Configuration.typeOptions.Add(typeof(ImmersalNotificationData.ImmersalEventTypes));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(OcclusionDataType)))
                BoltCore.Configuration.typeOptions.Add(typeof(OcclusionDataType));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(ConversionType)))
                BoltCore.Configuration.typeOptions.Add(typeof(ConversionType));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TextureFormat)))
                BoltCore.Configuration.typeOptions.Add(typeof(TextureFormat));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(FindingType)))
                BoltCore.Configuration.typeOptions.Add(typeof(FindingType));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(LocalizerPose)))
                BoltCore.Configuration.typeOptions.Add(typeof(LocalizerPose));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(Pose)))
                BoltCore.Configuration.typeOptions.Add(typeof(Pose));
            if (!BoltCore.Configuration.typeOptions.Contains(typeof(API)))
                BoltCore.Configuration.typeOptions.Add(typeof(API));

            //Action notification data
            if (!BoltCore.Configuration.typeOptions.Contains(typeof(AlgorithmSetterNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(AlgorithmSetterNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(AnchorNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(AnchorNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(ARAlgorithmNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(ARAlgorithmNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(AROcclusionNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(AROcclusionNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(BaseNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(BaseNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(FaceMeshNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(FaceMeshNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(FocusResultNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(FocusResultNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(ImmersalNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(ImmersalNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(MarkerNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(MarkerNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(OpenBuiltInNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(OpenBuiltInNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TryAcquireAppInfoNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(TryAcquireAppInfoNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TryAcquireCurrentFrameNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(TryAcquireCurrentFrameNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(MakeContentAppearAtNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(MakeContentAppearAtNotificationData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(ARRaycastNotificationData)))
                BoltCore.Configuration.typeOptions.Add(typeof(ARRaycastNotificationData));
            //Mirror and mirror extension
            if (!BoltCore.Configuration.typeOptions.Contains(typeof(NetworkConnectionToClient)))
                BoltCore.Configuration.typeOptions.Add(typeof(NetworkConnectionToClient));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(NetworkConnectionToServer)))
                BoltCore.Configuration.typeOptions.Add(typeof(NetworkConnectionToServer));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(NetworkPropertiesSync)))
                BoltCore.Configuration.typeOptions.Add(typeof(NetworkPropertiesSync));


            //TextMeshPro
            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TextMeshProUGUI)))
                BoltCore.Configuration.typeOptions.Add(typeof(TextMeshProUGUI));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TMP_InputField)))
                BoltCore.Configuration.typeOptions.Add(typeof(TMP_InputField));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TMP_Dropdown)))
                BoltCore.Configuration.typeOptions.Add(typeof(TMP_Dropdown));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TMP_Text)))
                BoltCore.Configuration.typeOptions.Add(typeof(TMP_Text));


            //Runtime Tag
            if (!BoltCore.Configuration.typeOptions.Contains(typeof(GameObjectRuntimeTag)))
                BoltCore.Configuration.typeOptions.Add(typeof(GameObjectRuntimeTag));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(TransformData)))
                BoltCore.Configuration.typeOptions.Add(typeof(TransformData));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(IRuntimeTag)))
                BoltCore.Configuration.typeOptions.Add(typeof(IRuntimeTag));

            if (!BoltCore.Configuration.typeOptions.Contains(typeof(RuntimeTagManager)))
                BoltCore.Configuration.typeOptions.Add(typeof(RuntimeTagManager));
            
            //NNE infernece
            // if (!BoltCore.Configuration.typeOptions.Contains(typeof(Model)))
            //     BoltCore.Configuration.typeOptions.Add(typeof(Model));
            //
            // if (!BoltCore.Configuration.typeOptions.Contains(typeof(IWorker)))
            //     BoltCore.Configuration.typeOptions.Add(typeof(IWorker));
            //
            // if (!BoltCore.Configuration.typeOptions.Contains(typeof(Tensor)))
            //     BoltCore.Configuration.typeOptions.Add(typeof(Tensor));
            //
            // if (!BoltCore.Configuration.typeOptions.Contains(typeof(ComputeShader)))
            //     BoltCore.Configuration.typeOptions.Add(typeof(ComputeShader));
            //
            // if (!BoltCore.Configuration.typeOptions.Contains(typeof(WorkerFactory.Type)))
            //     BoltCore.Configuration.typeOptions.Add(typeof(WorkerFactory.Type));
            
            //For VS1.7.6
            BoltCore.Configuration.GetMetadata(nameof(BoltCore.Configuration.assemblyOptions)).Save();
            BoltCore.Configuration.GetMetadata(nameof(BoltCore.Configuration.typeOptions)).Save();
            Codebase.UpdateSettings();
            UnitBase.Rebuild();

            await PackagesLinkXmlExtractor.CreateMergedLinkFromPackages();
            // Initialized = true;
            // EditorPrefs.SetBool(CONST_OPTOIN_INITIALIZED, Initialized);
        }

        //[MenuItem("Tools/Visual Scripting/AOT Build")]
        private static void AOTBuild()
        {
            AotPreBuilder.GenerateFromInternalMenu();
        }

        /// <summary>
        /// Copy entire project assets and scripts to other path
        /// </summary>
        /// <param name="_sourceDirectory"></param>
        /// <param name="_destDirName"></param>
        /// <param name="_copySubDirs"></param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        private static void CopyEntireFolder(string _sourceDirectory, string _destDirName, bool _copySubDirs)
        {
            DirectoryInfo tmp_SourceDir = new DirectoryInfo(_sourceDirectory);

            Debug.Log(tmp_SourceDir.Name);
            
            if (!tmp_SourceDir.Exists)
            {
                throw new DirectoryNotFoundException(
                    $"Source directory does not exist or could not be found");
            }

            DirectoryInfo[] tmp_Directories = tmp_SourceDir.GetDirectories();
            FileInfo[] tmp_FileInfos = tmp_SourceDir.GetFiles();
            foreach (FileInfo tmp_FileInfo in tmp_FileInfos)
            {
                //Ignore meta files
                //if (tmp_FileInfo.Name.EndsWith("meta")) continue;
                string tmp_Path = Path.Combine(_destDirName, tmp_FileInfo.Name);
                try
                {
                    tmp_FileInfo.CopyTo(tmp_Path, true);
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception.ToString());
                }
            }

            if (!_copySubDirs) return;

            foreach (DirectoryInfo tmp_SubDir in tmp_Directories)
            {
                var tmp_Path = Path.Combine(_destDirName, tmp_SubDir.FullName.Substring(_sourceDirectory.Length + 1));

                if (!Directory.Exists(tmp_Path))
                    Directory.CreateDirectory(tmp_Path);


                //Recursion
                CopyEntireFolder(tmp_SubDir.FullName, tmp_Path, true);
            }
        }
    }
}