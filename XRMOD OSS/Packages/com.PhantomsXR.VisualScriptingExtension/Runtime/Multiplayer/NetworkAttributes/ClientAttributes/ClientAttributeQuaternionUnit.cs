using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{

    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"), 
     UnitTitle("Quaternion Client Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("Client Trigger"),
     TypeIcon(typeof(Quaternion))]
    public class ClientAttributeQuaternionUnit:BaseClientAttributeUnit<Quaternion>
    {
    }
}