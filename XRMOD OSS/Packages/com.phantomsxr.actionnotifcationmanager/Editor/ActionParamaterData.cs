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

using System.Collections.Generic;
using UnityEngine;

namespace Action_Notification_Manager.Editor
{
    //[CreateAssetMenu(menuName = "AR-MOD/ANM/ActionKey")]
    public class ActionParamaterData : ScriptableObject
    {
        public List<string> ObserverKeys = new List<string>();
    }
}