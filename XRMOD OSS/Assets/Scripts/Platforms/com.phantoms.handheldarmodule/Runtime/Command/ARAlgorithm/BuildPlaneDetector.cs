// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The com.Phantoms.ARAlgorithm.Runtime cannot be copied, distributed, or made available to
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
    public class BuildPlaneDetector : BaseBuildFeature<PlaneDetectorDecorator>, ICommand, IReleaseCommand
    {
        public async void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_Config) return;

            GameObject tmp_PlaneVisualizer = null;
            if (String.Compare(tmp_Config.CustomPlaneVisualizerName, ConstKey.CONST_DEFAULT_PLANE_VISUALIZER_NAME,
                    StringComparison.Ordinal) == 0)
            {
                tmp_PlaneVisualizer =
                    Resources.Load<GameObject>(Path.Combine(ConstKey.CONST_PREFAB_FOLDER_NAME, ConstKey.CONST_DEFAULT_PLANE_VISUALIZER_NAME));
            }
            else if (String.Compare(tmp_Config.CustomPlaneVisualizerName,
                         ConstKey.CONST_DEFAULT_FEATHERED_PLANE_VISUALIZER,
                         StringComparison.Ordinal) == 0)
            {
                tmp_PlaneVisualizer =
                    Resources.Load<GameObject>(Path.Combine(ConstKey.CONST_PREFAB_FOLDER_NAME,
                        ConstKey.CONST_DEFAULT_FEATHERED_PLANE_VISUALIZER));
            }
            else
            {
                tmp_PlaneVisualizer = await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                    tmp_Config.ProjectName.ToLower(), tmp_Config.CustomPlaneVisualizerName);
            }

            IocContainer.GetIoc.Resolve<ARContextDataModel>().PlaneVisualizer = tmp_PlaneVisualizer;
            IocContainer.GetIoc.Resolve<ARContextDataModel>().PlaneDetectionMode = tmp_Config.PlaneDetectionMode;
            base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }
    }
}