using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"),
     UnitSurtitle("TransformData"),
     UnitTitle("TransformData Client Trigger"),
     UnitShortTitle("Client Trigger"),
     TypeIcon(typeof(Transform))]
    public class ClientAttributeTransformUnit : BaseClientAttributeUnit<TransformData>
    {
    }
}