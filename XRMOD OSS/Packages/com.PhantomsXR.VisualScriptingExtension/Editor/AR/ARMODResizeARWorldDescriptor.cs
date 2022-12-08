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

using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
#if UNITY_IOS || UNITY_ANDROID
    [Descriptor(typeof(ARMODResizeARWorld))]
    // ReSharper disable once IdentifierTypo
    public class ARMODResizeARWorldDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public ARMODResizeARWorldDescriptor(ARMODResizeARWorld target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return "To reset the AR world scale.";
        }

        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/box_resize.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/box_resize.png"));
        }
        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "ARWorldScale":
                    _description.summary = "The AR world size to be set 1 is equal to 1 meter.";
                    break;

            }
        }
    }
#endif
}