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
using System.IO;
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.BaseFeatures.Runtime.Models;
using com.phantoms.gltfextension.Runtime;
using UnityEngine.Networking;
using XRMODEngineCore.Runtime;
using Cysharp.Threading.Tasks;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildNetworkMeshDownloadCommand : ICommand, IReleaseCommand
    {
        public BuildNetworkMeshDownloadCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireDownloadMesh,
                nameof(ActionParameterDataType.DownloadMesh));
        }

        private async void TryAcquireDownloadMesh(BaseNotificationData _baseNotification)
        {
            var tmp_Path = new Uri(_baseNotification.BaseData).GetLeftPart(UriPartial.Path);
            var tmp_FileName = Path.GetFileName(tmp_Path);

            var tmp_FileCachePath = Path.Combine(GltfFileCacheManager.CachePath, tmp_FileName);
            var tmp_GltfCacheManager = IocContainer.GetIoc.Resolve<BaseFeatureModel>().GltfFileCacheManager;
            var tmp_Record = tmp_GltfCacheManager.GetRecord(new Uri(_baseNotification.BaseData));

            if (string.IsNullOrEmpty(tmp_Record))
            {
                var tmp_Request = UnityWebRequest.Get(_baseNotification.BaseData);
                tmp_Request.timeout = 10;

                await tmp_Request.SendWebRequest();
                await File.WriteAllBytesAsync(tmp_FileCachePath, tmp_Request.downloadHandler.data);
                tmp_GltfCacheManager.AddNewRecord(new Uri(_baseNotification.BaseData));
            }

            _baseNotification.NotificationActWithData?.Invoke(tmp_FileCachePath);
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.DownloadMesh));
        }
    }
}