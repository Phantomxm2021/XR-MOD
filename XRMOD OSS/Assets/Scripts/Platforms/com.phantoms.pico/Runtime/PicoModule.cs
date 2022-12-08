using com.Phantoms.ActionNotification.Runtime;
using com.phantoms.models.Runtime;
using ILRuntime.Runtime.Generated;
using NativePlugins.Plugin;
using Pico.Runtime.FeaturesDecorator;
using Pico.Runtime.Models;
using UnityEngine;
using XRMODEngineCore.Runtime;
using XRMODEngineCore.Runtime.Enums;

namespace Pico.Runtime
{
    public class PicoModule : IModule
    {
        public PicoModule()
        {
            RegisterDependence();
        }

        private void RegisterDependence()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver((_data) => { RegisterCLR(); }, nameof(RegisterCLR));
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                // Avoid executing features within a module before initializing base features
                IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.OnValueChanged += OnConfigUpdated;

                //Re-parse the json string to runtime project config,
                //if not re-parse the RuntimeProjectConfig type is BaseProjectConfigModel
                var tmp_Configures = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>();
                tmp_Configures.CurrentConfigures.Value =
                    JsonUtility.FromJson<PicoConfiguresModel>(tmp_Configures.MetaData);
            }, nameof(ActionParameterDataType.OnXRDataGot));

            IocContainer.GetIoc.Register(new PicoRuntimeContextData());

            IocContainer.GetIoc.Register(new PicoMixedRealityDecorator());
        }

        public bool StartModule()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.FetchProjectDetail),
                new BaseNotificationData());
            return true;
        }

        public bool PauseModule()
        {
            return true;
        }

        public bool StopModule()
        {
            IocContainer.GetIoc.Resolve<RuntimeProjectConfig>().CurrentConfigures.OnValueChanged -= OnConfigUpdated;
            IocContainer.GetIoc.UnRegister<PicoMixedRealityDecorator>();
            return true;
        }

        public bool IsModuleAvailability()
        {
            return true;
        }


        public void RegisterCLR()
        {
            PicoILCodeBindings.Binding();
        }

        private void OnConfigUpdated(IModel _config)
        {
            if (_config is not PicoConfiguresModel tmp_Config) return;
            Debug.Log($"{nameof(PicoModule)}:{nameof(OnConfigUpdated)}");
            if (tmp_Config.SDKDeviceType != SDKDeviceType.Pico)
            {
                string tmp_LogInfo = "This experience is not available for this device.";
                NativeAPI.ThrowException(tmp_LogInfo, -1);
                Debug.LogError(tmp_LogInfo);
                return;
            }

            AddFeatureDecorator(tmp_Config);
        }

        private void AddFeatureDecorator(PicoConfiguresModel _configures)
        {
            if (_configures.MixedReality)
            {
                // Because Pico not support HDR and Postprocess when mixed reality is enabled.
                IocContainer.GetIoc.Resolve<PicoMixedRealityDecorator>().StartAlgorithm();
            }
        }
    }
}