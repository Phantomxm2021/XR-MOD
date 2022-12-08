using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"),
     UnitTitle("Bool Server Trigger"),
     UnitSurtitle("Bool"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(bool))]
    public class ServerAttributeBoolUnit : BaseServerAttributeUnit<bool>
    {
    }
}