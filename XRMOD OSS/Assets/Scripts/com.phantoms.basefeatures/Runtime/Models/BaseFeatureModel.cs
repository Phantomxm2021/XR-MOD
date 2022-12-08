// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.gltfextension.Runtime;
using UnityEngine.EventSystems;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime.Models
{
    public class BaseFeatureModel : IModel, IReleaseCommand
    {
        public GltfFileCacheManager GltfFileCacheManager;
        public EventSystem EventSystem;

        public BaseFeatureModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            GltfFileCacheManager = new GltfFileCacheManager();
        }

        public void Release()
        {
            GltfFileCacheManager.CleanUp();
            GltfFileCacheManager = null;
        }
    }
}