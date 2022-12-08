using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"),
     UnitTitle("Bool Client Trigger"),
     UnitSurtitle("Bool"),
     UnitShortTitle("Client Trigger"),
     TypeIcon(typeof(bool))]
    public class ClientAttributeBoolUnit : BaseClientAttributeUnit<bool>
    {
    }
}