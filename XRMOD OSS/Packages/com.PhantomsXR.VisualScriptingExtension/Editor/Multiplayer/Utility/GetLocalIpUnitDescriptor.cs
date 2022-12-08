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
    [Descriptor(typeof(GetLocalIPUnit))]
    public class GetLocalIpUnitDescriptor:UnitDescriptor<GetLocalIPUnit>
    {
        public GetLocalIpUnitDescriptor(GetLocalIPUnit _target) : base(_target)
        {
        }
        

        protected override string DefinedSummary()
        {
            return "Get current device IP Address(IPV4).";
        }

        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/network_ip.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/network_ip.png"));
        }
        
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                
                case "inputTrigger":
                    _description.summary = "The entry point to invoke the method.";
                    break;

                case "outputTrigger":
                    _description.summary = "The action to call once the method has been invoked.";
                    break;
                
                case "IPAddress":
                    _description.summary = "The Ipv4 Address.";
                    break;
            }
        }
    }
}