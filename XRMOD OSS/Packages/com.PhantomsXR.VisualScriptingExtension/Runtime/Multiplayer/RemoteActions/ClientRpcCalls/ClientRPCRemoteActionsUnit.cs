using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/ClientRPC"),
     UnitTitle("Default ClientRPC Trigger"),
     UnitSurtitle("None"),
     UnitShortTitle("ClientRPC Trigger"), TypeIcon(typeof(CustomEvent))]
    public class ClientRPCRemoteActionsUnit : BaseNetworkRemoteActionsWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkRemoteActions>(RemoteActions);
            Assert.IsNotNull(tmp_RemoteActions);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            resultEventKey = nameof(tmp_RemoteActions.RpcClientRpcSender);
            if (NetworkClient.localPlayer.isServer)
            {
                tmp_RemoteActions.RpcClientRpcSender(tmp_EventName, tmp_Sender);
            }

            return outputTrigger;
        }
    }
}