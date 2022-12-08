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

using HandheldARModule.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class GpuImageDecorator : AbstractDecorator
    {
        private RenderTexture renderTexture;
        public Texture2D CameraTexture { get; private set; }
        private Material camBackgroundMat;

        public GpuImageDecorator(){
            renderTexture = new RenderTexture(Screen.width / 2, Screen.height / 2, 0);
            camBackgroundMat = IocContainer.GetIoc.Resolve<ARComponentModel>().ARCameraBackground.material;
        }

        public override void StartAlgorithm()
        {
            BlitGraph();
        }

        public override void PauseAlgorithm()
        {
        }

        public override void StopAlgorithm()
        {
            if (renderTexture)
            {
                Object.DestroyImmediate(renderTexture, true);
                renderTexture = null;
            }

            if (CameraTexture)
            {
                Object.DestroyImmediate(CameraTexture, true);
                CameraTexture = null;
            }

            if (camBackgroundMat)
            {
                Object.DestroyImmediate(camBackgroundMat, true);
                camBackgroundMat = null;
            }
        }


        private void BlitGraph()
        {
            Graphics.Blit(null, renderTexture, camBackgroundMat);
            var tmp_ActiveRenderTexture = RenderTexture.active;
            RenderTexture.active = renderTexture;
            if (CameraTexture == null)
                CameraTexture =
                    new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.Alpha8, false);
            CameraTexture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
            CameraTexture.Apply();
            RenderTexture.active = tmp_ActiveRenderTexture;
        }
    }
}