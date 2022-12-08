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
using com.Phantoms.ARMODPackageTools.Runtime;
using NativePlugins.Plugin;
using UnityEngine;

namespace SDKEntry.Runtime.DataRequest
{
    public class DownloadAssetBundleContent : IHttpRequestCommand<string>
    {
        private readonly QueryParameter queryParameter;

        public DownloadAssetBundleContent(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<string> Execute()
        {
            try
            {
                //var tmp_BundleJsonUrl = queryParameter.AssetBundleContentUrl.Trim().Replace("'", "");
                var tmp_BundleObjectUrl = queryParameter.AssetBundleContentUrl.Trim().Replace("'", "");
                var tmp_PropertyText = await BasePackageLoaderUtility.LoadBundleFromUrl<TextAsset>(
                    _uri: new Uri(tmp_BundleObjectUrl),
                    _timeout: queryParameter.Timeout,
                    _wannaLoadAssetsName: ConstKey.CONST_CONFIGURES,
                    _hash128: Hash128.Parse(queryParameter.Hash),
                    _crc: queryParameter.Crc,
                    _failedAction: Debug.LogError,
                    _progressAction: (_progress) =>
                    {
                        NativeAPI.UpdateLoadingProgress(_progress);
                        //Dismiss loading overlay UI
                        if (_progress >= 1)
                            NativeAPI.RemoveLoadingOverlay();
                    }
                );

                if (string.IsNullOrEmpty(tmp_PropertyText.text))
                {
                    throw new NullReferenceException();
                }

                return tmp_PropertyText.text;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                NativeAPI.ThrowException(nameof(ErrorCode.UNPACKING_FAILED), (int) ErrorCode.UNPACKING_FAILED);
                throw;
            }
        }
    }
}