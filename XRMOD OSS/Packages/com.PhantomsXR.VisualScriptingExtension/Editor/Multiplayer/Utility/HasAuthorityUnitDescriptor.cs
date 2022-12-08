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
    [Descriptor(typeof(HasAuthorityUnit))]
    public class HasAuthorityUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public HasAuthorityUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }

        protected override string DefaultSummary()
        {
            return "Check current game object has authority in this side.NetworkIdentity required";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/email_authentication.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/email_authentication.png"));
        }


        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);
            switch (_port.key)
            {
                case "Target":
                    _description.summary = "Where is the [NetworkIdentity] component in the game object.";
                    break;
                case "Result":
                    _description.summary =
                        "If return [True] current client has the authority of this game object. Otherwise";
                    break;
            }
        }
    }
}