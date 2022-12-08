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

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ILRuntime.CLRBinding.Adapter;
using UnityEngine;
using UnityEngine.EventSystems;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace com.phantoms.ilruntime.Runtime
{
    public class UserInstantiatedObjects : IReleaseCommand
    {
        private readonly List<Object> userInstantiateGameObjects = new();

        public void AddGameObject(Object _object)
        {
            userInstantiateGameObjects.Add(_object);
        }


        public void Release()
        {
            try
            {
                for (int tmp_Idx = 0; tmp_Idx < userInstantiateGameObjects.Count; tmp_Idx++)
                {
                    var tmp_Obj = userInstantiateGameObjects[tmp_Idx];
                    if (tmp_Obj == null) continue;
                    Object.Destroy(tmp_Obj);
                }


                userInstantiateGameObjects.Clear();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }
    }
}