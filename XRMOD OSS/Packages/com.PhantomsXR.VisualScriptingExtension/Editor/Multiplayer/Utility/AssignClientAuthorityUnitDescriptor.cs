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
using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(AssignClientAuthorityUnit))]
    public class AssignClientAuthorityUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public AssignClientAuthorityUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }

        protected override string DefaultSummary()
        {
            return "This can be done by calling AssignClientAuthority on the object you want to give authority to.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/authority.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/authority.png"));
        }


        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);
            switch (_port.key)
            {
                case "AssignObject":
                    _description.summary = "Network props that need to be reassigned.";
                    break;
                case "Connection":
                    _description.summary = "Authorized user.";
                    break;
            }
        }
    }
}