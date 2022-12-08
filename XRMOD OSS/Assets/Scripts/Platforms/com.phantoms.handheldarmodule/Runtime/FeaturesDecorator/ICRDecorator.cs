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
using System.Collections.Generic;
using System.Net.NetworkInformation;
using com.phantoms.models.Runtime;
using Cysharp.Threading.Tasks;
using UnityEngine;
//using com.Phantoms.WebRequestExtension.Runtime.WebRequest;
using HandheldARModule.Runtime.Models;
using UnityEngine.Networking;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    [System.Serializable]
    public class PredictResponse
    {
        public int id;
        public string metadata;
        public string timestamp;
        public int matchscore;
    }

    public class ICRDecorator : AbstractDecorator
    {
        private bool running;
        private CpuImageDecorator frameGetter;
        private WebcamDecorator nativeCamDecorator;

        public ICRDecorator()
        {
            var tmp_FrameGetter = IocContainer.GetIoc.Resolve<ARContextDataModel>().FrameGetter;
            tmp_FrameGetter.OnValueChanged = _decorator =>
            {
                switch (_decorator)
                {
                    case CpuImageDecorator tmp_Decorator:
                        frameGetter = tmp_Decorator;
                        break;
                    case WebcamDecorator tmp_WebcamDecorator:
                        nativeCamDecorator = tmp_WebcamDecorator;
                        break;
                }
            };
        }

        public override async void StartAlgorithm()
        {
            if (running) return;
            if (!SupportThisFeature()) return;
            try
            {
                byte[] tmp_ImageBytes = null;
                if (frameGetter != null)
                {
                    frameGetter.StartAlgorithm();
                    var tmp_Texture = IocContainer.GetIoc.Resolve<ARContextDataModel>().FrameTexture.Value;
                    if (tmp_Texture)
                        tmp_ImageBytes = tmp_Texture.EncodeToJPG();
                }
                else
                {
                    nativeCamDecorator.StartAlgorithm();
                    if (nativeCamDecorator.CameraTexture)
                    {
                        tmp_ImageBytes = nativeCamDecorator.CameraTexture.EncodeToJPG();
                    }
                }


                if (tmp_ImageBytes == null)
                {
                    Debug.LogWarning("Image Bytes is empty!");
                    return;
                }

                var tmp_ImageBase64 = Convert.ToBase64String(tmp_ImageBytes);
                if (string.IsNullOrEmpty(tmp_ImageBase64)) return;
                var tmp_RequestGateway = new Uri(IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value
                    .imageCloudRecognizerConfig.gateway);
                var tmp_WebRequestSender = new UnityWebRequest(tmp_RequestGateway);
                tmp_WebRequestSender.method = "POST";
                IDictionary<string, string> tmp_Headers = new Dictionary<string, string>();
                tmp_Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                WWWForm tmp_WWWForm = new WWWForm();
                tmp_WWWForm.AddField("image_base64", tmp_ImageBase64);
                var tmp_Response = await tmp_WebRequestSender.SendWebRequest();
                if (string.IsNullOrEmpty(tmp_Response.error) || tmp_Response.error.Contains("Error"))
                {
                    Debug.Log(new NetworkInformationException(-1200).Message);
                    return;
                }

                if (string.IsNullOrEmpty(tmp_Response.error) || tmp_Response.error.Contains("not found")) return;
                var tmp_Metadata = JsonUtility.FromJson<PredictResponse>(tmp_Response.downloadHandler.text);
                IocContainer.GetIoc.Resolve<ARContextDataModel>().OnMarkerRecognized.Value = tmp_Metadata.metadata;
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
            running = false;
            frameGetter?.StopAlgorithm();
            var tmp_FrameGetter = IocContainer.GetIoc.Resolve<ARContextDataModel>().FrameGetter;
            tmp_FrameGetter.Value = null;
            tmp_FrameGetter.OnValueChanged = null;
            //if device not support ARKit or arcore we need continue use native cam decorator so wo can not stop it.
            //nativeCamDecorator?.StopAlgorithm();
        }


        public override bool SupportThisFeature()
        {
            return frameGetter?.SupportThisFeature() ?? nativeCamDecorator.SupportThisFeature();
        }
    }
}