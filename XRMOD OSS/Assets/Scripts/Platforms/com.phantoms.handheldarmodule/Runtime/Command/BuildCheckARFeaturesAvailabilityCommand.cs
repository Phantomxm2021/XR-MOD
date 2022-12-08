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
    public class BuildCheckARFeaturesAvailabilityCommand : ICommand, IReleaseCommand
    {
        public BuildCheckARFeaturesAvailabilityCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(CheckARFeaturesAvailabilityObserver,
                nameof(ActionParameterDataType.CheckARFeaturesAvailability));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .CheckARFeaturesAvailability));
        }

        /// <summary>
        /// Check AR features is support on this device.
        /// </summary>
        /// <param name="_base">feature module name</param>
        /// <returns>True or False</returns>
        private string CheckARFeaturesAvailabilityObserver(BaseNotificationData _base)
        {
            return IocContainer.GetIoc.Resolve<ARAlgorithmUtility>().FeatureAvailability(_base.BaseData).ToString();
        }
    }
}