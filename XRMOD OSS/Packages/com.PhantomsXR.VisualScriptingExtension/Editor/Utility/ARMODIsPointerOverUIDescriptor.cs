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
    [Descriptor(typeof(ARMODIsPointerOverUI))]

    public class ARMODIsPointerOverUIDescriptor:UnitDescriptor<ARMODIsPointerOverUI>
    {
        public ARMODIsPointerOverUIDescriptor(ARMODIsPointerOverUI target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return "To check current click is in a UGUI component or not";
        }

        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/hand_property.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/hand_property.png"));
        }

        
        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            base.DefinedPort(port, description);

            switch (port.key)
            {
                case "inputTrigger":
                    description.summary = "The entry point to invoke the method.";
                    break;
                case "API":
                    description.summary = "The AR-MOD API.";
                    break;
                case "False":
                    description.summary = "Not over in UGUI component.";
                    break;
                case "True":
                    description.summary = "Current click is over in UGUI component.";
                    break;
            }
        }
    }
}