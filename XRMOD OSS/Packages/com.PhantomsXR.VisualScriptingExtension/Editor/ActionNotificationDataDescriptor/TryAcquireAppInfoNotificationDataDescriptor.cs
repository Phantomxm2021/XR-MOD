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
    [Descriptor(typeof(VSTryAcquireAppInfoData))]
    // ReSharper disable once IdentifierTypo
    public class TryAcquireAppInfoNotificationDataDescriptor : BaseNotificationDataDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public TryAcquireAppInfoNotificationDataDescriptor(VSTryAcquireAppInfoData _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return
                "Subclass of BaseNotificationData. " +
                "When you are call the [TryAcquireAppInfo] method  will be need pass this data to AR-MOD SDK.";
        }


        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "GetInfoType":
                    _description.summary = "Opcode to get app info.";
                    break;
            }
        }
    }
}