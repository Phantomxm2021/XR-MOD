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

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
#if UNITY_IOS || UNITY_ANDROID
    [Descriptor(typeof(VSAROcclusionData))]
    // ReSharper disable once IdentifierTypo
    public class AROcclusionNotificationDataDescriptor : BaseNotificationDataDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public AROcclusionNotificationDataDescriptor(VSAROcclusionData _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return
                "Subclass of BaseNotificationData. " +
                "When you are call the [TryAcquireAROcclusionFrame] method  will be need pass this data to AR-MOD SDK.";
        }


        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "OcclusionDataType":
                    _description.summary = "Obtain AR culling image data by specifying the type.";
                    break;
            }
        }
    }
#endif
}