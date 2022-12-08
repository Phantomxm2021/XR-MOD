using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"), 
     UnitTitle("GameObject ClientCallback Trigger"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("ClientCallback Trigger"),
     TypeIcon(typeof(GameObject))]
    public class ClientCallbackAttributeGameObjectUnit:BaseClientCallbackAttributeUnit<GameObject>
    {
    }
}