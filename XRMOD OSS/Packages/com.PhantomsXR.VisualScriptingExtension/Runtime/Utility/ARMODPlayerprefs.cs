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

using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public enum OperationTypeEnum
    {
        Save,
        Read,
    }

    [UnitCategory("ARMOD/Utility"), UnitTitle("KV Local Store")]
    [TypeIcon(typeof(AxisEventData))]
    public class ARMODPlayerprefs : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize] public ValueInput Key;
        [DoNotSerialize] public ValueInput Value;
        [DoNotSerialize] public ValueInput OperationType;


        private string getValueByKey;

        protected override void Definition()
        {
            base.Definition();
            Key = ValueInput(nameof(Key), string.Empty);
            Value = ValueInput(nameof(Value), string.Empty);
         
            OperationType = ValueInput(nameof(OperationType), OperationTypeEnum.Save);
            Result = ValueOutput(nameof(Result), _flow => getValueByKey);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_Api = _arg.GetValue<API>(Api);
            var tmp_Key = _arg.GetValue<string>(Key);
            var tmp_Value = _arg.GetValue<string>(Value);
            var tmp_OperationType = _arg.GetValue<OperationTypeEnum>(OperationType);
            switch (tmp_OperationType)
            {
                case OperationTypeEnum.Save:
                    tmp_Api?.SaveKeyAndValue(tmp_Key, tmp_Value);
                    getValueByKey = tmp_Value;
                    break;
                case OperationTypeEnum.Read:
                    getValueByKey = tmp_Api?.GetValueByKey(tmp_Key);
                    break;
            }

            return outputTrigger;
        }
    }
}