// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.XR.ARKit;
using UnityEditor.XR.Management;
using UnityEditor.XR.Management.Metadata;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.Management;

namespace XRMODEngineSettings.Editor
{
    public class XRSystemActiveDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP = "The current platform XR plugin has not been activated";

        public override void Draw()
        {
            DrawUtility.DrawSettingState("XR Plug-in", PLATFORM_HELP, CheckState(), CheckedTexture, ErrorTexture,
                ActivePlugin);
        }

        private bool CheckState()
        {
            var tmp_Target = EditorUserBuildSettings.activeBuildTarget;
            var tmp_BuiltTargetGroup = BuildPipeline.GetBuildTargetGroup(tmp_Target);
            EditorBuildSettings.TryGetConfigObject(XRGeneralSettings.k_SettingsKey,
                out XRGeneralSettingsPerBuildTarget _);

            string tmp_LoaderTypeName = string.Empty;
            switch (tmp_Target)
            {
                case BuildTarget.Android:
                    var tmp_CurPlatform = XRMODEnginePreferences._XRMOD_ENGINE_SETTINGS
                        .GetPlatformSettings(XRMODEnginePreferences.GetToolbarIndex).name;
#if HANDHELD_ARMODULE_INSTALL
                    tmp_LoaderTypeName = "UnityEngine.XR.ARCore.ARCoreLoader";

#elif PICO_INSTALL
                    tmp_LoaderTypeName = "Unity.XR.PXR.PXR_Loader";
#endif
                    break;
                case BuildTarget.iOS:
                    tmp_LoaderTypeName = "UnityEngine.XR.ARKit.ARKitLoader";
                    break;
                case BuildTarget.WSAPlayer:
                    break;
            }

            return XRPackageMetadataStore.IsLoaderAssigned(tmp_LoaderTypeName, tmp_BuiltTargetGroup);
        }

        private void ActivePlugin()
        {
            var tmp_Target = EditorUserBuildSettings.activeBuildTarget;
            var tmp_BuiltTargetGroup = BuildPipeline.GetBuildTargetGroup(tmp_Target);
            var tmp_XRGeneralSettings = ScriptableObject.CreateInstance<XRGeneralSettingsPerBuildTarget>();
            AssetDatabase.CreateAsset(tmp_XRGeneralSettings, "Assets/XR/XRGeneralSettings.asset");
            tmp_XRGeneralSettings.CreateDefaultManagerSettingsForBuildTarget(tmp_BuiltTargetGroup);
            AssetDatabase.Refresh();

            if (tmp_XRGeneralSettings.HasSettingsForBuildTarget(tmp_BuiltTargetGroup))
            {
                var tmp_Settings =
                    XRGeneralSettingsPerBuildTarget.XRGeneralSettingsForBuildTarget(tmp_BuiltTargetGroup);

                Assert.IsNotNull(tmp_Settings);
                string tmp_LoaderTypeName = string.Empty;
                switch (tmp_Target)
                {
                    case BuildTarget.Android:
#if HANDHELD_ARMODULE_INSTALL
                        tmp_LoaderTypeName = "Unity.XR.ARCore.ARCoreLoader";
#elif PICO_INSTALL
                        tmp_LoaderTypeName = "Unity.XR.PXR.PXR_Loader";
#endif
                        break;
                    case BuildTarget.iOS:
                        tmp_LoaderTypeName = "Unity.XR.ARKit.ARKitLoader";
                        ARKitSettings.currentSettings.faceTracking = true;
                        break;
                    case BuildTarget.WSAPlayer:
                        break;
                }

                XRPackageMetadataStore.AssignLoader(tmp_Settings.Manager, tmp_LoaderTypeName,
                    tmp_BuiltTargetGroup);

                AssetDatabase.Refresh();
                AssetDatabase.RefreshSettings();
            }
            else
            {
                EditorUtility.DisplayDialog("Error",
                    "Current platform has not been support, switch other platform plz.", "Ok");
            }
        }
    }
}