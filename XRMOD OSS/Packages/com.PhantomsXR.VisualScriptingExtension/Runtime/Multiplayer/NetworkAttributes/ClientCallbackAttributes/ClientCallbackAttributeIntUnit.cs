using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"), 
     UnitTitle("Int ClientCallback Trigger"),
     UnitSurtitle("Int"),
     UnitShortTitle("ClientCallback Trigger"),
     TypeIcon(typeof(int))]
    public class ClientCallbackAttributeIntUnit:BaseClientCallbackAttributeUnit<int>
    {
    }
}