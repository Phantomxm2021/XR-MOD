using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/NetworkAttributes/ServersCallback"),
     UnitTitle("Default ServerCallback Trigger"),
     UnitSurtitle("None"),
     UnitShortTitle("Default ServerCallback Trigger"),
     TypeIcon(typeof(CustomEvent))]
    public class ServerCallbackAttributeUnit : BaseNetworkAttributeWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkingCallbacks>(Attributes);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.ServerCallbackSender);

            if (NetworkClient.localPlayer.isServer)
            {
                tmp_RemoteActions.ServerCallbackSender(tmp_EventName, tmp_Sender);
            }

            return outputTrigger;
        }
    }
}