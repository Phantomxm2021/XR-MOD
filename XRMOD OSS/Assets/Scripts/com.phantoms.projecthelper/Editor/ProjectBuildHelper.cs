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
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.Build.Reporting;
#if UNITY_IOS
using UnityEditor.iOS.Xcode;
#endif
using UnityEngine;

namespace com.Phantoms.ProjectHelper.Editor
{
    public class ProjectBuildHelper
    {
        public static Action BUILD_COMPLETED;

        // [MenuItem("Tools/AR-MOD/Helper/Export Android Library")]
        public static void BuildAndroid()
        {
#if UNITY_ANDROID
            var tmp_BuildPath = GetBuildPath();
            if (string.IsNullOrEmpty(tmp_BuildPath)) return;

            EditorUserBuildSettings.androidBuildSystem = AndroidBuildSystem.Gradle;
            EditorUserBuildSettings.androidBuildType = AndroidBuildType.Release;
            var tmp_Options = BuildOptions.SymlinkSources | BuildOptions.AcceptExternalModificationsToPlayer;
            var tmp_Report =
                BuildPipeline.BuildPlayer(GetEnabledScenes(), tmp_BuildPath, BuildTarget.Android, tmp_Options);

            if (tmp_Report.summary.result == BuildResult.Succeeded)
                EditorUtility.RevealInFinder(tmp_BuildPath);
            else
                throw new Exception("Build Failed");

            // Modify build.gradle
            var tmp_UnityLibraryBuildFile = Path.Combine(tmp_BuildPath, "unityLibrary/build.gradle");
            var tmp_UnityLibraryBuildText = File.ReadAllText(tmp_UnityLibraryBuildFile);
            tmp_UnityLibraryBuildText =
                tmp_UnityLibraryBuildText.Replace("com.android.application", "com.android.library");
            tmp_UnityLibraryBuildText =
                tmp_UnityLibraryBuildText.Replace("buildToolsVersion '31.0.0'", "buildToolsVersion '29.0.0'");
            File.WriteAllText(tmp_UnityLibraryBuildFile, tmp_UnityLibraryBuildText);


            //Modify AndroidManifest.xml
            var tmp_ManifestFile = Path.Combine(tmp_BuildPath, "unityLibrary/src/main/AndroidManifest.xml");
            var tmp_ManifestText = File.ReadAllText(tmp_ManifestFile);
            tmp_ManifestText = Regex.Replace(tmp_ManifestText, @"<application .*>", "<application>");
            Regex tmp_Regex = new Regex(@"<activity.*>(\s|\S)+?</activity>", RegexOptions.Multiline);
            tmp_ManifestText = tmp_Regex.Replace(tmp_ManifestText, "");
            File.WriteAllText(tmp_ManifestFile, tmp_ManifestText);


            //Modify proguard-unity.txt
            var tmp_ProguardUnityFile = Path.Combine(tmp_BuildPath, "unityLibrary/proguard-unity.txt");
            var tmp_ProguardUnityText = File.ReadAllText(tmp_ProguardUnityFile);
            var tmp_LastIdx = tmp_ProguardUnityText.IndexOf("-ignorewarnings", StringComparison.Ordinal);
            var tmp_PhantomsXRLib = "-keep class com.phantomsxr.armodplugin.* { *; }";
            var tmp_Unity3dplugin = "\n-keep class com.unity3d.plugin.* { *; }";
            var tmp_ImmersalNativebindings = "\n-keep class com.immersal.nativebindings.* { *; }";
            var tmp_NativeGallery = "\n-keep class com.yasirkula.unity.* { *; }\n";
            tmp_ProguardUnityText = tmp_ProguardUnityText.Insert(tmp_LastIdx, tmp_PhantomsXRLib);
            
            tmp_ProguardUnityText =
                tmp_ProguardUnityText.Insert(tmp_LastIdx + tmp_PhantomsXRLib.Length, tmp_Unity3dplugin);
            
            tmp_ProguardUnityText = tmp_ProguardUnityText.Insert(
                tmp_LastIdx + tmp_PhantomsXRLib.Length + tmp_Unity3dplugin.Length, tmp_ImmersalNativebindings);
            
            tmp_ProguardUnityText = tmp_ProguardUnityText.Insert(
                tmp_LastIdx + tmp_PhantomsXRLib.Length + tmp_Unity3dplugin.Length+tmp_ImmersalNativebindings.Length, "tmp_NativeGallery");
            Debug.Log(tmp_ProguardUnityText);
            File.WriteAllText(tmp_ProguardUnityFile, tmp_ProguardUnityText);
            BUILD_COMPLETED?.Invoke();
#endif
        }

