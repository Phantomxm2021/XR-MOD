using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/ClientRPC"),
     UnitTitle("Float ClientRPC Trigger"),
     UnitSurtitle("Float"),
     UnitShortTitle("ClientRPC Trigger"),
    TypeIcon(typeof(float))]
    public class ClientRPCRemoteRemoteActionFloatUnit : BaseClientRPCRemoteActionUnit<float>
    {
    }
}