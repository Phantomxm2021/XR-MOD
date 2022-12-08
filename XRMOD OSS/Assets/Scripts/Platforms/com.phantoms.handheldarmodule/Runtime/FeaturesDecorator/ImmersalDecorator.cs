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

#if ENABLE_IMMERSAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandheldARModule.Runtime.Models;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Extension;
using Immersal;
using Immersal.AR;
using Immersal.REST;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using XRMODEngineCore.Runtime;
using LocalizerPose = com.Phantoms.ActionNotification.Runtime.LocalizerPose;
using Object = UnityEngine.Object;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class ImmersalDecorator : AbstractDecorator
    {
        private GameObject immersalGameObject;
        private ImmersalLocationProviderExtension locationProvider;

        private ImmersalSDK immersalSDK;
        private ARLocalizer arLocalizer;

        private Dictionary<int, ARMap> arMaps = new();
        private IDictionary<int, SDKJob> maps;
        private List<Task> jobs;
        private bool wasPaused;

        //private int jobLock = 0;

        private LocalizerPose localizerPose;
        private ImmersalNotificationData immersalNotificationData;
        private ARContextDataModel arContextData;

        public ImmersalDecorator()
        {
            arContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();

            //arMaps = new List<ARMap>();
            maps = new Dictionary<int, SDKJob>();
            jobs = new List<Task>();

            immersalGameObject = Object.Instantiate(Resources.Load<GameObject>("Prefabs/ImmersalSDK"));

            Assert.IsNotNull(immersalGameObject);
            immersalSDK = immersalGameObject.GetComponent<ImmersalSDK>();
            immersalSDK.enabled = false;

            if (!immersalGameObject.TryGetComponent(out arLocalizer))
            {
                arLocalizer = immersalGameObject.AddComponent<ARLocalizer>();
            }

            arLocalizer.enabled = false;

            // rmeoved on Immersal sdk 1.17.0
            //immersalSDK.Localizer = arLocalizer;

            if (arContextData.ImmersalParameters.UseServerLocalizer)
            {
                locationProvider = immersalGameObject.AddComponent<ImmersalLocationProviderExtension>();
                locationProvider.StartGeolocationTracking = GetMaps;
            }

            immersalSDK.onPoseFound = new UnityEvent();
            immersalSDK.onPoseFound.AddListener(OnPoseFound);
            immersalSDK.onPoseLost = new UnityEvent();
            immersalSDK.onPoseLost.AddListener(OnPoseLose);


            arLocalizer.OnPoseFound += OnLocalizerPoseFound;
            arLocalizer.OnMapChanged += OnMapChanged;
            arLocalizer.OnReset += OnReset;


            immersalSDK.developerToken = arContextData.ImmersalParameters.DeveloperToken;
            arLocalizer.autoStart = arContextData.ImmersalParameters.AutoStart;
            arLocalizer.burstMode = arContextData.ImmersalParameters.BurstMode;
            arLocalizer.localizationInterval = arContextData.ImmersalParameters.LocalizationInterval;
            arLocalizer.useServerLocalizer = arContextData.ImmersalParameters.UseServerLocalizer;
            arLocalizer.useFiltering = arContextData.ImmersalParameters.UseFiltering;
            arLocalizer.resetOnMapChange =arContextData.ImmersalParameters.ResetOnMapChange;
            //Prevent the resource from registering event listeners for loading before completion,
            //resulting in failure to respond

            ActionNotificationCenter.DefaultCenter.AddObserver(OnImmersalMapRegister,
                nameof(ActionParameterDataType.OnImmersalMapRegister));

            ActionNotificationCenter.DefaultCenter.AddObserver(Localize,
                nameof(ActionParameterDataType.ImmersalLocalizer));


            localizerPose = new LocalizerPose();
            immersalNotificationData = new ImmersalNotificationData();
        }


        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            immersalSDK.enabled = true;
            arLocalizer.enabled = true;
            if (wasPaused && arContextData.ImmersalParameters.AutoStart)
            {
                arLocalizer.autoStart = arContextData.ImmersalParameters.AutoStart;
                wasPaused = false;
                return;
            }

            if (arContextData.ImmersalParameters.UseServerLocalizer)
            {
                GetMaps();
                return;
            }


            if (arContextData.ImmersalParameters.AutoStart)
                arLocalizer.StartLocalizing();

            hasStarted = true;
        }

        private void OnImmersalMapRegister(BaseNotificationData _obj)
        {
            foreach (ARMap tmp_ARMap in Object.FindObjectsOfType<ARMap>())
            {
                if (!arMaps.TryAdd(tmp_ARMap.mapId, tmp_ARMap)) continue;
                tmp_ARMap.OnFirstLocalization ??= new MapLocalizedEvent();
                tmp_ARMap.OnFirstLocalization.AddListener(OnFirstLocalization);
            }
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;
            arLocalizer.enabled = false;
            immersalSDK.enabled = false;

            foreach (var tmp_Map in arMaps)
            {
                tmp_Map.Value.enabled = false;
            }

            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;

            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .OnImmersalMapRegister));

            if (arContextData.ImmersalParameters.UseServerLocalizer)
            {
                StopOnServerLocalizer();
                maps.Clear();
            }

            if (arLocalizer)
            {
                arLocalizer.OnPoseFound -= OnLocalizerPoseFound;
                arLocalizer.OnMapChanged -= OnMapChanged;
                arLocalizer.OnReset -= OnReset;

                arLocalizer.StopLocalizing();
                arLocalizer.StopAllCoroutines();

                arLocalizer.enabled = false;
            }

            if (immersalSDK)
            {
                immersalSDK.onPoseFound.RemoveAllListeners();
                immersalSDK.onPoseLost.RemoveAllListeners();
                immersalSDK.onPoseLost = null;
                immersalSDK.onPoseFound = null;
                immersalSDK.enabled = false;
                immersalSDK.developerToken = null;
                immersalGameObject.DestroyWithPlatform();
            }

            foreach (var tmp_Map in arMaps)
            {
                if (tmp_Map.Value == null) continue;
                tmp_Map.Value.OnFirstLocalization.RemoveAllListeners();
                tmp_Map.Value.OnFirstLocalization = null;
                tmp_Map.Value.FreeMap(true);
            }

            immersalNotificationData = null;

            ARMap.mapHandleToMap.Clear();
            ARSpace.spaceToTransform.Clear();
            ARSpace.transformToSpace.Clear();
            ARSpace.mapIdToMap.Clear();
            ARSpace.mapIdToOffset.Clear();

            arMaps.Clear();
            jobs.Clear();
            if (!arContextData.ImmersalParameters.AutoStart)
                ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                    .ImmersalLocalizer));
            hasStarted = false;
        }


        private void OnFirstLocalization(int _id)
        {
            immersalNotificationData.MapId = _id;
            immersalNotificationData.ActionName = nameof(OnFirstLocalization);
            immersalNotificationData.ImmersalEventType =
                ImmersalNotificationData.ImmersalEventTypes.OnFirstLocalization;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                immersalNotificationData);

            //To pause the localization
            if (!arContextData.ImmersalParameters.StopLocalizedAfterSuccess) return;
            arLocalizer.autoStart = false;
            arLocalizer.StopLocalizing();
            wasPaused = true;
        }

        private void OnLocalizerPoseFound(Immersal.AR.LocalizerPose _pose)
        {
            localizerPose.matrix = _pose.matrix;
            localizerPose.valid = _pose.valid;
            localizerPose.vAltitude = _pose.vAltitude;
            localizerPose.vLatitude = _pose.vLatitude;
            localizerPose.lastUpdatedPose = _pose.lastUpdatedPose;
            localizerPose.mapToEcef = _pose.mapToEcef;

            immersalNotificationData.LocalizerPose = localizerPose;
            immersalNotificationData.ActionName = nameof(OnLocalizerPoseFound);
            immersalNotificationData.ImmersalEventType =
                ImmersalNotificationData.ImmersalEventTypes.OnLocalizerPoseFound;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                immersalNotificationData);
        }

        private void StartOnServerLocalizer()
        {
            ARLocalizer.Instance.StopLocalizing();
            foreach (var tmp_Map in arMaps)
            {
                tmp_Map.Value.FreeMap();
                tmp_Map.Value.OnFirstLocalization.RemoveAllListeners();
                tmp_Map.Value.OnFirstLocalization = null;
            }


            List<SDKJob> tmp_Maps = new List<SDKJob>();
            tmp_Maps.AddRange(maps.Values.ToList());
            SDKMapId[] tmp_MapIds = new SDKMapId[tmp_Maps.Count];
            for (int tmp_Idx = 0; tmp_Idx < tmp_MapIds.Length; tmp_Idx++)
            {
                tmp_MapIds[tmp_Idx] = new SDKMapId {id = tmp_Maps[tmp_Idx].id};
            }

            if (tmp_MapIds.Length <= 0) return;
            if (tmp_MapIds.Length > 5)
                Array.Resize(ref tmp_MapIds, 5);

            ARLocalizer.Instance.OnMapChanged += OnMapChanged;
            ARLocalizer.Instance.mapIds = tmp_MapIds;
            ARLocalizer.Instance.StartLocalizing();
        }

        private void StopOnServerLocalizer()
        {
            ARLocalizer.Instance.useServerLocalizer = false;
            ARLocalizer.Instance.StopLocalizing();
            ARLocalizer.Instance.OnMapChanged -= OnMapChanged;
        }

        private void GetMaps()
        {
            JobListJobsAsync tmp_GetPrivateMapJobAsync = new JobListJobsAsync
            {
#if UNITY_EDITOR
                useGPS = true,
#else
                useGPS = locationProvider.gpsOn,
#endif
                latitude = locationProvider.latitude,
                longitude = locationProvider.longitude,
                radius = 200
            };

            tmp_GetPrivateMapJobAsync.OnResult += _result =>
            {
                maps.Clear();
                if (_result.count > 0)
                {
                    // add private maps
                    foreach (SDKJob tmp_Job in _result.jobs)
                    {
                        if (String.Compare(tmp_Job.status, ConstKey.CONST_STATUS_FAILED, StringComparison.Ordinal) != 0)
                        {
                            maps[tmp_Job.id] = tmp_Job;
                        }
                    }
                }

                //load public maps
                JobListJobsAsync tmp_GetPublicMapJobAsync = new JobListJobsAsync
                {
                    useToken = false,
                    useGPS = locationProvider.gpsOn,
                    latitude = locationProvider.latitude,
                    longitude = locationProvider.longitude,
                    radius = 200
                };
                tmp_GetPublicMapJobAsync.OnResult += _publicResult =>
                {
                    if (_publicResult.count > 0)
                    {
                        // add public maps
                        foreach (SDKJob tmp_Job in _publicResult.jobs)
                        {
                            if (tmp_Job.status != ConstKey.CONST_STATUS_FAILED)
                            {
                                maps[tmp_Job.id] = tmp_Job;
                            }
                        }
                    }

                    StartOnServerLocalizer();
                };

                jobs.Add(tmp_GetPublicMapJobAsync.RunJobAsync());
            };

            jobs.Add(tmp_GetPrivateMapJobAsync.RunJobAsync());
        }

        private async void RunJob(Task _t)
        {
            await _t;
            if (jobs.Count > 0)
            {
                jobs.RemoveAt(0);
            }

            //jobLock = 0;
        }


        private void OnPoseLose()
        {
            immersalNotificationData.ActionName = nameof(OnPoseLose);
            immersalNotificationData.ImmersalEventType =
                ImmersalNotificationData.ImmersalEventTypes.OnPoseLose;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void OnPoseFound()
        {
            immersalNotificationData.ActionName = nameof(OnPoseFound);
            immersalNotificationData.ImmersalEventType =
                ImmersalNotificationData.ImmersalEventTypes.OnPoseFound;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void OnReset()
        {
            immersalNotificationData.ActionName = nameof(OnReset);
            immersalNotificationData.ImmersalEventType =
                ImmersalNotificationData.ImmersalEventTypes.OnReset;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void OnMapChanged(int _id)
        {
            immersalNotificationData.MapId = _id;
            immersalNotificationData.ActionName = nameof(OnMapChanged);
            immersalNotificationData.ImmersalEventType =
                ImmersalNotificationData.ImmersalEventTypes.OnMapChanged;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void Localize(BaseNotificationData _notification)
        {
            immersalSDK.Localizer.Localize();
        }
    }
}
#endif