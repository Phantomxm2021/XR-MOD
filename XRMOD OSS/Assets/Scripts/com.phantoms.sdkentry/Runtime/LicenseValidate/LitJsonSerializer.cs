// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using LitJson;

namespace SDKEntry.Runtime
{
    public class LitJsonSerializer:IJsonSerializer
    {
        public string Serialize(object obj)
        {
            return JsonMapper.ToJson(obj);
        }

        public T Deserialize<T>(string json)
        {
            return JsonMapper.ToObject<T>(json);
        }
    }
}