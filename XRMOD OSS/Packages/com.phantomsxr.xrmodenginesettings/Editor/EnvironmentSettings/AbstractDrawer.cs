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

using System.IO;
using XRMODEngineSettings.Editor;
using UnityEditor;
using UnityEngine;

namespace XRMODEngineSettings.Editor
{
    public abstract class AbstractDrawer : ISettingsDrawer
    {
        public Texture CheckedTexture { get; set; }
        public Texture ErrorTexture { get; set; }
        protected const string CONST_CONST_WORKER_PATH = "Packages/com.phantomsxr.xrmodenginesettings";

        public AbstractDrawer()
        {
            Initializer();
        }

        public virtual void Initializer()
        {
            CheckedTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(Path.Combine(CONST_CONST_WORKER_PATH,
                "Editor/Assets/Textures/checked.png"));
            ErrorTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(Path.Combine(CONST_CONST_WORKER_PATH,
                "Editor/Assets/Textures/error.png"));
        }

        public abstract void Draw();
    }
}