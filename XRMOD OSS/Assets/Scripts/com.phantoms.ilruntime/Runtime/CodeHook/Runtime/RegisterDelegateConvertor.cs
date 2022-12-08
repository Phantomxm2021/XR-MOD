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
using System.Threading;
using System.Threading.Tasks;
using ILRuntime.CLRBinding.Adapter;
using ILRuntime.Runtime.Intepreter;
using LitJson;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
using Object = System.Object;

namespace com.Phantoms.ILRuntime.Runtime
{
    public class RegisterDelegateConvertor : IRegister
    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color32>();

            _appDomain.DelegateManager.RegisterDelegateConvertor<LitJson.ExporterFunc<Single>>(_act =>
            {
                return new LitJson.ExporterFunc<Single>((_obj, _writer) =>
                {
                    ((Action<Single, LitJson.JsonWriter>)_act)(_obj, _writer);
                });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<String>>((_act) =>
            {
                return new UnityAction<String>((_arg0) => { ((Action<String>)_act)(_arg0); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<Boolean>>(
                (_act) => { return new UnityAction<bool>((_arg0) => { ((Action<Boolean>)_act)(_arg0); }); });

            _appDomain.DelegateManager.RegisterDelegateConvertor<System.Threading.WaitCallback>((_act) =>
            {
                return new System.Threading.WaitCallback((_state) => { ((Action<System.Object>)_act)(_state); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction>(_act =>
            {
                return new UnityAction(() => { ((Action)_act)(); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<BaseEventData>>(
                (_act) =>
                {
                    void Target(BaseEventData _arg0)
                    {
                        ((Action<BaseEventData>)_act)(_arg0);
                    }

                    return new UnityAction<BaseEventData>(Target);
                });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<Single>>(_act =>
            {
                return new UnityAction<Single>(_arg0 => { ((Action<Single>)_act)(_arg0); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction>((_act) =>
            {
                return new UnityAction(() => { ((Action)_act)(); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnhandledExceptionEventHandler>((_act) =>
            {
                return new UnhandledExceptionEventHandler((_sender, _e) =>
                {
                    ((Action<object, UnhandledExceptionEventArgs>)_act)(_sender, _e);
                });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<Predicate<Object>>(_act =>
            {
                return new Predicate<Object>(_obj => ((Func<Object, Boolean>)_act)(_obj));
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<Predicate<ILTypeInstance>>(_act =>
            {
                return new Predicate<ILTypeInstance>(_obj => ((Func<ILTypeInstance, Boolean>)_act)(_obj));
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<Int32>>(_act =>
            {
                return new UnityAction<Int32>(_arg0 => { ((Action<Int32>)_act)(_arg0); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<Action<JsonData>>(_action =>
            {
                return new Action<JsonData>(a => { ((Action<JsonData>)_action)(a); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction>(_act =>
            {
#pragma warning disable 1998
                return new UnityAction(async () => { ((Action)_act)(); });
#pragma warning restore 1998
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<ThreadStart>(_act =>
            {
                return new ThreadStart(() => { ((Action)_act)(); });
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<Predicate<CoroutineAdapter.CoroutineAdaptor>>(
                (_act) =>
                {
                    return new Predicate<CoroutineAdapter.CoroutineAdaptor>((_obj) =>
                        ((Func<CoroutineAdapter.CoroutineAdaptor, Boolean>)_act)(_obj));
                });

            _appDomain.DelegateManager.RegisterDelegateConvertor<Predicate<MonoBehaviourAdapter.Adapter>>((_act) =>
            {
                return new Predicate<MonoBehaviourAdapter.Adapter>((_obj) =>
                    ((Func<MonoBehaviourAdapter.Adapter, Boolean>)_act)(_obj));
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<System.Timers.ElapsedEventHandler>((_act) =>
            {
                return new System.Timers.ElapsedEventHandler((_sender, _e) =>
                {
                    ((Action<Object, System.Timers.ElapsedEventArgs>)_act)(_sender, _e);
                });
            });

            _appDomain.DelegateManager.RegisterFunctionDelegate<CoroutineAdapter.CoroutineAdaptor, System.Boolean>();

            _appDomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Collider>>((act) =>
            {
                return new System.Comparison<UnityEngine.Collider>((x, y) =>
                    ((Func<UnityEngine.Collider, UnityEngine.Collider, System.Int32>)act)(x, y));
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Transform>>((act) =>
            {
                return new System.Comparison<UnityEngine.Transform>((x, y) =>
                    ((Func<UnityEngine.Transform, UnityEngine.Transform, System.Int32>)act)(x, y));
            });

            _appDomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.GameObject>>((act) =>
            {
                return new System.Comparison<UnityEngine.GameObject>((x, y) =>
                    ((Func<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>)act)(x, y));
            });

            _appDomain.DelegateManager.RegisterMethodDelegate<com.PhantomsXR.MirrorExtension.Runtime.TransformData>();


            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>)act)(_arg0);
                });
            });
            
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.TeleportingEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.TeleportingEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.TeleportingEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.BaseRegistrationEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.BaseRegistrationEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.BaseRegistrationEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>)act)(_arg0);
                });
            });
            
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>)act)(_arg0);
                });
            });
            
            _appDomain.DelegateManager.RegisterDelegateConvertor<UnityAction<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>>((act) =>
            {
                return new UnityAction<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>((_arg0) =>
                {
                    ((Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>)act)(_arg0);
                });
            });
        }
    }
}