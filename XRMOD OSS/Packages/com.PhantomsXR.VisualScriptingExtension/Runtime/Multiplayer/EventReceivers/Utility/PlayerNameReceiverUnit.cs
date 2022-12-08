using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/EntityProperties"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register Entity Name Receiver"),
     UnitShortTitle("Register Entity Name"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class PlayerNameReceiverUnit : PlayerPropertiesBaseUnit
    {
        private const string CONST_PLAYERH_NAME_SYNCED_CALLBACK = "PlayerNameSyncedCallback";

        protected override void ExecuteInternal(string _eventResponser, GameObject _eventTarget,
            NetworkPropertiesSync _synchronizer)
        {
            _synchronizer.ObjectNameSyncedCallback = (_name,_sender) =>
            {
                CustomEvent.Trigger(_eventTarget, _eventResponser ?? CONST_PLAYERH_NAME_SYNCED_CALLBACK, _name,_sender);
            };
        }
    }
}