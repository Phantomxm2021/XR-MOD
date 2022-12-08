using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"),
     UnitTitle("Bool ClientCallback Trigger"),
     UnitSurtitle("Bool"),
     UnitShortTitle("ClientCallback Trigger"),
    TypeIcon(typeof(bool))]
    public class ClientCallbackBoolUnit : BaseClientCallbackAttributeUnit<bool>
    {
    }
}