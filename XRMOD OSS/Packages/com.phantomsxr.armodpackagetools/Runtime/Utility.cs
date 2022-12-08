// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.IO;
using System.Linq;
using UnityEngine;

namespace com.Phantoms.ARMODPackageTools.Runtime
{
    public static class Utility
    {
        public static string GetPlatform()
        {
#if UNITY_IOS
            return "iOS";
#elif UNITY_ANDROID
            return "Android";
#elif UNITY_WSA
            return "WSA";
#elif UNITY_WEBGL
            return "WebGL";
#else
            return "";
#endif
        }

        public static string SearchFolderByName(string _folderName)
        {
            var tmp_DirectoryInfo = Directory
                .GetDirectories(Application.dataPath, "*", SearchOption.AllDirectories)
                .First(_folder => _folder.EndsWith(_folderName));
            return tmp_DirectoryInfo;
        }

        public static string SearchFileByName(string _rootPath, string _fileName, string _suffix = "*")
        {
            var tmp_FilesPaths =
                Directory.GetFiles(_rootPath, $"{_fileName}.{_suffix}", SearchOption.AllDirectories);
            return tmp_FilesPaths.Length > 0 ? tmp_FilesPaths[0] : null;
        }

        public static string ShortenPath(string _fullPath)
        {
            var tmp_AssetIdx = _fullPath.IndexOf("Assets", StringComparison.Ordinal);
            var tmp_ShortenPath = _fullPath.Substring(tmp_AssetIdx, _fullPath.Length - tmp_AssetIdx);
            return tmp_ShortenPath;
        }

        public static string SuffixMapping<T>() where T : UnityEngine.Object
        {
            var tmp_Type = typeof(T);
            string tmp_Suffix = "*";
            if (tmp_Type == typeof(GameObject))
            {
                tmp_Suffix = "prefab";
            }
            else if (tmp_Type == typeof(Animator))
            {
                tmp_Suffix = "controller";
            }
            else if (tmp_Type == typeof(AnimationClip))
            {
                tmp_Suffix = "ani";
            }

            return tmp_Suffix;
        }
    }
}