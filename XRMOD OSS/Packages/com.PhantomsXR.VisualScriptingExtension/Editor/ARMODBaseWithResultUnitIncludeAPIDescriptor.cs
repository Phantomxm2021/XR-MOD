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

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ARMODBaseWithResultUnitIncludeApi))]
    public class ARMODBaseWithResultUnitIncludeAPIDescriptor: ARMODBaseWithResultUnitDescriptor
    {
        public ARMODBaseWithResultUnitIncludeAPIDescriptor(ARMODBaseWithResultUnitIncludeApi _target) : base(_target)
        {
        }
        
        
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "API":
                    _description.summary = "The AR-MOD API instance.";
                    break;
            }
        }

    }
}