// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Platform.iOS
{
#if UNITY_IOS
    public class BuildCoachingOverlayCommand : BaseBuildFeature<CoachingOverlayDecorator>, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            var tmp_ARConfig =
                IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value as ARConfiguresModel;
            IocContainer.GetIoc.Resolve<ARConfiguresModel>().CoachingOverlay = tmp_ARConfig.CoachingOverlay;
            base.Create();
        }

        public void Release()
        {
        }
    }
#endif
}