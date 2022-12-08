using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Synchronizer"),
     UnitTitle("Quaternion Synchronizer"),
     UnitSurtitle("Quaternion"),
     UnitShortTitle("Synchronous Quaternion"), TypeIcon(typeof(Quaternion))]
    public class QuaternionSynchronizerUnit : BaseSynchronizerUnit
    {
        private QuaternionSynchronizer synchronizerObject;

        protected override void Definition()
        {
            base.Definition();
            SyncValue = ValueInput(nameof(SyncValue), Quaternion.identity);
            Result = ValueOutput(nameof(Result), _flow => synchronizerObject.GetSynchronousValue);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Target = _arg.GetValue<GameObject>(Target);
            Assert.IsNotNull(tmp_Target);
            synchronizerObject = tmp_Target.GetComponent<QuaternionSynchronizer>();
            Assert.IsNotNull(synchronizerObject);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            if (_arg.GetValue<bool>(Write))
                synchronizerObject.CmdModifyValue(_arg.GetValue<Quaternion>(SyncValue), tmp_Sender);

            return outputTrigger;
        }

        public override void Dispose()
        {
            base.Dispose();
            if (synchronizerObject)
                synchronizerObject.UnRegisterValueSyncedCallback();
        }
    }
}