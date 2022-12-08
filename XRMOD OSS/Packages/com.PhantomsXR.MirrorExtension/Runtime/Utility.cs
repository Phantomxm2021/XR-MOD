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

using com.Phantoms.ActionNotification.Runtime;
using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    public static class Utility
    {
        public static void Instantiate(GameObject _gameObject, out GameObject _Instantiate)
        {
            _Instantiate = null;

            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.Instantiate),
                new InstantiateNotificationData()
                {
                    Prefab = _gameObject,
                });

            foreach (object tmp_Item in tmp_Result)
            {
                if (!(tmp_Item is GameObject)) continue;
                _Instantiate = tmp_Item as GameObject;
                break;
            }
        }



        public static GameObject GetPrefabFromSpawningSystem(string _prefabName)
        {
            return NetworkManager.singleton.spawnPrefabs.Find(_prefab => _prefab.name.Equals(_prefabName));
        }
        
    }
}