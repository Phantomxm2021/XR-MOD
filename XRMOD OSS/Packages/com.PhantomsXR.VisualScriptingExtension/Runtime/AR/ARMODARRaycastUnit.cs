// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if UNITY_IOS || UNITY_ANDROID
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR"), UnitTitle("AR Raycast"),TypeIcon(typeof(Ray))]
    public class ARMODARRaycastUnit : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize] public ValueInput ScreenPoint;
        [DoNotSerialize] public ValueInput TrackableType;
        [DoNotSerialize] public ValueInput EventName;
        [DoNotSerialize, NullMeansSelf] public ValueInput EventTarget;


        protected override void Definition()
        {
            base.Definition();
            ScreenPoint = ValueInput(nameof(ScreenPoint), Vector3.zero);
            EventName = ValueInput(nameof(EventName),string.Empty);
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            TrackableType = ValueInput(nameof(TrackableType), TrackableTypeEnum.PlaneWithinPolygon);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Position = _arg.GetValue<Vector3>(ScreenPoint);
            var tmp_TrackableType = _arg.GetValue<TrackableTypeEnum>(TrackableType);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            _arg.GetValue<API>(Api).ARRaycast(tmp_Position, tmp_TrackableType,
                _pose => { CustomEvent.Trigger(tmp_EventTarget, tmp_EventName, _pose); });
            return outputTrigger;
        }
    }
}
#endif