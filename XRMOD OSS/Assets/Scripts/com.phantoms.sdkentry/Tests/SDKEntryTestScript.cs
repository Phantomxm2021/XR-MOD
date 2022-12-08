using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SDKEntry.Runtime;
using NUnit.Framework;
using SDKEntry.Runtime.Models;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;
using Cysharp.Threading.Tasks;
using UnityEngine.Networking;

public class SDKEntryTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void SDKEntryTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions
        // Debug.Log(Utility.GetGatewayVersion("https://weacw.com/api/v2/getarresources"));
        DoSendReq();
    }

    private async void DoSendReq()
    {
        // try
        // {
        var tmp_Str = await SendRequestTest<com.Phantoms.ARMODPackageTools.Runtime.XRExperienceData>(
            "https://assets.cn.weacw.com/1012451543/3663670167/1949473905/arexperiences/iOS/apitest.json", "get", 60,
            "eyJhbGciOiJIUzUxMiIsImlhdCI6MTY1NDA3MzE4NiwiZXhwIjoxMDI5NDA3MzE4Nn0.eyJwYWNrYWdlaWQiOiJjb20ucGhhbnRvbXN4ci5yb290IiwidXNlcl91aWQiOi0xfQ.LvwHxz5nSgk2sr9PseVO6IkfKcq6a9D8jOCmH20C2MlcXgoQu1WuD143Av7ubLFGaVKJcQo6gQooYNyI4W6Wgw",
            new Dictionary<string, string>()
            {
                {"project_id", "1949473905"},
            });
        Assert.IsNotNull(tmp_Str);
        Debug.Log(JsonUtility.ToJson(tmp_Str));
        // }
        // catch (Exception tmp_Exception)
        // {
        //     Debug.LogError(tmp_Exception);
        // }
    }

    public static async Task<T> SendRequestTest<T>(string _apiUrl, string _method, int _timeout, string _token,
        Dictionary<string, string> _params)
    {
        var tmp_Request = MakeSureUnityWebRequest(_apiUrl, _method, _params);
        Assert.IsNotNull(tmp_Request);
        tmp_Request.timeout = _timeout;
        tmp_Request.SetRequestHeader("Authorization", $"Token {_token}");
        tmp_Request.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        await tmp_Request.SendWebRequest();

        switch (tmp_Request.result)
        {
            case UnityWebRequest.Result.Success:
                Debug.Log(tmp_Request.downloadHandler.text);
                return JsonUtility.FromJson<T>(tmp_Request.downloadHandler.text);
        }

        throw new Exception("Test error");
    }


    private static UnityWebRequest MakeSureUnityWebRequest(string _apiUrl, string _method,
        Dictionary<string, string> _params)
    {
        if (_method.ToLower() == "get")
        {
            StringBuilder tmp_RequestParams = new StringBuilder();
            foreach (KeyValuePair<string, string> tmp_Param in _params)
            {
                tmp_RequestParams.Append($"{tmp_Param.Key}={tmp_Param.Value}");
            }

            return UnityWebRequest.Get($"{_apiUrl}?{tmp_RequestParams}");
        }
        else
        {
            return UnityWebRequest.Post(_apiUrl, _params);
        }
    }

    [Test]
    public void SDKEntryReleaseTestPasses()
    {
        // var tmp_SDKEntryPrefab = Resources.Load<GameObject>("Prefabs/EntryPoint");
        // var tmp_SDKEntryInstance = Object.Instantiate(tmp_SDKEntryPrefab);
        // Assert.IsNotNull(tmp_SDKEntryInstance);
        //
        // var tmp_SDKEntryPoint = Object.FindObjectOfType<SDKEntryPoint>();
        // var tmp_Simulater = Object.FindObjectOfType<Simulater>();
        // if (!string.IsNullOrEmpty(tmp_Simulater.SDKConfiguration.dashboardConfig.dashboardGateway))
        //     tmp_SDKEntryPoint.InitSDK(JsonUtility.ToJson(tmp_Simulater.SDKConfiguration));
        // else
        //     tmp_SDKEntryPoint.InitSDK(tmp_Simulater.configure);
        // tmp_SDKEntryPoint.LaunchXRQuery(tmp_Simulater.projectId);
    }


    [Test]
    public void JWTEncodeTestPasses()
    {
        var tmp_DateTimeOffset = DateTimeOffset.UtcNow.AddMinutes(1);

        OfflineLicense tmp_License = new OfflineLicense()
        {
            name = "zs",
            expiration_time = tmp_DateTimeOffset.ToUnixTimeMilliseconds()
        };

        var secretKey = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
        JsonWebToken.JsonSerializer = new LitJsonSerializer();
        string token = JsonWebToken.Encode(tmp_License, secretKey, JwtHashAlgorithm.HS256);
        Debug.Log(token);


        var tmp_OfflineToken = JsonWebToken.DecodeToObject<OfflineLicense>(
            "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJuYW1lIjoienMiLCJleHBpcmF0aW9uX3RpbWUiOjE2NTc2NzUzNjM3Mjl9.3BoSNif2MQjeME1wq4H4lNvDOMr9e3DOsnn80Onu2gs",
            secretKey);
        try
        {
            JsonWebToken.ValidateToken(tmp_OfflineToken.expiration_time);
        }
        catch (Exception tmp_Exception)
        {
            Debug.LogError(tmp_Exception.Message);
            throw;
        }
    }
}