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
using UnityEditor;
using UnityEngine.Assertions;
using System.Collections.Generic;
using System.IO;
using UnityEditor.IMGUI.Controls;
using com.Phantoms.ActionNotification.Runtime;


namespace com.Phantoms.ARMODPackageTools.Core
{
    internal class ProjectTreeRenderer : TreeView
    {
        private bool clickedOnItem;
        private const float CONST_ROW_HEIGHTS = 20f;
        private const string CONST_ROOT_DISPLAY_NAME = "Root";
        private const string CONST_COLLAB_EDIT_ICON = "CollabEdit Icon";
        private const string CONST_CREATE_PROJECT_NAME = "New Project";
        private const string CONST_OPEN_PROJECT_NAME = "Open Project";
        private const string CONST_REMOVE_PROJECT_NAME = "Remove";
        private const string CONST_EDIT_PROJECT_NAME = "Edit";
        private const string CONST_EXIT_EDITING_PROJECT_NAME = "Exit Editing";
        private const string CONST_CANCEL_NAME = "Cancel";
        private const string CONST_DIALOG_TITLE = "Remove Project";
        private const string CONST_RENAME_PROJECT_NAME = "Rename";
        private const string CONST_PREFABSFOLDERPATH = "Artwork/SampleAssets/Prefabs";
        protected const string CONST_MODIFYTTEMPLATEMONOBINDER = "ModifyTemplateMonoBinder";
        private const string CONST_PING_PROJECT = "PingProject";

        private readonly AllProjectsCache allProjectsCache;
        private readonly IList<TreeViewItem> rows;

        public ProjectTreeRenderer(TreeViewState state) : base(state)
        {
        }

