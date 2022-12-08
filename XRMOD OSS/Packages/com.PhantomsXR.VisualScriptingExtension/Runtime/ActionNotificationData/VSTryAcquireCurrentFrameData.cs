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
    [UnitCategory("ARMOD/NotificationData"), UnitShortTitle("Create Try Acquire Current Frame Data"),
     UnitTitle("Create Try Acquire Current Frame Data")]
    [TypeIcon(typeof(AxisEventData))]
    public class VSTryAcquireCurrentFrameData : VSBaseData
    {
        [DoNotSerialize] public ValueInput AcquiredTextureFormat;
        [DoNotSerialize] public ValueInput ConversionType;


        protected override void Definition()
        {
            ConversionType = ValueInput<ConversionType>(nameof(ConversionType));
            AcquiredTextureFormat = ValueInput<TextureFormat>(nameof(AcquiredTextureFormat));
            base.Definition();
        }

        protected override BaseNotificationData CreateData(Flow _arg)
        {
            var tmp_NotificationData =
                new TryAcquireCurrentFrameNotificationData()
                {
                    ActionName = _arg.GetValue<string>(ActionName),
                    BaseData = _arg.GetValue<string>(BaseData),
                    NotificationAct = () =>
                        CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                            _arg.GetValue<string>(NotificationAct)),
                    NotificationActWithData = _data => CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                        _arg.GetValue<string>(NotificationActWithData), _data),
                    ConversionType =
                        _arg.GetValue<ConversionType>(ConversionType),
                    AcquiredTextureFormat = _arg.GetValue<TextureFormat>(AcquiredTextureFormat),
                };
            return tmp_NotificationData;
        }
    }
}
#endif