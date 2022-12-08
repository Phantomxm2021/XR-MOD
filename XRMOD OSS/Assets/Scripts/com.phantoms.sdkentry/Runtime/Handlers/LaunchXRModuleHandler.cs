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
using com.phantoms.BaseFeatures.Runtime;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class LaunchXRModuleHandler : AbstractHandler
    {
        public override void Handle()
        {
            //Register base feature for all platform
            var tmp_BaseFeatureModule = new BaseFeatureModule();
            IocContainer.GetIoc.Register(tmp_BaseFeatureModule);
            tmp_BaseFeatureModule.StartModule();

            ActionNotificationCenter.DefaultCenter.PostNotification
                (nameof(ActionParameterDataType.OnXRDataGot), new BaseNotificationData());

            base.Handle();
        }
    }
}