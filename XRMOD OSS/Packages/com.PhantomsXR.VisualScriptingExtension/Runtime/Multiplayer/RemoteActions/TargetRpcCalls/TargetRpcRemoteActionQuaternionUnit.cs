using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"),
     UnitTitle("Quaternion TargetRPC Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("TargetRPC Trigger"), TypeIcon(typeof(Quaternion))]
    public class TargetRpcRemoteActionQuaternionUnit : BaseTargetRpcRemoteActionUnit<Quaternion>
    {
    }
}