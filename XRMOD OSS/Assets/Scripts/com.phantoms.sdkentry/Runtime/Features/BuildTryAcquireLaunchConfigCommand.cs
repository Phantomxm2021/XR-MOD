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
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class BuildTryAcquireLaunchConfigCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireLaunchConfigCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireCustomConfig,
                nameof(ActionParameterDataType.TryAcquireCustomConfig));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.TryAcquireCustomConfig));
        }

        private string TryAcquireCustomConfig(BaseNotificationData _notification)
        {
            return IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.customConfig.config;
        }
    }
}