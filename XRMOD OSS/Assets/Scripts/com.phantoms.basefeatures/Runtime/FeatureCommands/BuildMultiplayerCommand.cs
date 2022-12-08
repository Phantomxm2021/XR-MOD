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
    public class BuildMultiplayerCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        public void Execute()
        {
            base.Initializer();
            if (!RuntimeProjectConfig.CurrentConfigures.Value.Multiplayer) return;
            var tmp_Prefab = Resources.Load<GameObject>("XR-MOD NetworkManager");
            BaseContextDataModel.MultiplayerGo = Object.Instantiate(tmp_Prefab);

            if (Config.DisplayPing)
            {
                var tmp_PingDisplayPrefab = Resources.Load<GameObject>("PingDisplay");
                Object.Instantiate(tmp_PingDisplayPrefab, BaseContextDataModel.MultiplayerGo.transform);
            }

            var tmp_NetworkDiscoveryPrefab = Resources.Load<GameObject>("NetworkDiscovery");
            Object.Instantiate(tmp_NetworkDiscoveryPrefab, BaseContextDataModel.MultiplayerGo.transform);
        }

        public void Release()
        {
            if (RuntimeProjectConfig == null || !RuntimeProjectConfig.CurrentConfigures.Value.Multiplayer) return;
            if (Application.isEditor)
            {
                Object.DestroyImmediate(BaseContextDataModel.MultiplayerGo, true);
            }
            else
            {
                Object.Destroy(BaseContextDataModel.MultiplayerGo);
            }
        }
    }
}