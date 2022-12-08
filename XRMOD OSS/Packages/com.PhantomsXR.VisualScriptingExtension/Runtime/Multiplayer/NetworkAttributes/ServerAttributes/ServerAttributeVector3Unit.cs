using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"),
     UnitTitle("Vector3 Server Trigger"),
     UnitSurtitle("Vector3"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(Vector3))]
    public class ServerAttributeVector3Unit:BaseServerAttributeUnit<Vector3>
    {
        
    }
    
    
}