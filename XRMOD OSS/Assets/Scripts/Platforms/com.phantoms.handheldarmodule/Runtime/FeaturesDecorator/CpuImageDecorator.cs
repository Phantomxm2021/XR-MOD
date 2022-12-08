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

using System;
using HandheldARModule.Runtime.Utility;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class CpuImageDecorator : AbstractDecorator
    {
        //public Texture2D CameraTexture { get; private set; }
        private readonly ARCameraManager cameraManager;
        private readonly ConversionType conversionType;
        private readonly TextureFormat textureFormat;
        private ARContextDataModel arContextData;
        private bool inProcessing;

        public CpuImageDecorator()
        {
            ARComponentModel tmp_ARComponentModel = IocContainer.GetIoc.Resolve<ARComponentModel>();
            cameraManager = tmp_ARComponentModel.ARCameraManager;

            arContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            conversionType = arContextData.ConversionType;
            textureFormat = arContextData.TextureFormat;
        }

        public override void StartAlgorithm()
        {
            if (!IsValid())
            {
                Debug.LogWarning("Start Algorithm failed");
                return;
            }

            if (!cameraManager.enabled)
                cameraManager.enabled = true;

            if (!cameraManager.subsystem.running)
                cameraManager.subsystem.Start();

            switch (conversionType)
            {
                case ConversionType.Synchronous:
                    SynchronouslyGetImage();
                    break;
                case ConversionType.Asynchronous:
                    AsynchronouslyGetImage();
                    break;
            }
        }

        public override void PauseAlgorithm()
        {
            if (!arContextData.FrameTexture.Value) return;
            Object.DestroyImmediate(arContextData.FrameTexture.Value, true);
            arContextData.FrameTexture.Value = null;
        }

        public override void StopAlgorithm()
        {
            if (!arContextData.FrameTexture.Value) return;
            Object.DestroyImmediate(arContextData.FrameTexture.Value, true);
            arContextData.FrameTexture.Value = null;
        }

        private bool IsValid()
        {
            return cameraManager && cameraManager.subsystem != null;
        }

        public override bool SupportThisFeature()
        {
#if !UNITY_EDITOR
            return cameraManager.descriptor.supportsCameraImage;
#else
            return false;
#endif
        }

        unsafe void SynchronouslyGetImage()
        {
            if (!cameraManager.TryAcquireLatestCpuImageVersionAgnostic(out XRCpuImage tmp_Image))
                return;
            var tmp_ConversionParams = new XRCpuImage.ConversionParams
            {
                // Get the entire image.
                inputRect = new RectInt(0, 0, tmp_Image.width, tmp_Image.height),

#if UNITY_ANDROID
                outputDimensions = new Vector2Int(tmp_Image.width, tmp_Image.height),
#else
                // Downsample by 2.
                outputDimensions = new Vector2Int(tmp_Image.width / 2, tmp_Image.height / 2),
#endif

                // Choose RGBA format.
#if UNITY_ANDROID
                outputFormat = TextureFormat.RGBA32,
#else
                outputFormat = textureFormat,
#endif


                // Flip across the vertical axis (mirror image).
                transformation = XRCpuImage.Transformation.MirrorY
            };

            if (arContextData.FrameTexture.Value == null)
                arContextData.FrameTexture.Value = new Texture2D(
                    tmp_ConversionParams.outputDimensions.x,
                    tmp_ConversionParams.outputDimensions.y,
                    tmp_ConversionParams.outputFormat,
                    false);
            var tmp_RawTextureData = arContextData.FrameTexture.Value.GetRawTextureData<byte>();


            try
            {
                tmp_Image.Convert(tmp_ConversionParams, new IntPtr(tmp_RawTextureData.GetUnsafePtr()),
                    tmp_RawTextureData.Length);
            }
            finally
            {
                // We must dispose of the XRCpuImage after we're finished
                // with it to avoid leaking native resources.
                tmp_Image.Dispose();
            }

            arContextData.FrameTexture.Value.Apply();
        }


        private void AsynchronouslyGetImage()
        {
            //Do not start processing a CPU image until the previous one is finished.
            if (inProcessing) return;
            inProcessing = true;

            if (!cameraManager.TryAcquireLatestCpuImage(out XRCpuImage tmp_Image))
            {
                return;
            }

            tmp_Image.ConvertAsync(new XRCpuImage.ConversionParams
            {
                inputRect = new RectInt(0, 0, tmp_Image.width, tmp_Image.height),
                outputDimensions = new Vector2Int(tmp_Image.width / 2, tmp_Image.height / 2),
                outputFormat = textureFormat,
                transformation = XRCpuImage.Transformation.MirrorY
            }, ProcessImage);
            tmp_Image.Dispose();
        }

        private void ProcessImage(XRCpuImage.AsyncConversionStatus _status,
            XRCpuImage.ConversionParams _conversionParams, NativeArray<byte> _data)
        {
            if (_status != XRCpuImage.AsyncConversionStatus.Ready)
            {
                Debug.LogErrorFormat("Async request failed with status {0}", _status);
                return;
            }

            if (arContextData.FrameTexture.Value == null)
            {
                arContextData.FrameTexture.Value = new Texture2D(_conversionParams.outputDimensions.x,
                    _conversionParams.outputDimensions.y, _conversionParams.outputFormat, false);
            }


            arContextData.FrameTexture.Value.LoadRawTextureData(data: _data);
            arContextData.FrameTexture.Value.Apply(false);
            inProcessing = false;
        }
    }
}