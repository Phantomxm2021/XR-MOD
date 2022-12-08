using Unity.VisualScripting;
using Immersal.AR;

using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Utility"), UnitTitle("Convert From Cloud Space"), UnitShortTitle("Convert From Cloud Space")]
    public class ARMODFromCloudSpaceUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput Position;
        [DoNotSerialize] public ValueInput Rotation;

        [DoNotSerialize] [PortLabel("Position")]
        public ValueOutput CloudSpacePosition;

        [DoNotSerialize] [PortLabel("Rotation")]
        public ValueOutput CloudSpaceRotation;

        private ARSpace arSpace;
        private Pose pose;

        protected override void Definition()
        {
            base.Definition();

            Position = ValueInput<Vector3>(nameof(Position));
            Rotation = ValueInput<Quaternion>(nameof(Rotation));
            CloudSpacePosition = ValueOutput(nameof(CloudSpacePosition), _flow => pose.position);
            CloudSpaceRotation = ValueOutput(nameof(CloudSpaceRotation), _flow => pose.rotation);
            Requirement(Position, inputTrigger);
            Requirement(Rotation, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            if (arSpace == null)
                arSpace = Object.FindObjectOfType<ARSpace>();
            Assert.IsNotNull(arSpace);
            var tmp_Pos = _arg.GetValue<Vector3>(Position);
            var tmp_Rot = _arg.GetValue<Quaternion>(Rotation);
            pose = arSpace.FromCloudSpace(tmp_Pos, tmp_Rot);
            return outputTrigger;
        }
    }
}