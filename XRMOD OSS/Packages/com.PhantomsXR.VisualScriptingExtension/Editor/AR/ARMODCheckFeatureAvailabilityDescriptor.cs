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
    [Descriptor(typeof(ARMODCheckFeatureAvailability))]
    // ReSharper disable once IdentifierTypo
    public class ARMODCheckFeatureAvailabilityDescriptor : UnitDescriptor<ARMODCheckFeatureAvailability>
    {
        // ReSharper disable once IdentifierTypo
        public ARMODCheckFeatureAvailabilityDescriptor(ARMODCheckFeatureAvailability _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Check AR features are support on current device.";
        }
        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/check_box_list.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/check_box_list.png"));
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            base.DefinedPort(port, description);

            switch (port.key)
            {
                case "inputTrigger":
                    description.summary = "The entry point to invoke the method.";
                    break;

                case "True":
                    description.summary = "Current device is support this feature.";
                    break;
                case "API":
                    description.summary = "The AR-MOD API instance.";
                    break;
                case "False":
                    description.summary = "Current device is not support this feature.";
                    break;

                case "FeatureName":
                    description.summary = "Witch AR feature name.";
                    break;
            }
        }
    }
}