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
   
    [Descriptor(typeof(VSAnchorData))]
    // ReSharper disable once IdentifierTypo
    public class AnchorNotificationDataDescriptor : BaseNotificationDataDescriptor
    {
        // ReSharper disable once IdentifierTypo
        public AnchorNotificationDataDescriptor(VSAnchorData target) : base(target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Subclass of BaseNotificationData. " +
                   "When you are call the [StickObject] method  will be need pass this data to AR-MOD SDK.";
        }



        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            base.DefinedPort(port, description);

            switch (port.key)
            {
                case "TrackableType":
                    description.summary = "Interactor type.";
                    break;
                case "Position":
                    description.summary = "Anchor position(local position).";
                    break;
                case "Rotation":
                    description.summary = "Anchor rotation(local rotation).";
                    break;
                case "Offset":
                    description.summary = "Anchor offset position(local position).";
                    break;
                case "VirtualObject":
                    description.summary = "Game objects to be placed";
                    break;
            }
        }
    }
}