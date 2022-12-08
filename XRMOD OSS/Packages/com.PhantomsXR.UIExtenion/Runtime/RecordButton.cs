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

using System;
using System.Collections;
using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace com.PhantomsXR.Recorders.Runtime
{
    public class RecordButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [Header(@"Settings"), Range(5f, 60f), Tooltip(@"Maximum duration that button can be pressed.")]
        public float maxDuration = 10f;
        [Tooltip(@"Automatically register media recording and take photo events for the button.")]
        public bool AutoRegisterEvent = true;

        
        [Header(@"UI")] public Image countdown;
        
        
        public Action OnLongPressStart;
        public Action OnLongPressStop;
        public Action OnClick;


        public float DurationThreshold = 1.0f;
        private Image button;
        private bool touch;
        private bool longPressTriggered;
        private bool isPointerDown = false;

        private float timePressStarted;

        private void Awake()
        {
            if (button == null)
                button = GetComponent<Image>();
            
            if (!AutoRegisterEvent) return;
            OnLongPressStart = () =>
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.StartVideoRecording), null);
            };

            OnLongPressStop = () =>
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.StopVideoRecording), null);
            };

            OnClick = () =>
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(
                    nameof(ActionParameterDataType.TakePhoto), null);
            };
        }

        private void Start() => Reset();

        private void Reset()
        {
            button.fillAmount = 1.0f;
            countdown.fillAmount = 0.0f;
            longPressTriggered = false;
        }

        void IPointerDownHandler.OnPointerDown(PointerEventData _eventData)
        {
            timePressStarted = Time.time;
            isPointerDown = true;
        }

        void IPointerUpHandler.OnPointerUp(PointerEventData _eventData)
        {
            if (!longPressTriggered)
            {
                OnClick?.Invoke();
            }

            isPointerDown = false;
            touch = false;
        }

        private IEnumerator Countdown()
        {
            touch = true;
            // Wait for false touch
            yield return new WaitForSeconds(0.2f);
            if (!touch)
                yield break;
            OnLongPressStart?.Invoke();
            // Animate the countdown
            var tmp_StartTime = Time.time;
            while (touch)
            {
                var tmp_Ratio = (Time.time - tmp_StartTime) / maxDuration;
                touch = tmp_Ratio <= 1f;
                countdown.fillAmount = tmp_Ratio;
                button.fillAmount = 1f - tmp_Ratio;
                yield return null;
            }

            Reset();
            OnLongPressStop?.Invoke();
        }


        private void Update()
        {
            if (!isPointerDown || longPressTriggered) return;
            var tmp_Duration = Time.time - timePressStarted;
            longPressTriggered = tmp_Duration > DurationThreshold;
            if (longPressTriggered)
            {
                StartCoroutine(Countdown());
            }
        }
    }
}