using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace Web3D.Runtime
{
    public class AutoModuleRegister
    {
        [RuntimeInitializeOnLoadMethod]
        public static void AutoToRegister()
        {
            if (NativePlugins.Plugin.DevicePlatformAPI.IsWeb3D())
            {
                IocContainer.GetIoc.Register<IModule>(new Web3DModule());
            }
        }
    }

    public class Web3DModule : IModule
    {
        public bool IsModuleAvailability()
        {
            return true;
        }

        void IModule.RegisterCLR()
        {
            throw new System.NotImplementedException();
        }

        public bool PauseModule()
        {
            throw new System.NotImplementedException();
        }

        public bool StartModule()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.FetchProjectDetail),
                new BaseNotificationData());
            return true;
        }

        public bool StopModule()
        {
            return true;
        }
    }
}