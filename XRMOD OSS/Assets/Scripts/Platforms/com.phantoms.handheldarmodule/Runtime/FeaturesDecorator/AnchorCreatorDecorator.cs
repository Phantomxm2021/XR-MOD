// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using HandheldARModule.Runtime.Utility;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Extension;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public class AnchorCreatorDecorator : AbstractDecorator
    {
        private GameObject extensionGameObject;
        private ARAnchorManager arAnchorManager;
        private ARRaycastManager arRaycastManager;
        private AnchorManagerExtension anchorManagerExtension;

        public AnchorCreatorDecorator()
        {
            ARComponentModel tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ARComponent.XROriginGameObject);
            arAnchorManager = tmp_ARComponent.XROriginGameObject.AddComponent<ARAnchorManager>();
            tmp_ARComponent.ARAnchorManager = arAnchorManager;
            
            arRaycastManager = IocContainer.GetIoc.Resolve<ARComponentModel>().ARRaycastManager;
            extensionGameObject = new GameObject(ConstKey.CONST_GAME_OBJECT_NAME);
            anchorManagerExtension = extensionGameObject.AddComponent<AnchorManagerExtension>();

            if (arAnchorManager)
                arAnchorManager.enabled = false;

            if (arRaycastManager)
                arRaycastManager.enabled = false;

            if (anchorManagerExtension)
                anchorManagerExtension.enabled = false;
        }

        public override void StartAlgorithm()
        {
            if (hasStarted) return;
            if (arAnchorManager)
                arAnchorManager.enabled = true;

            if (arRaycastManager)
                arRaycastManager.enabled = true;

            if (anchorManagerExtension)
                anchorManagerExtension.enabled = true;

            hasStarted = true;
        }

        public override void PauseAlgorithm()
        {
            if (!hasStarted) return;

            anchorManagerExtension.enabled = false;

            if (arAnchorManager || arAnchorManager.descriptor != null)
            {
                arAnchorManager.enabled = false;
            }

            if (!arRaycastManager && arRaycastManager.descriptor == null) return;
            arRaycastManager.enabled = false;
            hasStarted = false;
        }

        public override void StopAlgorithm()
        {
            if (!hasStarted) return;

            if (anchorManagerExtension)
            {
                anchorManagerExtension.enabled = false;
                anchorManagerExtension.DestroyWithPlatform();
            }


            if (arAnchorManager || arAnchorManager.descriptor != null)
            {
                arAnchorManager.anchorPrefab = null;
                arAnchorManager.enabled = false;
                arAnchorManager.subsystem?.Stop();
                arAnchorManager.subsystem?.Destroy();
                arAnchorManager.DestroyWithPlatform();
            }

            if (!arRaycastManager && arRaycastManager.descriptor == null) return;
            arRaycastManager.enabled = false;
            arRaycastManager.DestroyWithPlatform();
            hasStarted = false;
        }

        public override bool SupportThisFeature()
        {
            return arAnchorManager.descriptor != null;
        }
    }
}