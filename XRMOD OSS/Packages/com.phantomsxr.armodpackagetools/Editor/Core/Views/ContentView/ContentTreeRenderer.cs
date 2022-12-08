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
using System.IO;
using System.Linq;
using com.Phantoms.ActionNotification.Runtime;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using Object = UnityEngine.Object;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class ContentTreeRenderer : TreeView
    {
        const float CONST_ROW_HEIGHTS = 20f;
        public Action addedNewElement;
        public Action removedElement;
        public bool CanDragAndDrop = true;

        private AllProjectsCache allProjectsCache;
        private List<ContentModel> contentModels;

        enum ColumnsType
        {
            Icon1,
            Name,
            AssetPath,
        }

        public ContentTreeRenderer(TreeViewState state) : base(state)
        {
        }

        public ContentTreeRenderer(TreeViewState state, MultiColumnHeader multiColumnHeader,
            AllProjectsCache _allProjectsCache) :
            base(state, multiColumnHeader)
        {
            allProjectsCache = _allProjectsCache;
            showBorder = true;
            rowHeight = CONST_ROW_HEIGHTS;
            showAlternatingRowBackgrounds = true;
            customFoldoutYOffset = (CONST_ROW_HEIGHTS - EditorGUIUtility.singleLineHeight) * 0.5f;
            UpdateContentList();
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
            {
                UpdateContentList();
                Reload();
            }, nameof(EditingProjectCommand));
        }

        private void UpdateContentList()
        {
            var tmp_ProjectCacheData = allProjectsCache.GetEditingProjectData();
            if (tmp_ProjectCacheData)
            {
                contentModels = tmp_ProjectCacheData.DetailCacheData.Contents ?? new List<ContentModel>();
                //Fix Asset's path
                tmp_ProjectCacheData.DetailCacheData.ChangeAssetsPath(tmp_ProjectCacheData.Project.DisplayName);
            }
            else
                contentModels = new List<ContentModel>();
        }

        protected override TreeViewItem BuildRoot()
        {
            return new TreeViewItem {id = -1, depth = -1, displayName = "Root"};
        }

        protected override IList<TreeViewItem> BuildRows(TreeViewItem root)
        {
            var tmp_Rows = GetRows() ?? new List<TreeViewItem>();
            tmp_Rows.Clear();
            foreach (var tmp_Content in contentModels)
            {
                var tmp_ProjectTreeViewItem = CreateTreeViewItem(tmp_Content);
                root.AddChild(tmp_ProjectTreeViewItem);
                tmp_Rows.Add(tmp_ProjectTreeViewItem);
            }

            return tmp_Rows;
        }

        protected override void RowGUI(RowGUIArgs _args)
        {
            var tmp_ContentTreeViewItem = _args.item as ContentTreeViewItem;

            for (int tmp_Idx = 0; tmp_Idx < _args.GetNumVisibleColumns(); ++tmp_Idx)
            {
                var tmp_CellRect = _args.GetCellRect(tmp_Idx);
                CenterRectUsingSingleLineHeight(ref tmp_CellRect);
                var tmp_ColumnIndex = _args.GetColumn(tmp_Idx);

                switch ((ColumnsType) tmp_ColumnIndex)
                {
                    case ColumnsType.Icon1:
                        break;
                    case ColumnsType.Name:
                        _args.rowRect = tmp_CellRect;
                        base.RowGUI(_args);
                        break;
                    case ColumnsType.AssetPath:
                        if (tmp_ContentTreeViewItem != null)
                            DefaultGUI.Label(tmp_CellRect, tmp_ContentTreeViewItem.ContentModel.AssetPathInUnity,
                                _args.selected,
                                _args.focused);
                        break;
                }
            }
        }


        ContentTreeViewItem CreateTreeViewItem(ContentModel _model)
        {
            return new ContentTreeViewItem {id = _model.Id, displayName = _model.DisplayName, ContentModel = _model};
        }


        protected override void ContextClickedItem(int _id)
        {
            base.ContextClickedItem(_id);
            var tmp_Item = contentModels.FirstOrDefault(_element => _element.Id == _id);
            GenericMenu tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Ping Object"), false, () =>
            {
                var tmp_Object = AssetDatabase.LoadAssetAtPath(tmp_Item.AssetPathInUnity, typeof(Object));
                EditorGUIUtility.PingObject(tmp_Object);
            });
            tmp_Menu.AddItem(new GUIContent("Short Name"), false, () =>
            {
                tmp_Item.DisplayName = Path.GetFileNameWithoutExtension(tmp_Item.DisplayName);
                RenameEnded(new RenameEndedArgs
                {
                    newName = Path.GetFileNameWithoutExtension(tmp_Item.DisplayName), itemID = tmp_Item.Id,
                    acceptedRename = true
                });
            });
            tmp_Menu.AddItem(new GUIContent("Rename"), false, () =>
            {
                if (BeginRename(FindItem(_id, rootItem)))
                {
                    Reload();
                }
            });
            tmp_Menu.AddSeparator("");
            tmp_Menu.AddItem(new GUIContent("Remove"), false, () =>
            {
                var tmp_ElementIDs = GetSelection();
                var tmp_Elements = contentModels.Where(_element => tmp_ElementIDs.Contains(_element.Id)).ToArray();
                foreach (var tmp_Element in tmp_Elements)
                    contentModels.Remove(tmp_Element);

                removedElement?.Invoke();
                Reload();
            });

            tmp_Menu.ShowAsContext();
        }

        public override void OnGUI(Rect _rect)
        {
            base.OnGUI(_rect);
        }

        protected override bool CanStartDrag(CanStartDragArgs _args)
        {
            return base.CanStartDrag(_args);
        }


        protected override void SetupDragAndDrop(SetupDragAndDropArgs _args)
        {
            base.SetupDragAndDrop(_args);
        }

        protected override DragAndDropVisualMode HandleDragAndDrop(DragAndDropArgs _args)
        {
            if (!CanDragAndDrop) return DragAndDropVisualMode.None;
            if (!_args.performDrop) return DragAndDropVisualMode.Link;
            DragAndDrop.visualMode = DragAndDropVisualMode.Link;
            DragAndDrop.AcceptDrag();

            foreach (Object tmp_DraggedObject in DragAndDrop.objectReferences)
            {
                if (tmp_DraggedObject is DefaultAsset)
                {
                    continue;
                }

                string tmp_AssetPath = AssetDatabase.GetAssetPath(tmp_DraggedObject);
                var tmp_Content = new ContentModel
                {
                    Id = GenerateContentIndex,
                    DisplayName = tmp_DraggedObject.name,
                    AssetPathInUnity = tmp_AssetPath,
                    Type = tmp_DraggedObject.GetType().Name
                };
                contentModels.Add(tmp_Content);
                addedNewElement?.Invoke();
            }

            Reload();
            return DragAndDropVisualMode.Generic;
        }

        protected override void RenameEnded(RenameEndedArgs _args)
        {
            base.RenameEnded(_args);
            if (!_args.acceptedRename) return;
            allProjectsCache.GetEditingProjectData().DetailCacheData.Find(_args.itemID).DisplayName = _args.newName;
            Reload();
        }

        protected override bool CanRename(TreeViewItem _item)
        {
            return true;
        }

        /// <summary>
        /// Generate the content item index id。
        /// Avoid drag-and-drop new object to contents view after the item is removed to generate the wrong id
        /// </summary>
        private int GenerateContentIndex =>
            contentModels.Count == 0 ? 0 : contentModels[contentModels.Count - 1].Id + 1;
    }
}