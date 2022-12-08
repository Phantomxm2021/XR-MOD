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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using SDKEntry.Runtime.Mapper;
using UnityEngine;
using UnityEngine.Networking;
//using com.Phantoms.ARMODPackageTools.Runtime;
//using com.Phantoms.WebRequestExtension.Runtime.WebRequest;
#if UNITY_ANDROID
using UnityEngine.Android;

#endif

namespace SDKEntry.Runtime
{
    public static class Utility
    {
        public static string GetGatewayVersion(string _gateway)
        {
            var tmp_Args = _gateway.Split("/");
            return tmp_Args[4];
        }

        /// <summary>
        /// MD5 encryption
        /// </summary>
        /// <param name="_originString">need to encryption string</param>
        /// <returns>MD5 String</returns>
        public static string MD5Encryption(string _originString)
        {
            var tmp_SignMD5Maker = MD5.Create();
            byte[] tmp_OriginStringBytes = Encoding.UTF8.GetBytes(_originString);
            var tmp_SignMD5Bytes = tmp_SignMD5Maker.ComputeHash(tmp_OriginStringBytes);
            StringBuilder tmp_MD5String = new StringBuilder();
            foreach (var tmp_T in tmp_SignMD5Bytes)
            {
                tmp_MD5String.Append(tmp_T.ToString("X2"));
            }

            return tmp_MD5String.ToString();
        }


        public static ProjectResourceMapper MakeSurePlatformAsset(string _platform, string _bundleURL, string _jsonURL)
        {
            switch (_platform)
            {
                case "Android":
                    return new ProjectResourceMapper()
                    {
                        bundle_url = _bundleURL,
                        json_url = _jsonURL,
                        platform_type = "Android"
                    };
                case "iOS":
                    return new ProjectResourceMapper()
                    {
                        bundle_url = _bundleURL,
                        json_url = _jsonURL,
                        platform_type = "iOS"
                    };
                case "WSA":
                    return new ProjectResourceMapper()
                    {
                        bundle_url = _bundleURL,
                        json_url = _jsonURL,
                        platform_type = "WSA"
                    };
                case "WebGL":
                    return new ProjectResourceMapper()
                    {
                        bundle_url = _bundleURL,
                        json_url = _jsonURL,
                        platform_type = "WebGL"
                    };
            }

            return null;
        }
        /// <summary>
        /// Does the current device support AR
        /// </summary>
        /// <returns></returns>
        // public static bool ARAvailability()
        // {
        //     return ARAlgorithmUtility.ARAvailability();
        // }


        /// <summary>
        /// Compare the version
        /// </summary>
        /// <param name="_version1">current version</param>
        /// <param name="_version2">package version</param>
        /// <returns>0:Equal,1:Greater，-1:less</returns>
        public static int CompareVersion(string _version1, string _version2)
        {
            System.Text.RegularExpressions.Regex tmp_Regex = new System.Text.RegularExpressions.Regex(@"([\d]+)");
            System.Text.RegularExpressions.MatchCollection tmp_M1 = tmp_Regex.Matches(_version1);
            System.Text.RegularExpressions.MatchCollection tmp_M2 = tmp_Regex.Matches(_version2);
            int tmp_Min = Math.Min(tmp_M1.Count, tmp_M2.Count);
            for (int tmp_Idx = 0; tmp_Idx < tmp_Min; tmp_Idx++)
            {
                if (Convert.ToInt32(tmp_M1[tmp_Idx].Value) > Convert.ToInt32(tmp_M2[tmp_Idx].Value))
                {
                    return 1;
                }

                if (Convert.ToInt32(tmp_M1[tmp_Idx].Value) < Convert.ToInt32(tmp_M2[tmp_Idx].Value))
                {
                    return -1;
                }
            }

            return 0;
        }


