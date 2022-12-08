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

using com.phantoms.models.Runtime;
using SDKEntry.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class CacheProjectInformationHandler : AbstractHandler
    {
        public override void Handle()
        {
            // Cache current project information
            var tmp_SDKEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();

            IocContainer.GetIoc.Resolve<BaseContextDataModel>().ProjectInfo =
                new BaseContextDataModel.ProjectInfoData()
                {
                    ProjectUid = tmp_SDKEntryPointModel.ResponseMapper.data.project_uid.ToString(),
                    Platform = tmp_SDKEntryPointModel.ResponseMapper.data.platform_type,
                    AppUid = tmp_SDKEntryPointModel.ResponseMapper.data.app_uid.ToString(),
                    UserUid = tmp_SDKEntryPointModel.ResponseMapper.data.user_uid.ToString(),
                };
            base.Handle();
        }
    }
}