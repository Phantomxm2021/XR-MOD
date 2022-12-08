using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"),
     UnitTitle("TransformData ServerCallback Trigger"),
     UnitSurtitle("TransformData"),
     UnitShortTitle("ServerCallback Trigger"),
     TypeIcon(typeof(Transform))]
    public class ServerCallbackAttributeTransformUnit : BaseServerCallbackAttributeUnit<TransformData>
    {
    }
}