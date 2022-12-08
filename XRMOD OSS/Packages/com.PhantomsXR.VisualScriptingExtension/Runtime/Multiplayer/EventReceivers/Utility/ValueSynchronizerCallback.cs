using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/EventReceivers/Other"),
     UnitSurtitle("Event Receiver"),
     UnitTitle("Register Synchronizer Receiver"),
     UnitShortTitle("Register Synchronous Value"),TypeIcon(typeof(AnimatorMessageListener))]
    public class ValueSynchronizerCallback : ARMODBaseUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize] [NullMeansSelf] public ValueInput Synchronizer;
        [DoNotSerialize, PortLabelHidden] public ValueInput SynchronizeType;

        private static readonly string CONST_EVENT_NUMBER_KEY = $"On{nameof(NumberSynchronizer)}Callback";
        private static readonly string CONST_EVENT_QUATERNION_KEY = $"On{nameof(QuaternionSynchronizer)}Callback";
        private static readonly string CONST_EVENT_STRING_KEY = $"On{nameof(StringSynchronizer)}Callback";
        private static readonly string CONST_EVENT_VECTOR3_KEY = $"On{nameof(Vector3Synchronizer)}Callback";
        private static readonly string CONST_EVENT_BOOL_KEY = $"On{nameof(BoolSynchronizer)}Callback";


        protected SynchronizeType SynchronizeTypeEnum;

        protected override void Definition()
        {
            base.Definition();
            Synchronizer = ValueInput(nameof(Synchronizer), (GameObject) null).NullMeansSelf();
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            SynchronizeType = ValueInput(nameof(SynchronizeType), Runtime.SynchronizeType.Int);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            Assert.IsNotNull(EventTarget);
            var tmp_EventTarget = _arg.GetValue<GameObject>(EventTarget);
            SynchronizeTypeEnum = _arg.GetValue<SynchronizeType>(SynchronizeType);


            switch (SynchronizeTypeEnum)
            {
                case Runtime.SynchronizeType.Float:
                case Runtime.SynchronizeType.Int:
                    var tmp_NumberSynchronous =
                        _arg.GetValue<GameObject>(Synchronizer).GetComponent<NumberSynchronizer>();
                    tmp_NumberSynchronous.RegisterValueSyncedCallback((_value,_sender) =>
                    {
                        CustomEvent.Trigger(tmp_EventTarget, CONST_EVENT_NUMBER_KEY, _value,_sender);
                    });
                    break;
                case Runtime.SynchronizeType.Bool:
                    var tmp_BoolSynchronous =
                        _arg.GetValue<GameObject>(Synchronizer).GetComponent<BoolSynchronizer>();
                    tmp_BoolSynchronous.RegisterValueSyncedCallback((_value,_sender) =>
                    {
                        CustomEvent.Trigger(tmp_EventTarget, CONST_EVENT_BOOL_KEY, _value,_sender);
                    });
                    break;

                case Runtime.SynchronizeType.String:
                    var tmp_StringSynchronous =
                        _arg.GetValue<GameObject>(Synchronizer).GetComponent<StringSynchronizer>();
                    tmp_StringSynchronous.RegisterValueSyncedCallback((_value,_sender) =>
                    {
                        CustomEvent.Trigger(tmp_EventTarget, CONST_EVENT_STRING_KEY, _value,_sender);
                    });
                    break;
                case Runtime.SynchronizeType.Vector3:
                    var tmp_Vector3Synchronous =
                        _arg.GetValue<GameObject>(Synchronizer).GetComponent<Vector3Synchronizer>();
                    tmp_Vector3Synchronous.RegisterValueSyncedCallback((_value,_sender) =>
                    {
                        CustomEvent.Trigger(tmp_EventTarget, CONST_EVENT_VECTOR3_KEY, _value,_sender);
                    });
                    break;
                case Runtime.SynchronizeType.Quaternion:
                    var tmp_QuaternionSynchronous =
                        _arg.GetValue<GameObject>(Synchronizer).GetComponent<QuaternionSynchronizer>();
                    tmp_QuaternionSynchronous.RegisterValueSyncedCallback((_value,_sender) =>
                    {
                        CustomEvent.Trigger(tmp_EventTarget, CONST_EVENT_QUATERNION_KEY, _value,_sender);
                    });
                    break;
            }

            return outputTrigger;
        }
    }
}