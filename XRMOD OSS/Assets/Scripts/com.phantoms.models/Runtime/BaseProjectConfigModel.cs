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

using XRMODEngineCore.Runtime;
using XRMODEngineCore.Runtime.Enums;

namespace com.phantoms.models.Runtime
{
    public enum AlgorithmType:int
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

    public class BaseProjectConfigModel : IModel
    {
        public string ProjectName;

        //Base
        public SDKDeviceType SDKDeviceType = SDKDeviceType.HandheldAR;
        public string Version = "0.0.1";
        public AlgorithmType Algorithm;
        public bool AlgorithmAutoStart;


        //script
        public string MainEntry;
        public string DomainName;
        public ProgrammableType ProgrammableType;
        public string MainVisualScripting;
        public bool DebugModel;
        public JITFlags JitFlag = 0;


        //Graphics
        public int QualityLevel = 1;

        public bool PostProcessing;


        //Multiplayer
        public bool Multiplayer;
        public bool DisplayPing;
        public bool Discovery;


        //Recording
        public bool UseMediaRecorder = false;
        public bool UseMicrophone = false;
        public MediaResolution MediaResolution = MediaResolution.Normal;

        public virtual void Initialize()
        {
        }
    }
}