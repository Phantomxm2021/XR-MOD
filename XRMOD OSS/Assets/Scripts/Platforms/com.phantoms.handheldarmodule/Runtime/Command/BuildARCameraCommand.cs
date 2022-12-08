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

using HandheldARModule.Runtime.Models;
using HandheldARModule.Runtime.Utility;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildARCameraCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            ARContextDataModel tmp_ARContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            var tmp_SceneGrab = UnityEngine.Object.FindObjectOfType<SceneGrab>();
            Assert.IsNotNull(tmp_SceneGrab);
            tmp_SceneGrab.BuiltinCamera.SetActive(false);

            //Does not support ARKit or ARCore, we need to be compatible
            //Just Web camera and 3D content
            if (!IocContainer.GetIoc.Resolve<ARAlgorithmUtility>().ARAvailability())
            {
                //Disable ARKit or ARCore sdk
                tmp_ARContextData.StopARModule = true;
                LoaderUtility.Deinitialize();

                //NotSupportedCompatibleDecorator();
                Object.Destroy(tmp_SceneGrab);
            }
            else
            {
                foreach (var tmp_ARObj in tmp_SceneGrab.HandheldARGameObjects)
                {
                    tmp_ARObj.SetActive(true);
                }
            }
        }

        public void Release()
        {
        }
    }
}