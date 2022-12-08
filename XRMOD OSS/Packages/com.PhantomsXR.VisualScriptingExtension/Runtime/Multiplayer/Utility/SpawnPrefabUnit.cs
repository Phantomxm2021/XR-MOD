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

using System;
using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Spawn Prefab")]
    public class SpawnPrefabUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput PrefabName;
        [DoNotSerialize] public ValueInput Position;
        [DoNotSerialize] public ValueInput Rotation;
        [DoNotSerialize] public ValueInput WorldPos;

        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;

        private const string MethodName = "SpawnPrefabCallback";

        protected override void Definition()
        {
            base.Definition();
            PrefabName = ValueInput(nameof(PrefabName), (string) null);
            Position = ValueInput(nameof(Position), Vector3.zero);
            Rotation = ValueInput(nameof(Rotation), Quaternion.identity);
            WorldPos = ValueInput(nameof(WorldPos), true);
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            Requirement(PrefabName, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_PrefabForInstance = _arg.GetValue<string>(PrefabName);
            Assert.AreNotEqual(tmp_PrefabForInstance, String.Empty);

            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            var tmp_Position = _arg.GetValue<Vector3>(Position);
            var tmp_Rotation = _arg.GetValue<Quaternion>(Rotation);
            var tmp_WorldPos = _arg.GetValue<bool>(WorldPos);
            Assert.IsNotNull(tmp_EventTarget);

            XRMODServices.GetBridge().SpawnCallback = _gameObject =>
            {
                CustomEvent.Trigger(tmp_EventTarget, MethodName, _gameObject);
            };
            XRMODServices.GetBridge().SpawnPrefab(tmp_PrefabForInstance, tmp_Position, tmp_Rotation, tmp_WorldPos);
            return outputTrigger;
        }
    }
}