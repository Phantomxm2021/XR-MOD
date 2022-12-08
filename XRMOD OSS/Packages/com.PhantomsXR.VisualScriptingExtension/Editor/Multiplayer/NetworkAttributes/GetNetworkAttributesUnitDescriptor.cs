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
    [Descriptor(typeof(GetNetworkAttributesUnit))]
    public class GetNetworkAttributesUnitDescriptor: ARMODBaseWithResultUnitDescriptor
    {
        public GetNetworkAttributesUnitDescriptor(GetNetworkAttributesUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Get the NetworkAttributes from the target object.";
        }

        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/script_bricks.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/script_bricks.png"));
        }
        
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "Target":
                    _description.summary = "Which game object has the NetworkAttributes component.";
                    break;
                case "Result":
                    _description.summary = "The NetworkAttributes component.";
                    break;
            }
        }
    }
}