// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.phantoms.BaseFeatures.Runtime;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using XRMODEngineCore.Runtime;

namespace Pico.Runtime.Models
{
    public class PicoRuntimeContextData : IModel
    {
        private const string CONST_XR_ORIGIN_NAME = "XR Origin";
        private const string CONST_TELEPORT_GAMEOBJECT_NAME = "Teleport Interactor";
        private const string CONST_RAY_GAMEOBJECT_NAME = "Ray Interactor";
        private const string CONST_DIRECT_GAMEOBJECT_NAME = "Direct Interactor";
        private const string CONST_CONTROLLER_LEFT_GAMEOBJECT_NAME = "XRControllerLeft";
        private const string CONST_CONTROLLER_RIGHT_GAMEOBJECT_NAME = "XRControllerRight";
        private const string CONST_CAMERA_OFFSET_GAMEOBJECT_NAME = "CameraOffset";
        private const string CONST_RIGHT_HAND_GAMEOBJECT_NAME = "RightHand";
        private const string CONST_LEFT_HAND_GAMEOBJECT_NAME = "LeftHand";

        internal GameObject LeftHandDirectGo { get; private set; }
        internal GameObject LeftHandRayInteractorGo { get; private set; }
        internal GameObject LeftHandControllerGo { get; private set; }
        internal GameObject LeftHandTeleportInteractorGo { get; private set; }
        internal GameObject RightHandDirectGo { get; private set; }
        internal GameObject RightHandRayInteractorGo { get; private set; }

        internal GameObject RightHandControllerGo { get; private set; }
        internal GameObject RightHandTeleportInteractorGo { get; private set; }
        internal GameObject XrOriginGo { get; private set; }

        internal MonoBehaviour CharacterCtrlDriver { get; private set; }
        internal CharacterController CharacterCtrl { get; private set; }
        internal DynamicMoveProvider DynamicMoveProvider { get; private set; }
        internal TwoHandedGrabMoveProvider TwoHandedGrabMoveProvider { get; private set; }
        internal ContinuousTurnProviderBase ContinuousTurnProvider { get; private set; }
        internal TeleportationProvider TeleportationProvider { get; private set; }
        internal LocomotionProvider LocomotionProvider { get; private set; }
        internal SnapTurnProviderBase SnapTurnProvider { get; private set; }

        public PicoRuntimeContextData()
        {
            Initialize();
        }

        public void Initialize()
        {
            XrOriginGo = GameObject.Find(CONST_XR_ORIGIN_NAME);
            var tmp_RightHandTransform =
                XrOriginGo.transform.Find($"{CONST_CAMERA_OFFSET_GAMEOBJECT_NAME}/{CONST_RIGHT_HAND_GAMEOBJECT_NAME}");
            var tmp_LeftHandTransform =
                XrOriginGo.transform.Find($"{CONST_CAMERA_OFFSET_GAMEOBJECT_NAME}/{CONST_LEFT_HAND_GAMEOBJECT_NAME}");

            LeftHandTeleportInteractorGo = tmp_LeftHandTransform.Find(CONST_TELEPORT_GAMEOBJECT_NAME).gameObject;
            RightHandTeleportInteractorGo = tmp_RightHandTransform.Find(CONST_TELEPORT_GAMEOBJECT_NAME).gameObject;

            LeftHandDirectGo = tmp_LeftHandTransform.Find(CONST_DIRECT_GAMEOBJECT_NAME).gameObject;
            RightHandDirectGo = tmp_RightHandTransform.Find(CONST_DIRECT_GAMEOBJECT_NAME).gameObject;

            LeftHandRayInteractorGo = tmp_LeftHandTransform.Find(CONST_RAY_GAMEOBJECT_NAME).gameObject;
            RightHandRayInteractorGo = tmp_RightHandTransform.Find(CONST_RAY_GAMEOBJECT_NAME).gameObject;

            LeftHandControllerGo = tmp_LeftHandTransform.Find(CONST_CONTROLLER_LEFT_GAMEOBJECT_NAME).gameObject;
            RightHandControllerGo = tmp_RightHandTransform.Find(CONST_CONTROLLER_RIGHT_GAMEOBJECT_NAME).gameObject;

            CharacterCtrl = XrOriginGo.GetComponent<CharacterController>();
            CharacterCtrlDriver = XrOriginGo.GetComponent<CharacterControllerDriver>();
            TwoHandedGrabMoveProvider = XrOriginGo.GetComponent<TwoHandedGrabMoveProvider>();
            DynamicMoveProvider = XrOriginGo.GetComponent<DynamicMoveProvider>();
            ContinuousTurnProvider = XrOriginGo.GetComponent<ContinuousTurnProviderBase>();
            TeleportationProvider = XrOriginGo.GetComponent<TeleportationProvider>();
            LocomotionProvider = XrOriginGo.GetComponent<LocomotionProvider>();
            SnapTurnProvider = XrOriginGo.GetComponent<SnapTurnProviderBase>();
        }
    }
}