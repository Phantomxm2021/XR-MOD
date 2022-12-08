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

using com.Phantoms.ActionNotification.Runtime;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildSendMessageToSDKCommand : ICommand, IReleaseCommand
    {
        public BuildSendMessageToSDKCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(SendMessageToSDK,
                nameof(ActionParameterDataType.SendMessageToSDK));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.SendMessageToSDK));
        }


        private void SendMessageToSDK(BaseNotificationData _notification)
        {
            NativePlugins.Plugin.NativeAPI.SendMessageToSDK(_notification.BaseData);
        }
    }
}