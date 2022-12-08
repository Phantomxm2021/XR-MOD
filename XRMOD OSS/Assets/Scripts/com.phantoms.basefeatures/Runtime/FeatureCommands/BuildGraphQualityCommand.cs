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

using UnityEngine;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildGraphQualityCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            base.Initializer();
            if (QualitySettings.GetQualityLevel() == Config.QualityLevel)
                return;
            QualitySettings.SetQualityLevel(Config.QualityLevel, true);
        }

        public void Release()
        {
            QualitySettings.SetQualityLevel(3, true);
            // var tmp_UberPost = Shader.Find("Hidden/Universal Render Pipeline/UberPost");
            // Resources.UnloadAsset(tmp_UberPost);
            //
            // var tmp_FinalPost = Shader.Find("Hidden/Universal Render Pipeline/FinalPost");
            // Resources.UnloadAsset(tmp_FinalPost);
        }
    }
}