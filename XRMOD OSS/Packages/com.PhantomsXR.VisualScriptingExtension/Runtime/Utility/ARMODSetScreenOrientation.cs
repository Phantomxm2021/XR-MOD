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

using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Set Screen Orientation")]
    [TypeIcon(typeof(Screen))]
    public class ARMODSetScreenOrientation : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize] [PortLabel("Orientation")]
        public ValueInput ScreenOrientation;

        protected override void Definition()
        {
            base.Definition();
            ScreenOrientation = ValueInput(nameof(ScreenOrientation), UnityEngine.ScreenOrientation.Portrait);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            _arg.GetValue<API>(Api).SetScreenOrientation(_arg.GetValue<ScreenOrientation>(ScreenOrientation));
            return outputTrigger;
        }
    }
}