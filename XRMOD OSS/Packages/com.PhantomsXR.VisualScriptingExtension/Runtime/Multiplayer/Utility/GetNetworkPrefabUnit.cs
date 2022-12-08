using System;
using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), 
     UnitTitle("Get NetworkPrefab"), 
     UnitShortTitle("Get NetworkPrefab"),TypeIcon(typeof(GameObject))]
    public class GetNetworkPrefabUnit : ARMODBaseWithResultUnit
    {
        private GameObject networkPrefab;
        [DoNotSerialize] public ValueInput PrefabName;

        protected override void Definition()
        {
            base.Definition();
            PrefabName = ValueInput(nameof(PrefabName),String.Empty);
            Result = ValueOutput(nameof(Result), _flow => networkPrefab);
            Requirement(PrefabName, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            networkPrefab = XRMODServices.GetBridge().GetNetworkPrefab(_arg.GetValue<string>(PrefabName));
            return outputTrigger;
        }
    }
}