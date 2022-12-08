using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Synchronizer"),
     UnitTitle("Vector3 Synchronizer"),
     UnitSurtitle("Vector3"),
     UnitShortTitle("Synchronous Vector3"),
     TypeIcon(typeof(Transform))]
    public class Vector3SynchronizerUnit : BaseSynchronizerUnit
    {
        private Vector3Synchronizer synchronizerObject;

        protected override void Definition()
        {
            base.Definition();
            SyncValue = ValueInput(nameof(SyncValue), Vector3.zero);
            Result = ValueOutput(nameof(Result), _flow => synchronizerObject.GetSynchronousValue);
        }


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Target = _arg.GetValue<GameObject>(Target);
            Assert.IsNotNull(tmp_Target);
            synchronizerObject = tmp_Target.GetComponent<Vector3Synchronizer>();
            Assert.IsNotNull(synchronizerObject);
            var tmp_Sender = _arg.GetValue<NetworkIdentity>(Sender);

            if (_arg.GetValue<bool>(Write))
                synchronizerObject.CmdModifyValue(_arg.GetValue<Vector3>(SyncValue), tmp_Sender);
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