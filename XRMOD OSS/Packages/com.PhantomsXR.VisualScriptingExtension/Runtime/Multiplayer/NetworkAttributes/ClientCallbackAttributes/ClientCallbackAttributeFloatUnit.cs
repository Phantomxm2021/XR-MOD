using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"),
     UnitTitle("Float ClientCallback Trigger"),
     UnitSurtitle("Float"),
     UnitShortTitle("ClientCallback Trigger"),
     TypeIcon(typeof(float))]
    public class ClientCallbackAttributeFloatUnit : BaseClientCallbackAttributeUnit<float>
    {
    }
}