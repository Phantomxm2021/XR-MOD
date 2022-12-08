using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"),
     UnitTitle("TransformData TargetRPC Trigger"),
     UnitSurtitle("TransformData"),
     UnitShortTitle("TargetRPC Trigger"), TypeIcon(typeof(Transform))]
    public class TargetRpcRemoteActionTransformUnit : BaseTargetRpcRemoteActionUnit<TransformData>
    {
    }
}