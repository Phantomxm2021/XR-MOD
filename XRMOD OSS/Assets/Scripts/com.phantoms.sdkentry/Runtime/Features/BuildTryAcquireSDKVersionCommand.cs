// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.SDKEntry.Runtime.
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
    public class BuildTryAcquireSDKVersionCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireSDKVersionCommand()
        {
            Execute();
        }
        
        /// <summary>
        /// Get current sdk version
        /// </summary>
        /// <param name="_base"></param>
        /// <returns>sdk version string</returns>
        private string TryAcquireSDKVersionObserver(BaseNotificationData _base)
        {
            return IocContainer.GetIoc.Resolve<SDKEntryPointModel>().SdkVersion.Value;
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireSDKVersionObserver,
                nameof(ActionParameterDataType.TryAcquireSDKVersion));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.TryAcquireSDKVersion));
        }
    }
}