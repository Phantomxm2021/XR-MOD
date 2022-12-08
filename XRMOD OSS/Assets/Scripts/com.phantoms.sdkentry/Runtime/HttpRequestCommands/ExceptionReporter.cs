// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.phantoms.models.Runtime;
using SDKEntry.Runtime.Mapper;
using SDKEntry.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime.DataRequest
{
    public class ExceptionReporter : IHttpRequestCommand<ResponseMapper>
    {
        private readonly Dictionary<string, string> parameter;

        [System.Serializable]
        public class DeviceInfo
        {
            public string deviceName;
            public string deviceType;
            public string osVersion;
            public string deviceUniqueIdentifier;
        }

        public ExceptionReporter(Dictionary<string, string> _parameter)
        {
            parameter = _parameter;
        }

        public async Task<ResponseMapper> Execute()
        {
            var tmp_SDKConfiguration = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value;
            var tmp_Url = tmp_SDKConfiguration.dashboardConfig.exceptionCollectorUrl;
            var tmp_Timeout = tmp_SDKConfiguration.dashboardConfig.timeout;
            var tmp_Token = tmp_SDKConfiguration.dashboardConfig.token;
            var tmp_ProjectInfo = IocContainer.GetIoc.Resolve<BaseContextDataModel>().ProjectInfo;
            if (string.IsNullOrEmpty(tmp_Url) || tmp_ProjectInfo == null)
            {
                return await Task.FromResult(new ResponseMapper());
            }

            var tmp_DeviceInfo = new DeviceInfo
            {
                deviceName = SystemInfo.deviceName,
                deviceType = SystemInfo.deviceType.ToString(),
                osVersion = SystemInfo.operatingSystem,
                deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier
            };
            parameter.Add("project_uid", tmp_ProjectInfo.ProjectUid);
            parameter.Add("identifier", Application.identifier);
            parameter.Add("app_name", Application.productName);
            parameter.Add("device_info", JsonUtility.ToJson(tmp_DeviceInfo));
            parameter.Add("create_time", DateTime.Now.ToString("s"));

            var tmp_Request =
                await NetworkRequestUtil.SendRequest<ResponseMapper>
                    (tmp_Url, "POST", tmp_Timeout, tmp_Token, parameter);
            parameter.Clear();
            return tmp_Request;
        }
    }
}