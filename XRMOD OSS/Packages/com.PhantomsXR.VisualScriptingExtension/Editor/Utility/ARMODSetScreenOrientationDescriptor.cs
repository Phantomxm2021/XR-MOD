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


namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ARMODSetScreenOrientation))]
    public class ARMODSetScreenOrientationDescriptor: ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        public ARMODSetScreenOrientationDescriptor(ARMODSetScreenOrientation _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Use this to set the device screen orientation.";
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "Orientation":
                    _description.summary = "Describes screen orientation.";
                    break;
            }
        }

    }
}