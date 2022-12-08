// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ARFeatures.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using HandheldARModule.Runtime.Models;
using HandheldARModule.Runtime.Utility;
using HandheldARModule.Runtime.FeaturesDecorator;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildOcclusionCommand : BaseBuildFeature<OcclusionDecorator>, ICommand, IReleaseCommand
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