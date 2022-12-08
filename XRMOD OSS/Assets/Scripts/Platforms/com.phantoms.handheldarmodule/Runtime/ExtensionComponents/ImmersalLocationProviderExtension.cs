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
using System.Collections;
using UnityEngine;
using Immersal;
#if UNITY_ANDROID
using UnityEngine.Android;

#endif
namespace HandheldARModule.Runtime.Extension
{
    public class ImmersalLocationProviderExtension : MonoBehaviour
    {
        public double latitude { get; private set; } = 0;
        public double longitude { get; private set; } = 0;
        public double altitude { get; private set; } = 0.0;

        private static ImmersalLocationProviderExtension INSTANCE;

        public Action StartGeolocationTracking;

        public bool gpsOn
        {
#if (UNITY_IOS || PLATFORM_ANDROID) && !UNITY_EDITOR
            get { return NativeBindings.LocationServicesEnabled(); }
#else
            get { return Input.location.status == LocationServiceStatus.Running; }
#endif
        }

        public static ImmersalLocationProviderExtension Instance
        {
            get
            {
#if UNITY_EDITOR
                if (INSTANCE == null && !Application.isPlaying)
                {
                    INSTANCE = UnityEngine.Object.FindObjectOfType<ImmersalLocationProviderExtension>();
                }
#endif
                if (INSTANCE == null)
                {
                    Debug.LogError("No LocationProvider instance found. Ensure one exists in the scene.");
                }

                return INSTANCE;
            }
        }


        void Awake()
        {
            if (INSTANCE == null)
            {
                INSTANCE = this;
            }

            if (INSTANCE != this)
            {
                Debug.LogError("There must be only one LocationProvider object in a scene.");
                UnityEngine.Object.DestroyImmediate(this);
                return;
            }
        }

        private void Start()
        {
#if UNITY_IOS
            StartCoroutine(EnableLocationServices());
#elif PLATFORM_ANDROID
            if (Permission.HasUserAuthorizedPermission(Permission.FineLocation))
            {
                Debug.Log("Location permission OK");
                StartCoroutine(EnableLocationServices());
            }
            else
            {
                Debug.Log("Requesting location permission");
                Permission.RequestUserPermission(Permission.FineLocation);
                StartCoroutine(WaitForLocationPermission());
            }
#endif
        }

        private void Update()
        {
            UpdateLocation();
        }

        private void UpdateLocation()
        {
            if (gpsOn)
            {
#if (UNITY_IOS || PLATFORM_ANDROID) && !UNITY_EDITOR
                latitude = NativeBindings.GetLatitude();
                longitude = NativeBindings.GetLongitude();
                altitude = NativeBindings.GetAltitude();
#else
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;
                altitude = Input.location.lastData.altitude;
#endif
            }
        }


#if PLATFORM_ANDROID
        private IEnumerator WaitForLocationPermission()
        {
            while (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
            {
                yield return null;
            }

            Debug.Log("Location permission OK");
            StartCoroutine(EnableLocationServices());
            yield return null;
        }
#endif

        private IEnumerator EnableLocationServices()
        {
            // First, check if user has location service enabled
            if (!Input.location.isEnabledByUser)
            {
                Debug.Log("Location services not enabled");
                yield break;
            }

            // Start service before querying location
#if (UNITY_IOS || PLATFORM_ANDROID) && !UNITY_EDITOR
            NativeBindings.StartLocation();
#else
            Input.location.Start(0.001f, 0.001f);
#endif
            // Wait until service initializes
            int tmp_MAXWait = 20;
#if (UNITY_IOS || PLATFORM_ANDROID) && !UNITY_EDITOR
            while (!NativeBindings.LocationServicesEnabled() && tmp_MAXWait > 0)
#else
            while (Input.location.status == LocationServiceStatus.Initializing && tmp_MAXWait > 0)
#endif
            {
                yield return new WaitForSeconds(1);
                tmp_MAXWait--;
            }

            // Service didn't initialize in 20 seconds
            if (tmp_MAXWait < 1)
            {
                Debug.Log("Timed out");
                yield break;
            }

            // Connection has failed
#if (UNITY_IOS || PLATFORM_ANDROID) && !UNITY_EDITOR
            if (!NativeBindings.LocationServicesEnabled())
#else
            if (Input.location.status == LocationServiceStatus.Failed)
#endif
            {
                Debug.Log("Unable to determine device location");
                yield break;
            }

#if (UNITY_IOS || PLATFORM_ANDROID) && !UNITY_EDITOR
            if (NativeBindings.LocationServicesEnabled())
#else
            if (Input.location.status == LocationServiceStatus.Running)
#endif
            {
                Debug.Log("Tracking geolocation");
                StartGeolocationTracking?.Invoke();
            }
        }
    }
}