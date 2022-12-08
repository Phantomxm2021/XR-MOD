// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Adapter.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using XRMODEngineCore.Runtime;

namespace ILRuntime.CLRBinding.Adapter
{
    public abstract  class BaseCrossBindingAdaptor :XRMODBehaviour, CrossBindingAdaptorType
    {
        protected ILTypeInstance instance;
        protected AppDomain appdomain;
        
        public BaseCrossBindingAdaptor(AppDomain _appdomain, ILTypeInstance _instance)
        {
            this.appdomain = _appdomain;
            this.instance = _instance;
        }

        public ILTypeInstance ILInstance
        {
            get => instance;
            set => instance = value;
        }

        public ILRuntime.Runtime.Enviorment.AppDomain AppDomain
        {
            get => appdomain;
            set => appdomain = value;
        }
        public BaseCrossBindingAdaptor(){}
    }
}