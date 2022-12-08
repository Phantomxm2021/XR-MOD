using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"), 
     UnitTitle("Int ServerCallback Trigger"),
     UnitSurtitle("Int"),
     UnitShortTitle("ServerCallback Trigger"),
     TypeIcon(typeof(int))]
    public class ServerCallbackAttributeIntUnit:BaseServerCallbackAttributeUnit<int>
    {
    }
}