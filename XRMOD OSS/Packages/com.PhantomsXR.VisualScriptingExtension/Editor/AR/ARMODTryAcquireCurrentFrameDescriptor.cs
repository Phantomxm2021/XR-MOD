// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
#if UNITY_IOS || UNITY_ANDROID
    [Descriptor(typeof(ARMODTryAcquireCurrentFrame))]
    // ReSharper disable once IdentifierTypo
    public class ARMODTryAcquireCurrentFrameDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public ARMODTryAcquireCurrentFrameDescriptor(ARMODTryAcquireCurrentFrame target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Get the AR frame texture to AR-Experience.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/picture.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/picture.png"));
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "Data":
                    _description.summary = "Data sent to the AR-MOD to try acquire the texture.";
                    break;

                case "Result":
                    _description.summary = "Frame texture.";

                    break;
            }
        }
    }
#endif
}