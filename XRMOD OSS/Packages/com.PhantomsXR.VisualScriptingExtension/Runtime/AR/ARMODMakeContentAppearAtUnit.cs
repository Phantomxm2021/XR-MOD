// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if UNITY_IOS || UNITY_ANDROID

using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/AR"), UnitTitle("Make Content Appear At"),TypeIcon(typeof(GameObject))]
    public class ARMODMakeContentAppearAtUnit:ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize] public ValueInput Position;
        [DoNotSerialize] public ValueInput Rotation;
        [DoNotSerialize] public ValueInput ContentTransform;
        
        protected override void Definition()
        {
            base.Definition();
            Position = ValueInput(nameof(Position), Vector3.zero);
            Rotation = ValueInput(nameof(Rotation), Quaternion.identity);
            ContentTransform = ValueInput(nameof(ContentTransform), (Transform)null);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Position = _arg.GetValue<Vector3>(Position);
            var tmp_Rotation = _arg.GetValue<Quaternion>(Rotation);
            var tmp_Transform = _arg.GetValue<Transform>(ContentTransform);
            _arg.GetValue<API>(Api).MakeContentAppearAt(tmp_Transform,tmp_Position,tmp_Rotation);
            return outputTrigger;
        }
    }
}
#endif