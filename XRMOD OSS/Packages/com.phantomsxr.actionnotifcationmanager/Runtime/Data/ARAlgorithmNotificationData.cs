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

namespace com.Phantoms.ActionNotification.Runtime
{
    public enum ARAlgorithmType
    {
        Anchor,
        FocusSLAM,
        ImageTracker,
        Immersal,
        FaceMesh,
        //2.0.0-pre.2
        ARBackground,
        Basic,
        Meshing
    }

    public enum ARAlgorithmOperator
    {
        StartAlgorithm,
        PauseAlgorithm,
        StopAlgorithm
    }

    public class ARAlgorithmNotificationData : BaseNotificationData
    {
        public ARAlgorithmType ARAlgorithmType;
        public ARAlgorithmOperator ARAlgorithmOperator;
        public bool Mixed;
    }
}