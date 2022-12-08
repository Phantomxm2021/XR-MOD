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

namespace com.Phantoms.ActionNotification.Runtime
{
    [Flags]
    public enum TrackableTypeEnum:int
    {
        /// <summary>
        /// No trackable.
        /// </summary>
        None = 0,

        /// <summary>
        /// Refers to the 2D convex shape associated with a plane's boundary points.
        /// </summary>
        /// <remarks>
        /// When used as the <c>trackableTypeMask</c> in a
        /// <see cref="XRRaycastSubsystem.Raycast(Ray, TrackableType, Unity.Collections.Allocator)"/>,
        /// the ray is considered to have hit if the ray intersects with the polygon described by the exact
        /// boundary of the plane.
        /// </remarks>
        PlaneWithinPolygon = 1 << 0,

        /// <summary>
        /// Refers to the 2D rectangular bounding box that tightly encloses the plane's polygon.
        /// </summary>
        /// <remarks>
        /// When used as the <c>trackableTypeMask</c> in a
        /// <see cref="XRRaycastSubsystem.Raycast(Ray, TrackableType, Unity.Collections.Allocator)"/>,
        /// the ray is considered to have hit if the ray intersects with the 2D box described by the
        /// size of the plane.
        /// </remarks>
        PlaneWithinBounds = 1 << 1,

        /// <summary>
        /// Refers to the infinite plane described by its <c>Pose</c> (a position and orientation).
        /// </summary>
        /// <remarks>
        /// When used as the <c>trackableTypeMask</c> in a
        /// <see cref="XRRaycastSubsystem.Raycast(Ray, TrackableType, Unity.Collections.Allocator)"/>,
        /// the ray is considered to have hit if the ray intersects with the infinite plane.
        /// </remarks>
        PlaneWithinInfinity = 1 << 2,

        /// <summary>
        /// Refers to an estimated plane.
        /// </summary>
        /// <remarks>
        /// When used as the <c>trackableTypeMask</c> in a
        /// <see cref="XRRaycastSubsystem.Raycast(Ray, TrackableType, Unity.Collections.Allocator)"/>,
        /// the ray is considered to have hit if the ray intersects with an estimated plane. An estimated
        /// plane is implementation-defined, but might not have an exact boundary. It is a guess that suggests
        /// the ray is near a surface.
        /// </remarks>
        PlaneEstimated = 1 << 3,

        /// <summary>
        /// Refers to any of the plane type trackables.
        /// </summary>
        /// <remarks>
        /// Often used with the <c>trackableTypeMask</c> in a
        /// <see cref="XRRaycastSubsystem.Raycast(Ray, TrackableType, Unity.Collections.Allocator)"/>,
        /// the ray is considered to have hit if the ray intersects with any of the plane types.
        /// </remarks>
        Planes =
            PlaneWithinPolygon |
            PlaneWithinBounds |
            PlaneWithinInfinity |
            PlaneEstimated,

        /// <summary>
        /// Refers to a feature point (that is, a point in a point cloud).
        /// </summary>
        /// <remarks>
        /// When used as the <c>trackableTypeMask</c> in a
        /// <see cref="XRRaycastSubsystem.Raycast(Ray, TrackableType, Unity.Collections.Allocator)"/>,
        /// the ray is considered to have hit if a cone around the ray intersects with a point in a point cloud.
        /// </remarks>
        FeaturePoint = 1 << 4,

        /// <summary>
        /// Refers to a tracked image.
        /// </summary>
        Image = 1 << 5,

        /// <summary>
        /// Refers to a tracked face.
        /// </summary>
        Face = 1 << 6,

        /// <summary>
        /// Refers to a point in the depth map.
        /// </summary>
        Depth = 1 << 7,

        /// <summary>
        /// Deprecated in favor of <see cref="TrackableType.AllTypes"/>. Refers to all trackable types except
        /// <see cref="TrackableType.Depth"/>.
        /// </summary>
        [Obsolete("Use TrackableType.AllTypes instead. (2021-05-02)")]
        All = Planes | FeaturePoint | Image | Face,

        /// <summary>
        /// Refers to all trackable types.
        /// </summary>
        AllTypes = -1,
    }
    
    public class AnchorNotificationData : BaseNotificationData
    {
       

        public StickTypeEnum StickType;
        public TrackableTypeEnum TrackableType;
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Offset;
        public GameObject AnchorPrefab;

        public enum StickTypeEnum
        {
            //ByScreen,
            ByTrackableType
        }
    }
}