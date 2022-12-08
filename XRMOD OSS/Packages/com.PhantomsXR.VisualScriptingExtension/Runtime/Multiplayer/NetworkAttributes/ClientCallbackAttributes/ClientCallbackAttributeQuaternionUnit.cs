using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{

    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"), 
     UnitTitle("Quaternion ClientCallback Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("ClientCallback Trigger"),
     TypeIcon(typeof(Quaternion))]
    public class ClientCallbackAttributeQuaternionUnit:BaseClientCallbackAttributeUnit<Quaternion>
    {
    }
}