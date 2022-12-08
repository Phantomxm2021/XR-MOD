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

namespace HandheldARModule.Runtime
{
    public class ConstKey
    {
        public const string CONST_ON_EVENT = nameof(ActionParameterDataType.OnEvent);
        public const string CONST_SET_FOCUS_ALGORITHM_STATE = nameof(ActionParameterDataType.SetFocusAlgorithmState);
        public const string CONST_MAIN_CAMERA_TAG_NAME = "MainCamera";
#if ARFOUNDATION_5_0_0
        public const string CONST_AR_SESSION_ORIGIN_NAME = "XROrigin";
#else
        public const string CONST_AR_SESSION_ORIGIN_NAME = "ARSessionOrigin";
#endif
        public const string CONST_AR_SESSION_NAME = "ARSession";
        public const string CONST_GAME_OBJECT_NAME = "AnchorManagerExtension";
        public const string CONST_AR_CAMERA_NAME = "AR Camera";
        public const string CONST_TRACKABLES_NAME = "Trackables";
        public const string CONST_DEFAULT_PLANE_VISUALIZER_NAME = "ARDefaultPlaneVisualizer";
        public const string CONST_DEFAULT_POINT_CLOUD_VISUALIZER_NAME = "ARDefaultPointCloudVisualizer";
        public const string CONST_DEFAULT_FEATHERED_PLANE_VISUALIZER = "ARFeatheredPlaneVisualizer";
        public const string CONST_IMAGE_LIBRARY = "ReferenceImageLibrary";
        public const string CONST_PREFAB_FOLDER_NAME = "Prefabs";

        // public const string CONST_ACTION_KEY_ON_FIRST_LOCALIZATION = "OnFirstLocalization";
        // public const string CONST_ACTION_KEY_ON_LOCALIZER_POSE_FOUND = "OnLocalizerPoseFound";
        // public const string CONST_ACTION_KEY_ON_POSE_LOSE = "OnPoseLose";
        // public const string CONST_ACTION_KEY_ON_POSE_FOUND = "OnPoseFound";
        // public const string CONST_ACTION_KEY_ON_MAP_CHANGED = "OnMapChanged"; ARFOUNDATION_4_2_3_OR_NEWER


        public const int CONST_DEFAULT_RADIUS = 200;
        public const string CONST_STATUS_SPARSE = "sparse";
        public const string CONST_STATUS_DONE = "done";
        public const string CONST_STATUS_FAILED = "failed";
        public const string CONST_STATUS_PENDING = "pending";
        public const string CONST_STATUS_PROCESSING = "processing";

        public const string CONST_LIGHT_ESTIMATION = "Light Estimation";
        public const string CONST_NATIVE_CAMERA_NAME = "NativeCam";
        public const string CONST_NO_SESSION_ERROR = "No session subsystem available. Could not load.";
        public const string CONST_ARWORD_DESERIALIZED = "Deserialized successfully.";
        public const string CONST_INVALID_ARWORD_DATA = "Data is not a valid ARWorldMap.";
    }
}