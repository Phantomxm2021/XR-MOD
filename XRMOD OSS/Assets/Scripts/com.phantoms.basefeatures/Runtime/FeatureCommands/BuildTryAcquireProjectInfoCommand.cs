// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildTryAcquireProjectInfoCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireProjectInfoCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireProjectInfo,
                nameof(ActionParameterDataType.TryAcquireProjectInfo));
        }


        /// <summary>
        /// Get AR experience project uid, this project uid parameter from developer passing.
        /// </summary>
        /// <param name="_base">Notification data</param>
        /// <returns>Project uid</returns>
        private string TryAcquireProjectInfo(BaseNotificationData _base)
        {
            return JsonUtility.ToJson(IocContainer.GetIoc.Resolve<BaseContextDataModel>().ProjectInfo);
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(TryAcquireProjectInfo));
        }
    }
}