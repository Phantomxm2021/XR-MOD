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
    [Descriptor(typeof(VSFocusResultData))]
    public class FocusResultDataDescriptor : UnitDescriptor<VSFocusResultData>
    {
        public FocusResultDataDescriptor(VSFocusResultData _target) : base(_target)
        {
           
        }

        protected override string DefinedSummary()
        {
            return "Receive AR-MOD SDK data when found and focus on a plane.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/database_red.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/database_red.png"));
        }
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);
            
            switch (_port.key)
            {
                case "Data":
                    _description.summary = "Receive AR-MOD SDK data when focus on a plane.";
                    break;
                case "Result":
                    _description.summary = "Focus on a plane data.";
                    break;
            }
        }
    }
#endif
}