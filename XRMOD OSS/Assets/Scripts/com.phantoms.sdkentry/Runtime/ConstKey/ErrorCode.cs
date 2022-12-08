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

namespace SDKEntry.Runtime
{
    public enum ErrorCode : int
    {
        INIT_SDK_FAILED = -1,
        INIT_SDK_SUCCESS = 0,
        UNPACKING_FAILED = 1,
        DOWNLOAD_FAILED = 2,
        LOAD_VISUALIZER_FAILED = 3,
        ALGORITHM_ERROR = 4,
        REACHED_MAXIMUM_OF_RETRIES = 5,
        SDK_VERSION_IS_TOO_LOW = 6
    }
}