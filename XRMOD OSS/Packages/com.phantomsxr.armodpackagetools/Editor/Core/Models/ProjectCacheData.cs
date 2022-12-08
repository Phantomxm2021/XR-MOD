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

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class ProjectCacheData : ScriptableObject
    {
        public ProjectDetailCacheData DetailCacheData;
        public ProjectModel Project;

        public void UpdateId(int _id)
        {
            DetailCacheData.Id = _id;
            Project.Id = _id;
        }

        public void EntryEditing(bool _exit)
        {
            Project.ProjectStatus =
                _exit ? ProjectModel.ProjectStatusEnum.Close : ProjectModel.ProjectStatusEnum.Opening;
        }
    }
}