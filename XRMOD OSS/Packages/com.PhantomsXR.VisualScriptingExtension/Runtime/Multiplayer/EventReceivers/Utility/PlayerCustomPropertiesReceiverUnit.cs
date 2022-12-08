using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/EntityProperties"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register Entity CustomProperties Receiver"),
     UnitShortTitle("Register Entity CustomProperties"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class PlayerCustomPropertiesReceiverUnit : PlayerPropertiesBaseUnit
    {
        private const string CONST_CUSTOM_PROPERTIES_SYNCED_CALLBACK = "CustomPropertiesSyncedCallback";

        protected override void ExecuteInternal(string _eventResponser, GameObject _eventTarget,NetworkPropertiesSync _synchronizer)
        {
            _synchronizer.CustomPropertiesSyncedCallback = (_customProperties,_sender) =>
            {
                CustomEvent.Trigger(_eventTarget, _eventResponser ?? CONST_CUSTOM_PROPERTIES_SYNCED_CALLBACK,
                    _customProperties,_sender);
            };
        }
    }
}