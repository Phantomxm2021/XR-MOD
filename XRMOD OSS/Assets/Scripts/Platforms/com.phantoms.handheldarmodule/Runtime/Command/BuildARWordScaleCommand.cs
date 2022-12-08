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

using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildARWordScaleCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            var tmp_SessionOrigin = IocContainer.GetIoc.Resolve<ARComponentModel>().XROrigin.gameObject;
            if (IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.Value is not
                ARConfiguresModel tmp_ConfigModel) return;
            var tmp_WordScale = tmp_ConfigModel.ARWorldScale;
            if (!tmp_SessionOrigin) return;
            var tmp_Trans = tmp_SessionOrigin.transform;
            //Will ignore
            if (tmp_WordScale <= 0) tmp_WordScale = 1f;

            tmp_Trans.localScale = Vector3.one * tmp_WordScale;
        }

        public void Release()
        {
            var tmp_SessionOrigin = IocContainer.GetIoc.Resolve<ARComponentModel>().XROriginGameObject;
            if (!tmp_SessionOrigin) return;
            var tmp_Trans = tmp_SessionOrigin.transform;
            tmp_Trans.localScale = Vector3.one;
        }
    }
}