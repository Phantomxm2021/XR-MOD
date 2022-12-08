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
    [UnitCategory("ARMOD/Multiplayer/RemoteActions/Command"),
     UnitTitle("GameObject Command Trigger"),
     UnitSurtitle("GameObject"),
     UnitShortTitle("Command Trigger"), TypeIcon(typeof(GameObject))]
    public class CommandRemoteRemoteActionGameObjectUnit : BaseCommandRemoteActionUnit<GameObject>
    {
    }
}