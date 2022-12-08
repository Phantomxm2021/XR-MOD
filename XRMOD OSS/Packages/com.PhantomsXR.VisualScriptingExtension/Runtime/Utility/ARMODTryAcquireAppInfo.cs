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

using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Try Acquire App Info")]
    [TypeIcon(typeof(AnimatorStateInfo))]
    public class ARMODTryAcquireAppInfo : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize][PortLabel("Data")] public ValueInput TryAcquireAppInfoData;

        protected override void Definition()
        {
            base.Definition();
            TryAcquireAppInfoData = ValueInput<TryAcquireAppInfoNotificationData>(nameof(TryAcquireAppInfoData), null);
            Requirement(TryAcquireAppInfoData,inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            _arg.GetValue<TryAcquireAppInfoNotificationData>(TryAcquireAppInfoData).NotificationActWithData.Invoke("123");
            _arg.GetValue<API>(Api)
                .TryAcquireAppInfo(_arg.GetValue<TryAcquireAppInfoNotificationData>(TryAcquireAppInfoData));
            return outputTrigger;
        }
    }
}