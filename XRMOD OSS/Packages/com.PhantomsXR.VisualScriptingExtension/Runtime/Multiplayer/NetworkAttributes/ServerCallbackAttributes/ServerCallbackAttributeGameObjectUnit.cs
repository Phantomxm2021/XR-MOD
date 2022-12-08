using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"), 
     UnitTitle("GameObject ServerCallback Trigger"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("ServerCallback Trigger"),
     TypeIcon(typeof(GameObject))]
    public class ServerCallbackAttributeGameObjectUnit:BaseServerCallbackAttributeUnit<GameObject>
    {
    }
}