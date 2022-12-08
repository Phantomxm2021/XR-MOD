using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"), 
     UnitTitle("Int Server Trigger"),
     UnitSurtitle("Int"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(int))]
    public class ServerAttributeIntUnit:BaseServerAttributeUnit<int>
    {
    }
}