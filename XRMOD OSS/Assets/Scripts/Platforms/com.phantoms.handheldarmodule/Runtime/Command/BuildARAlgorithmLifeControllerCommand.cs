// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ARFeatureModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ActionNotification.Runtime;
using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildARAlgorithmLifeControllerCommand : ICommand, IReleaseCommand
    {
        public BuildARAlgorithmLifeControllerCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(ARAlgorithmLifeController,
                nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.ARAlgorithmLifeCTRL));
        }


        /// <summary>
        /// Create the addition ar algorithm
        /// </summary>
        /// <param name="_base">Action data</param>
        private void ARAlgorithmLifeController(BaseNotificationData _base)
        {
            if (!(_base is ARAlgorithmNotificationData tmp_NotifyData)) return;

            System.Type tmp_AlgorithmType = null;
            AbstractDecorator tmp_Decorator;
            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            switch (tmp_NotifyData.ARAlgorithmType)
            {
                case ARAlgorithmType.Anchor:
                    tmp_AlgorithmType = typeof(AnchorCreatorDecorator);
                    IocContainer.GetIoc.Resolve<BuildAnchorCommand>().Execute();
                    break;
                case ARAlgorithmType.FocusSLAM:
                    tmp_AlgorithmType = typeof(FocusSlamDecorator);
                    IocContainer.GetIoc.Resolve<BuildFocusSlamCommand>().Execute();
                    break;
                case ARAlgorithmType.ImageTracker:
                    tmp_AlgorithmType = typeof(ImageTrackDecorator);
                    IocContainer.GetIoc.Resolve<BuildImageTrackCommand>().Execute();
                    break;
#if ENABLE_IMMERSAL
                case ARAlgorithmType.Immersal:
                    tmp_AlgorithmType = typeof(ImmersalDecorator);
                    IocContainer.GetIoc.Resolve<BuildImmersalCommand>().Execute();
                    break;
#endif
                case ARAlgorithmType.FaceMesh:
                    tmp_AlgorithmType = typeof(FaceMeshDecorator);
                    IocContainer.GetIoc.Resolve<BuildFaceMeshCommand>().Execute();
                    break;
                case ARAlgorithmType.ARBackground:
                    tmp_ARComponent.ARCameraBackground.enabled =
                        tmp_NotifyData.ARAlgorithmOperator != ARAlgorithmOperator.PauseAlgorithm;
                    break;
                case ARAlgorithmType.Basic:
                    bool tmp_Paused = tmp_NotifyData.ARAlgorithmOperator != ARAlgorithmOperator.PauseAlgorithm;
                    tmp_ARComponent.ARSession.enabled = tmp_Paused;
                    tmp_ARComponent.ARCameraBackground.enabled = tmp_Paused;
                    break;
                case ARAlgorithmType.Meshing:
                    bool tmp_PausedMeshing = tmp_NotifyData.ARAlgorithmOperator != ARAlgorithmOperator.PauseAlgorithm
                                             || tmp_NotifyData.ARAlgorithmOperator != ARAlgorithmOperator.StopAlgorithm;
                    IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager.gameObject
                        .SetActive(tmp_PausedMeshing);
                    break;
            }

            if (tmp_AlgorithmType == null ||
                !tmp_ARComponent.AbstractDecorators.TryGetValue(tmp_AlgorithmType!, out tmp_Decorator)) return;
            switch (tmp_NotifyData.ARAlgorithmOperator)
            {
                case ARAlgorithmOperator.StartAlgorithm:
                    tmp_Decorator?.StartAlgorithm();
                    break;
                case ARAlgorithmOperator.PauseAlgorithm:
                    tmp_Decorator?.PauseAlgorithm();
                    break;
                case ARAlgorithmOperator.StopAlgorithm:
                    tmp_Decorator?.StopAlgorithm();
                    break;
            }

            tmp_NotifyData.NotificationAct?.Invoke();
        }
    }
}