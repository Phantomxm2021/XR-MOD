// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Pico.Runtime.FeaturesDecorator
{
    public interface IFeatureDecorator
    {
        public virtual bool SupportThisFeature()
        {
            return true;
        }

        public abstract void StartAlgorithm();
        public abstract void PauseAlgorithm();
        public abstract void StopAlgorithm();
    }
}