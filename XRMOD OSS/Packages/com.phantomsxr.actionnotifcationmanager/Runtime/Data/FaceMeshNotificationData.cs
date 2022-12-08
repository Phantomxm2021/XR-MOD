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


using Unity.Collections;
using UnityEngine;

namespace com.Phantoms.ActionNotification.Runtime
{
    public enum FaceTrackingState
    {
        /// <summary>
        /// Not tracking.
        /// </summary>
        None,
        
        /// <summary>
        /// Add new face
        /// </summary>
        Added,

        /// <summary>
        /// Some tracking information is available, but it is limited or of poor quality.
        /// </summary>
        Limited,

        /// <summary>
        /// Tracking is working normally.
        /// </summary>
        Tracking,
    }
    public class FaceMeshNotificationData:BaseNotificationData
    {
        public string TrackingId;
        public GameObject FaceAnchor;
        public FaceTrackingState FaceTrackingState;
        public NativeArray<Vector3> vertices;
        public NativeArray<int> indices;
        public NativeArray<Vector3> normals;
        public NativeArray<Vector2> uvs;
    }
}