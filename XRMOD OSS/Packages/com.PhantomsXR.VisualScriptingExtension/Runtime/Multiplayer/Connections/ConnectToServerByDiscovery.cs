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

using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Connections"), UnitTitle("ConnectByDiscovery")]
    public class ConnectToServerByDiscovery: ARMODBaseUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            XRMODServices.GetBridge().ConnectToServerByDiscovery();
            return outputTrigger;
        }
    }
}