using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"), 
     UnitTitle("Int TargetRPC"),
     UnitSurtitle("Int"),
     UnitShortTitle("TargetRPC"),
    TypeIcon(typeof(int))]
    public class TargetRpcRemoteActionIntUnit:BaseTargetRpcRemoteActionUnit<int>
    {
    }
}