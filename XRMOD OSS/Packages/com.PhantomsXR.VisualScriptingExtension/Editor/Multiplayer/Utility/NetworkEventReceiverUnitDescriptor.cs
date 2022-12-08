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
    [Descriptor(typeof(OnNetworkEventReceiver))]
    public class NetworkEventReceiverUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public NetworkEventReceiverUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }
        
        // protected override EditorTexture DefaultIcon()
        // {
        //    
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ear_listen.png"));
        // }
        //
        // protected override EditorTexture DefinedIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ear_listen.png"));
        // }

        protected override string DefinedSummary()
        {
            return "Receive the network status.";
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "EventTarget":
                    _description.summary =
                        "Where is the [Network Status] event responder(Custom Event Node in bolt) in the graph.";
                    break;
            }
        }
    }
}