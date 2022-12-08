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
    [Descriptor(typeof(CreateARMODAPI))]
    public class ARMODAPIDescriptor : ARMODBaseWithResultUnitDescriptor
    {
        protected override string DefinedSummary()
        {
            return "AR-MOD API is an indispensable code script interface in the AR-MOD framework." +
                   "It allows us to write complex scripts to produce our AR creative interactive content.The content developed by this API";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/document_shapes.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/document_shapes.png"));
        }
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "ProjectName":
                    _description.summary = "Current AR Experience project name";
                    break;
                case "API":
                    _description.summary = "AR-MOD API instance";
                    break;
            }
        }

        public ARMODAPIDescriptor(CreateARMODAPI target) : base(target)
        {
        }
    }
}