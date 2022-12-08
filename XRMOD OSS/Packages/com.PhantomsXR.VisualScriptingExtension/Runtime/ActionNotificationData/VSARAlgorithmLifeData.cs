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
     UnitShortTitle("Create AR Algorithm Life Data"),
    UnitTitle("Create AR Algorithm Life Data")]
    [TypeIcon(typeof(AxisEventData))]

    public class VSARAlgorithmLifeData : VSBaseData
    {
        [DoNotSerialize] public ValueInput ARAlgorithmType;
        [DoNotSerialize] public ValueInput ARAlgorithmOperator;
        [DoNotSerialize] public ValueInput Mixed;


        protected override void Definition()
        {
            ARAlgorithmType =
                ValueInput<ARAlgorithmType>(
                    nameof(ARAlgorithmType));
            ARAlgorithmOperator =
                ValueInput<ARAlgorithmOperator>(
                    nameof(ARAlgorithmOperator));
            Mixed = ValueInput(nameof(Mixed), false);

            base.Definition();
        }

        protected override BaseNotificationData CreateData(Flow _arg)
        {
            var tmp_AlgorithmType =
                _arg.GetValue<ARAlgorithmType>(ARAlgorithmType);
            var tmp_Operator =
                _arg.GetValue<ARAlgorithmOperator>(ARAlgorithmOperator);
            var tmp_Mixed = _arg.GetValue<bool>(Mixed);
            var tmp_NotificationData = new ARAlgorithmNotificationData()
            {
                ActionName = _arg.GetValue<string>(ActionName),
                BaseData = _arg.GetValue<string>(BaseData),
                NotificationAct = () =>
                    CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget), _arg.GetValue<string>(NotificationAct)),
                NotificationActWithData = _data => CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                    _arg.GetValue<string>(NotificationActWithData), _data),
                
                Mixed = tmp_Mixed,
                ARAlgorithmType = tmp_AlgorithmType,
                ARAlgorithmOperator = tmp_Operator,
            };
            return tmp_NotificationData;
        }
    }
}
#endif