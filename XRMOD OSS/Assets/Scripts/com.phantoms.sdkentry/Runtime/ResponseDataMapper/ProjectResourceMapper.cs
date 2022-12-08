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


// ReSharper disable  InconsistentNaming
namespace SDKEntry.Runtime.Mapper
{
    #region v1

    [System.Serializable]
    public class ProjectTableMapper
    {
        public string arexperience_uid;
        public ProjectAssetMapper arexperience_asset;
        public string app_id;
        public string name;
    }

    [System.Serializable]
    public class ProjectAssetMapper
    {
        public string android_bundle;
        public string android_json;
        public float android_bundle_size;
        public string ios_bundle;
        public string ios_json;
        public float ios_bundle_size;
    }

    #endregion

    #region v2

    [System.Serializable]
    public class ProjectResourceMapper
    {
        public long user_uid;
        public long app_uid;
        public long project_uid;
        public string bundle_url;
        public string json_url;
        public float bundle_size;
        public string platform_type;
    }

    #endregion
}