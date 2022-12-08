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

using UnityEditor;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class RemoveProjectCommand : BaseGenericMenuItemCommand
    {
        //private readonly AllProjectsCache allProjectsCache;
        private readonly int removeId;

        public RemoveProjectCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
            allProjectsCache = _commandData.AllProjectsCache;
            removeId = _commandData.SelectedId;
        }

        public override void Execute()
        {
            var tmp_ProjectCache = allProjectsCache.GetEditingProjectData();
            if (tmp_ProjectCache && tmp_ProjectCache.Project.Id.Equals(removeId))
            {
                EditorUtility.DisplayDialog("Error!", "Your project is opening! You can not to remove it!",
                    "OK");
                return;
            }

            allProjectsCache.RemoveProject(removeId);

            //Re-sort all id
            int tmp_CurrentId = 0;
            foreach (ProjectCacheData tmp_CacheData in allProjectsCache.ProjectCacheDataList)
            {
                tmp_CacheData.UpdateId(tmp_CurrentId);
                tmp_CurrentId++;
            }
        }
    }
}