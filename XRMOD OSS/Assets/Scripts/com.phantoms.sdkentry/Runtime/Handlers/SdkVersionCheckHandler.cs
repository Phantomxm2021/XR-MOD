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

using System;
using com.phantoms.models.Runtime;
using NativePlugins.Plugin;
using SDKEntry.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class SdkVersionCheckHandler : AbstractHandler
    {
        public override void Handle()
        {
            // Break chain
            var tmp_SDKEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
            if (tmp_SDKEntryPointModel.BreakDownloadWhenGreaterPresetSize.Value)
                return;

            //Check the sdk version required by the current AR Experience package (minimum version)
            //If the current SDK is lower than the minimum version required by  AR Experience package,
            //the current AR Experience package cannot be used. It will throw exception.
            var tmp_SdkVersion = Resources.Load<SDKInformation>("SDKInformation");
            IocContainer.GetIoc.Resolve<SDKEntryPointModel>().SdkVersion.Value = tmp_SdkVersion.Version;
            Assert.IsNotNull(IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value);
            var tmp_ValueVersion = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value.Version;

            int tmp_CompareResult = Utility.CompareVersion(tmp_SdkVersion.Version, tmp_ValueVersion);
          
            if (tmp_CompareResult >= 0)
            {
                IocContainer.GetIoc.Resolve<SDKEntryPointModel>().VersionMatched.Value = true;
                base.Handle();
                return;
            }

            var tmp_RequiredVersion = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures
                .Value.Version;
            var tmp_ErrorMsg =
                $"{nameof(ErrorCode.SDK_VERSION_IS_TOO_LOW)},SDK version:{tmp_SdkVersion},AR Experiences required version:{tmp_RequiredVersion}";
            NativeAPI.ThrowException(tmp_ErrorMsg, (int) ErrorCode.SDK_VERSION_IS_TOO_LOW);
            throw new Exception(tmp_ErrorMsg);
        }
    }
}