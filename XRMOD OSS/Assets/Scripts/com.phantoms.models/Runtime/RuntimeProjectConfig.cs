// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using XRMODEngineCore.Runtime;

namespace com.phantoms.models.Runtime
{
    public class RuntimeProjectConfig : IModel, IReleaseCommand
    {
        public BindableProperty<BaseProjectConfigModel> CurrentConfigures { get; private set; }
        public string MetaData;
        
        public void Initialize()
        {
            CurrentConfigures = new BindableProperty<BaseProjectConfigModel>();
        }

        public RuntimeProjectConfig()
        {
            Initialize();
        }

        public void Release()
        {
            CurrentConfigures.OnValueChanged = null;
            CurrentConfigures.Value = null;
        }
    }
}