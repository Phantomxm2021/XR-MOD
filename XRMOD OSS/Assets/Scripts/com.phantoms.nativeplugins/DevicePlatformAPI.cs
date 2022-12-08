// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the NativePlugins.Plugin.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace NativePlugins.Plugin
{
    public static class DevicePlatformAPI
    {
        public static string GetPlatformName()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return "Pico";
#elif HANDHELD_ARMODULE_INSTALL && UNITY_IOS
            return "ARKit";
#elif HANDHELD_ARMODULE_INSTALL && UNITY_ANDROID
            return "ARCore";
#elif HOLOLENS_2_INSTALL && UNITY_WSA
            return "Hololens2";
#elif QUEST_2_INSTALL && UNITY_ANDROID
            return "Quest2";
            #else
            return "";
#endif
        }

        public static bool IsPico()
        {
#if PICO_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }


        public static bool IsHandheldAR()
        {
#if HANDHELD_ARMODULE_INSTALL && (UNITY_ANDROID||UNITY_IOS)
            return true;
#else
            return false;
#endif
        }

        public static bool IsHololens2()
        {
#if HOLOLENS_2_INSTALL && UNITY_WSA
            return true;
#else
            return false;
#endif
        }

        public static bool IsQuest2()
        {
#if QUEST_2_INSTALL && UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }


        public static bool IsWebAR()
        {
#if WEB_AR_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }


        public static bool IsWebVR()
        {
#if WEB_VR_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }


        public static bool IsWeb3D()
        {
#if WEB_3D_INSTALL && UNITY_WEBGL
            return true;
#else
            return false;
#endif
        }

        public static bool IsClassic3D()
        {
#if CLASSIC_3D_INSTALL && (UNITY_IOS||UNITY_ANDROID)
            return true;
#else
            return false;
#endif
        }
    }
}