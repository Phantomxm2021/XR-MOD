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
using com.Phantoms.ARMODPackageTools.Runtime;
using com.phantoms.BaseFeatures.Runtime;
using com.phantoms.models.Runtime;
using NativePlugins.Plugin;
using SDKEntry.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class DisposeXRMODEngineHandler : AbstractHandler
    {
        public override void Handle()
        {
            BasePackageLoaderUtility.ReleaseAllAssetBundle();
            InstantiateUtility.CleanPool();
            Handheld.ClearShaderCache();
            Resources.UnloadUnusedAssets();

            ActionNotificationCenter.DefaultCenter.Release();

            IocContainer.GetIoc.UnRegister<BuildExitCommand>();
            IocContainer.GetIoc.UnRegister<BuildExceptionCollectorCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireSdkTypeCommand>();
            // IocContainer.GetIoc.UnRegister<FetchProjectDetailCommand>();
            // IocContainer.GetIoc.UnRegister<FetchXRResourcesCommand>();
            // IocContainer.GetIoc.UnRegister<DownloadAndSDKVersionCheckCommand>();
            // IocContainer.GetIoc.UnRegister<VerificationVersionCommand>();
            IocContainer.GetIoc.UnRegister<BuildTryAcquireSDKVersionCommand>();

            IocContainer.GetIoc.UnRegister<BaseFeatureModule>();
            IocContainer.GetIoc.UnRegister<IModule>();


            IocContainer.GetIoc.UnRegister<SDKEntryPointModel>();
            IocContainer.GetIoc.UnRegister<RuntimeProjectConfig>();

            //De-initialize the AR session after scene loaded
            LoaderUtility.Deinitialize();

            //Notice app, xr-mod was closed.
            NativeAPI.OnXRMODExit();
            base.Handle();
        }
    }
}