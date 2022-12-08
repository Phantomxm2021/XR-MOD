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
#if UNITY_IOS || UNITY_ANDROID || UNITY_WSA || UNITY_EDITOR || UNITY_STANDALONE

using System;
using com.Phantoms.ActionNotification.Runtime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/NotificationData"),
     UnitShortTitle("Create Base Data"),
     UnitTitle("Create Base Data")]
    [TypeIcon(typeof(AxisEventData))]
    public class VSBaseData : Unit
    {
        [DoNotSerialize] public ValueInput ActionName;
        [DoNotSerialize] public ValueInput BaseData;
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize] public ValueInput NotificationAct;
        [DoNotSerialize] public ValueInput NotificationActWithData;

        [DoNotSerialize] public ValueOutput Result;


        protected override void Definition()
        {
            ActionName = ValueInput<string>(nameof(ActionName), String.Empty);
            BaseData = ValueInput<string>(nameof(BaseData), String.Empty);
            EventTarget = ValueInput<GameObject>(nameof(EventTarget), null).NullMeansSelf();
            NotificationAct = ValueInput<string>(nameof(NotificationAct), String.Empty);
            NotificationActWithData = ValueInput<string>(nameof(NotificationActWithData), String.Empty);
            Result = ValueOutput(nameof(Result), CreateData);
        }

        protected virtual BaseNotificationData CreateData(Flow _arg)
        {
            var tmp_NotificationData = new BaseNotificationData()
            {
                ActionName = _arg.GetValue<string>(ActionName),
                BaseData = _arg.GetValue<string>(BaseData),
                NotificationAct = () =>
                    CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget), _arg.GetValue<string>(NotificationAct)),
                NotificationActWithData = _data => CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                    _arg.GetValue<string>(NotificationActWithData), _data),
            };
            return tmp_NotificationData;
        }
    }
}
#endif