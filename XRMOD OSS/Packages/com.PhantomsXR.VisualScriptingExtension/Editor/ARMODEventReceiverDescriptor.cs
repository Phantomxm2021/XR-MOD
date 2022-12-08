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
    [Descriptor(typeof(ARMODSDKEventReceiver))]
    // ReSharper disable once IdentifierTypo
    public class ARMODEventReceiverDescriptor : UnitDescriptor<ARMODSDKEventReceiver>
    {
        // ReSharper disable once IdentifierTypo
        public ARMODEventReceiverDescriptor(ARMODSDKEventReceiver target) : base(target)
        {
            
        }

        protected override string DefinedSummary()
        {
            return "Receive [AR-MOD SDK] AR algorithm event.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ear_listen.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/ear_listen.png"));
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            base.DefinedPort(port, description);

            switch (port.key)
            {
                case "inputTrigger":
                    description.summary =
                        "Trigger the concatenation of the myValueA with the myValueB and return the result string on the Result Port.";
                    break;
                case "outputTrigger":
                    description.summary = "Execute the next action after Event Receiver was created.";
                    break;
                case "EventTarget":
                    description.summary =
                        "Where is the [AR-MOD SDK] event responder(Custom Event Node in bolt) in the graph.";
                    break;
            }
        }
    }
}