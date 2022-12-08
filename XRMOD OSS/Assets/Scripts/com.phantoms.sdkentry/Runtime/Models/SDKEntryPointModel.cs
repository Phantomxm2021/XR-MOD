// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ARMODPackageTools.Runtime;
using SDKEntry.Runtime.DataRequest;
using SDKEntry.Runtime.Mapper;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime.Models
{
    public class SDKEntryPointModel : IReleaseCommand
    {
        private SDKInformation sdkInformation;
        public const string CONST_SECRET_KEY = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

        public SDKInformation SDKInformation => sdkInformation ??= Resources.Load<SDKInformation>("SDKInformation");

        public BindableProperty<string> SdkVersion = new()
        {
            Value = string.Empty
        };

        public BindableProperty<string> SdkType = new BindableProperty<string>()
        {
            Value = Resources.Load<SDKInformation>("SDKInformation").currentSDKDeviceType.ToString()
        };

        public BindableProperty<bool> SdkInitialed = new()
        {
            Value = false
        };

        public BindableProperty<int> MaximumOfRetries = new()
        {
            Value = 5
        };

        public BindableProperty<bool> SDKAvailability = new()
        {
            Value = false
        };

        public BindableProperty<ProjectResourceMapper> ProjectResourceInfo = new();

        //Conditions for executing the method of continuing to download assets
        public BindableProperty<bool> BreakDownloadWhenGreaterPresetSize = new();
        public BindableProperty<bool> VersionMatched = new();

        public NetworkRequestType NetworkRequestType;
        public ResponseMapper ResponseMapper;
        public XRExperienceData XRExperienceData;

        public void Release()
        {
            SdkVersion.OnValueChanged = null;
            SdkInitialed.OnValueChanged = null;
            MaximumOfRetries.OnValueChanged = null;
            SDKAvailability.OnValueChanged = null;
            ProjectResourceInfo.OnValueChanged = null;
            BreakDownloadWhenGreaterPresetSize.OnValueChanged = null;
            VersionMatched.OnValueChanged = null;
        }
    }
}