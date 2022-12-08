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
using UnityEngine.XR.ARSubsystems;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class Configures : ScriptableObject
    {
        public SDKDeviceType SDKDeviceType = SDKDeviceType.HandheldAR;
        public float ARWorldScale = 1.0f;
        public string Version = "1.0.0";
        public AlgorithmType Algorithm;
        public bool AlgorithmAutoStart = true;

        public PlaneDetectionMode PlaneDetectionMode = PlaneDetectionMode.Horizontal;
        public string ProjectName;

        //script
        public string MainEntry;
        public string DomainName;
        public ProgrammableType ProgrammableType;
        public string MainVisualScripting;
        public bool DebugModel;
        public JITFlags JitFlag = 0;


        //visualizer
        public string CustomPointCloudVisualizerName;
        public string CustomPlaneVisualizerName;


        //2d features
        public int MaxMovingOfTracking;


        //features
        public bool EnvironmentProbe;

        /// With automatic environment probe placement, the device
        /// automatically selects suitable locations for environment probes and creates them.
        /// Environment probes can be created in any orientation. However, Unity's reflection probes,
        /// which consume the environment probe data, only support axis-aligned orientations.
        /// This means the orientation you specify (or your application selected automatically) might not be fully respected
        public bool AutoPlacementOfEnvironmentProbe;

        public bool UseEnvironmentHDRTexture;

        public bool LightEstimation;
        public bool LightEstimationHDR;
        public float LightShadowStrength = 0.7f;

        public bool CoachingOverlay;

        public bool PostProcessing;

        public bool CanInteraction;

        //face mesh
        public int MaximumFaceCount = 1;

        //immersal
        public string DeveloperToken;
        public float LocalizationInterval;
        public bool UseServerLocalizer;
        public bool AutoStart = true;
        public bool UseFiltering = true;
        public bool BurstMode = true;
        public bool StopLocalizedAfterSuccess = false;
        public bool ResetOnMapChange = false;

        //Occlusion
        public bool AROcclusion;
        public bool TemporalSmoothing;
        public EnvironmentDepthMode EnvironmentDepthMode;
        public HumanSegmentationDepthMode HumanSegmentationDepthMode;
        public HumanSegmentationStencilMode HumanSegmentationStencilMode;
        public OcclusionPreferenceMode OcclusionPreferenceMode;

        //Multiplayer
        public bool Multiplayer;
        public bool DisplayPing;
        public bool Discovery;

        //Graphics
        public int QualityLevel = 1;

        //Recording
        public bool UseMediaRecorder = false;
        public bool UseMicrophone = true;
        public MediaResolution MediaResolution = MediaResolution.Normal;


        //Pico
        public bool MixedReality = false;
    }

    public enum RenderMode : int
    {
        DoNotRender,
        EditorOnly,
        EditorAndRuntime
    }

    public enum AlgorithmType
    {
        FocusSlam,
        Anchor,
        Gyro,
        Fixed,
        ImageTracker,
        Immersal,
        FaceMesh,
        Meshing,
        Classic3D,
    }

    public enum ImageLostMode
    {
        Hiding,
        Destroy,
        OnScreen,
        Custom
    }

    public enum ProgrammableType
    {
        CSharp,
        VisualScripting
    }

    public enum JITFlags : int
    {
        None = 0,

        /// <summary>
        /// Method will be JIT when method is called multiple time
        /// </summary>
        JITOnDemand = 1,

        /// <summary>
        /// Method will be JIT immediately when called, instead of progressively warm up
        /// </summary>
        JITImmediately = 2,

        /// <summary>
        /// Method will not be JIT when called
        /// </summary>
        NoJIT = 4,

        /// <summary>
        /// Method will always be inlined when called
        /// </summary>
        ForceInline = 8,
    }

    public enum MediaResolution : uint
    {
        Normal,
        HD
    }

    public enum SDKDeviceType : int
    {
        AppleGlass,
        HandheldAR,
        Hololens2,
        Pico,
        Quest2,
        WebAR,
        WebVR,
        Classic3D,
        Web3D
    }
}