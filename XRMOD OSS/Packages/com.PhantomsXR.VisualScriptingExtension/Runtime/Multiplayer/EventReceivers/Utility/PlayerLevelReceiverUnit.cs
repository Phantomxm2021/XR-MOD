using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/EntityProperties"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register Entity Level Receiver"),
     UnitShortTitle("Register Entity Level"),
     TypeIcon(typeof(AnimatorMessageListener))]
    public class PlayerLevelReceiverUnit : PlayerPropertiesBaseUnit
    {
        private const string CONST_PLAYERH_LEVEL_SYNCED_CALLBACK = "PlayerLevelSyncedCallback";

        protected override void ExecuteInternal(string _eventResponser, GameObject _eventTarget,
            NetworkPropertiesSync _synchronizer)
        {
            _synchronizer.ObjectLevelSyncedCallback = (_level,_sender) =>
            {
                CustomEvent.Trigger(_eventTarget, _eventResponser ?? CONST_PLAYERH_LEVEL_SYNCED_CALLBACK, _level,_sender);
            };
        }
    }
}