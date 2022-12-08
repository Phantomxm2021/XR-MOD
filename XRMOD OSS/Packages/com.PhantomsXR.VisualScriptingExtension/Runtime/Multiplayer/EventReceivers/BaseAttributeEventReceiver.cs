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

using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public abstract class BaseAttributeEventReceiver:BaseEventReceiver
    {
        [DoNotSerialize] [NullMeansSelf] public ValueInput Attributes;
        protected NetworkingCallbacks NetworkingCallbacks;

        protected override void Definition()
        {
            base.Definition();
            Attributes = ValueInput(nameof(Attributes), (NetworkingCallbacks)null).NullMeansSelf();
            Requirement(Attributes, inputTrigger);
            Requirement(EventTarget, inputTrigger);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            NetworkingCallbacks = _arg.GetValue<NetworkingCallbacks>(Attributes);
            Assert.IsNotNull(NetworkingCallbacks);
            DataTypeEnum = _arg.GetValue<DataType>(DataType);
            RegisterPropertiesSyncedEvent(_arg);
            return outputTrigger;
        }

        protected abstract void RegisterPropertiesSyncedEvent(Flow _arg);
    }
}