// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineCore.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace XRMODEngineCore.Runtime
{
    public interface IModule
    {
        /// <summary>
        /// build a base ar algorithm
        /// </summary>
        /// <returns>True:Build success,False:Build Failed</returns>
        bool StartModule();


        /// <summary>
        /// Pause current algorithm, But not kill and dispose it
        /// </summary>
        /// <returns>True:Pause Success,False:Pause Failed</returns>
        bool PauseModule();


        /// <summary>
        /// Kill and dispose current algorithm,Including all decorator
        /// </summary>
        /// <returns>Always True</returns>
        bool StopModule();

        /// <summary>
        /// Check current module can run on this devices
        /// </summary>
        /// <returns></returns>
        bool IsModuleAvailability();

        void RegisterCLR();
    }
}