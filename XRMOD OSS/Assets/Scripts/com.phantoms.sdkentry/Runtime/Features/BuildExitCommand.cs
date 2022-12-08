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
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class BuildExitCommand : ICommand, IReleaseCommand
    {
        public BuildExitCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(CreateExitARObserver,
                nameof(ActionParameterDataType.Exit));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.Exit));
        }

        /// <summary>
        /// Close AR observer
        /// </summary>
        /// <param name="_notificationData"></param>
        private void CreateExitARObserver(BaseNotificationData _notificationData)
        {
            var tmp_AppEntry = Object.FindObjectOfType<SDKEntryPoint>();
            tmp_AppEntry.Dispose();
        }
    }
}