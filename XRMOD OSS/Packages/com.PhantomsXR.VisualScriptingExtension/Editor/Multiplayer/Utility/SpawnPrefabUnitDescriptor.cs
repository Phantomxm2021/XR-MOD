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
    [Descriptor(typeof(SpawnPrefabUnit))]
    public class SpawnPrefabUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public SpawnPrefabUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }
        protected override string DefinedSummary()
        {
            return "The server manages spawned game objects alongside all other networked game objects, " +
                   "so that if another client joins the game later, the server can spawn the game objects on that client.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/draw_clone.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/draw_clone.png"));
        }
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "PrefabName":
                    _description.summary = "Which prefab in the spawn register list will be instanced";
                    break;
                case "EventTarget":
                    _description.summary ="Instanced the prefab callback.Event Name:[SpawnPrefabCallback]";
                    break;
            }
        }
    }
}