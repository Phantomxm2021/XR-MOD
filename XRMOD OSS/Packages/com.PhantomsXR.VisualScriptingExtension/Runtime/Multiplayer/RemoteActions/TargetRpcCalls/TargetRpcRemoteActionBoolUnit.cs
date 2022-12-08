using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"),
     UnitTitle("Bool TargetRPC Trigger"),
     UnitSurtitle("Bool"),
     UnitShortTitle("TargetRPC Trigger"),
     TypeIcon(typeof(bool))]
    public class TargetRpcRemoteActionBoolUnit : BaseTargetRpcRemoteActionUnit<bool>
    {
    }
}