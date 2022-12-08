using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/Server"),
     UnitTitle("Default Server Trigger"),
     UnitSurtitle("None"),
     UnitShortTitle("Default Server Trigger"),
     TypeIcon(typeof(CustomEvent))]
    public class ServerAttributeUnit : BaseNetworkAttributeWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkingCallbacks>(Attributes);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.ServerSender);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            if (NetworkClient.localPlayer.isServer)
            {
                tmp_RemoteActions.ServerSender(tmp_EventName, tmp_Sender);
            }

            return outputTrigger;
        }
    }
}