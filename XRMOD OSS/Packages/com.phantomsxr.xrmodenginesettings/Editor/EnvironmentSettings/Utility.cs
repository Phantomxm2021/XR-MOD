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

using UnityEditor;

namespace XRMODEngineSettings.Editor
{
    public static class Utility
    {
        public static BuildTargetGroup GetBuildTargetGroup()
        {
            var tmp_Target = EditorUserBuildSettings.activeBuildTarget;
            return BuildPipeline.GetBuildTargetGroup(tmp_Target);
        }

        public static BuildTarget GetBuildTarget() => EditorUserBuildSettings.activeBuildTarget;

        public static BuildTarget GetSimulationTarget()
        {
#if UNITY_EDITOR_OSX
            return BuildTarget.StandaloneOSX;
#else
            return BuildTarget.StandaloneWindows;
#endif
        }
    }
}