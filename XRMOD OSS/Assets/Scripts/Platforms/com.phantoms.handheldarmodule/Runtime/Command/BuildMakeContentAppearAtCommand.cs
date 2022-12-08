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
using HandheldARModule.Runtime.Models;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace HandheldARModule.Runtime.Command
{
    public class BuildMakeContentAppearAtCommand : ICommand, IReleaseCommand
    {
        public BuildMakeContentAppearAtCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(MakeContentAppearAt,
                nameof(ActionParameterDataType.MakeContentAppearAt));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.MakeContentAppearAt));
        }


        /// <summary>
        /// Make content Appear at for open api
        /// </summary>
        /// <param name="_data"></param>
        private void MakeContentAppearAt(BaseNotificationData _data)
        {
            Assert.IsNotNull(_data);
            if (_data is not MakeContentAppearAtNotificationData tmp_Data) return;
            Assert.IsNotNull(tmp_Data.ContentTrans);

            IocContainer.GetIoc.Resolve<ARComponentModel>().XROrigin
                .MakeContentAppearAt(tmp_Data.ContentTrans, tmp_Data.Position, tmp_Data.Rotation);
        }
    }
}