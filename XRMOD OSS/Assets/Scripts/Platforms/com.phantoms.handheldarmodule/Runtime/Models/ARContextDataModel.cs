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

using HandheldARModule.Runtime.FeaturesDecorator;
using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Models
{
    public class ARContextDataModel : IModel, IReleaseCommand
    {
        public BindableProperty<bool> ARAvailability { get; private set; }
        public BindableProperty<ARSessionState> ARSessionState { get; private set; }

        public BindableProperty<bool> EnableHDR { get; private set; }

        public ImmersalContextDataModel ImmersalParameters { get; set; }

        public XRReferenceImageLibrary ReferenceImageLibrary { get; set; }

        public BindableProperty<Texture2D> FrameTexture { get; private set; }

        public BindableProperty<string> OnMarkerRecognized;

        public BindableProperty<AbstractDecorator> FrameGetter;
        public GameObject PlaneVisualizer { get; set; }

        public GameObject PointCloudVisualizer { get; set; }

        public PlaneDetectionMode PlaneDetectionMode { get; set; }

        public ConversionType ConversionType { get; set; }

        public TextureFormat TextureFormat { get; set; }

        public bool StopARModule { get; set; }

        public bool IsARCollaborationAvailability = false;
        public bool ARKitCoachingOverlayAvailability = false;

        public string ARKitWordMapSavePath = $"{Application.temporaryCachePath}/ARKitWordMap.bytes";

        public ARContextDataModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            FrameGetter = new BindableProperty<AbstractDecorator>();
            OnMarkerRecognized = new BindableProperty<string>();
            FrameTexture = new BindableProperty<Texture2D>();
            ARAvailability = new BindableProperty<bool>();
            EnableHDR = new BindableProperty<bool>();
            ARSessionState = new BindableProperty<ARSessionState>();
        }

        public void Release()
        {
            ARAvailability.OnValueChanged = null;
            EnableHDR.OnValueChanged = null;
            ARSessionState.OnValueChanged = null;
            FrameGetter.OnValueChanged = null;
            OnMarkerRecognized.OnValueChanged = null;

            ImmersalParameters = null;
            ReferenceImageLibrary = null;

            StopARModule = false;
            //ProjectUid = null;
        }
    }
}