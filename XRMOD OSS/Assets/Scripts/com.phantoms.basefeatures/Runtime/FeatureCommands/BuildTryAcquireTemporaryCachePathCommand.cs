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

using System.IO;
using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildTryAcquireTemporaryCachePathCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireTemporaryCachePathCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireTemporaryCachePath,
                nameof(ActionParameterDataType.TryAcquireTemporaryCachePath));
        }

        private string TryAcquireTemporaryCachePath(BaseNotificationData _baseNotificationData)
        {
            return Path.Combine(Application.temporaryCachePath, "XRMODEngine");
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .TryAcquireTemporaryCachePath));
        }
    }
}