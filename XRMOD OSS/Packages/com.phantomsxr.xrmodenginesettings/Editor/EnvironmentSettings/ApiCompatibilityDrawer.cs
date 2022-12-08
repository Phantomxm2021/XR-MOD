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

using UnityEditor;
using UnityEngine;

namespace XRMODEngineSettings.Editor
{
    public class ApiCompatibilityDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP = "XRMOD Only support .Net4.x";

        public override void Draw()
        {
            DrawUtility.DrawSettingState("Api Compatibility Level", PLATFORM_HELP, CheckApiCompatibilityLevel(),
                CheckedTexture,
                ErrorTexture,
                SwitchApiCompatibilityLevel);
        }

        private bool CheckApiCompatibilityLevel()
        {
            return PlayerSettings.GetApiCompatibilityLevel(GetBuildTargetGroup()) ==
                   ApiCompatibilityLevel.NET_Unity_4_8;
        }

        private void SwitchApiCompatibilityLevel()
        {
            PlayerSettings.SetApiCompatibilityLevel(GetBuildTargetGroup(), ApiCompatibilityLevel.NET_Unity_4_8);
        }

        private BuildTargetGroup GetBuildTargetGroup()
        {
            var tmp_Target = EditorUserBuildSettings.activeBuildTarget;
            return BuildPipeline.GetBuildTargetGroup(tmp_Target);
        }
    }
}