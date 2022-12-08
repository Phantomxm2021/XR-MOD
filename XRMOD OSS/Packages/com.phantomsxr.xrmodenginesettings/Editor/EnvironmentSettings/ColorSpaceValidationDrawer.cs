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
using UnityEngine;

namespace XRMODEngineSettings.Editor
{
    public class ColorSpaceValidationDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP = "There is an error in colorspace, please fix it.";

        public override void Draw()
        {
            DrawUtility.DrawSettingState("Color Space", PLATFORM_HELP, CheckColorSpaceType(),
                CheckedTexture,
                ErrorTexture,
                FixColorSpace);
        }

        private void FixColorSpace()
        {
            PlayerSettings.colorSpace = ColorSpace.Linear;
        }

        private bool CheckColorSpaceType()
        {
            return PlayerSettings.colorSpace == ColorSpace.Linear;
        }
    }
}