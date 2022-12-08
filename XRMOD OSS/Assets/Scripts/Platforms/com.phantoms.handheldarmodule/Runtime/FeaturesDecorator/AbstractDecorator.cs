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

using UnityEngine;

namespace HandheldARModule.Runtime.FeaturesDecorator
{
    public abstract class AbstractDecorator
    {
        protected  bool hasStarted;
        
        public virtual bool SupportThisFeature()
        {
            return true;
        }

        public abstract void StartAlgorithm();
        public abstract void PauseAlgorithm();
        public abstract void StopAlgorithm();
    }
}