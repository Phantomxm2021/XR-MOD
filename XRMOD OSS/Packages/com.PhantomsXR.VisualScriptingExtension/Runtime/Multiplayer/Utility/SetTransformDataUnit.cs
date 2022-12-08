// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;

using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitSurtitle("Create"),
     UnitTitle("Create TransformData"), TypeIcon(typeof(Transform)),UnitShortTitle("TransformData")]
    public class SetTransformDataUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] public ValueInput Position;
        [DoNotSerialize] public ValueInput Rotation;
        [DoNotSerialize] public ValueInput Scale;

        private TransformData transformData;

        protected override void Definition()
        {
            base.Definition();

            Position = ValueInput(nameof(Position), Vector3.zero);
            Rotation = ValueInput(nameof(Rotation), Quaternion.identity);
            Scale = ValueInput(nameof(Scale), Vector3.one);

            Result = ValueOutput(nameof(Result), _flow => transformData);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            transformData = new TransformData
            {
                Position = _arg.GetValue<UnityEngine.Vector3>(Position),
                Rotation = _arg.GetValue<UnityEngine.Quaternion>(Rotation),
                Scale = _arg.GetValue<UnityEngine.Vector3>(Scale)
            };
            return outputTrigger;
        }
    }
}