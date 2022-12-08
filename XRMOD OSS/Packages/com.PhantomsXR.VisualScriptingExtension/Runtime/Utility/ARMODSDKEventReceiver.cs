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
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility")]
    [UnitShortTitle("SDK Event Receiver")]
    [UnitSubtitle("Receive AR-MOD SDK Event")]
    [TypeIcon(type: typeof(MessageListener))]
    public class ARMODSDKEventReceiver : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        private GameObject eventTarget;

        protected const string CONST_ON_IMAGE_TRACKING = "ImageTracking";
        protected const string CONST_ON_FACE_MESH = "FaceMesh";
        protected const string CONST_ON_FOCUS_RESULT = "FocusResult";
        protected const string CONST_ON_IMMERSAL = "Immersal";


        /// <summary>
        /// Receive AR-MOD SDK Event and call to visual scripting [Custom Event]
        /// </summary>
        /// <param name="_baseData"></param>
        private void OnEvent(BaseNotificationData _baseData)
        {
            switch (_baseData)
            {
                case MarkerNotificationData tmp_Marker:
                    CustomEvent.Trigger(eventTarget, CONST_ON_IMAGE_TRACKING, tmp_Marker);
                    break;
                case FaceMeshNotificationData tmp_FaceMesh:
                    CustomEvent.Trigger(eventTarget, CONST_ON_FACE_MESH, tmp_FaceMesh);
                    break;
                case FocusResultNotificationData tmp_FocusResult:
                    CustomEvent.Trigger(eventTarget, CONST_ON_FOCUS_RESULT, tmp_FocusResult);
                    break;
                case ImmersalNotificationData tmp_Immersal:
                    CustomEvent.Trigger(eventTarget, CONST_ON_IMMERSAL, tmp_Immersal);
                    break;
            }
        }

        protected override void Definition()
        {
            base.Definition();
            EventTarget = ValueInput("EventTarget", (GameObject)null).NullMeansSelf();

            //Binding the [OnEvent] method, To Receive AR-MOD SDK Callback
            ActionNotificationCenter.DefaultCenter.AddObserver(OnEvent,
                nameof(ActionParameterDataType.OnEvent));
        }

        public override ControlOutput Execute(Flow _arg)
        {
            eventTarget = _arg.GetValue<GameObject>(EventTarget);
            return outputTrigger;
        }

        public override void Dispose()
        {
            base.Dispose();
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.OnEvent));
        }
    }
}