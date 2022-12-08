using System;
using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Spawn Player")]
    public class SpawnPlayerUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput PrefabName;
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        private const string MethodName = "SpawnPlayerCallback";


        protected override void Definition()
        {
            base.Definition();
            PrefabName = ValueInput(nameof(PrefabName),(string)null);
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            Requirement(PrefabName, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_PrefabForInstance = _arg.GetValue<string>(PrefabName);
            Assert.AreNotEqual(tmp_PrefabForInstance, String.Empty);

            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            Assert.IsNotNull(tmp_EventTarget);

            XRMODServices.GetBridge().SpawnPlayer(tmp_PrefabForInstance);

            XRMODServices.GetBridge().SpawnCallback = _gameObject =>
            {
                CustomEvent.Trigger(tmp_EventTarget, MethodName, _gameObject);
            };
            return outputTrigger;
        }
    }
}