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

using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    // [UnitCategory("ARMOD/Multiplayer/EventReceivers/EntityProperties"),
    //  UnitSurtitle("Event Receiver"),
    //  UnitTitle("Register Entity Properties Receiver"),
    //  UnitShortTitle("Register Entity Properties")]
    // public class PlayerPropertiesSyncedReceiverUnit : Unit
    // {
    //     [DoNotSerialize][PortLabelHidden] public ControlInput Start;
    //     [DoNotSerialize][PortLabelHidden] public ControlOutput Complete;
    //
    //
    //     [DoNotSerialize] [NullMeansSelf] public ValueInput EventTarget;
    //     [DoNotSerialize] [NullMeansSelf] public ValueInput Target;
    //
    //     [DoNotSerialize] public ValueOutput Result;
    //
    //     [DoNotSerialize] public ValueOutput Health;
    //     [DoNotSerialize] public ValueOutput Name;
    //     [DoNotSerialize] public ValueOutput Level;
    //     [DoNotSerialize] public ValueOutput CustomProperties;
    //
    //
    //     private GameObject eventTarget;
    //     private NetworkPropertiesSync networkProperties;
    //
    //     private const string CONST_HEALTH_SYNCED_CALLBACK = "HealthSyncedCallback";
    //     private const string CONST_PLAYERH_NAME_SYNCED_CALLBACK = "PlayerNameSyncedCallback";
    //     private const string CONST_PLAYERH_LEVEL_SYNCED_CALLBACK = "PlayerLevelSyncedCallback";
    //     private const string CONST_CUSTOM_PROPERTIES_SYNCED_CALLBACK = "CustomPropertiesSyncedCallback";
    //
    //     protected override void Definition()
    //     {
    //         Start = ControlInput(nameof(Start), Execute);
    //         Complete = ControlOutput(nameof(Complete));
    //         Result = ValueOutput(nameof(Result), _flow => networkProperties);
    //
    //         Health = ValueOutput(nameof(Health), _flow => networkProperties.GetHealth);
    //         Name = ValueOutput(nameof(Name), _flow => networkProperties.GetPlayerName);
    //         Level = ValueOutput(nameof(Level), _flow => networkProperties.GetPlayerLevel);
    //         CustomProperties = ValueOutput(nameof(CustomProperties), _flow => networkProperties.GetCustomProperties);
    //
    //         Target = ValueInput(nameof(Target), (GameObject) null).NullMeansSelf();
    //         EventTarget = ValueInput(nameof(EventTarget), (GameObject) null).NullMeansSelf();
    //
    //         Succession(Start, Complete);
    //         Requirement(Target, Start);
    //     }
    //
    //     private ControlOutput Execute(Flow _arg)
    //     {
    //         networkProperties = _arg.GetValue<GameObject>(Target).GetComponent<NetworkPropertiesSync>();
    //         eventTarget = _arg.GetValue<GameObject>(EventTarget);
    //         Assert.IsNotNull(networkProperties);
    //
    //         RegisterPropertiesSyncedEvent();
    //
    //         return Complete;
    //     }
    //
    //     private void RegisterPropertiesSyncedEvent()
    //     {
    //         networkProperties.HealthSyncedCallback = (_health,_sender) =>
    //         {
    //             Debug.Log(_sender.name);
    //             CustomEvent.Trigger(eventTarget, CONST_HEALTH_SYNCED_CALLBACK, _health,_sender);
    //         };
    //
    //         networkProperties.PlayerLevelSyncedCallback = (_level,_sender) =>
    //         {
    //             CustomEvent.Trigger(eventTarget, CONST_PLAYERH_LEVEL_SYNCED_CALLBACK, _level,_sender);
    //         };
    //
    //         networkProperties.PlayerNameSyncedCallback = (_name,_sender) =>
    //         {
    //             CustomEvent.Trigger(eventTarget, CONST_PLAYERH_NAME_SYNCED_CALLBACK, _name,_sender);
    //         };
    //
    //         networkProperties.CustomPropertiesSyncedCallback = (_customProperties,_sender) =>
    //         {
    //             CustomEvent.Trigger(eventTarget, CONST_CUSTOM_PROPERTIES_SYNCED_CALLBACK, _customProperties,_sender);
    //         };
    //     }
    // }
}