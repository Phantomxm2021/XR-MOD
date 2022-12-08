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
#if UNITY_IOS || UNITY_ANDROID

using Unity.VisualScripting;
using com.Phantoms.ARMODAPI.Runtime;


namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR"),UnitTitle("Resize AR World")]
    public class ARMODResizeARWorld : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize] public ValueInput ARWorldScale;

        protected override void Definition()
        {
            base.Definition();
            ARWorldScale = ValueInput<float>(nameof(ARWorldScale));
        }

        public override ControlOutput Execute(Flow _arg)
        {
            _arg.GetValue<API>(Api).ResizeARWorldScale(_arg.GetValue<float>(ARWorldScale));
            return outputTrigger;
        }
    }
}
#endif