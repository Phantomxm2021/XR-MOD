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
    [Descriptor(typeof(ARMODPlayerprefs))]
    public class ARMODPlayerprefsDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        public ARMODPlayerprefsDescriptor(ARMODPlayerprefs target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return
                "`PlayerPrefs` is a class that stores Player preferences between game sessions. " +
                "It can store string values into the user’s platform registry.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/database_cleanup.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/database_cleanup.png"));
        }
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "Key":
                    _description.summary = "Sets a single string value for the preference identified by the given key.";
                    break;
                case "Value":
                    _description.summary = "Stores data of string ";
                    break;
                case "OperationType":
                    _description.summary = "Read or write.";
                    break;
                case "Result":
                    _description.summary = "Result the value when OperationType is Read.";
                    break;
            }
        }
    }
}