using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/TargetRPC"),
     UnitTitle("Default TargetRPC Trigger"),
     UnitShortTitle("Default TargetRPC Trigger"),
     UnitSubtitle("None"),
     TypeIcon(typeof(CustomEvent))]
    public class TargetRpcRemoteActionsUnit : BaseNetworkRemoteActionsWithoutParameterUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_RemoteActions = _arg.GetValue<NetworkRemoteActions>(RemoteActions);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            var tmp_EventName = _arg.GetValue<string>(EventName);
            Assert.IsNotNull(tmp_RemoteActions);
            resultEventKey = nameof(tmp_RemoteActions.TargetRpcSender);
            if (tmp_RemoteActions.hasAuthority)
            {
                tmp_RemoteActions.TargetRpcSender(tmp_EventName, tmp_Sender);
            }
            else
                Debug.LogWarning("Current side has not authority!");

            return outputTrigger;
        }
    }
}