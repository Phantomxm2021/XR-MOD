// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using com.phantoms.BaseFeatures.Runtime.Models;
using UnityEngine;
using UnityEngine.EventSystems;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildEventSystemCommand : ICommand, IReleaseCommand
    {
        readonly BaseFeatureModel baseFeatureModel = IocContainer.GetIoc.Resolve<BaseFeatureModel>();


        public void Execute()
        {
            baseFeatureModel.EventSystem = Object.FindObjectOfType<EventSystem>();
            if (baseFeatureModel.EventSystem) return;
            baseFeatureModel.EventSystem = new GameObject("EventSystem-AutoCreate").AddComponent<EventSystem>();
        }

        public void Release()
        {
            if (!baseFeatureModel.EventSystem) return;
            baseFeatureModel.EventSystem.gameObject.SetActive(false);
        }
    }
}