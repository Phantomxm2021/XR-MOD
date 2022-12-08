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

using com.Phantoms.ARMODPackageTools.Runtime;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using UnityEngine.XR.ARSubsystems;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildImageTrackCommand : BaseBuildFeature<ImageTrackDecorator>, ICommand, IReleaseCommand
    {
        public async void Execute()
        {
            if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                ARConfiguresModel
                tmp_Config) return;
            
            IocContainer.GetIoc.Resolve<ARContextDataModel>().ReferenceImageLibrary =
                await BasePackageLoaderUtility.LoadAssetFromPackage<XRReferenceImageLibrary>(tmp_Config.ProjectName,
                    ConstKey.CONST_IMAGE_LIBRARY);
            base.Create();
        }

        public void Release()
        {
            base.ReleaseFeature();
        }
    }
}