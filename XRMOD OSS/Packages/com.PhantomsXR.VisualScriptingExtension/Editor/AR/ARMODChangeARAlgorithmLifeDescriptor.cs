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
    [Descriptor(typeof(ARMODChangeARAlgorithmLife))]
    // ReSharper disable once IdentifierTypo
    public class ARMODChangeARAlgorithmLifeDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public ARMODChangeARAlgorithmLifeDescriptor(ARMODChangeARAlgorithmLife _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Set the AR algorithm state.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/cursor_lifebuoy.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/cursor_lifebuoy.png"));
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "Data":
                    _description.summary = "Data sent to the AR-MOD to set AR algorithm state.";
                    break;
            }
        }
    }
#endif
}