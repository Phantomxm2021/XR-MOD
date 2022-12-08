using Mirror;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class BaseSynchronizerUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput Target;
        [DoNotSerialize] [NullMeansSelf] public ValueInput Sender;
        [DoNotSerialize] public ValueInput Write;
        [DoNotSerialize] public ValueInput SyncValue;

        protected override void Definition()
        {
            base.Definition();
            Target = ValueInput(nameof(Target), (GameObject) null).NullMeansSelf();
            Sender = ValueInput(nameof(Sender), (NetworkIdentity) null).NullMeansSelf();
            Write = ValueInput<bool>(nameof(Write), false);
        }
    }
}