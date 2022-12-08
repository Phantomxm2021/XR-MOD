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
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Utility
{
    public class ARAlgorithmUtility : IReleaseCommand, IUtility
    {
        /// <summary>
        /// CPU image holder
        /// </summary>
        private static Dictionary<OcclusionDataType, Texture2D> _TEXTURE_2DS = new();


        public bool ARAvailability()
        {
            switch (Application.platform)
            {
                case RuntimePlatform.Android:
                case RuntimePlatform.IPhonePlayer:
                    return ARSession.state is ARSessionState.Ready
                        or ARSessionState.SessionTracking
                        or ARSessionState.SessionInitializing;
                default: return false;
            }
        }

        /// <summary>
        /// Detect the AR algorithm supported by the current device
        /// </summary>
        /// <param name="_featureName">feature name of AR algorithm</param>
        /// <returns>True:Available,False:Unavailable</returns>
        public bool FeatureAvailability(string _featureName)
        {
            var tmp_RayCastDescriptors = new List<XRRaycastSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_RayCastDescriptors);
            var tmp_FaceDescriptors = new List<XRFaceSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_FaceDescriptors);

            var tmp_ImageDescriptors = new List<XRImageTrackingSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_ImageDescriptors);

            var tmp_EnvDescriptors = new List<XREnvironmentProbeSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_EnvDescriptors);

            var tmp_AnchorDescriptors = new List<XRAnchorSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_AnchorDescriptors);

            var tmp_ObjectDescriptors = new List<XRObjectTrackingSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_ObjectDescriptors);

            var tmp_ParticipantDescriptors = new List<XRParticipantSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_ParticipantDescriptors);

            var tmp_DepthDescriptors = new List<XRPointCloudSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_DepthDescriptors);

            var tmp_OcclusionDescriptors = new List<XROcclusionSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_OcclusionDescriptors);

            var tmp_CameraDescriptors = new List<XRCameraSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_CameraDescriptors);

            var tmp_SessionDescriptors = new List<XRSessionSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_SessionDescriptors);

            var tmp_BodyTrackingDescriptors = new List<XRHumanBodySubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_BodyTrackingDescriptors);

            var tmp_PlaneDescriptors = new List<XRPlaneSubsystemDescriptor>();
            SubsystemManager.GetSubsystemDescriptors(tmp_PlaneDescriptors);
            switch (_featureName)
            {
                case "SimpleAR":
                    if (tmp_PlaneDescriptors.Count > 0 && tmp_RayCastDescriptors.Count > 0)
                        return true;
                    break;
                case "ImageTracking":
                    if (tmp_ImageDescriptors.Count > 0) return true;
                    break;
                case "Anchors":
                    if (tmp_AnchorDescriptors.Count > 0) return true;
                    break;
                case "CpuImages":
                    if (tmp_CameraDescriptors.Count > 0) return true;
                    break;
                case "EnvironmentProbes":
                    if (tmp_EnvDescriptors.Count > 0) return true;
                    break;
                case "ARCollaborationData":
                    return IocContainer.GetIoc.Resolve<ARContextDataModel>().IsARCollaborationAvailability;
                case "ARKitCoachingOverlay":
                    return IocContainer.GetIoc.Resolve<ARContextDataModel>().IsARCollaborationAvailability;
                case "ObjectTracking":
                    if (tmp_ObjectDescriptors.Count > 0) return true;

                    break;
                case "FaceTracking":
                    if (tmp_FaceDescriptors.Count > 0) return true;
                    break;
                case "BodyTracking":
                    if (tmp_BodyTrackingDescriptors.Count > 0) return true;

                    break;
                case "BasicLightEstimation":
                    foreach (var tmp_CameraDescriptor in tmp_CameraDescriptors)
                    {
                        if (tmp_CameraDescriptor.supportsFaceTrackingHDRLightEstimation ||
                            tmp_CameraDescriptor.supportsWorldTrackingHDRLightEstimation)
                        {
                            return true;
                        }
                    }

                    break;
                case "HDRLightEstimation":
                    foreach (var tmp_CameraDescriptor in tmp_CameraDescriptors)
                    {
                        if ((tmp_CameraDescriptor.supportsAverageBrightness ||
                             tmp_CameraDescriptor.supportsAverageIntensityInLumens) &&
                            (tmp_CameraDescriptor.supportsAverageColorTemperature ||
                             tmp_CameraDescriptor.supportsColorCorrection) &&
                            tmp_CameraDescriptor.supportsCameraConfigurations &&
                            tmp_CameraDescriptor.supportsCameraImage)
                        {
                            return true;
                        }
                    }

                    break;
                case "PlaneClassification":
                    foreach (var tmp_PlaneDescriptor in tmp_PlaneDescriptors)
                    {
                        if (tmp_PlaneDescriptor.supportsClassification)
                        {
                            return true;
                        }
                    }

                    break;
                case "Meshing":
                    var activeLoader = LoaderUtility.GetActiveLoader();
                    if (activeLoader && activeLoader.GetLoadedSubsystem<XRMeshSubsystem>() != null)
                    {
                        return true;
                    }

                    break;
                case "Depth":
                    if (tmp_OcclusionDescriptors.Count > 0)
                    {
                        foreach (var tmp_OcclusionDescriptor in tmp_OcclusionDescriptors)
                        {
                            return tmp_OcclusionDescriptor.environmentDepthImageSupported == Supported.Supported
                                   || tmp_OcclusionDescriptor.humanSegmentationDepthImageSupported ==
                                   Supported.Supported
                                   || tmp_OcclusionDescriptor.humanSegmentationStencilImageSupported ==
                                   Supported.Supported;
                        }
                    }

                    break;

                case "ThermalState":
                    return Application.platform == RuntimePlatform.IPhonePlayer;
            }

            return false;
        }


        /// <summary>
        /// Acquire the AR frame texture from XRCpuImage
        /// </summary>
        /// <param name="_cpuImage">ARFoundation cpu image</param>
        /// <param name="_type"></param>
        /// <returns>AR frame texture</returns>
        public Texture2D CreateTextureFromARFrame(XRCpuImage _cpuImage, OcclusionDataType _type)
        {
            if (!_TEXTURE_2DS.TryGetValue(_type, out var tmp_PreviewT2d))
            {
                // If the texture hasn't yet been created, or if its dimensions have changed, (re)create the texture.
                // Note: Although texture dimensions do not normally change frame-to-frame, they can change in response to
                //    a change in the camera resolution (for camera images) or changes to the quality of the human depth
                //    and human stencil buffers.
                tmp_PreviewT2d = new Texture2D(_cpuImage.width, _cpuImage.height, _cpuImage.format.AsTextureFormat(),
                    false);
                _TEXTURE_2DS.Add(_type, tmp_PreviewT2d);
            }


            // For display, we need to mirror about the vertical access.
            var tmp_ConversionParams = new XRCpuImage.ConversionParams(_cpuImage, _cpuImage.format.AsTextureFormat(),
                XRCpuImage.Transformation.MirrorY);

            // Get the Texture2D's underlying pixel buffer.
            var tmp_RawTextureData = tmp_PreviewT2d.GetRawTextureData<byte>();

            // Make sure the destination buffer is large enough to hold the converted data (they should be the same size)
            Debug.Assert(
                tmp_RawTextureData.Length ==
                _cpuImage.GetConvertedDataSize(tmp_ConversionParams.outputDimensions,
                    tmp_ConversionParams.outputFormat),
                "The Texture2D is not the same size as the converted data.");

            // Perform the conversion.
            _cpuImage.Convert(tmp_ConversionParams, tmp_RawTextureData);

            // "Apply" the new pixel data to the Texture2D.
            tmp_PreviewT2d.Apply();
            return tmp_PreviewT2d;
        }

        public void Release()
        {
            foreach (KeyValuePair<OcclusionDataType, Texture2D> tmp_Texture2D in _TEXTURE_2DS)
            {
                tmp_Texture2D.Value.DestroyWithPlatform();
            }

            _TEXTURE_2DS.Clear();
        }
    }
}