        // [MenuItem("Tools/AR-MOD/Helper/Export iOS Library")]
        public static void BuildIOS()
        {
#if UNITY_IOS
            var tmp_BuildPath = GetBuildPath();
            if (string.IsNullOrEmpty(tmp_BuildPath)) return;
#if UNITY_2021_1_OR_NEWER
            EditorUserBuildSettings.iOSXcodeBuildConfig = XcodeBuildConfig.Release;
            var options = BuildOptions.SymlinkSources;
#else
            EditorUserBuildSettings.iOSBuildConfigType = iOSBuildType.Release;
            var options = BuildOptions.SymlinkLibraries;
#endif
            var tmp_Report = BuildPipeline.BuildPlayer(
                GetEnabledScenes(),
                tmp_BuildPath,
                BuildTarget.iOS,
                options
            );

            if (tmp_Report.summary.result == BuildResult.Succeeded)
                EditorUtility.RevealInFinder(tmp_BuildPath);
            else
                throw new Exception($"Build failed.{tmp_Report.summary}");

            var tmp_NativeCallProxyHeadFile = "Libraries/Scripts/com.Phantoms.NativePlugins/iOS/NativeCallProxy.h";

            //Read pbx project
            var tmp_PBXProjectFilePath = tmp_BuildPath + "/Unity-iPhone.xcodeproj/project.pbxproj";
            PBXProject tmp_PBXProject = new PBXProject();
            tmp_PBXProject.ReadFromFile(tmp_PBXProjectFilePath);
            var tmp_UnityiPhoneTarget = tmp_PBXProject.TargetGuidByName("Unity-iPhone");
            tmp_PBXProject.SetBuildProperty(tmp_UnityiPhoneTarget, "ENABLE_BITCODE", "NO");

            var tmp_DataGuid = tmp_PBXProject.FindFileGuidByProjectPath("Data");
            var tmp_NativeCallProxyGuid = tmp_PBXProject.FindFileGuidByProjectPath(tmp_NativeCallProxyHeadFile);
            var tmp_FrameworkTarget = tmp_PBXProject.GetUnityFrameworkTargetGuid();

            tmp_PBXProject.AddFileToBuild(tmp_FrameworkTarget, tmp_DataGuid);

            //Modify NativeCallProxy.h to public
            tmp_PBXProject.AddPublicHeaderToBuild(tmp_FrameworkTarget, tmp_NativeCallProxyGuid);

            //Modify SplashScreen.mm to adapt to AR-MOD SDK
            string tmp_TemplateOriginalFile = Path.Combine(Application.dataPath,
                $"Scripts/com.Phantoms.ProjectHelper/Editor/SplashScreen.mm");
            tmp_PBXProject.ReplaceFile(tmp_PBXProject.FindFileGuidByProjectPath("Classes/UI/SplashScreen.mm"),
                tmp_TemplateOriginalFile);

            //Reduce framework package size
            tmp_PBXProject.SetBuildProperty(tmp_FrameworkTarget, "GCC_GENERATE_DEBUGGING_SYMBOLS", "NO");
            tmp_PBXProject.SetBuildProperty(tmp_FrameworkTarget, "ENABLE_BITCODE", "NO");
            // tmp_PBXProject.SetBuildProperty(tmp_FrameworkTarget,"Enable C++ Exceptions","No");
            // tmp_PBXProject.SetBuildProperty(tmp_FrameworkTarget,"Enable Objective-C Exceptions","No");

            //Apply all settings
            File.WriteAllText(tmp_PBXProjectFilePath, tmp_PBXProject.WriteToString());


            //Modify Xcode scheme
            string tmp_SchemePath =
                tmp_BuildPath + "/Unity-iPhone.xcodeproj/xcshareddata/xcschemes/Unity-iPhone.xcscheme";
            var tmp_Xcscheme = new XcScheme();
            tmp_Xcscheme.ReadFromFile(tmp_SchemePath);
            tmp_Xcscheme.SetMetalValidationOnRun(XcScheme.MetalValidation.Extended);
            tmp_Xcscheme.SetFrameCaptureModeOnRun(XcScheme.FrameCaptureMode.Metal);
            tmp_Xcscheme.SetBuildConfiguration("Release");
            tmp_Xcscheme.WriteToFile(tmp_SchemePath);
            BUILD_COMPLETED?.Invoke();
#endif
        }


        private static string GetBuildPath()
        {
            var tmp_Path = EditorUtility.SaveFolderPanel("Build AR-MOD SDK", "", "");
            return string.IsNullOrEmpty(tmp_Path) ? null : tmp_Path;
        }

        private static string[] GetEnabledScenes()
        {
            var tmp_Scenes = EditorBuildSettings.scenes
                .Where(_s => _s.enabled)
                .Select(_s => _s.path)
                .ToArray();

            return tmp_Scenes;
        }
    }
}