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


namespace com.Phantoms.ActionNotification.Runtime
{
    public enum ActionParameterDataType
    {
        OnFocusStateChange,
        ImageStateChange,
        ReleaseMemory,
        OnUpdate,
        OnLoad,
        OnEvent,
        InitMonoScripts,
        StickObject,
        SetFocusAlgorithmState,
        OpenBuiltInBrowser,
        Exit,
        TryAcquireAppInfo,
        TryAcquireCurrentFrame,
        TryAcquireAROcclusionFrame,
        TryAcquireSDKVersion,
        TryAcquireProjectInfo,
        TryAcquireLightEstimateValue,
        TryAcquireNetworkMesh,
        CheckARAvailability,
        CheckARFeaturesAvailability,
        ARAlgorithmLifeCTRL,
        TryAcquireLoadObject,
        ResizeARWorldScale,
        ImmersalLocalizer,
        Instantiate,
        OnMultiplayerEvent,
        MakeContentAppearAt,
        AlignWorldOriginByImageTrack,
        ARRaycast,
        StartVideoRecording,
        StopVideoRecording,
        TakePhoto,
        TryAcquireTemporaryCachePath,
        TryAcquireSdkType,
        TryAcquireCustomConfig,
        OnXRDataGot,
        FetchProjectDetail,
        DownloadMesh,

        /// <summary>
        /// Call this method when the immersal map was
        /// load into the memory and starting localizing
        /// </summary>
        OnImmersalMapRegister,
        SendMessageToSDK,
#if UNITY_IOS
        /// <summary>
        /// Send the notification message to
        /// trigger the  `load the AR word map` method
        /// </summary>
        LoadARWordMap,

        /// <summary>
        /// Send the notification message to
        /// trigger the `save the AR word map` method
        /// </summary>
        SaveARWordMap,
#endif
    }
}