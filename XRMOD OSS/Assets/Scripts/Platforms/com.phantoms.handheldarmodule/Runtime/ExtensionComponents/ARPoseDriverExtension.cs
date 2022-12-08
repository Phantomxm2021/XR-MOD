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

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace HandheldARModule.Runtime.Extension
{
    public class ARPoseDriverExtension : MonoBehaviour
    {
        public enum PoseType
        {
            None,
            Position,
            Rotation,
            PositionAndRotation
        }

        public PoseType CurrentPoseType;

        internal struct NullablePose
        {
            internal Vector3? Position;
            internal Quaternion? Rotation;
        }

        protected void OnEnable()
        {
            Application.onBeforeRender += OnBeforeRender;
        }

        protected void OnDisable()
        {
            Application.onBeforeRender -= OnBeforeRender;
        }

        protected void Update()
        {
            PerformUpdate();
        }

        protected void OnBeforeRender()
        {
            PerformUpdate();
        }

        protected void PerformUpdate()
        {
            if (!enabled)
                return;

            var tmp_UpdatedPose = GetNodePoseData(XRNode.CenterEye);

            switch (CurrentPoseType)
            {
                case PoseType.None:
                    break;
                case PoseType.Position:
                    if (tmp_UpdatedPose.Position.HasValue)
                        transform.localPosition = tmp_UpdatedPose.Position.Value;
                    break;
                case PoseType.Rotation:
                    if (tmp_UpdatedPose.Rotation.HasValue)
                        transform.localRotation = tmp_UpdatedPose.Rotation.Value;
                    break;
                case PoseType.PositionAndRotation:
                    if (tmp_UpdatedPose.Position.HasValue)
                        transform.localPosition = tmp_UpdatedPose.Position.Value;
                    if (tmp_UpdatedPose.Rotation.HasValue)
                        transform.localRotation = tmp_UpdatedPose.Rotation.Value;
                    break;
            }
        }

        static internal readonly List<XRNodeState> NodeStates = new List<XRNodeState>();

        static internal NullablePose GetNodePoseData(XRNode _currentNode)
        {
            NullablePose tmp_ResultPose = new NullablePose();
            InputTracking.GetNodeStates(NodeStates);
            foreach (var nodeState in NodeStates)
            {
                if (nodeState.nodeType == _currentNode)
                {
                    var tmp_Pose = Pose.identity;
                    var tmp_PositionSuccess = nodeState.TryGetPosition(out tmp_Pose.position);
                    var tmp_RotationSuccess = nodeState.TryGetRotation(out tmp_Pose.rotation);

                    if (tmp_PositionSuccess)
                        tmp_ResultPose.Position = tmp_Pose.position;
                    if (tmp_RotationSuccess)
                        tmp_ResultPose.Rotation = tmp_Pose.rotation;

                    return tmp_ResultPose;
                }
            }

            return tmp_ResultPose;
        }
    }
}