        public ProjectTreeRenderer(TreeViewState state, MultiColumnHeader multiColumnHeader,
            ref AllProjectsCache _allProjectsCache) : base(state, multiColumnHeader)
        {
            Assert.IsNotNull(_allProjectsCache);
            allProjectsCache = _allProjectsCache;
            allProjectsCache.OnListChanged += Reload;

            useScrollView = true;
            showBorder = true;
            rowHeight = CONST_ROW_HEIGHTS;
            showAlternatingRowBackgrounds = true;
            customFoldoutYOffset = (CONST_ROW_HEIGHTS - EditorGUIUtility.singleLineHeight) * 0.5f;
            rows = new List<TreeViewItem>();

            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                //Enter editing model
                var tmp_NewProject =
                    allProjectsCache.ProjectCacheDataList[allProjectsCache.ProjectCacheDataList.Count - 1];
                EnterEditingModel(tmp_NewProject.Project.Id);
            }, nameof(CreateProjectCommand));
        }

        protected override TreeViewItem BuildRoot()
        {
            return new TreeViewItem {id = -1, depth = -1, displayName = CONST_ROOT_DISPLAY_NAME};
        }

        protected override void RenameEnded(RenameEndedArgs _args)
        {
            base.RenameEnded(_args);
            if (!_args.acceptedRename) return;
            allProjectsCache.Find(_args.itemID).Project.DisplayName = _args.newName;
            Reload();
        }

        protected override bool CanRename(TreeViewItem _item)
        {
            return true;
        }

        protected override IList<TreeViewItem> BuildRows(TreeViewItem root)
        {
            rows.Clear();

            foreach (var tmp_ProjectCache in allProjectsCache.ProjectCacheDataList)
            {
                if (tmp_ProjectCache == null) continue;
                var tmp_ProjectTreeViewItem = CreateTreeViewItem(tmp_ProjectCache.Project);
                root.AddChild(tmp_ProjectTreeViewItem);
                rows.Add(tmp_ProjectTreeViewItem);
            }

            return rows;
        }


        protected override void RowGUI(RowGUIArgs _args)
        {
            var tmp_ProjectTreeViewItem = _args.item as ProjectTreeViewItem;
            for (int tmp_Idx = 0; tmp_Idx < _args.GetNumVisibleColumns(); ++tmp_Idx)
            {
                var tmp_CellRect = _args.GetCellRect(tmp_Idx);
                CenterRectUsingSingleLineHeight(ref tmp_CellRect);
                var tmp_ColumnIndex = _args.GetColumn(tmp_Idx);
                if (tmp_ColumnIndex == 0)
                {
                    if (tmp_ProjectTreeViewItem != null)
                    {
                        if (tmp_ProjectTreeViewItem.ProjectModel.ProjectStatus ==
                            ProjectModel.ProjectStatusEnum.Opening)
                        {
                            Rect tmp_IconRect = new Rect(_args.rowRect.width - 50, _args.rowRect.y, 60,
                                _args.rowRect.height);
                            GUI.DrawTexture(tmp_IconRect, EditorGUIUtility.FindTexture(CONST_COLLAB_EDIT_ICON),
                                ScaleMode.ScaleToFit);
                        }
                    }
                }

                _args.rowRect = tmp_CellRect;
                base.RowGUI(_args);
            }
        }

        ProjectTreeViewItem CreateTreeViewItem(ProjectModel _model)
        {
            return new ProjectTreeViewItem {id = _model.Id, displayName = _model.DisplayName, ProjectModel = _model};
        }

        protected override void ContextClickedItem(int _id)
        {
            base.ContextClickedItem(_id);
            clickedOnItem = true;
            GenericMenu tmp_Menu = new GenericMenu();

            var tmp_CurrentProjectData = allProjectsCache.Find(_id);
            if (tmp_CurrentProjectData &&
                tmp_CurrentProjectData.Project.ProjectStatus == ProjectModel.ProjectStatusEnum.Opening)
            {
                tmp_Menu.AddItem(new GUIContent(CONST_EXIT_EDITING_PROJECT_NAME), false,
                    () =>
                    {
                        GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
                        {
                            CommandId = nameof(ExitEditingProjectCommand),
                            AllProjectsCache = allProjectsCache,
                            SelectedId = GetSelection()[0]
                        };
                        CommandFactory.CreateAndExecuteCommand(tmp_Data);
                    });
            }
            else
            {
                tmp_Menu.AddItem(new GUIContent(CONST_EDIT_PROJECT_NAME), false, () =>
                {
                    EnterEditingModel(GetSelection()[0]);
                    Reload();
                });
            }

            tmp_Menu.AddItem(new GUIContent(CONST_RENAME_PROJECT_NAME), false,
                () =>
                {
                    var tmp_TreeItem = FindItem(_id, rootItem);
                    if (BeginRename(tmp_TreeItem))
                        tmp_CurrentProjectData.Project.DisplayName = tmp_TreeItem.displayName;
                });

            tmp_Menu.AddItem(new GUIContent(CONST_PING_PROJECT), false,
                () =>
                {
                    EditorGUIUtility.PingObject(
                        AssetDatabase.LoadAssetAtPath<Object>(tmp_CurrentProjectData.DetailCacheData.SubPath));
                });

            tmp_Menu.AddSeparator(string.Empty);
            GenericCreateProjectMenu(ref tmp_Menu);
            tmp_Menu.AddSeparator(string.Empty);
            tmp_Menu.AddItem(new GUIContent(CONST_REMOVE_PROJECT_NAME), false, () =>
            {
                if (!EditorUtility.DisplayDialog(CONST_DIALOG_TITLE, "Do you wanna remove this project?",
                        CONST_REMOVE_PROJECT_NAME,
                        CONST_CANCEL_NAME)) return;
                GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
                {
                    CommandId = nameof(RemoveProjectCommand),
                    AllProjectsCache = allProjectsCache,
                    SelectedId = -1
                };
                foreach (int tmp_SelectionId in GetSelection())
                {
                    tmp_Data.SelectedId = tmp_SelectionId;
                    CommandFactory.CreateAndExecuteCommand(tmp_Data);
                }

                Reload();
            });
            tmp_Menu.ShowAsContext();
        }


        protected override void ContextClicked()
        {
            if (clickedOnItem)
            {
                clickedOnItem = !clickedOnItem;
                return;
            }

            base.ContextClicked();

            if (EditorApplication.isCompiling) return;
            GenericMenu tmp_Menu = new GenericMenu();
            GenericCreateProjectMenu(ref tmp_Menu);
            tmp_Menu.ShowAsContext();
        }

        private void GenericCreateProjectMenu(ref GenericMenu _menu)
        {
            _menu.AddItem(new GUIContent(CONST_CREATE_PROJECT_NAME), false,
                NewProjectWizard.ShowNewProjectWizard);

            _menu.AddItem(new GUIContent(CONST_OPEN_PROJECT_NAME), false,
                () =>
                {
                    GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
                    {
                        CommandId = nameof(OpenProjectCommand),
                        AllProjectsCache = allProjectsCache,
                        SelectedId = -1
                    };
                    CommandFactory.CreateAndExecuteCommand(tmp_Data);
                });
        }


        private void EnterEditingModel(int _id)
        {
            GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
            {
                CommandId = nameof(EditingProjectCommand),
                AllProjectsCache = allProjectsCache,
                SelectedId = _id
            };
            CommandFactory.CreateAndExecuteCommand(tmp_Data);
        }

        [InitializeOnLoadMethod]
        private static void WaitToCompiling()
        {
            if (EditorPrefs.GetBool(ConstKey.CONST_CREATE_NEW_AR_EXPERIENCE))
            {
                AssemblyReloadEvents.afterAssemblyReload += DelayCallForEditingProject;
            }
        }

        private static void DelayCallForEditingProject()
        {
            EditorApplication.delayCall += () =>
            {
                EditorApplication.delayCall = () =>
                {
                    var tmp_ProjectIndexId = PackageToolsEditor.ALL_PROJECT_CACHE.GetLast().Project.Id;

                    //Editing this project after added to our project-list
                    GenericMenuItemCommandData tmp_CommandData = new GenericMenuItemCommandData
                    {
                        CommandId = nameof(EditingProjectCommand),
                        AllProjectsCache = PackageToolsEditor.ALL_PROJECT_CACHE,
                        SelectedId = tmp_ProjectIndexId,
                        DestinationPath = PackageToolsEditor.ALL_PROJECT_CACHE.GetLast().DetailCacheData.SubPath
                    };

                    CommandFactory.CreateAndExecuteCommand(tmp_CommandData);


                    //To Avoid ModifyTemplateMonoBinder key error when create project without from template.
                    var tmp_PrefabsFolder =
                        Path.Combine(tmp_CommandData.DestinationPath, CONST_PREFABSFOLDERPATH);
                    if (Directory.Exists(tmp_PrefabsFolder))
                    {
                        ActionNotificationCenter.DefaultCenter.PostNotification(CONST_MODIFYTTEMPLATEMONOBINDER,
                            new BaseNotificationData
                            {
                                BaseData =
                                    $"{Path.Combine(tmp_CommandData.DestinationPath, CONST_PREFABSFOLDERPATH)}|{tmp_CommandData.AllProjectsCache.Find(tmp_ProjectIndexId).Project.DisplayName}"
                            });
                    }

                    EditorApplication.delayCall = null;
                    AssemblyReloadEvents.afterAssemblyReload -= DelayCallForEditingProject;
                    EditorPrefs.SetBool(ConstKey.CONST_CREATE_NEW_AR_EXPERIENCE, false);
                };
            };
        }
    }
}