        /// <summary>
        /// acquire the device's camera permission
        /// </summary>
        /// <param name="_callback">run after got the permission of device camera</param>
        /// <returns>IEnumerator</returns>
        public static IEnumerator TryAcquireCameraPermission(Action _callback)
        {
            switch (Application.platform)
            {
#if UNITY_ANDROID
                case RuntimePlatform.Android when !Permission.HasUserAuthorizedPermission(Permission.Camera):
                    Permission.RequestUserPermission(Permission.Camera);
                    yield return new WaitUntil(() => Permission.HasUserAuthorizedPermission(Permission.Camera));
                    break;
#endif
                case RuntimePlatform.IPhonePlayer:
                    Application.RequestUserAuthorization(UserAuthorization.WebCam);
                    yield return new WaitUntil(() => Application.HasUserAuthorization(UserAuthorization.WebCam));
                    break;
            }

            _callback?.Invoke();
        }

        /// <summary>
        /// Get file size from url
        /// </summary>
        /// <param name="_url">file's url</param>
        /// <returns>file size length</returns>
        public static async Task<long> GetFileSize(string _url)
        {
            UnityWebRequest tmp_Uwr = UnityWebRequest.Head(_url);
            await tmp_Uwr.SendWebRequest();
            string tmp_Size = tmp_Uwr.GetResponseHeader("Content-Length");

            switch (tmp_Uwr.result)
            {
                case UnityWebRequest.Result.Success:
                    return Convert.ToInt64(tmp_Size);
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.ProtocolError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.Log("Error While Getting Length: " + tmp_Uwr.error);
                    break;
            }

            return -1;
        }


        /// <summary>
        /// Get the resource address of the corresponding platform
        /// </summary>
        /// <param name="_projectAssetMapper">project asset response</param>
        /// <param name="_bundletUrl">bundle url</param>
        /// <param name="_jsonUrl">json url</param>
        public static void GetCurrentPlatformAssetUrl(ProjectAssetMapper _projectAssetMapper, out string _bundletUrl,
            out string _jsonUrl)
        {
            switch (Application.platform)
            {
                case RuntimePlatform.WindowsEditor:
                case RuntimePlatform.OSXEditor:
#if UNITY_ANDROID
                    _jsonUrl = _projectAssetMapper.android_json;
                    _bundletUrl = _projectAssetMapper.android_bundle;
#else
                    _jsonUrl = _projectAssetMapper.ios_json;
                    _bundletUrl = _projectAssetMapper.ios_bundle;
#endif
                    break;

                case RuntimePlatform.Android:
                    _jsonUrl = _projectAssetMapper.android_json;
                    _bundletUrl = _projectAssetMapper.android_bundle;
                    break;
                case RuntimePlatform.IPhonePlayer:
                    _jsonUrl = _projectAssetMapper.ios_json;
                    _bundletUrl = _projectAssetMapper.ios_bundle;
                    break;
                default:
                    _bundletUrl = _jsonUrl = string.Empty;
                    break;
            }
        }


        /// <summary>
        /// Check current AR experience is cached
        /// </summary>
        /// <param name="_bundleName">bundle name</param>
        /// <param name="_hash128">bundle hash128</param>
        /// <returns>True:in cache,False:otherwise</returns>
        public static bool ARExperienceInCache(string _bundleName, Hash128 _hash128)
        {
            return Caching.IsVersionCached(_bundleName, _hash128);
        }


        /// <summary>
        /// Get the resource size of the corresponding platform
        /// </summary>
        /// <param name="_projectAssetMapper">project asset response</param>
        /// <returns>resource size(M)</returns>
        public static float GetCurrentPlatformARExperiencePackageSize(ProjectAssetMapper _projectAssetMapper)
        {
#if UNITY_ANDROID
                return _projectAssetMapper.android_bundle_size;
#elif UNITY_IOS
            return _projectAssetMapper.ios_bundle_size;
#else
            return 0;
#endif
        }


        // public static void ResizeARWorldScale(float _worldScale)
        // {
        //     var tmp_SessionOrigin = Object.FindObjectOfType<ARSessionOrigin>();
        //     if (tmp_SessionOrigin)
        //     {
        //         var tmp_Trans = tmp_SessionOrigin.transform;
        //         //Will ignore
        //         if (_worldScale <= 0) _worldScale = 1f;
        //
        //         tmp_Trans.localScale = Vector3.one * _worldScale;
        //     }
        // }
    }
}