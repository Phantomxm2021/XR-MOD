using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"),
     UnitSurtitle("TransformData"),
     UnitTitle("TransformData ClientCallback Trigger"),
     UnitShortTitle("ClientCallback Trigger"),
     TypeIcon(typeof(Transform))]
    public class ClientCallbackAttributeTransformUnit : BaseClientAttributeUnit<TransformData>
    {
    }
}