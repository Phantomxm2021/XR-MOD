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

using System;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using HandheldARModule.Runtime.Utility;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildTryAcquireAROcclusionFrameCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireAROcclusionFrame,
                nameof(ActionParameterDataType.TryAcquireAROcclusionFrame));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.TryAcquireAROcclusionFrame));
        }

        /// <summary>
        /// Attempt to get the latest human stencil CPU image. 
        /// </summary>
        /// <param name="_base"></param>
        /// <returns></returns>
        private Texture2D TryAcquireAROcclusionFrame(BaseNotificationData _base)
        {
            var tmp_AROcclusionManager =
                IocContainer.GetIoc.Resolve<ARComponentModel>().AROcclusionManager;
            Assert.IsNotNull(tmp_AROcclusionManager);
            switch (_base)
            {
                case AROcclusionNotificationData tmp_OcclusionNotificationData:

                    switch (tmp_OcclusionNotificationData.OcclusionDataType)
                    {
                        case OcclusionDataType.HumanStencil:
                            if (tmp_AROcclusionManager.TryAcquireHumanStencilCpuImage(out var tmp_HumanStencil))
                            {
                                return GetTexture2D(tmp_HumanStencil, OcclusionDataType.HumanStencil);
                            }

                            break;
                        case OcclusionDataType.HumanDepth:
                            if (tmp_AROcclusionManager.TryAcquireHumanDepthCpuImage(out var tmp_HumanDepth))
                            {
                                return GetTexture2D(tmp_HumanDepth, OcclusionDataType.HumanDepth);
                            }

                            break;
                        case OcclusionDataType.Environment:
                            if (tmp_AROcclusionManager.TryAcquireEnvironmentDepthCpuImage(out var tmp_Environment))
                            {
                                return GetTexture2D(tmp_Environment, OcclusionDataType.Environment);
                            }

                            break;

                        case OcclusionDataType.EnvironmentConfidence:
                            if (tmp_AROcclusionManager.TryAcquireEnvironmentDepthConfidenceCpuImage(
                                    out var tmp_EnvironmentConfidence))
                            {
                                return GetTexture2D(tmp_EnvironmentConfidence, OcclusionDataType.EnvironmentConfidence);
                            }

                            break;
                        case OcclusionDataType.SmoothedEnvironmentDepth:
                            if (tmp_AROcclusionManager.TryAcquireSmoothedEnvironmentDepthCpuImage(
                                    out var tmp_SmoothedEnvironmentDepth))
                            {
                                return GetTexture2D(tmp_SmoothedEnvironmentDepth,
                                    OcclusionDataType.SmoothedEnvironmentDepth);
                            }

                            break;
                        case OcclusionDataType.RawEnvironmentDepth:
                            if (tmp_AROcclusionManager.TryAcquireRawEnvironmentDepthCpuImage(
                                    out var tmp_RawEnvironmentDepth))
                            {
                                return GetTexture2D(tmp_RawEnvironmentDepth, OcclusionDataType.RawEnvironmentDepth);
                            }

                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
            }

            return null;
        }

        private Texture2D GetTexture2D(XRCpuImage _cpuImage, OcclusionDataType _type)
        {
            using (_cpuImage)
            {
                return IocContainer.GetIoc.Resolve<ARAlgorithmUtility>().CreateTextureFromARFrame(_cpuImage, _type);
            }
        }
    }
}