using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/Command"),
     UnitTitle("Quaternion Client Trigger"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("Command Trigger"), TypeIcon(typeof(Quaternion))]
    public class CommandRemoteRemoteActionQuaternionUnit : BaseCommandRemoteActionUnit<Quaternion>
    {
    }
}