using Mirror;
using Unity.VisualScripting;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Is Server"), UnitShortTitle("Is Server")]
    public class IsServerUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] [PortLabelHidden]
        public ValueInput Target;

        private NetworkIdentity networkIdentity;
        private bool isServer;

        protected override void Definition()
        {
            base.Definition();
            Target = ValueInput(nameof(Target), (NetworkIdentity) null).NullMeansSelf();
            Result = ValueOutput(nameof(Result), _flow => isServer);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            Assert.IsNotNull(Target);
            networkIdentity = _arg.GetValue<NetworkIdentity>(Target);
            isServer = networkIdentity.isServer;
            return outputTrigger;
        }
    }
}