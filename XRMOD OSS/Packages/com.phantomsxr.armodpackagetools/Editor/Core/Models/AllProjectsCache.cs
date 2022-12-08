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

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class AllProjectsCache : ScriptableObject
    {
        public List<ProjectCacheData> ProjectCacheDataList;
        public Action OnListChanged;
        public int SeletedId = 0;

        public void Initialization()
        {
            if (ProjectCacheDataList == null || ProjectCacheDataList.Count == 0)
            {
                ProjectCacheDataList = new List<ProjectCacheData>();
            }
        }

        /// <summary>
        /// Get total of AR-MOD projects on unity editor
        /// </summary>
        public int GetTotalOfProjects => ProjectCacheDataList.Count == 0 ? 0 : ProjectCacheDataList.Count;

        public ProjectCacheData GetLast()
        {
            return ProjectCacheDataList.Count > 0 ? ProjectCacheDataList[ProjectCacheDataList.Count - 1] : null;
        }

        public ProjectCacheData GetEditingProjectData()
        {
            var tmp_ProjectCache = ProjectCacheDataList?.Find(_project =>
                _project.Project.ProjectStatus == ProjectModel.ProjectStatusEnum.Opening);
            return tmp_ProjectCache == null ? null : tmp_ProjectCache;
        }

        public Configures GetEditingProjectConfigure()
        {
            Assert.IsNotNull(GetEditingProjectData()?.DetailCacheData.Configures);
            return GetEditingProjectData()?.DetailCacheData.Configures;
        }

        public void AddNewProject(ref ProjectCacheData _projectCacheData)
        {
            ProjectCacheDataList.Add(_projectCacheData);
            OnListChanged?.Invoke();
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            for (int tmp_Idx = 0; tmp_Idx < ProjectCacheDataList.Count; tmp_Idx++)
            {
                var tmp_CacheData = ProjectCacheDataList[tmp_Idx];
                if (tmp_CacheData == null)
                {
                    ProjectCacheDataList.Remove(tmp_CacheData);
                }
            }
        }
#endif
        /// <summary>
        /// Remote project by id
        /// </summary>
        /// <param name="_id"></param>
        public void RemoveProject(int _id)
        {
            var tmp_ProjectCacheData = ProjectCacheDataList.Find(_project => _project.Project.Id.Equals(_id));
            ProjectCacheDataList.Remove(tmp_ProjectCacheData);
            OnListChanged?.Invoke();
        }

        /// <summary>
        /// Exit editing all projects
        /// </summary>
        public void ExitEditingForAll()
        {
            foreach (ProjectCacheData tmp_ProjectCacheData in ProjectCacheDataList)
            {
                tmp_ProjectCacheData.Project.ProjectStatus = ProjectModel.ProjectStatusEnum.Close;
            }
        }

        public ProjectCacheData Find(int _id)
        {
            return ProjectCacheDataList.FirstOrDefault(_cache => _cache.Project.Id == _id);
        }
    }
}