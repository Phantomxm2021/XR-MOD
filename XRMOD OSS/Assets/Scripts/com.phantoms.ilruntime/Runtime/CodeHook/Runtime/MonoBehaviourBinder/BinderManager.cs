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

using System.Collections.Generic;
using com.Phantoms.ILRuntime.Runtime.CodeHook;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook
{
    public class BinderManager : MonoBehaviour
    {
        public static void Instantiate()
        {
            INSTANCE = new GameObject("ClassBindMgr").AddComponent<BinderManager>();
            DontDestroyOnLoad(INSTANCE);
        }

        private static BinderManager INSTANCE;
        private static List<MonoBinder> MONO_BINDERS;

        [ContextMenu("Test")]
        private void Awake()
        {
            if (INSTANCE != null)
            {
                Destroy(this);
            }

            MONO_BINDERS = new List<MonoBinder>(0);

            DoBind();
        }

        public static async void DoBind(List<MonoBinder> _monoBinders)
        {
            foreach (var tmp_MonoBinder in _monoBinders)
            {
                //先添加
                foreach (MonoData tmp_MonoData in tmp_MonoBinder.ScriptList)
                {
                    if (tmp_MonoData == null || tmp_MonoData.Added)
                    {
                        continue;
                    }

                    tmp_MonoBinder.AddRuntimeClass(tmp_MonoData);
                }
            }

            foreach (var tmp_MonoBinder in _monoBinders)
            {
                //再赋值
                foreach (MonoData tmp_MonoData in tmp_MonoBinder.ScriptList)
                {
                    if (tmp_MonoData == null || tmp_MonoData.BoundData)
                    {
                        continue;
                    }

                    await tmp_MonoBinder.SetValues(tmp_MonoData);
                }
            }

            //激活
            foreach (var tmp_MonoBinder in _monoBinders)
            {
                foreach (MonoData tmp_MonoData in tmp_MonoBinder.ScriptList)
                {
                    if (tmp_MonoData == null || tmp_MonoData.Activated)
                    {
                        continue;
                    }

                    tmp_MonoBinder.Active(tmp_MonoData);
                }
            }
        }

        public static void DoBind()
        {
            MONO_BINDERS.AddRange(Resources.FindObjectsOfTypeAll<MonoBinder>());
            DoBind(MONO_BINDERS);
        }
    }
}