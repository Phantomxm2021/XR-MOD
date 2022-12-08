// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ProjectHelper.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;

namespace com.Phantoms.ProjectHelper.Editor
{
    public class BuildSettingsScriptableObject : ScriptableObject
    {
        public string ExportPath;
        public XRMODEngineSettings.Editor.XRMODEngineSettings XrmodEngineSettings;
        public string License;
        public void OnValidate()
        {
            if (XrmodEngineSettings == null)
                XrmodEngineSettings =
                    AssetDatabase.LoadAssetAtPath<XRMODEngineSettings.Editor.XRMODEngineSettings>("Assets/XR/XRMODEngineSettings.asset");
        }
    }
}