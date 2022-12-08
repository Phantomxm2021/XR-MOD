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

using System.Text;
using System.Threading.Tasks;
using com.phantoms.models.Runtime;
using SDKEntry.Runtime.DataRequest;
using SDKEntry.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class GetXRPackageConfigHandler : AbstractHandler
    {
        public override async void Handle()
        {
            var tmp_SdkEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
            var tmp_Response = tmp_SdkEntryPointModel.ResponseMapper;
            var tmp_PackageBaseConfigureStr = (await NetworkRequestFactory<TextAsset>.CreateNetworkRequest(
                NetworkRequestType.LoadConfigure,
                new QueryParameter()
                {
                    AssetBundleContentUrl = tmp_Response.data.bundle_url,
                    Crc = tmp_SdkEntryPointModel.XRExperienceData.BundleDetails.m_Crc,
                    Hash = tmp_SdkEntryPointModel.XRExperienceData.BundleDetails.m_Hash,
                })).text;
            IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().MetaData = tmp_PackageBaseConfigureStr;
            IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value =
                JsonUtility.FromJson<BaseProjectConfigModel>(tmp_PackageBaseConfigureStr);
            base.Handle();
        }
    }
}