using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"), 
     UnitTitle("Int Client Trigger"),
     UnitSurtitle("Int"),
     UnitShortTitle("Client Trigger"),
     TypeIcon(typeof(int))]
    public class ClientAttributeIntUnit:BaseClientAttributeUnit<int>
    {
    }
}