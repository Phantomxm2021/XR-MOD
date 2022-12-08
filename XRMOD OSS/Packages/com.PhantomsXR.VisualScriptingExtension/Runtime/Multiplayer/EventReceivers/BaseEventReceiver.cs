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
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class BaseEventReceiver:ARMODBaseUnit
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
        [DoNotSerialize] [NullMeansSelf] [PortLabelHidden]
        public ValueInput DataType;
        [DoNotSerialize]  public ValueInput EventName;

        protected DataType DataTypeEnum;
        
        protected override void Definition()
        {
            base.Definition();
            EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
            DataType = ValueInput(nameof(DataType), Runtime.DataType.None);
            EventName = ValueInput(nameof(EventName), string.Empty);
            Requirement(EventTarget, inputTrigger);
        }
    }
}