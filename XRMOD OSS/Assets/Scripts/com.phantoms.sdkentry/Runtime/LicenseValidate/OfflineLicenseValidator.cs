// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.models.Runtime;
using SDKEntry.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class OfflineLicenseValidator : ICommand
    {
        public void Execute()
        {
            JsonWebToken.JsonSerializer = new LitJsonSerializer();
            var tmp_Token = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.dashboardConfig.token;
            var tmp_OfflineToken = JsonWebToken.DecodeToObject<OfflineLicense>(tmp_Token, SDKEntryPointModel.CONST_SECRET_KEY);
            JsonWebToken.ValidateToken(tmp_OfflineToken.expiration_time);
        }
    }
}