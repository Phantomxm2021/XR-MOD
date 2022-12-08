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

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
#if UNITY_ANDROID || UNITY_IOS
    [Descriptor(typeof(ARMODTryAcquireAROcclusionFrame))]
    // ReSharper disable once IdentifierTypo
    public class ARMODTryAcquireAROcclusionFrameDescriptor : ARMODBaseWithResultUnitIncludeAPIDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public ARMODTryAcquireAROcclusionFrameDescriptor(ARMODTryAcquireAROcclusionFrame target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Get the AR Occlusion frame texture to AR-Experience.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(EditorGUIUtility.IconContent("d_OcclusionPortal Icon").image);
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(EditorGUIUtility.IconContent("d_OcclusionPortal Icon").image);
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription _description)
        {
            base.DefinedPort(port, _description);

            switch (port.key)
            {
                case "Data":
                    _description.summary = "Data sent to the AR-MOD to try acquire the occlusion texture.";
                    break;

                case "Result":
                    _description.summary = "Occlusion texture.";

                    break;
            }
        }
    }
#endif
}