// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEditor.XR.ARKit;
using UnityEditor.XR.Management;
using UnityEditor.XR.Management.Metadata;
using UnityEngine;
using UnityEngine.XR.Management;

namespace XRMODEngineSettings.Editor
{
    public class SimulationDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP = "You have turned on simulation but haven't set up Plug-in yet.";

        public override void Draw()
        {
            if (XRMODEnginePreferences._XRMOD_ENGINE_SETTINGS.Simulation)
                DrawUtility.DrawSettingState("Simulation", PLATFORM_HELP, CheckState(), CheckedTexture, ErrorTexture,
                    ActivePlugin);
        }

        private bool CheckState()
        {
            var tmp_BuiltTargetGroup = BuildPipeline.GetBuildTargetGroup(Utility.GetSimulationTarget());
            string tmp_LoaderTypeName = "UnityEngine.XR.Simulation.SimulationLoader";
            return XRPackageMetadataStore.IsLoaderAssigned(tmp_LoaderTypeName, tmp_BuiltTargetGroup);
        }

        private void ActivePlugin()
        {
            var tmp_BuiltTargetGroup = BuildPipeline.GetBuildTargetGroup(Utility.GetSimulationTarget());
            EditorBuildSettings.TryGetConfigObject(XRGeneralSettings.k_SettingsKey,
                out XRGeneralSettingsPerBuildTarget buildTargetSettings);
            var tmp_Settings = buildTargetSettings.SettingsForBuildTarget(tmp_BuiltTargetGroup);

            string tmp_LoaderTypeName = "UnityEngine.XR.Simulation.SimulationLoader";

            XRPackageMetadataStore.AssignLoader(tmp_Settings.Manager, tmp_LoaderTypeName, tmp_BuiltTargetGroup);
        }
    }
}