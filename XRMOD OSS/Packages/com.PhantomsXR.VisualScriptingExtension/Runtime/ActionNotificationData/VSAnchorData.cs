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

using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/NotificationData"),
     UnitShortTitle("Create Anchor Data"),
     UnitTitle("Create Anchor Data")]
    [TypeIcon(typeof(AxisEventData))]
    public class VSAnchorData : VSBaseData
    {
        // [DoNotSerialize] public ValueInput StickType;
        [DoNotSerialize] public ValueInput TrackableType;
        [DoNotSerialize] public ValueInput Position;
        [DoNotSerialize] public ValueInput Rotation;
        [DoNotSerialize] public ValueInput Offset;
        [DoNotSerialize] public ValueInput VirtualObject;


        protected override void Definition()
        {
            TrackableType =
                ValueInput<TrackableTypeEnum>(
                    nameof(TrackableType));
            Position = ValueInput(nameof(Position), Vector3.zero);
            Rotation = ValueInput(nameof(Rotation), Quaternion.identity);
            Offset = ValueInput(nameof(Offset), Vector3.zero);
            VirtualObject = ValueInput<GameObject>(nameof(VirtualObject), null);
            base.Definition();
        }

        protected override BaseNotificationData CreateData(Flow _arg)
        {
            var tmp_TrackableType =  _arg.GetValue<TrackableTypeEnum>(TrackableType);
            var tmp_Position = _arg.GetValue<Vector3>(Position);
            var tmp_Rotation = _arg.GetValue<Quaternion>(Rotation);
            var tmp_Offset = _arg.GetValue<Vector3>(Offset);
            var tmp_ControllerTargetNode = _arg.GetValue<GameObject>(VirtualObject);
            var tmp_NotificationData = new AnchorNotificationData
            {
                ActionName = _arg.GetValue<string>(ActionName),
                BaseData = _arg.GetValue<string>(BaseData),
                NotificationAct = () =>
                    CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget), _arg.GetValue<string>(NotificationAct)),
                NotificationActWithData = _data => CustomEvent.Trigger(_arg.GetValue<GameObject>(EventTarget),
                    _arg.GetValue<string>(NotificationActWithData), _data),

                Offset = tmp_Offset,
                Position = tmp_Position,
                Rotation = tmp_Rotation,
                TrackableType = tmp_TrackableType,
                StickType = AnchorNotificationData.StickTypeEnum.ByTrackableType,
                AnchorPrefab = tmp_ControllerTargetNode
            };
            return tmp_NotificationData;
        }
    }
}
#endif