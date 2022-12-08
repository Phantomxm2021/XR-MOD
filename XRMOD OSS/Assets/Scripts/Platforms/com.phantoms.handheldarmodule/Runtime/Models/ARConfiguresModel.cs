// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.models.Runtime;
using UnityEngine.XR.ARSubsystems;

namespace HandheldARModule.Runtime.Models
{
    public class ARConfiguresModel : BaseProjectConfigModel
    {
        public float ARWorldScale = 1.0f;

        public PlaneDetectionMode PlaneDetectionMode = PlaneDetectionMode.Horizontal;

        //visualizer
        public string CustomPointCloudVisualizerName;
        public string CustomPlaneVisualizerName;


        //2d features
        public int MaxMovingOfTracking;

        //features
        public bool EnvironmentProbe;

        ///With automatic environment probe placement, the device
        /// automatically selects suitable locations for environment probes and creates them.
        /// Environment probes can be created in any orientation. However, Unity's reflection probes,
        /// which consume the environment probe data, only support axis-aligned orientations.
        /// This means the orientation you specify (or your application selected automatically) might not be fully respected
        public bool AutoPlacementOfEnvironmentProbe;

        public bool UseEnvironmentHDRTexture;


        public bool LightEstimation;
        public bool LightEstimationHDR;
        public float ShadowStrength;


        public bool CoachingOverlay;


        public bool CanInteraction;
        public bool AutoSelect;

        //face mesh
        public int MaximumFaceCount = 1;


        //immersal
        public bool BurstMode;
        public bool AutoStart;
        public string DeveloperToken;
        public float LocalizationInterval;
        public bool UseServerLocalizer;
        public bool StopLocalizedAfterSuccess = true;
        public bool UseFiltering;
        public bool ContinueLocalizer;

        //Occlusion
        public bool AROcclusion;
        public bool TemporalSmoothing = true;
        public EnvironmentDepthMode EnvironmentDepthMode;
        public HumanSegmentationDepthMode HumanSegmentationDepthMode;
        public HumanSegmentationStencilMode HumanSegmentationStencilMode;
        public OcclusionPreferenceMode OcclusionPreferenceMode;
    }
}