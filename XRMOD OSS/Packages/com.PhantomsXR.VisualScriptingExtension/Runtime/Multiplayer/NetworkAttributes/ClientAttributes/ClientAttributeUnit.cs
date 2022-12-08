using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Client"),
     UnitTitle("Default Client Trigger"),
     UnitSurtitle("None"),
     UnitShortTitle("Default Client Trigger"),
     TypeIcon(typeof(CustomEvent))]
    public class ClientAttributeUnit : BaseNetworkAttributeWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkingCallbacks>(Attributes);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.ClientSender);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);

            if (tmp_RemoteActions.hasAuthority)
            {
                tmp_RemoteActions.ClientSender(tmp_EventName, tmp_Sender);
            }
            else
                Debug.LogWarning("Current side has not authority!");

            return outputTrigger;
        }
    }
}