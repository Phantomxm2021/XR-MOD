// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Spawn Sync"),
     UnitShortTitle("Spawn Sync")]
    public class SpawnSyncUnit : ARMODBaseUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput GameObject;
        [DoNotSerialize] [NullMeansSelf] public ValueInput Identity;

        protected override void Definition()
        {
            base.Definition();
            GameObject = ValueInput(nameof(GameObject), (GameObject) null).NullMeansSelf();
            Identity = ValueInput(nameof(Identity), (GameObject) null).NullMeansSelf();
            Requirement(GameObject, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_SyncGameObject = _arg.GetValue<GameObject>(this.GameObject);
            Assert.IsNotNull(tmp_SyncGameObject);

            var tmp_Identity = _arg.GetValue<GameObject>(this.Identity);
            if (tmp_Identity)
            {
                var tmp_IdentityComp = tmp_Identity.GetComponent<NetworkIdentity>();
                XRMODServices.GetBridge().SpawnSync(tmp_SyncGameObject, tmp_IdentityComp.connectionToClient);
            }
            else
                XRMODServices.GetBridge().SpawnSync(tmp_SyncGameObject);

            return outputTrigger;
        }
    }
}