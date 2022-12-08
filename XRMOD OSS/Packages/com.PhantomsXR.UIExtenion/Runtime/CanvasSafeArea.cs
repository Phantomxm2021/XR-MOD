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

using UnityEngine;

namespace com.PhantomsXR.UIExtension
{
    public class CanvasSafeArea : MonoBehaviour
    {
        public RectTransform SafeAreaRect;

        private Rect lastSafeArea = Rect.zero;
        [SerializeField] private Canvas canvas;

        private void Awake()
        {
            if (!canvas)
                canvas = GetComponent<Canvas>();
        }

        private void Update()
        {
            if (lastSafeArea == Screen.safeArea) return;
            lastSafeArea = Screen.safeArea;
            ApplySafeArea();
        }

        [ContextMenu("Run Adapt")]
        void Start()
        {
            lastSafeArea = Screen.safeArea;
            ApplySafeArea();
        }

        void ApplySafeArea()
        {
            if (SafeAreaRect == null)
            {
                return;
            }

            Rect safeArea = Screen.safeArea;

            Vector2 tmp_AnchorMin = safeArea.position;
            Vector2 tmp_AnchorMax = safeArea.position + safeArea.size;
            var tmp_PixelRect = canvas.pixelRect;
            tmp_AnchorMin.x /= tmp_PixelRect.width;
            tmp_AnchorMin.y /= tmp_PixelRect.height;
            tmp_AnchorMax.x /= tmp_PixelRect.width;
            tmp_AnchorMax.y /= tmp_PixelRect.height;

            SafeAreaRect.anchorMin = tmp_AnchorMin;
            SafeAreaRect.anchorMax = tmp_AnchorMax;
        }
    }
}