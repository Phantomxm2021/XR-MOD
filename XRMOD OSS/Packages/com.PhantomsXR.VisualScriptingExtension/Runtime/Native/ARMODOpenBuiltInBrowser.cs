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

using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Native"), UnitTitle("Open Built-InBrowser")]
    [TypeIcon(typeof(Application))]
    public class ARMODOpenBuiltInBrowser : ARMODBaseWithResultUnitIncludeApi
    {
        [DoNotSerialize][PortLabel("Data")] public ValueInput OpenBuiltInData;

        protected override void Definition()
        {
            base.Definition();
            OpenBuiltInData = ValueInput<OpenBuiltInNotificationData>(nameof(OpenBuiltInData));
        }

        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_API = _arg.GetValue<API>(Api);
            tmp_API.OpenBuiltInBrowser(_arg.GetValue<OpenBuiltInNotificationData>(OpenBuiltInData));
            return outputTrigger;
        }
    }
}