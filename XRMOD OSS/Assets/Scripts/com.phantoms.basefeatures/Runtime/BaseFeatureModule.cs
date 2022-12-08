// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Assembly-CSharp.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using com.phantoms.BaseFeatures.Runtime.Models;
using com.phantoms.models.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BaseFeatureModule : IModule
    {
        public BaseFeatureModule()
        {
            IocContainer.GetIoc.Register(new BaseFeatureModel());
            IocContainer.GetIoc.Register(new BuildGltfLoaderCommand());
            IocContainer.GetIoc.Register(new BuildMultiplayerCommand());
            IocContainer.GetIoc.Register(new BuildEventSystemCommand());
            IocContainer.GetIoc.Register(new BuildGraphQualityCommand());
            IocContainer.GetIoc.Register(new BuildPostProcessingCommand());
            IocContainer.GetIoc.Register(new BuildSendMessageToSDKCommand());
            IocContainer.GetIoc.Register(new BuildOpenBuiltInBrowserCommand());
            IocContainer.GetIoc.Register(new BuildRuntimeDebugConsoleCommand());
            IocContainer.GetIoc.Register(new BuildNetworkMeshDownloadCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireLoadObjectCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireProjectInfoCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireInformationCommand());
            IocContainer.GetIoc.Register(new BuildScriptRuntimeEnvironmentCommand());
            IocContainer.GetIoc.Register(new BuildTryAcquireTemporaryCachePathCommand());
            IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.OnValueChanged += _config =>
            {
                if (_config.PostProcessing)
                {
                    IocContainer.GetIoc.Resolve<BuildPostProcessingCommand>().Execute();
                }

                if (_config.Multiplayer)
                {
                    IocContainer.GetIoc.Resolve<BuildMultiplayerCommand>().Execute();
                }


                if (_config.DebugModel)
                {
                    IocContainer.GetIoc.Resolve<BuildRuntimeDebugConsoleCommand>().Execute();
                }
            };
        }

        private void DisposeModule()
        {
            try
            {
                IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.OnValueChanged = null;

                IocContainer.GetIoc.UnRegister<BaseFeatureModel>();
                IocContainer.GetIoc.UnRegister<BuildGltfLoaderCommand>();
                IocContainer.GetIoc.UnRegister<BuildMultiplayerCommand>();
                IocContainer.GetIoc.UnRegister<BuildEventSystemCommand>();
                IocContainer.GetIoc.UnRegister<BuildGraphQualityCommand>();
                IocContainer.GetIoc.UnRegister<BuildPostProcessingCommand>();
                IocContainer.GetIoc.UnRegister<BuildOpenBuiltInBrowserCommand>();

                IocContainer.GetIoc.UnRegister<BuildSendMessageToSDKCommand>();

                IocContainer.GetIoc.UnRegister<BuildRuntimeDebugConsoleCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireProjectInfoCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireLoadObjectCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireInformationCommand>();
                IocContainer.GetIoc.UnRegister<BuildTryAcquireTemporaryCachePathCommand>();

                IocContainer.GetIoc.UnRegister<BuildScriptRuntimeEnvironmentCommand>();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        public bool StartModule()
        {
            IocContainer.GetIoc.Resolve<BuildGraphQualityCommand>().Execute();
            IocContainer.GetIoc.Resolve<BuildScriptRuntimeEnvironmentCommand>().Execute();
            return true;
        }

        public bool PauseModule()
        {
            throw new System.NotImplementedException();
        }

        public bool StopModule()
        {
            DisposeModule();
            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }

        void IModule.RegisterCLR()
        {
            throw new NotImplementedException();
        }
    }
}