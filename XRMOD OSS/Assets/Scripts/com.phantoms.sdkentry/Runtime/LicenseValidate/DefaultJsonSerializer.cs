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

using UnityEngine;

namespace SDKEntry.Runtime
{
    // <summary>
    /// JSON Serializer using JavaScriptSerializer
    /// </summary>
    public class DefaultJsonSerializer : IJsonSerializer
    {
        /// <summary>
        /// Serialize an object to JSON string
        /// </summary>
        /// <param name="_obj">object</param>
        /// <returns>JSON string</returns>
        public string Serialize(object _obj)
        {
            Debug.Log(JsonUtility.ToJson(_obj));
            return JsonUtility.ToJson(_obj);
        }

        /// <summary>
        /// Deserialize a JSON string to typed object.
        /// </summary>
        /// <typeparam name="T">type of object</typeparam>
        /// <param name="_json">JSON string</param>
        /// <returns>typed object</returns>
        public T Deserialize<T>(string _json)
        {
            return JsonUtility.FromJson<T>(_json);
        }
    }
}