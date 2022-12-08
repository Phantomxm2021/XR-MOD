// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ARFeatureModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildTryAcquireCurrentFrameCommand : IReleaseCommand
    {
        private Texture2D frame;

        public BuildTryAcquireCurrentFrameCommand()
        {
            var tmp_ARContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            tmp_ARContextData.FrameTexture.OnValueChanged = _texture2D => { frame = _texture2D; };

            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireCurrentFrame,
                nameof(ActionParameterDataType.TryAcquireCurrentFrame));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.TryAcquireCurrentFrame));
        }

        /// <summary>
        /// Get current frame
        /// </summary>
        /// <param name="_base"></param>
        /// <returns>frame texture</returns>
        private Texture2D TryAcquireCurrentFrame(BaseNotificationData _base)
        {
            var tmp_ARContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            tmp_ARContextData.ConversionType = ConversionType.Synchronous;
            tmp_ARContextData.TextureFormat = TextureFormat.R8;
            if (_base is not TryAcquireCurrentFrameNotificationData tmp_Data) return null;
            tmp_ARContextData.TextureFormat = tmp_Data.AcquiredTextureFormat;
            tmp_ARContextData.ConversionType = tmp_Data.ConversionType;
            IocContainer.GetIoc.Resolve<BuildCpuImageCommand>().Execute();
            IocContainer.GetIoc.Resolve<BuildCpuImageCommand>().OnTick();
            return frame;
        }
    }
}