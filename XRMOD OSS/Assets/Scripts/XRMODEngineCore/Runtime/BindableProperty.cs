// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace XRMODEngineCore.Runtime
{
    public class BindableProperty<T>
    {
        private T value;
        public Action<T> OnValueChanged;

        public T Value
        {
            get => this.value;
            set
            {
                this.value = value;
                OnValueChanged?.Invoke(this.value);
            }
        }
    }
}