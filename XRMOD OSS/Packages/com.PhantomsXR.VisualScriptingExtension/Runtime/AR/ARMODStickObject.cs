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
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;


namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR"), UnitTitle("Stick Object")]
    public class ARMODStickObject : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize][PortLabel("Data")] public ValueInput AnchorNotificationData;

        protected override void Definition()
        {
            base.Definition();
            AnchorNotificationData =
                ValueInput<AnchorNotificationData>(nameof(AnchorNotificationData), null);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            _arg.GetValue<API>(Api)
                .StickObject(
                    _arg.GetValue<AnchorNotificationData>(
                        AnchorNotificationData));
            return outputTrigger;
        }
    }
}
#endif