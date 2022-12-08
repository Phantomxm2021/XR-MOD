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
    
    [Descriptor(typeof(ARMODGetDeviceInfo))]
    public class ARMODGetDeviceInfoDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        public ARMODGetDeviceInfoDescriptor(ARMODGetDeviceInfo target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Get current device information";
        }

        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "Result":
                    _description.summary = "Device information.";
                    break;
            }
        }
    }
}