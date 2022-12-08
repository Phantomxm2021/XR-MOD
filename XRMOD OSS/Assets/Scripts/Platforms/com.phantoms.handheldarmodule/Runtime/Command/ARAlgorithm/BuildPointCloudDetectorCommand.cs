// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using com.Phantoms.ARMODPackageTools.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildPointCloudDetectorCommand : BaseBuildFeature<PointCloudDetectorDecorator>, ICommand,
        IReleaseCommand
    {
        public async void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_Config) return;
            GameObject tmp_PointCloudVisualizer = null;
            if (string.IsNullOrEmpty(tmp_Config.CustomPointCloudVisualizerName)) return;
            if (String.Compare(tmp_Config.CustomPointCloudVisualizerName,
                    ConstKey.CONST_DEFAULT_POINT_CLOUD_VISUALIZER_NAME,
                    StringComparison.Ordinal) == 0)
            {
                tmp_PointCloudVisualizer =
                    Resources.Load<GameObject>(Path.Combine(ConstKey.CONST_PREFAB_FOLDER_NAME,
                        ConstKey.CONST_DEFAULT_POINT_CLOUD_VISUALIZER_NAME));
            }
            else
            {
                tmp_PointCloudVisualizer = await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                    tmp_Config.ProjectName.ToLower(),
                    tmp_Config.CustomPointCloudVisualizerName);
            }


            IocContainer.GetIoc.Resolve<ARContextDataModel>().PointCloudVisualizer = tmp_PointCloudVisualizer;
            base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }
    }
}