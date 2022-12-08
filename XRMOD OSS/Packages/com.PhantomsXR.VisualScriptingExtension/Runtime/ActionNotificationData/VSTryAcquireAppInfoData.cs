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
#if UNITY_IOS || UNITY_ANDROID || UNITY_WSA || UNITY_EDITOR

using Unity.VisualScripting;
using com.Phantoms.ActionNotification.Runtime;

using UnityEngine;
using UnityEngine.EventSystems;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/NotificationData"), UnitShortTitle("Create Try AcquireApp Info Data"),
     UnitTitle("Create Try AcquireApp info Data")]
    [TypeIcon(typeof(AxisEventData))]
    public class VSTryAcquireAppInfoData : VSBaseData
    {
        [DoNotSerialize] public ValueInput GetInfoType;


        protected override void Definition()
        {
            GetInfoType = ValueInput<string>(nameof(GetInfoType));
            base.Definition();
        }

        protected override BaseNotificationData CreateData(Flow _arg)
        {
            var tmp_NotificationData = new TryAcquireAppInfoNotificationData()
            {
                ActionName = _arg.GetValue<string>(ActionName),
                BaseData = _arg.GetValue<string>(BaseData),
                NotificationAct = () =>
                    CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget), _arg.GetValue<string>(NotificationAct)),
                NotificationActWithData = _data => CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                    _arg.GetValue<string>(NotificationActWithData), _data),
                GetInfoType = _arg.GetValue<string>(GetInfoType),
            };
            return tmp_NotificationData;
        }
    }
}
#endif