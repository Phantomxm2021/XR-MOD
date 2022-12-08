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
using com.PhantomsXR.VisualScriptingExtension.Runtime.Editor;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ARMODOpenBuiltInBrowser))]
    public class ARMODOpenBuiltInBrowserDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        public ARMODOpenBuiltInBrowserDescriptor(ARMODOpenBuiltInBrowser target) : base(target)
        {
        }

        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/safari_browser.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/safari_browser.png"));
        }
        
        protected override string DefinedSummary()
        {
            return "Open the url by APP's built-in browser ";
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "URL":
                    _description.summary = "URL to be opened.";
                    break;
                
                case "Data":
                    _description.summary = "Addition data.";
                    break;
            }
        }
    }
}