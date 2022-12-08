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
using com.Phantoms.ActionNotification.Runtime;
using com.PhantomsXR.MirrorExtension.Runtime;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.Video;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace com.Phantoms.ILRuntime.Runtime
{
    public class RegisterDelegate : IRegister
    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.DelegateManager.RegisterMethodDelegate<BaseNotificationData>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Transform>();
            _appDomain.DelegateManager.RegisterMethodDelegate<BaseEventData>();
            _appDomain.DelegateManager.RegisterMethodDelegate<GameObject>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Texture2D>();
            _appDomain.DelegateManager.RegisterMethodDelegate<TextAsset>();
            _appDomain.DelegateManager.RegisterMethodDelegate<AudioClip>();
            _appDomain.DelegateManager.RegisterMethodDelegate<SpriteAtlas>();
            _appDomain.DelegateManager.RegisterMethodDelegate<VideoClip>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Material>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Shader>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Sprite>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Animation>();
            _appDomain.DelegateManager.RegisterMethodDelegate<PhysicMaterial>();

            _appDomain.DelegateManager.RegisterMethodDelegate<int>();
            _appDomain.DelegateManager.RegisterMethodDelegate<bool>();
            _appDomain.DelegateManager.RegisterMethodDelegate<byte[]>();
            _appDomain.DelegateManager.RegisterMethodDelegate<long[]>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Single>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String>();


            _appDomain.DelegateManager.RegisterMethodDelegate<Single, LitJson.JsonWriter>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, GameObject>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, Transform>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, Texture2D>();
            _appDomain.DelegateManager.RegisterMethodDelegate<int, GameObject>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<Collider, Collider, Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<Transform, Transform, Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<GameObject, GameObject, Int32>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.Object>>();

            _appDomain.DelegateManager.RegisterMethodDelegate<AsyncOperation>();

            _appDomain.DelegateManager.RegisterMethodDelegate<Single, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<int, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<bool, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<GameObject, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<TransformData, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Quaternion, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Vector3, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, Mirror.NetworkIdentity>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Object>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Pose>();

            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.TeleportingEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.BaseRegistrationEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>();

            _appDomain.DelegateManager
                .RegisterFunctionDelegate<UnityEngine.Vector3, System.Int32,
                    System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, System.Int32>>();
            _appDomain.DelegateManager
                .RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, System.Int32>,
                    UnityEngine.Vector3>();

            _appDomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, System.Boolean>();
        }
    }
}