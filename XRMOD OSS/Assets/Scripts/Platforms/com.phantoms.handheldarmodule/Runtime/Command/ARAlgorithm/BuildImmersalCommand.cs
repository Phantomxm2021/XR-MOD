// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The com.Phantoms.ARAlgorithm.Runtime cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildImmersalCommand : BaseBuildFeature<ImmersalDecorator>, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_Config) return;
            
            IocContainer.GetIoc.Resolve<ARContextDataModel>().ImmersalParameters = new ImmersalContextDataModel
            {
                DeveloperToken = tmp_Config.DeveloperToken,
                AutoStart = tmp_Config.AutoStart,
                UseFiltering = tmp_Config.UseFiltering,
                LocalizationInterval = tmp_Config.LocalizationInterval,
                UseServerLocalizer = tmp_Config.UseServerLocalizer,
                BurstMode = tmp_Config.BurstMode,
                StopLocalizedAfterSuccess = tmp_Config.StopLocalizedAfterSuccess
            };

            base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }
    }
}