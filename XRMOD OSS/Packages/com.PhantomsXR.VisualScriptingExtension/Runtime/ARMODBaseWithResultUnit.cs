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


using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class ARMODBaseWithResultUnit : ARMODBaseUnit
    {
        [DoNotSerialize] [PortLabelHidden] public ValueOutput Result;


        public override ControlOutput Execute(Flow _arg)
        {
            throw new System.NotImplementedException();
        }
    }
}