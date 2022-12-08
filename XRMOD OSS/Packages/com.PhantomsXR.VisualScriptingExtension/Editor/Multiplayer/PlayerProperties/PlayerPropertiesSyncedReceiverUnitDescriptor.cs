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
    // [Descriptor(typeof(PlayerPropertiesSyncedReceiverUnit))]
    // public class PlayerPropertiesSyncedReceiverUnitDescriptor : UnitDescriptor<PlayerPropertiesSyncedReceiverUnit>
    // {
    //     public PlayerPropertiesSyncedReceiverUnitDescriptor(PlayerPropertiesSyncedReceiverUnit _target) : base(_target)
    //     {
    //     }
    //
    //     protected override string DefinedSummary()
    //     {
    //         return "Receiver the player properties synced event.";
    //     }
    //     
    //
    //
    //     protected override EditorTexture DefaultIcon()
    //     {
    //        
    //         return EditorTexture.Single(
    //             AssetDatabase.LoadAssetAtPath<Texture>(
    //                 "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ear_listen.png"));
    //     }
    //
    //     protected override EditorTexture DefinedIcon()
    //     {
    //         return EditorTexture.Single(
    //             AssetDatabase.LoadAssetAtPath<Texture>(
    //                 "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ear_listen.png"));
    //     }
    //
    //     protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
    //     {
    //         base.DefinedPort(_port, _description);
    //
    //         switch (_port.key)
    //         {
    //             case "Name":
    //                 _description.summary = "Synced Name";
    //                 break;
    //             case "Level":
    //                 _description.summary = "Synced Level";
    //                 break;
    //             case "Health":
    //                 _description.summary = "Synced Health";
    //                 break;
    //             case "CustomProperties":
    //                 _description.summary = "Synced CustomProperties";
    //                 break;
    //             case "Target":
    //                 _description.summary = "Where is the NetworkPropertiesSync component";
    //                 break;
    //             case "EventTarget":
    //                 _description.summary =
    //                     "Where is the [Client Attribute] event responder(Custom Event Node in bolt) in the graph.";
    //                 break;
    //             case "Properties":
    //                 _description.summary = "The component of store the Player information.";
    //                 break;
    //             case "CalculationType":
    //                 _description.summary = "Increase or decrease";
    //                 break;
    //         }
    //     }
    // }
}