using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ClientCallback"),
     UnitTitle("Default ClientCallback Trigger"),
     UnitSurtitle("None"),
     UnitShortTitle("Default ClientCallback Trigger"),
     TypeIcon(typeof(CustomEvent))]
    public class ClientCallbackAttributeUnit : BaseNetworkAttributeWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkingCallbacks>(Attributes);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.ClientCallbackSender);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_Eventname = _arg.GetValue<string>(EventName);

            if (tmp_RemoteActions.hasAuthority)
            {
                tmp_RemoteActions.ClientCallbackSender(tmp_Eventname, tmp_Sender);
            }

            return outputTrigger;
        }
    }
}