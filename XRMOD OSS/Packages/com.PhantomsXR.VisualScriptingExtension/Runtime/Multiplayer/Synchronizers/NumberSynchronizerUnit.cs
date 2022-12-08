using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Synchronizer"),
     UnitTitle("Number Synchronizer"),
     UnitSurtitle("Number"),
     UnitShortTitle("Synchronous Number"),
     TypeIcon(typeof(float))]
    public class NumberSynchronizerUnit : BaseSynchronizerUnit
    {
        private NumberSynchronizer synchronizerObject;

        protected override void Definition()
        {
            base.Definition();
            SyncValue = ValueInput(nameof(SyncValue), 0);
            Result = ValueOutput(nameof(Result), _flow => synchronizerObject.GetSynchronousValue);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Target = _arg.GetValue<GameObject>(Target);
            synchronizerObject = tmp_Target.GetComponent<NumberSynchronizer>();
            Assert.IsNotNull(synchronizerObject);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);
            if (_arg.GetValue<bool>(Write))
                synchronizerObject.CmdModifyValue(_arg.GetValue<float>(SyncValue),tmp_Sender);

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