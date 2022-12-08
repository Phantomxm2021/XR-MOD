// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ARFeatureModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.Utility;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildCheckARAvailabilityCommand : ICommand, IReleaseCommand
    {
        public BuildCheckARAvailabilityCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(CheckARAvailabilityObserver,
                nameof(ActionParameterDataType.CheckARAvailability));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.CheckARAvailability));
        }

        /// <summary>
        /// Check whether the current device supports ARKit or ARCore
        /// </summary>
        /// <param name="_base"></param>
        /// <returns>True:Supports,False:otherwise</returns>
        private string CheckARAvailabilityObserver(BaseNotificationData _base)
        {
            return IocContainer.GetIoc.Resolve<ARAlgorithmUtility>().ARAvailability().ToString();
        }
    }
}