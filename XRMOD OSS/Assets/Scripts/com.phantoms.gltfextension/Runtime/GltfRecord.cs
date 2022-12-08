// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the glTFExtension.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace com.phantoms.gltfextension.Runtime
{
    [System.Serializable]
    public class GltfRecord
    {
        public string GltfFilePath;
        public string Timestamp;
    }

    [System.Serializable]
    public class GltfCacheDb
    {
        public Dictionary<string, GltfRecord> cacheDict = new Dictionary<string, GltfRecord>();

        public string Serializer()
        {
            return JsonUtility.ToJson(new Serialization<string, GltfRecord>(cacheDict));
        }

        public void DeSerializer(string _jsonStr)
        {
            var tmp_Serialization = JsonUtility.FromJson<Serialization<string, GltfRecord>>(_jsonStr);
            cacheDict = tmp_Serialization.ToDictionary();
        }
    }
}