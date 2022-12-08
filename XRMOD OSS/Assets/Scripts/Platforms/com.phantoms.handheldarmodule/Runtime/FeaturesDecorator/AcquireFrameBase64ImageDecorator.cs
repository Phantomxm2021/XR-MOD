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
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class AcquireFrameBase64ImageDecorator : AbstractDecorator
    {
        private readonly CpuImageDecorator cpuImageDecorator;
        private readonly GpuImageDecorator gpuImageDecorator;
        public Action<string> GotBase64Image;

        public AcquireFrameBase64ImageDecorator(
            CpuImageDecorator _cpuImageDecorator)
        {
            Assert.IsNotNull(_cpuImageDecorator);
            cpuImageDecorator = _cpuImageDecorator;
        }

        public AcquireFrameBase64ImageDecorator(
            GpuImageDecorator _gpuImageDecorator)
        {
            Assert.IsNotNull(_gpuImageDecorator);
            gpuImageDecorator = _gpuImageDecorator;
        }

        public override void StartAlgorithm()
        {
            if (!SupportThisFeature()) return;
            try
            {
                byte[] tmp_FrameBytes = null;
                if (cpuImageDecorator != null)
                {
                    cpuImageDecorator.StartAlgorithm();
                    var tmp_Texture = IocContainer.GetIoc.Resolve<ARContextDataModel>().FrameTexture.Value;
                    if (tmp_Texture == null) return;
                    tmp_FrameBytes = tmp_Texture.EncodeToJPG();
                }
                else
                {
                    gpuImageDecorator.StartAlgorithm();
                    tmp_FrameBytes = gpuImageDecorator.CameraTexture.EncodeToJPG();
                }

                if (tmp_FrameBytes == null) return;
                var tmp_ImageBase64 = Convert.ToBase64String(tmp_FrameBytes);
                if (string.IsNullOrEmpty(tmp_ImageBase64)) return;
                GotBase64Image?.Invoke(tmp_ImageBase64);
            }
            catch (OperationCanceledException tmp_Exception)
            {
                Debug.LogError(
                    $"{nameof(OperationCanceledException)} throw WithOperator message:{tmp_Exception.Message}");
            }
        }

        public override void PauseAlgorithm()
        {
            throw new NotImplementedException("This decorator can not paused!");
        }

        public override void StopAlgorithm()
        {
            GotBase64Image = null;
            cpuImageDecorator?.StopAlgorithm();
            gpuImageDecorator?.StopAlgorithm();
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return cpuImageDecorator?.SupportThisFeature() ?? gpuImageDecorator.SupportThisFeature();
        }
    }
}