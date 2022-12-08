using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"),
     UnitTitle("Float Client Trigger"),
     UnitSurtitle("Float"),
     UnitShortTitle("Client Trigger"),
     TypeIcon(typeof(float))]
    public class ClientAttributeFloatUnit : BaseClientAttributeUnit<float>
    {
    }
}