using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/ClientRPC"),
     UnitTitle("TransformData ClientRPC"),
     UnitSurtitle("TransformData"),
     UnitShortTitle("ClientRPC Trigger"),
     TypeIcon(typeof(Transform))]
    public class ClientRpcRemoteActionTransformUnit : BaseClientRPCRemoteActionUnit<TransformData>
    {
    }
}