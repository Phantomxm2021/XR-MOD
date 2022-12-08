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

using System;

namespace XRMODEngineCore.Runtime
{
    public class Event
    {
        private Action onEvent;

        public void RegisterEvent(Action _event)
        {
            onEvent += _event;
        }

        public void UnRegisterEvent(Action _event)
        {
            onEvent -= _event;
        }

        public void UnRegisterAll()
        {
            onEvent = null;
        }

        public void TriggerEvent()
        {
            onEvent?.Invoke();
        }
    }
}