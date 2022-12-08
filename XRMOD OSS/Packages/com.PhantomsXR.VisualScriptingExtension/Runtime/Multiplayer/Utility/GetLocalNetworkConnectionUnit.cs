using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Get NetworkConnection"),
     UnitShortTitle("Get NetworkConnection")]
    public class GetLocalNetworkConnectionUnit : ARMODBaseWithResultUnit
    {
        private NetworkConnectionToServer networkConnectionToClient;

        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => networkConnectionToClient);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            networkConnectionToClient =
                XRMODServices.GetBridge().GetLocalNetworkConnection() as NetworkConnectionToServer;
            return outputTrigger;
        }
    }
}