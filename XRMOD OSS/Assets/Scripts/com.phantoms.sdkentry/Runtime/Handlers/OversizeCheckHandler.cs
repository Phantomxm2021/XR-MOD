// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Threading.Tasks;
using com.Phantoms.ARMODPackageTools.Runtime;
using com.phantoms.models.Runtime;
using NativePlugins.Plugin;
using SDKEntry.Runtime.Mapper;
using SDKEntry.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class OversizeCheckHandler : AbstractHandler
    {
        private XRExperienceData xrExperienceData;
        private ResponseMapper responseMapper;
        private float maximumDownloadSize;
        private float packageSize;
        private SDKEntryPointModel sdkEntryPointModel;

        public OversizeCheckHandler()
        {
            sdkEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
            maximumDownloadSize = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.dashboardConfig
                .maximumDownloadSize;
        }

        public override void Handle()
        {
            xrExperienceData = sdkEntryPointModel.XRExperienceData;
            packageSize = sdkEntryPointModel.ResponseMapper.data.bundle_size;
            Hash128 tmp_Hash128 = Hash128.Parse(xrExperienceData.BundleDetails.m_Hash);
            bool tmp_InCache = Utility.ARExperienceInCache(xrExperienceData.BundleName, tmp_Hash128);
            if (packageSize < maximumDownloadSize || tmp_InCache || Application.internetReachability !=
                NetworkReachability.ReachableViaLocalAreaNetwork)
            {
                base.Handle();
                return;
            }

            sdkEntryPointModel.BreakDownloadWhenGreaterPresetSize.Value = true;
            //show alert to user and tell him the package size is more then (n)M
            NativeAPI.PackageSizeMoreThanPresetSize(packageSize, maximumDownloadSize);
        }
    }
}