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

using com.phantoms.BaseFeatures.Runtime;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class CreateUIEventSystemHandler : AbstractHandler
    {
        public override void Handle()
        {
            IocContainer.GetIoc.Resolve<BuildEventSystemCommand>().Execute();
            base.Handle();
        }
    }
}