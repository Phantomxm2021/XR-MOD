using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"),
     UnitTitle("Vector3 TargetRPC Trigger"),
     UnitSurtitle("Vector3"),
     UnitShortTitle("TargetRPC Trigger"),
     TypeIcon(typeof(Vector3))]
    public class TargetRpcRemoteActionVector3Unit : BaseTargetRpcRemoteActionUnit<Vector3>
    {
    }
}