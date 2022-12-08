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
using UnityEngine.Rendering;

namespace XRMODEngineSettings.Editor
{
    public class AndroidGraphicsDrawer : AbstractDrawer
    {
        private const string PLATFORM_HELP = "XRMOD only support OpenGL, No support for Vulkan";

        public override void Draw()
        {
#if UNITY_ANDROID
            DrawUtility.DrawSettingState("Graphics APIs", PLATFORM_HELP, CheckGraphicsType(),
                CheckedTexture,
                ErrorTexture,
                FixGraphics);
#endif
        }

        private void FixGraphics()
        {
            PlayerSettings.SetUseDefaultGraphicsAPIs(Utility.GetBuildTarget(), false);
            PlayerSettings.SetGraphicsAPIs(Utility.GetBuildTarget(), new GraphicsDeviceType[1]
            {
                GraphicsDeviceType.OpenGLES3
            });
        }

        private bool CheckGraphicsType()
        {
            var tmp_Graphics = PlayerSettings.GetGraphicsAPIs(Utility.GetBuildTarget());
            foreach (GraphicsDeviceType tmp_GraphicType in tmp_Graphics)
            {
                if (tmp_GraphicType == GraphicsDeviceType.Vulkan)
                    return false;
            }

            return true;
        }
    }
}