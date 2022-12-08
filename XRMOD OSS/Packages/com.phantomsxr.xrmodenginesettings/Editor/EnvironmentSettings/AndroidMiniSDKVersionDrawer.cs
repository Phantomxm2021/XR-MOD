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
    public class AndroidMiniSDKVersionDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP =
            "The minimum version of Android is 26, and the current version is below 26.";

        public override void Draw()
        {
#if UNITY_ANDROID
            DrawUtility.DrawSettingState("Minimum SDK Version", PLATFORM_HELP, CheckMinSdkVersion(),
                CheckedTexture,
                ErrorTexture,
                FixMinSdkVersion);
#endif
        }

        private bool CheckMinSdkVersion()
        {
            return PlayerSettings.Android.minSdkVersion == AndroidSdkVersions.AndroidApiLevel26;
        }

        private void FixMinSdkVersion()
        {
            PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel26;
        }
    }
}