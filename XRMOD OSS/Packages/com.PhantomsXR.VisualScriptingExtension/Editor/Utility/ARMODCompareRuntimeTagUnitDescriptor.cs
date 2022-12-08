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
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ARMODCompareRuntimeTagUnit))]
    public class ARMODCompareRuntimeTagUnitDescriptor : ARMODBaseWithResultUnitDescriptor
    {
        public ARMODCompareRuntimeTagUnitDescriptor(ARMODBaseWithResultUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Is this game object tagged with tag ?";
        }

        // protected override EditorTexture DefaultIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/circle-equal.png"));
        // }
        //
        // protected override EditorTexture DefinedIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/circle-equal.png"));
        // }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);
            switch (_port.key)
            {
                case "Result":
                    _description.summary = "If return true the game object was tagged, otherwise.";
                    break;
                case "Tag":
                    _description.summary = "The tag to compare.";
                    break;
                case "Target":
                    _description.summary = "Runtime Tag component on that game object.";
                    break;
            }
        }
    }
}