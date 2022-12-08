using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{

    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"), 
     UnitTitle("Quaternion ServerCallback Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("ServerCallback Trigger"),
     TypeIcon(typeof(Quaternion))]
    public class ServerCallbackAttributeQuaternionUnit:BaseServerCallbackAttributeUnit<Quaternion>
    {
    }
}