using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/EntityProperties"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register Entity Health Receiver"),
     UnitShortTitle("Register Entity Health"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class PlayerHealthReceiverUnit : PlayerPropertiesBaseUnit
    {
        private const string CONST_HEALTH_SYNCED_CALLBACK = "HealthSyncedCallback";

        protected override void ExecuteInternal(string _eventResponser, GameObject _eventTarget,
            NetworkPropertiesSync _synchronizer)
        {
            _synchronizer.HealthSyncedCallback = (_health, _sender) =>
            {
                CustomEvent.Trigger(_eventTarget, _eventResponser ?? CONST_HEALTH_SYNCED_CALLBACK, _health,
                    _sender);
            };
        }
    }
}