// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Cysharp.Threading.Tasks;

namespace SDKEntry.Runtime.DataRequest
{
    public static class NetworkRequestUtil
    {
        public static async Task<T> SendRequest<T>(string _apiUrl, string _method, int _timeout, string _token,
            Dictionary<string, string> _params = null)
        {
            var tmp_Request = MakeSureUnityWebRequest(_apiUrl, _method, _params);
            tmp_Request.timeout = _timeout;
            tmp_Request.SetRequestHeader("Authorization", $"Token {_token}");

            await tmp_Request.SendWebRequest();
            switch (tmp_Request.result)
            {
                case UnityWebRequest.Result.Success:
                    return JsonUtility.FromJson<T>(tmp_Request.downloadHandler.text);
            }

            throw new Exception(tmp_Request.error);
        }


        private static UnityWebRequest MakeSureUnityWebRequest(string _apiUrl, string _method,
            Dictionary<string, string> _params)
        {
            if (_method.ToLower() == "get")
            {
                if (_params == null)
                {
                    var tmp_Request = UnityWebRequest.Get(_apiUrl);
                    // Fix Curl error 60: Cert verify failed: UNITYTLS_X509VERIFY_FLAG_EXPIRED SSL CA certificate error
                    // https://answers.unity.com/questions/1874008/curl-error-60-cert-verify-failed-unitytls-x509veri-1.html
                    // tmp_Request.certificateHandler = new CertificateWhore();
                    return tmp_Request;
                }

                StringBuilder tmp_RequestParams = new StringBuilder();
                foreach (KeyValuePair<string, string> tmp_Param in _params)
                {
                    tmp_RequestParams.Append($"{tmp_Param.Key}={tmp_Param.Value}&");
                }

                var tmp_RequestUrl = $"{_apiUrl}?{tmp_RequestParams}";
                tmp_RequestUrl = tmp_RequestUrl.Remove(tmp_RequestUrl.Length - 1);
                return UnityWebRequest.Get(tmp_RequestUrl);
            }
            else
            {
                var tmp_Request = UnityWebRequest.Post(_apiUrl, _params);
                tmp_Request.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                return tmp_Request;
            }
        }

        public class CertificateWhore : CertificateHandler
        {
            protected override bool ValidateCertificate(byte[] _certificateData)
            {
                return true;
            }
        }
    }
}