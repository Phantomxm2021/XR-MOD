using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"),
     UnitTitle("TransformData Server Trigger"),
     UnitSurtitle("TransformData"),
     UnitShortTitle("Server Trigger"),
     TypeIcon(typeof(Transform))]
    public class ServerAttributeTransformUnit : BaseServerAttributeUnit<TransformData>
    {
    }
}