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
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODPackageTools.Runtime;
using com.phantoms.ilruntime.Runtime;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Generated;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
using com.Phantoms.ILRuntime.Runtime.CodeHook;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;


namespace com.Phantoms.ILRuntime.Runtime
{
    // ReSharper disable once InconsistentNaming
    public class CodesHook
    {
        public bool debug { get; set; }

        private int jitFlag = 0;
        private string runtimeEntryPoint;
        private string lowerProjectName;

        private static bool _INITIALIZED;
        private static string _PROJECT_NAME;
        private static AppDomain _APPDOMAIN;

        private MemoryStream dllStream;
        private MemoryStream symbolStream;

        private IMethod updateMethod;
        private IMethod onEventMethod;
        private IMethod onMultiplayerMethod;
        private ILTypeInstance ilTypeInstance;

        public static AppDomain GetAppDomain => _APPDOMAIN ??= new AppDomain();
        public static string GetProjectName => _PROJECT_NAME;


        public void InitializeHook(string _projectName, string _domainName, string _mainEntryPoint, int _jitFlag)
        {
            _PROJECT_NAME = _projectName;
            lowerProjectName = _projectName.ToLower();
            runtimeEntryPoint = $"{_domainName}.{_mainEntryPoint}";
            jitFlag = _jitFlag;
            LoadExpandDll();

            IocContainer.GetIoc.Register(new UserInstantiatedObjects());
        }

