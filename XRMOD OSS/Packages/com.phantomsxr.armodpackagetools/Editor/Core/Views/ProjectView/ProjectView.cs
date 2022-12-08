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
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.IMGUI.Controls;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class ProjectView : VisualElement
    {
        private ProjectTreeRenderer treeRenderer;
        private MultiColumnHeaderState.Column nameColumn;

        public new class UxmlFactory : UxmlFactory<ProjectView, UxmlTraits>
        {
        }

        public ProjectView()
        {
            BuildTreeView();
            DrawProjectList();

            RegisterCallback<GeometryChangedEvent>((_v) => { nameColumn.width = contentRect.width; });
        }

        internal void DrawProjectList()
        {
            IMGUIContainer tmp_IMGUIContainer = new IMGUIContainer(() =>
            {
                var tmp_Rect = EditorGUILayout.GetControlRect(false, contentRect.height);
                treeRenderer?.OnGUI(tmp_Rect);
            });

            Add(tmp_IMGUIContainer);
            AddToClassList("full-vertical-view");
            tmp_IMGUIContainer.AddToClassList("full-vertical-view");
        }

        internal void BuildTreeView()
        {
            nameColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent("Project Name"),
                headerTextAlignment = TextAlignment.Left,
                canSort = true,
                minWidth = 50,
                autoResize = true,
                allowToggleVisibility = false
            };
            var tmp_HeaderState = new MultiColumnHeaderState(new[] {nameColumn});
            var tmp_MultiColumnHeader = new MultiColumnHeader(tmp_HeaderState);
            var tmp_TreeViewState = new TreeViewState();
            var tmp_AllProjectCache = PackageToolsEditor.ALL_PROJECT_CACHE;
            treeRenderer = new ProjectTreeRenderer(tmp_TreeViewState, tmp_MultiColumnHeader,
                ref tmp_AllProjectCache);
            treeRenderer.Reload();
        }
    }
}