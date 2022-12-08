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

using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

#if UNITY_IOS
using UnityEngine.XR.ARKit;
#endif

namespace HandheldARModule.Runtime.Extension
{
    public class CoachingOverlayExtension : MonoBehaviour
    {
#if UNITY_IOS
        [SerializeField] bool activatesAutomatically = true;

        // Duplicate the ARCoachingGoal enum so that we can use it on a serialized field
        enum CoachingGoal
        {
            Tracking,
            HorizontalPlane,
            VerticalPlane,
            AnyPlane
        }

        [SerializeField] [Tooltip("The coaching goal associated with the coaching overlay.")]
        CoachingGoal goal = CoachingGoal.Tracking;


#if UNITY_IOS
        /// <summary>
        /// The [ARCoachingGoal](https://developer.apple.com/documentation/arkit/arcoachinggoal) associated with the coaching overlay
        /// </summary>
        public ARCoachingGoal Goal
        {
            get
            {
                if (GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
                {
                    return tmp_SessionSubsystem.requestedCoachingGoal;
                }
                else
                {
                    return (ARCoachingGoal) goal;
                }
            }

            set
            {
                goal = (CoachingGoal) value;
                if (supported && GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
                {
                    tmp_SessionSubsystem.requestedCoachingGoal = value;
                }
            }
        }
#endif

        /// <summary>
        /// Whether the coaching overlay activates automatically
        /// </summary>
        public bool ActivatesAutomatically
        {
            get
            {
#if UNITY_IOS
                if (supported && GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
                {
                    return tmp_SessionSubsystem.coachingActivatesAutomatically;
                }
#endif
                return activatesAutomatically;
            }

            set
            {
                activatesAutomatically = value;

#if UNITY_IOS
                if (supported && GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
                {
                    tmp_SessionSubsystem.coachingActivatesAutomatically = value;
                }
#endif
            }
        }

        /// <summary>
        /// Whether the [ARCoachingGoal](https://developer.apple.com/documentation/arkit/arcoachinggoal) is supported.
        /// </summary>
        public bool supported
        {
            get
            {
#if UNITY_IOS
                return ARKitSessionSubsystem.coachingOverlaySupported;
#else
                return false;
#endif
            }
        }

        void OnEnable()
        {
#if UNITY_IOS
            if (supported && GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
            {
                tmp_SessionSubsystem.requestedCoachingGoal = (ARCoachingGoal) goal;
                tmp_SessionSubsystem.coachingActivatesAutomatically = activatesAutomatically;
                //tmp_SessionSubsystem.sessionDelegate = new CustomSessionDelegate();
            }
            else
#endif
            {
                Debug.LogError("ARCoachingOverlayView is not supported by this device.");
            }
        }

        /// <summary>
        /// Activates the [ARCoachingGoal](https://developer.apple.com/documentation/arkit/arcoachinggoal)
        /// </summary>
        /// <param name="animated">If <c>true</c>, the coaching overlay is animated, e.g. fades in.
        /// If <c>false</c>, the coaching overlay appears instantly, without any transition.
        /// </param>
        public void ActivateCoaching(bool animated)
        {
#if !UNITY_EDITOR
#if UNITY_IOS
            if (supported && GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
            {
                tmp_SessionSubsystem.SetCoachingActive(true,
                    animated ? ARCoachingOverlayTransition.Animated : ARCoachingOverlayTransition.Instant);
            }
            else
#endif
            {
                throw new NotSupportedException("ARCoachingOverlay is not supported");
            }
#endif
        }

        /// <summary>
        /// Disables the [ARCoachingGoal](https://developer.apple.com/documentation/arkit/arcoachinggoal)
        /// </summary>
        /// <param name="_animated">If <c>true</c>, the coaching overlay is animated, e.g. fades out.
        /// If <c>false</c>, the coaching overlay disappears instantly, without any transition.
        /// </param>
        public void DisableCoaching(bool _animated)
        {
#if UNITY_IOS
            if (supported && GetComponent<ARSession>().subsystem is ARKitSessionSubsystem tmp_SessionSubsystem)
            {
                tmp_SessionSubsystem.SetCoachingActive(false,
                    _animated ? ARCoachingOverlayTransition.Animated : ARCoachingOverlayTransition.Instant);
            }
            else
#endif
            {
                throw new NotSupportedException("ARCoachingOverlay is not supported");
            }
        }
#endif
    }
}