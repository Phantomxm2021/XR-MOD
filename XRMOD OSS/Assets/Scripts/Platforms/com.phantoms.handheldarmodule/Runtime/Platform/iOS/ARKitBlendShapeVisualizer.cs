using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARKit;
using UnityEngine.XR.ARSubsystems;

namespace HandheldARModule.Runtime.Platform.iOS
{
    public class ARKitBlendShapeVisualizer : MonoBehaviour
    {
        private float coefficientScale = 100f;
        public string BlendShapePrefix = "blendShape.";

        // public float GetCoefficientScale
        // {
        //     get => coefficientScale;
        //     set => coefficientScale = value;
        // }

        [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;

        // public SkinnedMeshRenderer GetSkinnedMeshRenderer
        // {
        //     get => skinnedMeshRenderer;
        //     set
        //     {
        //         skinnedMeshRenderer = value;
        //         CreateFeatureBlendMapping();
        //     }
        // }


        ARKitFaceSubsystem faceSubsystem;
        Dictionary<ARKitBlendShapeLocation, int> faceArkitBlendShapeIndexMap;

        private ARFace face;

        private void Awake()
        {
            face = GetComponentInParent<ARFace>();
            CreateFeatureBlendMapping();
        }


        private void CreateFeatureBlendMapping()
        {
            if (skinnedMeshRenderer == null || skinnedMeshRenderer.sharedMesh == null) return;


            faceArkitBlendShapeIndexMap = new Dictionary<ARKitBlendShapeLocation, int>();

            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowDownLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "browDown_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowDownRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "browDown_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowInnerUp] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "browInnerUp");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowOuterUpLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "browOuterUp_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowOuterUpRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "browOuterUp_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.CheekPuff] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "cheekPuff");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.CheekSquintLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "cheekSquint_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.CheekSquintRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "cheekSquint_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeBlinkLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeBlink_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeBlinkRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeBlink_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookDownLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookDown_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookDownRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookDown_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookInLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookIn_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookInRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookIn_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookOutLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookOut_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookOutRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookOut_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookUpLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookUp_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookUpRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeLookUp_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeSquintLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeSquint_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeSquintRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeSquint_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeWideLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeWide_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeWideRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "eyeWide_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawForward] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "jawForward");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "jawLeft");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawOpen] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "jawOpen");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "jawRight");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthClose] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthClose");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthDimpleLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthDimple_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthDimpleRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthDimple_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthFrownLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthFrown_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthFrownRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthFrown_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthFunnel] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthFunnel");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthLeft");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthLowerDownLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthLowerDown_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthLowerDownRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthLowerDown_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthPressLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthPress_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthPressRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthPress_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthPucker] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthPucker");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthRight");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthRollLower] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthRollLower");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthRollUpper] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthRollUpper");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthShrugLower] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthShrugLower");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthShrugUpper] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthShrugUpper");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthSmileLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthSmile_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthSmileRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthSmile_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthStretchLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthStretch_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthStretchRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthStretch_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthUpperUpLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthUpperUp_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthUpperUpRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "mouthUpperUp_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.NoseSneerLeft] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "noseSneer_L");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.NoseSneerRight] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "noseSneer_R");
            faceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.TongueOut] =
                skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapePrefix + "tongueOut");
        }


        void SetVisible(bool _visible)
        {
            if (skinnedMeshRenderer == null) return;
            skinnedMeshRenderer.enabled = _visible;
        }

        void UpdateVisibility()
        {
            if (face == null) return;
            var tmp_Visible = enabled && (face.trackingState == TrackingState.Tracking) &&
                              (ARSession.state > ARSessionState.Ready);
            SetVisible(tmp_Visible);
        }

        private void OnEnable()
        {
            var tmp_FaceManager = FindObjectOfType<ARFaceManager>();
            if (tmp_FaceManager != null)
            {
                faceSubsystem = tmp_FaceManager.subsystem as ARKitFaceSubsystem;
            }

            UpdateVisibility();
            face.updated += OnFaceUpdate;
            ARSession.stateChanged += OnSystemStateChanged;
        }

        private void OnDisable()
        {
            face.updated -= OnFaceUpdate;
            ARSession.stateChanged -= OnSystemStateChanged;
        }

        private void OnSystemStateChanged(ARSessionStateChangedEventArgs _obj)
        {
            UpdateVisibility();
        }

        private void OnFaceUpdate(ARFaceUpdatedEventArgs _obj)
        {
            UpdateVisibility();
            UpdateFaceFeatures();
        }

        private void UpdateFaceFeatures()
        {
            if (skinnedMeshRenderer == null || !skinnedMeshRenderer.enabled ||
                skinnedMeshRenderer.sharedMesh == null) return;

            using (var tmp_BlendShapes = faceSubsystem.GetBlendShapeCoefficients(face.trackableId, Allocator.Temp))
            {
                foreach (var tmp_FeatureCoefficient in tmp_BlendShapes)
                {
                    if (faceArkitBlendShapeIndexMap.TryGetValue(tmp_FeatureCoefficient.blendShapeLocation,
                            out var tmp_MappedBlendShapeIndex))
                    {
                        if (tmp_MappedBlendShapeIndex >= 0)
                        {
                            skinnedMeshRenderer.SetBlendShapeWeight(tmp_MappedBlendShapeIndex,
                                tmp_FeatureCoefficient.coefficient * coefficientScale);
                        }
                    }
                }
            }
        }
    }
}