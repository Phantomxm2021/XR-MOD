using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"),
     UnitTitle("Float Server Trigger"),
     UnitSurtitle("Float"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(float))]
    public class ServerAttributeFloatUnit : BaseServerAttributeUnit<float>
    {
    }
}