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
using com.Phantoms.ARMODPackageTools.Runtime;
using com.phantoms.models.Runtime;
using SDKEntry.Runtime.DataRequest;
using SDKEntry.Runtime.Mapper;
using SDKEntry.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class FetchXRResourcesHandler : AbstractHandler
    {
        private readonly NetworkRequestType networkRequestType;
        private readonly string projectUid;

        /// <summary>
        /// Get current ARExperience information
        /// </summary>
        /// <param name="_networkRequestType"></param>
        /// <param name="_projectUid"></param>
        public FetchXRResourcesHandler(NetworkRequestType _networkRequestType, string _projectUid)
        {
            networkRequestType = _networkRequestType;
            projectUid = _projectUid;
        }

        public override async void Handle()
        {
            try
            {
                var tmp_SDKEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
                var tmp_Config = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.dashboardConfig;
                var tmp_QueryParameter = new QueryParameter
                {
                    ProjectUid = projectUid,
                    Platform = com.Phantoms.ARMODPackageTools.Runtime.Utility.GetPlatform(),
                    URL = tmp_Config.dashboardGateway,
                    Token = tmp_Config.token,
                    Timeout = tmp_Config.timeout,
                };

                var tmp_Response =
                    await NetworkRequestFactory<ResponseMapper>.CreateNetworkRequest(networkRequestType,
                        tmp_QueryParameter);
                tmp_SDKEntryPointModel.ResponseMapper = tmp_Response;


                tmp_SDKEntryPointModel.XRExperienceData =
                    await NetworkRequestFactory<XRExperienceData>.CreateNetworkRequest(
                        NetworkRequestType.DownloadAssetBundleJson,
                        new QueryParameter
                            {AssetBundleJsonUrl = tmp_Response.data.json_url.Trim().Replace("'", "")}
                    );

                base.Handle();
            }
            catch (Exception tmp_Exception)
            {
                throw new Exception($"Project not found.\n {tmp_Exception.Message}");
            }
        }
    }
}