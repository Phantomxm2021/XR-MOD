using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Assign ClientAuthority"),
     UnitShortTitle("Assign ClientAuthority")]
    public class AssignClientAuthorityUnit : ARMODBaseUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput AssignObject;
        [DoNotSerialize] [NullMeansSelf] public ValueInput Connection;

        protected override void Definition()
        {
            base.Definition();
            AssignObject = ValueInput(nameof(AssignObject), (NetworkIdentity) null).NullMeansSelf();
            Connection = ValueInput(nameof(Connection), (NetworkIdentity) null).NullMeansSelf();
            Requirement(AssignObject, inputTrigger);
            Requirement(Connection, inputTrigger);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_NetworkIdentity = _arg.GetValue<NetworkIdentity>(AssignObject);
            Assert.IsNotNull(tmp_NetworkIdentity);
            var tmp_Connection = _arg.GetValue<NetworkIdentity>(Connection);

            if (tmp_NetworkIdentity)
            {
                XRMODServices.GetBridge().AssignClientAuthority(tmp_NetworkIdentity, tmp_Connection);
            }

            return outputTrigger;
        }
    }
}