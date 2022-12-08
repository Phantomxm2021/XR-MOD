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
using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.BaseFeatures.Runtime.Models;
using GLTFast;
using UnityEngine;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildGltfLoaderCommand : ICommand, IReleaseCommand
    {
        public BuildGltfLoaderCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireNetworkMesh,
                nameof(ActionParameterDataType.TryAcquireNetworkMesh));
        }

        public void Release()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(TryAcquireNetworkMesh));
            ReleaseShaders();
        }


        private void ReleaseShaders()
        {
            string[] tmp_ShaderNames = {"glTF-pbrMetallicRoughness", "glTF-pbrSpecularGlossiness", "glTF-unlit"};
            foreach (string tmp_ShaderName in tmp_ShaderNames)
            {
                var tmp_Shader = Shader.Find($"Shader Graphs/{tmp_ShaderName}");
                Resources.UnloadAsset(tmp_Shader);
            }
        }

        /// <summary>
        /// Get the mesh file from network
        /// </summary>
        /// <param name="_base">Notification data</param>
        private async void TryAcquireNetworkMesh(BaseNotificationData _base)
        {
            var tmp_GltfFileCacheManager = IocContainer.GetIoc.Resolve<BaseFeatureModel>().GltfFileCacheManager;
            var tmp_LocalPath = tmp_GltfFileCacheManager.GetRecord(new Uri(_base.BaseData));
            var tmp_LoaderGo = new GameObject(nameof(TryAcquireNetworkMesh));
            var tmp_Loader = tmp_LoaderGo.AddComponent<GltfLoader>();
            IDeferAgent tmp_DeferAgent = tmp_LoaderGo.AddComponent<TimeBudgetPerFrameDeferAgent>();
            tmp_Loader.createBoxCollider = false;

            var tmp_IsLoad = await tmp_Loader.Load(string.IsNullOrEmpty(tmp_LocalPath)
                ? _base.BaseData
                : $"file:///{tmp_LocalPath}", deferAgent: tmp_DeferAgent);
            if (!tmp_IsLoad) return;
            tmp_Loader.name += tmp_Loader.GetHashCode(); //System.IO.Path.GetFileNameWithoutExtension(_base.BaseData);
            _base.NotificationActWithData?.Invoke(tmp_Loader.gameObject);

            // Caching
            // await IocContainer.GetIoc.Resolve<BaseFeatureModel>().GltfFileCacheManager
            //     .AddNewRecord(new Uri(_base.BaseData), new[] {tmp_Loader.gameObject});
        }
    }
}