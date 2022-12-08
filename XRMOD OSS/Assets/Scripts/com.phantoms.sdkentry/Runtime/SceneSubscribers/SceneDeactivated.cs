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
using System.Collections;
using com.phantoms.models.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace SDKEntry.Runtime
{
    public class SceneDeactivated
    {
        /// <summary>
        /// Deactivated current scene to release the memory
        /// </summary>
        public bool Executed()
        {
            try
            {
                Debug.Log(nameof(SceneDeactivated));
                //Disable the script logic on ARExperience
                Assert.IsNotNull(IocContainer.GetIoc.Resolve<BaseContextDataModel>());
                // IocContainer.GetIoc.Resolve<BaseContextDataModel>().CodeHook.Value.Dispose();
                Object.FindObjectOfType<MonoBehaviour>().StartCoroutine(FixScreenFreeze());
                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                return false;
            }
        }


        private IEnumerator FixScreenFreeze()
        {
            //Reset to low memory quality level.
            //To reduce the memory required when running in the background.
            QualitySettings.SetQualityLevel(3, true);
            yield return new WaitForSeconds(0.0125f);
            var tmp_EngineType = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.engineType;

            //Why to unregister at here?
            //Because the two sets of data will also be used to
            IocContainer.GetIoc.UnRegister<SdkConfigModel>();
            IocContainer.GetIoc.UnRegister<BaseContextDataModel>();
            
            LoaderUtility.Deinitialize();

            GC.Collect();
            Resources.UnloadUnusedAssets();
            //Fix Unity 2021.3.7f1 Android crashed.When unload mult-time can not found SceneGrab script
// #if UNITY_2021_2_OR_NEWER && UNITY_ANDROID
//             SceneManager.LoadScene(nameof(SceneTags.Main), LoadSceneMode.Single);
// #endif
            yield return new WaitForSeconds(0.0125f);
            if (tmp_EngineType == EngineType.Native)
            {
#if !ENABLED_FOR_DEBUG
                //Unload the unity player
                Application.Unload();
#endif
            }
            else
            {
                var tmp_SDKEntryPoint = Object.FindObjectOfType<SDKEntryPoint>();
                if (tmp_SDKEntryPoint)
                {
                    tmp_SDKEntryPoint.gameObject.DestroyWithPlatform();
                }

// #if UNITY_EDITOR
//                 Object.Instantiate(Resources.Load<GameObject>("Prefabs/EntryPoint"));
// #endif
            }
        }
    }
}