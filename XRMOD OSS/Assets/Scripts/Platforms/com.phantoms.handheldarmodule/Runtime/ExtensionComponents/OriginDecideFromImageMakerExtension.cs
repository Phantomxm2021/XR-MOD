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

using System.Collections;
using com.Phantoms.ActionNotification.Runtime;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace HandheldARModule.Runtime.Extension
{
    public class OriginDecideFromImageMakerExtension : MonoBehaviour
    {
        private ARTrackedImageManager imageManager;
        private XROrigin sessionOrigin;
        private GameObject worldOrigin;
        private WaitForSeconds waitForSeconds;
        private IEnumerator coroutine;
        private Transform worldOriginTrans;

        public float TrackInterval = 5f;
        public bool alignOnce;
        private bool executed;

        private void Start()
        {
            waitForSeconds = new WaitForSeconds(TrackInterval);
        }

        private void OnEnable()
        {
            worldOrigin = new GameObject("World Origin");
            worldOriginTrans = worldOrigin.transform;
            imageManager.trackedImagesChanged += OnTrackedImagesChanged;
            ActionNotificationCenter.DefaultCenter.AddObserver(AlignRelativePositionNotifier,
                nameof(ActionParameterDataType.AlignWorldOriginByImageTrack));
        }

        private void OnDisable()
        {
            imageManager.trackedImagesChanged -= OnTrackedImagesChanged;
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .AlignWorldOriginByImageTrack));

            Destroy(worldOrigin);
            StopCoroutine(coroutine);
            coroutine = null;
        }

        private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs _obj)
        {
            foreach (var tmp_TrackedImage in _obj.added)
            {
                StartDecide(tmp_TrackedImage.transform);
            }

            if (alignOnce) return;
            foreach (ARTrackedImage tmp_TrackedImage in _obj.updated)
            {
                StartDecide(tmp_TrackedImage.transform);
            }
        }

        private void StartDecide(Transform _transform)
        {
            coroutine ??= OriginDecide(_transform);
            StartCoroutine(coroutine);
        }

        public Vector3 GetWorldOriginLocal(Vector3 _world)
        {
            return worldOriginTrans.InverseTransformDirection(_world);
        }

        /// <summary>
        /// Determine the origin position
        /// </summary>
        /// <param name="_transform">The image marker transform</param>
        /// <returns></returns>
        private IEnumerator OriginDecide(Transform _transform)
        {
            if (executed)
                yield return waitForSeconds;
            else
            {
                executed = true;
                yield return null;
            }

            worldOriginTrans.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            sessionOrigin.MakeContentAppearAt(worldOriginTrans, _transform.position, _transform.rotation);
            StopCoroutine(coroutine);
            coroutine = null;
        }

        private void AlignRelativePositionNotifier(BaseNotificationData _data)
        {
            if (_data is not TransformNotificationData tmp_Data) return;
            var tmp_RelativePosition = GetWorldOriginLocal(tmp_Data.Position);
            tmp_Data.NotificationActWithData?.Invoke(tmp_RelativePosition);
        }
    }
}