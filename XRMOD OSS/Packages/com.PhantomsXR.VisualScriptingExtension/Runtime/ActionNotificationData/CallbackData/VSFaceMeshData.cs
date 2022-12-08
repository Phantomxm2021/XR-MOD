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
#if UNITY_IOS || UNITY_ANDROID

using com.Phantoms.ActionNotification.Runtime;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    /// <summary>
    /// Receive AR-MOD SDK data when found a face.
    /// </summary>
    [UnitCategory("ARMOD/NotificationData/Callback"), UnitShortTitle("Face Mesh Data Response"),
     UnitTitle("Face Mesh Data Response")]
    [TypeIcon(typeof(AxisEventData))]
    public class VSFaceMeshData : Unit
    {
        [DoNotSerialize] [PortLabelHidden] public ValueInput BaseData;
        [DoNotSerialize] [PortLabelHidden] public ValueOutput Result;

        protected override void Definition()
        {
            BaseData =
                ValueInput<FaceMeshNotificationData>(nameof(BaseData));

            Result =
                ValueOutput(nameof(Result),
                    _flow =>
                        _flow.GetValue<FaceMeshNotificationData>(
                            BaseData));
        }
    }
}
#endif