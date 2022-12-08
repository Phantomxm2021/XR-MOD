// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARAlgorithm.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildARAvailabilityCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            var tmp_MonoBehaviour = Object.FindObjectOfType<MonoBehaviour>();
            tmp_MonoBehaviour.StartCoroutine(CheckAvailability());
        }

        private IEnumerator CheckAvailability()
        {
            if (ARSession.state is ARSessionState.None or ARSessionState.CheckingAvailability)
            {
                yield return ARSession.CheckAvailability();
            }
#if UNITY_EDITOR
            IocContainer.GetIoc.Resolve<ARContextDataModel>().ARSessionState.Value = ARSessionState.SessionTracking;
#else
            IocContainer.GetIoc.Resolve<ARContextDataModel>().ARSessionState.Value = ARSession.state;
#endif
        }

        public void Release()
        {
        }
    }
}