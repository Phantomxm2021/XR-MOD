using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"), 
     UnitTitle("GameObject TargetRPC"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("TargetRPC Trigger"),
    TypeIcon(typeof(GameObject))]
    public class TargetRpcRemoteActionGameObjectUnit:BaseTargetRpcRemoteActionUnit<GameObject>
    {
    }
}