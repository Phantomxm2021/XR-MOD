using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{

    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"), 
     UnitTitle("Quaternion Server Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(Quaternion))]
    public class ServerAttributeQuaternionUnit:BaseServerAttributeUnit<Quaternion>
    {
    }
}