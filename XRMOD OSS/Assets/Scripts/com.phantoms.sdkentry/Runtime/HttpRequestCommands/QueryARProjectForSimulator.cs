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

using System.IO;
using System.Threading.Tasks;
using SDKEntry.Runtime.Mapper;
using UnityEngine;

namespace SDKEntry.Runtime.DataRequest
{
    public readonly struct QueryARProjectForSimulator : IHttpRequestCommand<ResponseMapper>
    {
        private const string _CONST_ASSETS_FOLDER = "Assets";
        private const string _CONST_SERVER_DATA_FOLDER = "ServerData";
        private const string _CONST_ASSET_SUFFIX = "arexperience";
        private const string _CONST_JSON_SUFFIX = "json";
        private readonly QueryParameter queryParameter;


        public QueryARProjectForSimulator(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<ResponseMapper> Execute()
        {
            string tmp_ProjectNameLowercase = queryParameter.ProjectUid.ToLower();

            var tmp_ServerDataWithPlatform =
                Path.Combine(Application.dataPath.Replace(_CONST_ASSETS_FOLDER, _CONST_SERVER_DATA_FOLDER),
                    queryParameter.Platform.ToLower());
            var tmp_FinalServerDataPath = Path.Combine(tmp_ServerDataWithPlatform, tmp_ProjectNameLowercase);
            var tmp_BundleURL =
                Path.Combine(tmp_FinalServerDataPath, $"{tmp_ProjectNameLowercase}.{_CONST_ASSET_SUFFIX}");
            var tmp_JsonURL = Path.Combine(tmp_FinalServerDataPath, $"{tmp_ProjectNameLowercase}.{_CONST_JSON_SUFFIX}");

            var tmp_ResponseMapper = new ResponseMapper
            {
                code = 200,
                msg = "",
                data = Utility.MakeSurePlatformAsset(queryParameter.Platform, tmp_BundleURL, tmp_JsonURL)
            };
            await Task.Delay(1000);
            return tmp_ResponseMapper;
        }
    }
}