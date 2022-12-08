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
using System.Threading.Tasks;
using com.phantoms.models.Runtime;
using SDKEntry.Runtime.Mapper;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime.DataRequest
{
    public enum NetworkRequestType
    {
        InfoByUId,
        InfoByMarker,
        DownloadAssetBundleJson,
        DownloadAssetBundleContent,
        LoadConfigure
    }

    public class NetworkRequestFactory<T> : SingletonTemplate<NetworkRequestFactory<T>> where T : class, new()
    {
        public static async Task<T> CreateNetworkRequest(NetworkRequestType _networkRequestType,
            QueryParameter _param)
        {
            var tmp_SDKConfiguration = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value;
            switch (_networkRequestType)
            {
                case NetworkRequestType.InfoByUId:
                    switch (tmp_SDKConfiguration.AppModel)
                    {
                        case AppModel.Online:
                            return await new QueryARProjectForOnline<T>(_param).Execute();
                        case AppModel.Offline:
                            return await new QueryARProjectForOffline(_param).Execute() as T;
                        case AppModel.Simulator:
                            return await new QueryARProjectForSimulator(_param).Execute() as T;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                case NetworkRequestType.DownloadAssetBundleJson:
                    var tmp_JsonUrl = tmp_SDKConfiguration.AppModel is AppModel.Online
                        ? _param.AssetBundleJsonUrl
                        : $"file://{_param.AssetBundleJsonUrl}";
                    _param.AssetBundleJsonUrl = tmp_JsonUrl;
                    return await new DownloadAssetBundleJson<T>(_param).Execute();
                case NetworkRequestType.DownloadAssetBundleContent:
                    return await new DownloadAssetBundleContent(_param).Execute() as T;
                case NetworkRequestType.LoadConfigure:
                    return await new GetPackageConfigure(_param).Execute() as T;
                case NetworkRequestType.InfoByMarker:
                    throw new ArgumentOutOfRangeException(nameof(_networkRequestType), _networkRequestType, null);
                default:
                    throw new ArgumentOutOfRangeException(nameof(_networkRequestType), _networkRequestType, null);
            }
        }
    }

    public struct QueryParameter
    {
        public string URL;
        public string Token;
        public int Timeout;
        public string ProjectUid;
        public string Platform;
        public string AssetBundleJsonUrl;
        public string AssetBundleContentUrl;
        public uint Crc;
        public string Hash;
    }
}