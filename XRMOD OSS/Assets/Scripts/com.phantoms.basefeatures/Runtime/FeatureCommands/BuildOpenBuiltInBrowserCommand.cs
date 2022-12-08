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
using NativePlugins.Plugin;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildOpenBuiltInBrowserCommand : ICommand, IReleaseCommand
    {
        public BuildOpenBuiltInBrowserCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(OpenBuiltInBrowserObserver,
                nameof(ActionParameterDataType.OpenBuiltInBrowser));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.OpenBuiltInBrowser));
        }

        /// <summary>
        /// Open Builtin browser observer
        /// </summary>
        /// <param name="_data">url</param>
        private void OpenBuiltInBrowserObserver(BaseNotificationData _data)
        {
            if (!(_data is OpenBuiltInNotificationData tmp_OpenBuiltInNotificationData)) return;
            NativeAPI.OpenBuiltInBrowser(tmp_OpenBuiltInNotificationData.Url);
            _data.NotificationAct?.Invoke();
        }
    }
}