using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class PlayerPropertiesBaseUnit : ARMODBaseUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize] [NullMeansSelf] public ValueInput Synchronizer;
        [DoNotSerialize] public ValueInput EventResponser;

        protected override void Definition()
        {
            base.Definition();
            Synchronizer = ValueInput(nameof(Synchronizer), (NetworkPropertiesSync) null)
                .NullMeansSelf();
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            EventResponser = ValueInput(nameof(EventResponser), string.Empty);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Synchronizer = _arg.GetValue<NetworkPropertiesSync>(Synchronizer);
            Assert.IsNotNull(tmp_Synchronizer);

            var tmp_EventResponser = _arg.GetValue<string>(EventResponser);

            //Attention:Here must passed the parameters instead.
            //Otherwise is will be cached,resulting in an event object error. 
            ExecuteInternal(tmp_EventResponser, _arg.GetValue<GameObject>(EventTarget), tmp_Synchronizer);
            return outputTrigger;
        }

        protected abstract void ExecuteInternal(string _eventResponser,
            GameObject _eventTarget,
            NetworkPropertiesSync _synchronizer);
    }
}