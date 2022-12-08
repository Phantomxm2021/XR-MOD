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
using HandheldARModule.Runtime.Extension;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildTryAcquireLightEstimateCommand:ICommand,IReleaseCommand
    {
        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireLightEstimateValue,
                nameof(ActionParameterDataType.TryAcquireLightEstimateValue));

        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.TryAcquireLightEstimateValue));

        }
        
        /// <summary>
        /// Acquire the light estimation value from light system
        /// </summary>
        /// <param name="_base"></param>
        /// <returns>Light System</returns>
        private Light TryAcquireLightEstimateValue(BaseNotificationData _base)
        {
            var tmp_LightEstimation = Object.FindObjectOfType<LightEstimationExtension>();
            return tmp_LightEstimation ? tmp_LightEstimation.LightSystem : null;
        }
    }
}