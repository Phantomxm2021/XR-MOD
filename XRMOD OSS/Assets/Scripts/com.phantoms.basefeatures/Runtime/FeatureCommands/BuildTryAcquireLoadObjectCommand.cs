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

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODPackageTools.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildTryAcquireLoadObjectCommand : ICommand, IReleaseCommand
    {
        public BuildTryAcquireLoadObjectCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireLoadObject,
                nameof(ActionParameterDataType.TryAcquireLoadObject)
            );
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.TryAcquireLoadObject));
        }


        /// <summary>
        /// Acquire object from asset bundle package
        /// </summary>
        /// <param name="_base"></param>
        /// <returns></returns>
        private async Task<List<Object>> TryAcquireLoadObject(BaseNotificationData _base)
        {
            List<Object> tmp_Objects = new List<Object>();

            if (!(_base is LoadObjectNotificationData tmp_LoadObjectNotificationData)) return tmp_Objects;
            Type tmp_Type = tmp_LoadObjectNotificationData.LoadObjectType;
            if (tmp_Type == typeof(GameObject))
            {
                foreach (string tmp_LoadedAssetName in tmp_LoadObjectNotificationData.LoadObjectName)
                {
                    var tmp_GameObject = await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                        tmp_LoadObjectNotificationData.ProjectName, tmp_LoadedAssetName);
                    tmp_Objects.Add(tmp_GameObject);
                }
            }
            else if (tmp_Type == typeof(TextAsset))
            {
                foreach (string tmp_ObjName in tmp_LoadObjectNotificationData.LoadObjectName)
                {
                    var tmp_TextAssets =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<TextAsset>(
                            tmp_LoadObjectNotificationData.ProjectName, tmp_ObjName);
                    tmp_Objects.Add(tmp_TextAssets);
                }
            }
            else
            {
                throw new TypeAccessException();
            }

            return tmp_Objects;
        }
    }
}