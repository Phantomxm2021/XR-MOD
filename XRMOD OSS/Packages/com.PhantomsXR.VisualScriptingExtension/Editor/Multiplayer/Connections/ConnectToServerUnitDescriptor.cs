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
    [Descriptor(typeof(ConnectToServer))]
    public class ConnectToServerUnitDescriptor:ARMODBaseUnitDescriptor
    {
        public ConnectToServerUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }
        
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/connect.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/connect.png"));
        }
        
        protected override string DefinedSummary()
        {
            return "Connect to a server.";
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "PrefabName":
                    _description.summary = "The name of a game object was register in the spawning system.";
                    break;
                case "NetworkConnection":
                    _description.summary = "Base NetworkConnection class for server-to-client and client-to-server connection.";
                    break;
            }
        }
    }
}