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

using UnityEngine;
using UnityEngine.EventSystems;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/NotificationData"), 
     UnitShortTitle("Create AR Occlusion Data"),
     UnitTitle("Create AR Occlusion Data")]
    [TypeIcon(typeof(AxisEventData))]

    public class VSAROcclusionData : VSBaseData
    {
        [DoNotSerialize] public ValueInput OcclusionDataType;


        protected override void Definition()
        {
            OcclusionDataType =
                ValueInput<OcclusionDataType>(nameof(OcclusionDataType));
            base.Definition();
        }

        protected override BaseNotificationData CreateData(Flow _arg)
        {
            var tmp_OcclusionDataType =
                _arg.GetValue<OcclusionDataType>(OcclusionDataType);
            var tmp_NotificationData = new AROcclusionNotificationData
            {
                ActionName = _arg.GetValue<string>(ActionName),
                BaseData = _arg.GetValue<string>(BaseData),
                NotificationAct = () =>
                    CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget), _arg.GetValue<string>(NotificationAct)),
                NotificationActWithData = _data => CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                    _arg.GetValue<string>(NotificationActWithData), _data),

                OcclusionDataType = tmp_OcclusionDataType
            };
            return tmp_NotificationData;
        }
    }
}
#endif