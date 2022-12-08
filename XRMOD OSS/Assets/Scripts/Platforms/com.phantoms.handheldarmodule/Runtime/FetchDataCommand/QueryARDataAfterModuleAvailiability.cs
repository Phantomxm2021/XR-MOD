// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.Command;
using HandheldARModule.Runtime.Models;
using NativePlugins.Plugin;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime
{
    public class QueryARDataAfterModuleAvailiability : ICommand
    {
        public void Execute()
        {
            var tmp_ARContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            tmp_ARContextData.ARSessionState.OnValueChanged += OnARSessionStateChanged;

            //Register event callback for ARAvailability value changed
            tmp_ARContextData.ARAvailability.OnValueChanged += _availability =>
            {
                if (!_availability && !Application.isEditor) return;

                //Trigger the fetch server process event
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.FetchProjectDetail),
                    new BaseNotificationData());
            };
            IocContainer.GetIoc.Resolve<BuildARAvailabilityCommand>().Execute();
        }

        private void OnARSessionStateChanged(ARSessionState _state)
        {
            switch (_state)
            {
                case ARSessionState.Unsupported:
                    if (Application.isEditor)
                    {
                        NativeAPI.SdkInitialized();
                    }
                    else
                    {
                        NativeAPI.DeviceNotSupport();
                    }

                    break;
                case ARSessionState.NeedsInstall:
                    if (Application.platform == RuntimePlatform.Android)
                    {
                        NativeAPI.NeedInstallARCoreServices();
                    }

                    break;
                case ARSessionState.Ready:
                case ARSessionState.SessionTracking:
                case ARSessionState.SessionInitializing:
                    NativeAPI.SdkInitialized();
                    IocContainer.GetIoc.Resolve<ARContextDataModel>().ARAvailability.Value = true;
                    break;
            }
        }
    }
}