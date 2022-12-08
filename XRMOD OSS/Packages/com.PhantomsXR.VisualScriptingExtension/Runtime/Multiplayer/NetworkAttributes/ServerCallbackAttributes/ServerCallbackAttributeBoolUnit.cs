using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"),
     UnitTitle("Bool ServerCallback Trigger"),
     UnitSurtitle("Bool"),
     UnitShortTitle("ServerCallback Trigger"),
     TypeIcon(typeof(bool))]
    public class ServerCallbackAttributeBoolUnit : BaseServerCallbackAttributeUnit<bool>
    {
    }
}