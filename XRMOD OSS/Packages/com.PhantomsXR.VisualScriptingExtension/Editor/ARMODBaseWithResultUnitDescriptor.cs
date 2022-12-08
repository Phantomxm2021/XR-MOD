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

    [Descriptor(typeof(ARMODBaseWithResultUnit))]
    public class ARMODBaseWithResultUnitDescriptor: UnitDescriptor<ARMODBaseWithResultUnit>
    {
        public ARMODBaseWithResultUnitDescriptor(ARMODBaseWithResultUnit target) : base(target)
        {
        }
        
        
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "inputTrigger":
                    _description.summary = "The entry point to invoke the method.";
                    break;

                case "outputTrigger":
                    _description.summary = "The action to call once the method has been invoked.";
                    break;
            }
        }

    }
}