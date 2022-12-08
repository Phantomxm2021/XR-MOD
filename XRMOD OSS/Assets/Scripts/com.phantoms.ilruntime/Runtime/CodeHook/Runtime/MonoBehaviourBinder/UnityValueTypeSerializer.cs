// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook
{
    public static class UnityValueTypeSerializer
    {
        public static string Serializer(this Vector2 _vector2)
        {
            return JsonUtility.ToJson(_vector2);
        }
        
        public static string Serializer(this Vector3 _vector3)
        {
            return JsonUtility.ToJson(_vector3);
        }
        
        public static string Serializer(this Vector4 _vector4)
        {
            return JsonUtility.ToJson(_vector4);
        }
        
        public static string Serializer(this Quaternion _quaternion)
        {
            return JsonUtility.ToJson(_quaternion);
        }
    }
}