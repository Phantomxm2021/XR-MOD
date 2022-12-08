// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using HandheldARModule.Runtime.FeaturesDecorator;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Platform.iOS
{
    public class BuildMeshingCommand: BaseBuildFeature<MeshingDecorator>, ICommand,IReleaseCommand
    {
        public void Execute()
        {
            base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }
    }
}