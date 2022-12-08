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

using HandheldARModule.Runtime.FeaturesDecorator;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildFaceMeshCommand : BaseBuildFeature<FaceMeshDecorator>, ICommand,IReleaseCommand
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