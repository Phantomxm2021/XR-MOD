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

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ARMODBaseUnit))]
    public class ARMODBaseUnitDescriptor : UnitDescriptor<ARMODBaseUnit>
    {
        public ARMODBaseUnitDescriptor(ARMODBaseUnit target) : base(target)
        {
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
            }
        }
    }
}