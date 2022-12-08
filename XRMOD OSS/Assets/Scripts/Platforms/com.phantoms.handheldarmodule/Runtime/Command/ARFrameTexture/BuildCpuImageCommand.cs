// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ARFeatureModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using HandheldARModule.Runtime.FeaturesDecorator;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildCpuImageCommand : BaseBuildFeature<CpuImageDecorator>, ICommand, IReleaseCommand, ITick
    {
        private AbstractDecorator decorator;

        public void Execute()
        {
            decorator ??= base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }

        public void OnTick()
        {
            decorator?.StartAlgorithm();
        }
    }
}