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

using com.phantoms.models.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class WebcamDecorator : AbstractDecorator
    {
        public Texture2D CameraTexture { get; private set; }
        private WebCamTexture webCamTexture;
        private Color32[] webCamTextureFrameColors;

        private readonly RawImage previewRawImage;
        private readonly GameObject nativeComponents;


        public WebcamDecorator()
        {
            //Init scene
            var tmp_NativeComponentsPrefab = Resources.Load<GameObject>("Prefabs/NativeComponents");
            nativeComponents = Object.Instantiate(tmp_NativeComponentsPrefab, Vector3.zero, Quaternion.identity);
            var tmp_AspectRatioFitter = nativeComponents.GetComponentInChildren<AspectRatioFitter>();
            previewRawImage = nativeComponents.GetComponentInChildren<RawImage>();
            previewRawImage.color = Color.black;

            //Init webcam
            webCamTexture = new WebCamTexture(720, 1280, 30);
            tmp_AspectRatioFitter.aspectRatio = (float) webCamTexture.requestedHeight / webCamTexture.requestedWidth;
            webCamTextureFrameColors = new Color32[webCamTexture.requestedWidth * webCamTexture.requestedHeight];
            CameraTexture = new Texture2D(webCamTexture.requestedHeight, webCamTexture.requestedWidth,
                TextureFormat.RGB24, false);
            previewRawImage.texture = webCamTexture;
            previewRawImage.color = Color.white;


            //Fixed preview texture orientation
            var tmp_RectTransform = previewRawImage.rectTransform;
            tmp_RectTransform.localRotation = Quaternion.Euler(0, 0, 90);
            tmp_RectTransform.localScale = new Vector3(-1, -1, 1);


            //Start webcam
            webCamTexture.Play();
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            webCamTextureFrameColors = webCamTexture.GetPixels32();
            CameraTexture.SetPixels32(webCamTextureFrameColors, 0);
            CameraTexture.Apply(false);
            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;
            webCamTextureFrameColors = null;

            if (webCamTexture)
            {
                webCamTexture.Stop();
                webCamTexture.DestroyWithPlatform();
                webCamTexture = null;
            }

            if (CameraTexture)
                CameraTexture.DestroyWithPlatform();


            if (previewRawImage)
                previewRawImage.texture = null;

            if (nativeComponents)
                nativeComponents.DestroyWithPlatform();
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return webCamTexture.deviceName != null;
        }
    }
}