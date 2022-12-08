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

namespace XRMODEngineSettings.Editor
{
    public class InputSystemDrawer : AbstractDrawer
    {
        private const string _CONST_INPUT_SYSTEM_ERROR =
            "You need set Active Input Handling to Both. Project Setting->Player->Others Settings->Active Input Handling";

        public override void Draw()
        {
            DrawUtility.DrawSettingState("InputSystem", _CONST_INPUT_SYSTEM_ERROR, CheckInputSystem(),
                CheckedTexture,
                ErrorTexture,FixInputSystem);
        }

        private void FixInputSystem()
        {
            EditorUtility.DisplayDialog("Tips", _CONST_INPUT_SYSTEM_ERROR, "OK");
        }

        private bool CheckInputSystem()
        {
#if ENABLE_INPUT_SYSTEM && ENABLE_LEGACY_INPUT_MANAGER
            return true;
#else
            return false;
#endif
        }
    }
}