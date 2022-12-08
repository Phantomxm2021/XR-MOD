using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"),
     UnitTitle("Float ServerCallback Trigger"),
     UnitSurtitle("Float"),
     UnitShortTitle("ServerCallback Trigger"),
     TypeIcon(typeof(float))]
    public class ServerCallbackAttributeFloatUnit : BaseServerCallbackAttributeUnit<float>
    {
    }
}