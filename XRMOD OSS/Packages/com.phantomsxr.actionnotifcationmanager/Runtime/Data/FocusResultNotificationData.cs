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

using UnityEngine;

namespace com.Phantoms.ActionNotification.Runtime
{
    /// <summary>
    /// 发现平面状态
    /// </summary>
    public enum FindingType
    {
        Finding,
        Found,
        Limit
    }

    public enum PlaneAlignment
    {
        None = 0,
        HorizontalUp = 100, // 0x00000064
        HorizontalDown = 101, // 0x00000065
        Vertical = 200, // 0x000000C8
        NotAxisAligned = 300, // 0x0000012C
    }

    /// <summary>
    /// Represents the alignment of a plane (for example, whether it is horizontal or vertical).
    /// </summary>
    /// <seealso cref="BoundedPlane.classification"/>
    public enum PlaneClassification
    {
        /// <summary>
        /// The plane does not match any available classification.
        /// </summary>
        None = 0,

        /// <summary>
        /// The plane is horizontal with an upward facing normal (for example, a floor).
        /// </summary>
        Wall,

        /// <summary>
        /// The plane is classified as the floor.
        /// </summary>
        Floor,

        /// <summary>
        /// The plane is classified as the ceiling.
        /// </summary>
        Ceiling,

        /// <summary>
        /// The plane is classified as a table.
        /// </summary>
        Table,

        /// <summary>
        /// The plane is classified as a seat.
        /// </summary>
        Seat,

        /// <summary>
        /// The plane is classified as a door.
        /// </summary>
        Door,

        /// <summary>
        /// The plane is classified as a window.
        /// </summary>
        Window
    }

    public class FocusResultNotificationData : BaseNotificationData
    {
        /// <summary>
        /// The physical size (dimensions) of the plane in meters.
        /// </summary>
        public Vector2 size;

        /// <summary>
        /// Hit position
        /// </summary>
        public Vector3 FocusPos;

        /// <summary>
        /// Hit rotation
        /// </summary>
        public Quaternion FocusRot;

        /// <summary>
        /// Hit type
        /// </summary>
        public FindingType FocusState;

        /// <summary>
        /// The alignment of this plane.
        /// </summary>
        public PlaneAlignment PlaneAlignment;

        /// <summary>
        /// The classification of this plane.
        /// </summary>
        public PlaneClassification PlaneClassification;
    }
}