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

using com.phantoms.models.Runtime;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public abstract class AbstractCommand
    {
        protected BaseProjectConfigModel Config;
        protected RuntimeProjectConfig RuntimeProjectConfig;
        protected BaseContextDataModel BaseContextDataModel;
        private bool initialized;
        
        protected virtual void Initializer()
        {
            if (initialized) return;
            ARContext();
            ARConfig();
            initialized = true;
        }

        private void ARConfig()
        {
            Config = RuntimeProjectConfig.CurrentConfigures.Value;
            Assert.IsNotNull(Config);
        }

        private void ARContext()
        {
            RuntimeProjectConfig = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>();
            Assert.IsNotNull(RuntimeProjectConfig);

            BaseContextDataModel = IocContainer.GetIoc.Resolve<BaseContextDataModel>();
            Assert.IsNotNull(BaseContextDataModel);

        }
    }
}