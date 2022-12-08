using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"), 
     UnitTitle("GameObject Server Trigger"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(GameObject))]
    public class ServerAttributeGameObjectUnit:BaseServerAttributeUnit<GameObject>
    {
    }
}