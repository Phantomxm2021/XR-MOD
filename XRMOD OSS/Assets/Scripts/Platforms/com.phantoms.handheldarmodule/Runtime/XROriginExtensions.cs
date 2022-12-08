// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace HandheldARModule.Runtime
{
#if ARFOUNDATION_5_0_0
    /// <summary>
    /// This class contains extension methods suitable for replacing the <c>ARSessionOrigin.MakeContentAppearAt</c>
    /// API as existed in AR Foundation 4.2, allowing users to upgrade projects from
    /// <see cref="ARSessionOrigin"/> to <see cref="XROrigin"/> with continued access to this API. 
    /// </summary>
    public static class XROriginExtensions
    {
        /// <summary>
        /// Makes <paramref name="_content"/> appear to be placed at <paramref name="_position"/> with orientation <paramref name="_rotation"/>.
        /// </summary>
        /// <param name="_origin">The <c>XROrigin</c> in the Scene.</param>
        /// <param name="_content">The <c>Transform</c> of the content you wish to affect.</param>
        /// <param name="_position">The position you wish the content to appear at. This could be
        /// a position on a detected plane, for example.</param>
        /// <param name="_rotation">The rotation the content should appear to be in, relative
        /// to the <c>Camera</c>.</param>
        /// <remarks>
        /// This method does not actually change the <c>Transform</c> of content; instead,
        /// it updates the <c>XROrigin</c>'s <c>Transform</c> so the content
        /// appears to be at the given position and rotation. This is useful for placing AR
        /// content onto surfaces when the content itself cannot be moved at runtime.
        /// For example, if your content includes terrain or a NavMesh, it cannot
        /// be moved or rotated dynamically.
        /// </remarks>
        public static void MakeContentAppearAt(this XROrigin _origin, Transform _content, Vector3 _position,
            Quaternion _rotation)
        {
            MakeContentAppearAt(_origin, _content, _position);
            MakeContentAppearAt(_origin, _content, _rotation);
        }

        /// <summary>
        /// Makes <paramref name="_content"/> appear to be placed at <paramref name="_position"/>.
        /// </summary>
        /// <param name="_origin">The <c>XROrigin</c> in the Scene.</param>
        /// <param name="_content">The <c>Transform</c> of the content you wish to affect.</param>
        /// <param name="_position">The position you wish the content to appear at. This could be
        /// a position on a detected plane, for example.</param>
        /// <remarks>
        /// This method does not actually change the <c>Transform</c> of content; instead,
        /// it updates the <c>XROrigin</c>'s <c>Transform</c> so the content
        /// appears to be at the given position.
        /// </remarks>
        public static void MakeContentAppearAt(this XROrigin _origin, Transform _content, Vector3 _position)
        {
            if (_content == null)
                throw new ArgumentNullException(nameof(_content));

            var tmp_OriginTransform = _origin.transform;

            // Adjust the Camera Offset transform to account
            // for the actual position we want the content to appear at.
            _origin.CameraFloorOffsetObject.transform.position += tmp_OriginTransform.position - _position;

            // The XROrigin's position needs to match the content's pivot. This is so
            // the entire XROrigin rotates around the content (so the impression is that
            // the content is rotating, not the rig).
            tmp_OriginTransform.position = _content.position;
        }

        /// <summary>
        /// Makes <paramref name="_content"/> appear to have orientation <paramref name="_rotation"/> relative to the <c>Camera</c>.
        /// </summary>
        /// <param name="_origin">The <c>XROrigin</c> in the Scene.</param>
        /// <param name="_content">The <c>Transform</c> of the content you wish to affect.</param>
        /// <param name="_rotation">The rotation the content should appear to be in, relative
        /// to the <c>Camera</c>.</param>
        /// <remarks>
        /// This method does not actually change the <c>Transform</c> of content; instead,
        /// it updates the <c>XROrigin</c>'s <c>Transform</c> so that the content
        /// appears to be in the requested orientation.
        /// </remarks>
        public static void MakeContentAppearAt(this XROrigin _origin, Transform _content, Quaternion _rotation)
        {
            if (_content == null)
                throw new ArgumentNullException(nameof(_content));

            // Since we aren't rotating the content, we need to perform the inverse
            // operation on the XROrigin. For example, if we want the
            // content to appear to be rotated 90 degrees on the Y axis, we should
            // rotate our rig -90 degrees on the Y axis.
            _origin.transform.rotation = Quaternion.Inverse(_rotation) * _content.rotation;
        }
    }
#endif
}