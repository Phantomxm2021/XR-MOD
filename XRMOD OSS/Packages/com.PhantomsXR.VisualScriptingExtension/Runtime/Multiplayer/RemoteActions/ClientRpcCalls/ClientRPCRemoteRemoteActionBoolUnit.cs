using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/ClientRPC"),
     UnitTitle("Bool ClientRPC"),
     UnitSurtitle("Bool"),
     UnitShortTitle("ClientRPC Trigger"),
    TypeIcon(typeof(bool))]
    public class ClientRPCRemoteRemoteActionBoolUnit : BaseClientRPCRemoteActionUnit<bool>
    {
    }
}