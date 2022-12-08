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

using UnityEngine;


namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR/Data")]
    [UnitTitle("Current Frame")]
    [TypeIcon(typeof(CanvasRenderer))]
    public class ARMODTryAcquireCurrentFrame : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize][PortLabel("Data")] public ValueInput TryAcquireCurrentFrameNotificationData;
        private Texture frame;

        protected override void Definition()
        {
            base.Definition();
            TryAcquireCurrentFrameNotificationData =
                ValueInput<TryAcquireCurrentFrameNotificationData>(nameof(TryAcquireCurrentFrameNotificationData), null);
            Result = ValueOutput(nameof(Result), _flow => frame);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            frame = _arg.GetValue<API>(Api)
                .TryAcquireCurrentFrame(
                    _arg.GetValue<TryAcquireCurrentFrameNotificationData>(TryAcquireCurrentFrameNotificationData));
            return outputTrigger;
        }
    }
}
#endif