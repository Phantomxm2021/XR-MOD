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
    public class ScriptingBackendValidationDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP = "All Application need 64bit";

        public override void Draw()
        {
            DrawUtility.DrawSettingState("Scripting Backend", PLATFORM_HELP, CheckScriptBackend(),
                CheckedTexture,
                ErrorTexture,
                FixScriptBackend);
        }

        private bool CheckScriptBackend()
        {
            return PlayerSettings.GetScriptingBackend(Utility.GetBuildTargetGroup()) == ScriptingImplementation.IL2CPP;
        }

        private void FixScriptBackend()
        {
            PlayerSettings.SetScriptingBackend(Utility.GetBuildTargetGroup(), ScriptingImplementation.IL2CPP);

#if UNITY_ANDROID
            PlayerSettings.SetIl2CppCompilerConfiguration(Utility.GetBuildTargetGroup(),Il2CppCompilerConfiguration.Release);
#elif UNITY_WSA
            PlayerSettings.SetIl2CppCompilerConfiguration(Utility.GetBuildTargetGroup(),Il2CppCompilerConfiguration.Release);
#elif UNITY_WEBGL
            PlayerSettings.SetIl2CppCompilerConfiguration(Utility.GetBuildTargetGroup(),Il2CppCompilerConfiguration.Release);
#else
#endif
        }
    }
}