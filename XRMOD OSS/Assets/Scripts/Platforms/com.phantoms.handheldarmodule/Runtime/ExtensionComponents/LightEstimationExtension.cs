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
using UnityEngine.Rendering;
using UnityEngine.XR.ARFoundation;

namespace HandheldARModule.Runtime.Extension
{
    /// <summary>
    /// A component that can be used to access the most
    /// recently received light estimation information
    /// for the physical environment as observed by an
    /// AR device.
    /// </summary>
    [RequireComponent(typeof(Light))]
    public class LightEstimationExtension : MonoBehaviour
    {
        public ARCameraManager CameraManager;
        public Light LightSystem { get; private set; }

        /// <summary>
        /// Get or set the <c>ARCameraManager</c>.
        /// </summary>
        public ARCameraManager GetCameraManager
        {
            get => CameraManager;
            set
            {
                if (CameraManager == value)
                    return;

                if (CameraManager != null)
                    CameraManager.frameReceived -= FrameChanged;

                CameraManager = value;

                if (CameraManager != null & enabled)
                    CameraManager.frameReceived += FrameChanged;
            }
        }

        /// <summary>
        /// The estimated brightness of the physical environment, if available.
        /// </summary>
        public float? Brightness { get; private set; }

        /// <summary>
        /// The estimated color temperature of the physical environment, if available.
        /// </summary>
        public float? ColorTemperature { get; private set; }

        /// <summary>
        /// The estimated color correction value of the physical environment, if available.
        /// </summary>
        public Color? ColorCorrection { get; private set; }

        /// <summary>
        /// The estimated direction of the main light of the physical environment, if available.
        /// </summary>
        public Vector3? MainLightDirection { get; private set; }

        /// <summary>
        /// The estimated color of the main light of the physical environment, if available.
        /// </summary>
        public Color? MainLightColor { get; private set; }

        /// <summary>
        /// The estimated intensity in lumens of main light of the physical environment, if available.
        /// </summary>
        public float? MainLightIntensityLumens { get; private set; }

        /// <summary>
        /// The estimated spherical harmonics coefficients of the physical environment, if available.
        /// </summary>
        public SphericalHarmonicsL2? SphericalHarmonics { get; private set; }

        void Awake()
        {
            LightSystem = GetComponent<Light>();
            LightSystem.type = LightType.Directional;
            LightSystem.shadows = LightShadows.Soft;
            LightSystem.transform.rotation = Quaternion.Euler(50, -30, 0);
        }

        void OnEnable()
        {
            if (CameraManager != null)
                CameraManager.frameReceived += FrameChanged;
        }

        void OnDisable()
        {
            if (CameraManager != null)
                CameraManager.frameReceived -= FrameChanged;
        }


        private void OnDestroy()
        {
            Destroy(LightSystem);
        }

        void FrameChanged(ARCameraFrameEventArgs _args)
        {
            if (_args.lightEstimation.averageBrightness.HasValue)
            {
                Brightness = _args.lightEstimation.averageBrightness.Value;
                LightSystem.intensity = Brightness.Value;
            }
            else
            {
                Brightness = null;
            }

            if (_args.lightEstimation.averageColorTemperature.HasValue)
            {
                ColorTemperature = _args.lightEstimation.averageColorTemperature.Value;
                LightSystem.colorTemperature = ColorTemperature.Value;
            }
            else
            {
                ColorTemperature = null;
            }

            if (_args.lightEstimation.colorCorrection.HasValue)
            {
                ColorCorrection = _args.lightEstimation.colorCorrection.Value;
                LightSystem.color = ColorCorrection.Value;
            }
            else
            {
                ColorCorrection = null;
            }

            if (_args.lightEstimation.mainLightDirection.HasValue)
            {
                MainLightDirection = _args.lightEstimation.mainLightDirection;
                LightSystem.transform.rotation = Quaternion.LookRotation(MainLightDirection.Value);
            }
            else
            {
                MainLightDirection = null;
            }

            if (_args.lightEstimation.mainLightColor.HasValue)
            {
                MainLightColor = _args.lightEstimation.mainLightColor;
                LightSystem.color = MainLightColor.Value;
            }
            else
            {
                MainLightColor = null;
            }

            if (_args.lightEstimation.mainLightIntensityLumens.HasValue)
            {
                MainLightIntensityLumens = _args.lightEstimation.mainLightIntensityLumens;
                if (_args.lightEstimation.averageMainLightBrightness != null)
                    LightSystem.intensity = _args.lightEstimation.averageMainLightBrightness.Value;
            }
            else
            {
                MainLightIntensityLumens = null;
            }

            if (_args.lightEstimation.ambientSphericalHarmonics.HasValue)
            {
                SphericalHarmonics = _args.lightEstimation.ambientSphericalHarmonics;
                RenderSettings.ambientMode = AmbientMode.Skybox;
                RenderSettings.ambientProbe = SphericalHarmonics.Value;
            }
            else
            {
                SphericalHarmonics = null;
            }
        }
    }
}