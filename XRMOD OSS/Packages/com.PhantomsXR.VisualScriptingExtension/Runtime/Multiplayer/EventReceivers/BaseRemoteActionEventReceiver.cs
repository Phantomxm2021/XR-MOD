using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class BaseRemoteActionEventReceiver : BaseEventReceiver
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput RemoteAction;
        protected NetworkRemoteActions NetworkRemoteActions;

        protected override void Definition()
        {
            base.Definition();
            RemoteAction = ValueInput(nameof(RemoteAction), (NetworkingCallbacks)null).NullMeansSelf();
            Requirement(RemoteAction, inputTrigger);
            Requirement(EventTarget, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            NetworkRemoteActions = _arg.GetValue<NetworkRemoteActions>(RemoteAction);
            Assert.IsNotNull(NetworkRemoteActions);
            DataTypeEnum = _arg.GetValue<DataType>(DataType);
            RegisterPropertiesSyncedEvent(_arg);
            return outputTrigger;
        }

        protected abstract void RegisterPropertiesSyncedEvent(Flow _arg);
    }
}