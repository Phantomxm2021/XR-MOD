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
    [Descriptor(typeof(ARMODLoadAsset))]
    public class ARMODLoadAssetDescriptor : UnitDescriptor<ARMODLoadAsset>
    {
        public ARMODLoadAssetDescriptor(ARMODLoadAsset target) : base(target)
        {
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ocr_language_support.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ocr_language_support.png"));
        }

        protected override string DefinedSummary()
        {
            return "Load the Asset(GameObject,Texture,Material,VideoClip, etc) from the ARExperience bundle.";
        }

        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            base.DefinedPort(port, description);

            switch (port.key)
            {
                case "inputTrigger":
                    description.summary = "The entry point to invoke the method.";
                    break;
                case "outputTrigger":
                    description.summary = "The action to call once the method has been invoked.";
                    break;
                case "Name":
                    description.summary = "Want to load object's name.";
                    break;
                case "API":
                    description.summary = "The AR-MOD API instance.";
                    break;
                case "LoadType":
                    description.summary = "Asset types.";
                    break;
                case "Result":
                    description.summary = "Loaded Asset.";
                    break;
            }
        }
    }
}