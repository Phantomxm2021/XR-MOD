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
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitSurtitle("Get"),
     UnitTitle("Get TransformData"), TypeIcon(typeof(Transform)), UnitShortTitle("TransformData")]
    public class GetTransformDataUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput TransformData;
        [DoNotSerialize] public ValueOutput Position;
        [DoNotSerialize] public ValueOutput Rotation;
        [DoNotSerialize] public ValueOutput Scale;

        private TransformData transformData;

        protected override void Definition()
        {
            base.Definition();

            TransformData = ValueInput<TransformData>(nameof(TransformData));
            Position = ValueOutput(nameof(Position), _flow => transformData.Position);
            Rotation = ValueOutput(nameof(Rotation), _flow => transformData.Rotation);
            Scale = ValueOutput(nameof(Scale), _flow => transformData.Scale);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            transformData = _arg.GetValue<TransformData>(TransformData);
            return outputTrigger;
        }
    }
}