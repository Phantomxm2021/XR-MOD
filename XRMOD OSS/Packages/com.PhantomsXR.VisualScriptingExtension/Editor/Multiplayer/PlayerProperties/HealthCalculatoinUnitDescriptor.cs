// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.VisualScripting;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(HealthCalculationUnit))]
    public class HealthCalculationUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public HealthCalculationUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Change the Health value.Add health value or subtract the health value";
        }
        
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/health.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/health.png"));
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "Health":
                    _description.summary = "Increase or decrease of Health";
                    break;
                case "Properties":
                    _description.summary = "The component of store the Player information.";
                    break;           
                case "CalculationType":
                    _description.summary = "Increase or decrease";
                    break;
            }
        }
    }
}