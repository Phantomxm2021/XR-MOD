using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;

namespace ILRuntime.Runtime.Generated
{
    public static class CLRBindings
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterToAutoExecuted()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                if (_data is RegisterCLRNotificationData tmp_Data)
                {
                    Initialize(tmp_Data.AppDomain as Enviorment.AppDomain);
                }
            }, "RegisterCLR");
        }

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(Enviorment.AppDomain _app)
        {
            ILRTClrBinding.Binding(_app);
            PhantomsClrBinding.Binding(_app);
            SystemClrBinding.Binding(_app);
            MirrorClrBinding.Binding(_app);
            UnityEngineClrBinding.Binding(_app);
            UnityEngine_Pose_Binding.Register(_app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(Enviorment.AppDomain _app)
        {
        }
    }
}