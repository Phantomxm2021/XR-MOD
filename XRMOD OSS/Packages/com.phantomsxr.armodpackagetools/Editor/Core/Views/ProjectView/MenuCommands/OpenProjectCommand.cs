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
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class OpenProjectCommand : BaseGenericMenuItemCommand
    {
        private const string CONST_OPEN_FOLDER_TITLE = "Open exist AR-MOD project";
        private const string CONST_BASE_FOLDER_NAME = "Assets";
        private const string CONST_DEFAULT_NAME = "ARExperienceProject";
        private const string CONST_CACHE_NAME = "Cache";

        private const string CONST_ERROR_WINDOW_TITLE = "ERROR";
        
        public OpenProjectCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
        }


        public override void Execute()
        {
            var tmp_ProjectPath = GenericMenuItemCommandData.DestinationPath;
            if (string.IsNullOrEmpty(tmp_ProjectPath))
            {
                tmp_ProjectPath =
                    EditorUtility.OpenFolderPanel(CONST_OPEN_FOLDER_TITLE, CONST_BASE_FOLDER_NAME, CONST_DEFAULT_NAME);
                if (string.IsNullOrEmpty(tmp_ProjectPath)) return;
                AssetDatabase.Refresh();
            }


            if (!Utility.IsCorrectProjectStructure(tmp_ProjectPath))
            {
                //Alert window to notify users
                EditorUtility.DisplayDialog(CONST_ERROR_WINDOW_TITLE, "InCorrect project structure!",
                    "Ok");
                return;
            }

            string tmp_ProjectName = new DirectoryInfo(tmp_ProjectPath).Name;

            var tmp_ProjectCount = allProjectsCache.GetTotalOfProjects;

            //Check already
            for (int tmp_Index = 0; tmp_Index < tmp_ProjectCount; tmp_Index++)
            {
                var tmp_QueryElement = allProjectsCache.Find(tmp_Index);
                if (tmp_QueryElement != null && !tmp_QueryElement.Project.DisplayName.Equals(tmp_ProjectName)) continue;
                //Alert window to notify users
                EditorUtility.DisplayDialog(CONST_ERROR_WINDOW_TITLE, $"Error! Project({tmp_ProjectName}) is exist!",
                    "Ok");
                return;
            }

            var tmp_ShortenPath = Utility.ShortenPath(tmp_ProjectPath);
            var tmp_CachePath = Path.Combine(tmp_ShortenPath, $"{CONST_CACHE_NAME}/{nameof(ProjectCacheData)}.asset");
            var tmp_ProjectCacheData = AssetDatabase.LoadAssetAtPath<ProjectCacheData>(tmp_CachePath);
            Assert.IsNotNull(tmp_ProjectCacheData);
            tmp_ProjectCacheData.UpdateId(allProjectsCache.GetTotalOfProjects);

            //Check whether the project is consistent with the previous location.
            //Inconsistency will cause errors, so we update the path in the cache to the current project path.
            //ERROR:https://www.teambition.com/task/60c4b986ab475d00440770de
            var tmp_SingleProjectCacheData = tmp_ProjectCacheData.DetailCacheData;
            if (String.CompareOrdinal(tmp_SingleProjectCacheData.SubPath, tmp_ShortenPath) !=
                0)
            {
                tmp_SingleProjectCacheData.SubPath = tmp_ShortenPath;
                Debug.Log("Fix project path");
            }

            tmp_ProjectCacheData.DetailCacheData.ChangeAssetsPath(tmp_ProjectName);
            allProjectsCache.AddNewProject(ref tmp_ProjectCacheData);

            //The last project is the one we just created.
            var tmp_LastProject = allProjectsCache.GetLast();

            GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
            {
                CommandId = nameof(EditingProjectCommand),
                AllProjectsCache = allProjectsCache,
                SelectedId = tmp_LastProject.Project.Id
            };
            CommandFactory.CreateAndExecuteCommand(tmp_Data);
            
            
            //Re-sort all project's id
            int tmp_CurrentId = 0;
            foreach (ProjectCacheData tmp_CacheData in allProjectsCache.ProjectCacheDataList)
            {
                tmp_CacheData.UpdateId(tmp_CurrentId);
                tmp_CurrentId++;
            }
        }
    }
}