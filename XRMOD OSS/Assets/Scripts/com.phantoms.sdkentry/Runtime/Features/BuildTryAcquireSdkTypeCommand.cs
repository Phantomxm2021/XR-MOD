// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ActionNotification.Runtime;
using SDKEntry.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class BuildTryAcquireSdkTypeCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireSdkTypeCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireSdkType,
                nameof(ActionParameterDataType.TryAcquireSdkType));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.TryAcquireSdkType));
        }

        private string TryAcquireSdkType(BaseNotificationData _notification)
        {
            return IocContainer.GetIoc.Resolve<SDKEntryPointModel>().SdkType.Value;
        }
    }
}