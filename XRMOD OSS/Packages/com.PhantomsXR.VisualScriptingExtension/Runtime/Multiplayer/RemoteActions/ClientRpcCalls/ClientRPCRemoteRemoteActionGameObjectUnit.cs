using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/ClientRPC"), 
     UnitTitle("GameObject ClientRPC Trigger"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("ClientRPC Trigger"),
    TypeIcon(typeof(GameObject))]
    public class ClientRPCRemoteRemoteActionGameObjectUnit:BaseClientRPCRemoteActionUnit<GameObject>
    {
    }
}