using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{

    [UnitCategory("ARMOD/Multiplayer/RemoteActions/ClientRPC"), 
     UnitTitle("Quaternion ClientRPC Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("ClientRPC Trigger"),
    TypeIcon(typeof(Quaternion))]
    public class ClientRPCRemoteRemoteActionQuaternionUnit:BaseClientRPCRemoteActionUnit<Quaternion>
    {
    }
}