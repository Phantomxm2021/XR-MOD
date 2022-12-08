// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the HandheldARModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using UnityEngine;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Platform.iOS
{
    public class ARKitDependenceInject : MonoBehaviour, IPlatformDependenceInject
    {
        public void Inject()
        {
#if UNITY_IOS
            IocContainer.GetIoc.Register(new BuildCoachingOverlayCommand());
            IocContainer.GetIoc.Register(new BuildARWordMapCommand());
            IocContainer.GetIoc.Register(new ARCollaborationAvailabilityCommand());
            IocContainer.GetIoc.Register(new ARKitCoachingOverlayAvailabilityCommand());
            IocContainer.GetIoc.Register(new BuildMeshingCommand());
#endif
        }

        public void UnInject()
        {
#if UNITY_IOS
            IocContainer.GetIoc.UnRegister<BuildCoachingOverlayCommand>();
            IocContainer.GetIoc.UnRegister<BuildARWordMapCommand>();
            IocContainer.GetIoc.UnRegister<ARCollaborationAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<ARKitCoachingOverlayAvailabilityCommand>();
            IocContainer.GetIoc.UnRegister<BuildMeshingCommand>();

#endif
        }

        public void AddFeature(string _featureName)
        {
#if UNITY_IOS

            switch (_featureName)
            {
                case nameof(BuildCoachingOverlayCommand):
                    IocContainer.GetIoc.Resolve<BuildCoachingOverlayCommand>().Execute();
                    break;
                case "Meshing":
                    IocContainer.GetIoc.Resolve<BuildMeshingCommand>().Execute();
                    break;
            }
#endif
        }
    }
}