        private async void LoadExpandDll()
        {
            _INITIALIZED = _APPDOMAIN != null;
            _APPDOMAIN ??= new AppDomain(jitFlag);
            try
            {
                if (debug)
                {
                    var tmp_DllBytes =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<TextAsset>(_PROJECT_NAME,
                            $"{lowerProjectName}.runtime.dll");
                    var tmp_PdbBytes =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<TextAsset>(_PROJECT_NAME,
                            $"{lowerProjectName}.runtime.pdb");
                    dllStream = new MemoryStream(tmp_DllBytes.bytes);
                    symbolStream = new MemoryStream(tmp_PdbBytes.bytes);
                    _APPDOMAIN.LoadAssembly(dllStream, symbolStream,
                        new global::ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
                }
                else
                {
                    var tmp_DllBytes =
                        await BasePackageLoaderUtility.LoadAssetFromPackage<TextAsset>(_PROJECT_NAME,
                            $"{lowerProjectName}.runtime.dll");
                    dllStream = new MemoryStream(tmp_DllBytes.bytes);
                    _APPDOMAIN.LoadAssembly(dllStream, null, new global::ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
                }

                InitializeIlRuntime();
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"{tmp_Exception.Message}\n{tmp_Exception.StackTrace}");
            }
        }

        private void InitializeIlRuntime()
        {
#if DEBUG && (UNITY_EDITOR || UNITY_ANDROID || UNITY_IPHONE)
            _APPDOMAIN.UnityMainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;
#endif
            if (!_INITIALIZED)
            {
                Singleton<RegisterCrossBindingAdaptor>.GetInstance.Register(_APPDOMAIN);
                Singleton<RegisterDelegate>.GetInstance.Register(_APPDOMAIN);
                Singleton<RegisterDelegateConvertor>.GetInstance.Register(_APPDOMAIN);
                Singleton<RegisterValueBinding>.GetInstance.Register(_APPDOMAIN);
                Singleton<RegisterClrMethodRedirection>.GetInstance.Register(_APPDOMAIN);

                // Send register clr command to every modules
                ActionNotificationCenter.DefaultCenter.PostNotification("RegisterCLR", new RegisterCLRNotificationData()
                {
                    AppDomain = GetAppDomain
                });
                _INITIALIZED = true;
            }

            // Fix null exception after second load.
            // Since the release of AR Experience, the notification list will be cleaned up.
            // So we need to warm it.
            ActionNotificationCenter.DefaultCenter.AddObserver(InstantiatingNotificationAction,
                nameof(ActionParameterDataType.Instantiate));

            StartHookingCode();
        }


        private void StartHookingCode()
        {
            var tmp_MethodDirectory = _APPDOMAIN.LoadedTypes[runtimeEntryPoint];
            ilTypeInstance = ((ILType) tmp_MethodDirectory).Instantiate();
            var tmp_Constructor = ilTypeInstance.Type.GetConstructor(new List<IType>());
            if (tmp_Constructor != null)
            {
                _APPDOMAIN.Invoke(tmp_Constructor, ilTypeInstance, null);
            }

            try
            {
                if (runtimeEntryPoint != null)
                    _APPDOMAIN.Invoke(runtimeEntryPoint, MethodKey.ONLOAD, ilTypeInstance, null);
                if (runtimeEntryPoint != null)
                    _APPDOMAIN.Invoke(runtimeEntryPoint, MethodKey.INITMONOSCRIPTS, ilTypeInstance, null);
                if (tmp_MethodDirectory == null) return;
                onEventMethod = tmp_MethodDirectory.GetMethod(MethodKey.ONEVENT, 1);
                onMultiplayerMethod = tmp_MethodDirectory.GetMethod(MethodKey.ONMULTIPLAYEREVENT, 1);
                updateMethod = tmp_MethodDirectory.GetMethod(MethodKey.ONUPDATE, 0);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }


        #region Unity Life cycle methods

        ////////////////////////
        //Call back function////
        ////////////////////////
        public void OnUpdate()
        {
            if (!_INITIALIZED || runtimeEntryPoint == null || updateMethod == null || dllStream == null) return;
            _APPDOMAIN.Invoke(updateMethod, ilTypeInstance);
        }


        public void OnEvent(BaseNotificationData _data)
        {
            if (!_INITIALIZED || runtimeEntryPoint == null || onEventMethod == null || dllStream == null) return;
            _APPDOMAIN.Invoke(onEventMethod, ilTypeInstance, _data);
        }

        public void OnMultiplayerEvent(BaseNotificationData _data)
        {
            if (!_INITIALIZED || runtimeEntryPoint == null || onMultiplayerMethod == null || dllStream == null) return;
            _APPDOMAIN.Invoke(onMultiplayerMethod, ilTypeInstance, _data);
        }


        public void ReleaseMemory()
        {
            if (!_INITIALIZED || runtimeEntryPoint == null || dllStream == null) return;
            _APPDOMAIN.Invoke(runtimeEntryPoint, MethodKey.RELEASEMEMORY, ilTypeInstance, null);
        }

        public void Dispose()
        {
            try
            {
                ReleaseMemory();

                //Release MonoBehaviour
                var tmp_MonoAdaptors = Object.FindObjectsOfType<MonoBehaviourAdapter.Adapter>();
                for (int tmp_Idx = 0; tmp_Idx < tmp_MonoAdaptors.Length; tmp_Idx++)
                {
                    if (tmp_MonoAdaptors[tmp_Idx] == null) continue;
                    tmp_MonoAdaptors[tmp_Idx].enabled = false;
                    Object.DestroyImmediate(tmp_MonoAdaptors[tmp_Idx], true);
                }

                IocContainer.GetIoc.UnRegister<UserInstantiatedObjects>();


                _PROJECT_NAME = null;
                lowerProjectName = null;
                updateMethod = null;
                onEventMethod = null;

                runtimeEntryPoint = null;
                ilTypeInstance = null;

                dllStream?.Dispose();
                symbolStream?.Dispose();
                dllStream = symbolStream = null;
            }
            catch (Exception tmp_Exception)
            {
                throw new Exception($"CodesHook dispose error:{tmp_Exception.Message}");
            }
        }

        #endregion


        private object InstantiatingNotificationAction(BaseNotificationData _arg)
        {
            if (_arg is not InstantiateNotificationData tmp_Data) return null;
            if (GetAppDomain == null)
            {
                Assert.IsNotNull(tmp_Data.Prefab);
                return tmp_Data.Parent
                    ? Object.Instantiate(tmp_Data.Prefab, tmp_Data.Parent)
                    : Object.Instantiate(tmp_Data.Prefab);
            }

            Utility.CheckoutIlTypeInstance(tmp_Data.Prefab, out var tmp_Go, out var tmp_Type);

            var tmp_ResultOfThisMethod = tmp_Data.Parent
                ? Object.Instantiate(tmp_Data.Prefab, tmp_Data.Parent)
                : Object.Instantiate(tmp_Data.Prefab);

            var tmp_Res = Utility.Instantiate(tmp_Go, tmp_ResultOfThisMethod, GetAppDomain, tmp_Type);

            if (tmp_Type == null && tmp_Res is GameObject tmp_GameObject &&
                tmp_GameObject.GetType() != tmp_Data.Prefab.GetType())
            {
                return tmp_GameObject.GetComponent(tmp_Data.Prefab.GetType());
            }

            return tmp_Res;
        }
    }
}