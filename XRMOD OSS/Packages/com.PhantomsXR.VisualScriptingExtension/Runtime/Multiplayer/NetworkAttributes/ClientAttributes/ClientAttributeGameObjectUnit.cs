using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"), 
     UnitTitle("GameObject Client Trigger"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("Client Trigger"),
     TypeIcon(typeof(GameObject))]
    public class ClientAttributeGameObjectUnit:BaseClientAttributeUnit<GameObject>
    {
    }
}