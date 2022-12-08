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

using HandheldARModule.Runtime.Models;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class MeshingDecorator : AbstractDecorator
    {
        private const string _CONST_MESHING_NAME = "Camera Offset/Meshing";

        public MeshingDecorator()
        {
            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();
            var tmp_MeshingGameObject = tmp_ARComponent.XROrigin.transform.Find(_CONST_MESHING_NAME);
            Assert.IsNotNull(tmp_MeshingGameObject);
            tmp_ARComponent.ARMeshManager = tmp_MeshingGameObject.GetComponent<ARMeshManager>();
        }

        public override void StartAlgorithm()
        {
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager.gameObject.SetActive(true);
        }

        public override void PauseAlgorithm()
        {
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager.gameObject.SetActive(false);
        }

        public override void StopAlgorithm()
        {
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager.gameObject.SetActive(false);
        }
    }
}