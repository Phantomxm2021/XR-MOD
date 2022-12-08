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
using UnityEngine.EventSystems;
using Unity.VisualScripting;
namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/NotificationData/Callback"), UnitShortTitle("Immersal Data Response"),
     UnitTitle("Immersal Data Response")]
    [TypeIcon(typeof(AxisEventData))]
    public class VSImmersalData : Unit
    {
        [DoNotSerialize] public ValueInput BaseData;
        [DoNotSerialize] public ValueOutput ResultData;

        protected override void Definition()
        {
            BaseData =
                ValueInput<ImmersalNotificationData>(nameof(BaseData));

            ResultData =
                ValueOutput(nameof(ResultData),
                    _flow =>
                        _flow.GetValue<ImmersalNotificationData>(
                            BaseData));
        }
    }
}