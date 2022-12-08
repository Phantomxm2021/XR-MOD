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

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    //[Descriptor(typeof(ARMODSetFocusAlgorithmState))]
    public class ARMODSetFocusAlgorithmStateUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public ARMODSetFocusAlgorithmStateUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Turn on and off the Focus algorithm.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(EditorGUIUtility.IconContent("Preset Icon").image);
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(EditorGUIUtility.IconContent("Preset Icon").image);
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "Data":
                    _description.summary = "Data sent to the anchor manager.";
                    break;
            }
        }
    }
}