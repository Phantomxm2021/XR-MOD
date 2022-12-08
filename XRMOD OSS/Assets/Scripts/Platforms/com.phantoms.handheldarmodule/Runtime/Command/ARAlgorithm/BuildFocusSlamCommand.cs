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
using HandheldARModule.Runtime.Models;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildFocusSlamCommand : BaseBuildFeature<FocusSlamDecorator>, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARRaycastManager = !IocContainer.GetIoc
                .Resolve<ARComponentModel>().XROriginGameObject
                .TryGetComponent(out ARRaycastManager tmp_ARRaycastManager)
                ? IocContainer.GetIoc.Resolve<ARComponentModel>().XROriginGameObject.AddComponent<ARRaycastManager>()
                : tmp_ARRaycastManager;

            base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }
    }
}