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
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using SDKEntry.Runtime;
using SDKEntry.Runtime.Models;
using UnityEngine;
using UnityEngine.SceneManagement;
using XRMODEngineCore.Runtime;


public class Simulater : MonoBehaviour
{
    public string configure;
    public SDKConfiguration SDKConfiguration;
    private SDKEntryPoint sdkEntryPoint;
    public string projectId;
    private SDKEntryPointModel sdkEntryPointModel;
#if UNITY_EDITOR

    private void OnGUI()
    {
        if (GUILayout.Button("Launch XR"))
        {
            StartXR();
        }

        if (GUILayout.Button("Disable XR"))
        {
            if (sdkEntryPoint.Dispose())
            {
                ReSpawnSDK();
            }
        }

        if (GUILayout.Button("Download Mesh"))
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.DownloadMesh),
                new BaseNotificationData()
                {
                    BaseData = "https://assets.cn.weacw.com/ForTest/DamagedHelmet.glb"
                });
        }

        if (GUILayout.Button("Clean Cache"))
        {
            Debug.Log($"ClearCache:{Caching.ClearCache()}");
        }

        sdkEntryPointModel ??= IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
        if (!sdkEntryPointModel.BreakDownloadWhenGreaterPresetSize.Value) return;
        if (GUILayout.Button("Continue"))
        {
            FindObjectOfType<SDKEntryPoint>().ContinueToDownloadAssets();
        }
    }

    internal async void ReSpawnSDK()
    {
        await Task.Delay(1000);
        Instantiate(Resources.Load<GameObject>("Prefabs/EntryPoint"));
        SceneManager.LoadScene(nameof(SceneTags.Main));
    }

    private async void StartXR()
    {
        sdkEntryPoint = FindObjectOfType<SDKEntryPoint>();
        if (!string.IsNullOrEmpty(SDKConfiguration.dashboardConfig.dashboardGateway))
            sdkEntryPoint.InitSDK(JsonUtility.ToJson(SDKConfiguration));
        else
            sdkEntryPoint.InitSDK(configure);
        await Task.Delay(125);
        sdkEntryPoint.LaunchXRQuery(projectId);
    }
#endif
}