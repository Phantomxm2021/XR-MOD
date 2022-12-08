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

using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.UIElements;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class ContentView : VisualElement
    {
        private ContentTreeRenderer treeRenderer;
        private List<MultiColumnHeaderState.Column> nameColumnList = new List<MultiColumnHeaderState.Column>();
        internal float height = 0;
        public new class UxmlFactory : UxmlFactory<ContentView, VisualElement.UxmlTraits>
        {
        }

        public ContentView()
        {
            BuildTreeView();
            DrawContentList();
        }


        internal void DrawContentList()
        {
            IMGUIContainer tmp_IMGUIContainer = new IMGUIContainer(() =>
            {
                var tmp_Rect = EditorGUILayout.GetControlRect(false, layout.height);
                treeRenderer.OnGUI(tmp_Rect);
            });

            Add(tmp_IMGUIContainer);
            AddToClassList("full-vertical-view");
            tmp_IMGUIContainer.AddToClassList("full-vertical-view");
        }

        internal void BuildTreeView()
        {
            var tmp_IconColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent(EditorGUIUtility.FindTexture("FilterByLabel"), ""),
                contextMenuText = "Asset",
                headerTextAlignment = TextAlignment.Left,
                sortedAscending = true,
                sortingArrowAlignment = TextAlignment.Right,
                width = 30,
                minWidth = 30,
                maxWidth = 60,
                autoResize = false,
                allowToggleVisibility = true,
                canSort = true
            };

            var tmp_NameColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent("Asset Name"),
                headerTextAlignment = TextAlignment.Left,
                sortedAscending = true,
                sortingArrowAlignment = TextAlignment.Right,
                width = 200,
                minWidth = 60,
                autoResize = false,
                allowToggleVisibility = false
            };

            var tmp_FullPathColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent("Asset Path"),
                headerTextAlignment = TextAlignment.Left,
                sortedAscending = true,
                sortingArrowAlignment = TextAlignment.Left,
                width = 1000,
                minWidth = 60,
                autoResize = true
            };

            nameColumnList.Add(tmp_IconColumn);
            nameColumnList.Add(tmp_NameColumn);
            nameColumnList.Add(tmp_FullPathColumn);

            var headerState = new MultiColumnHeaderState(nameColumnList.ToArray());
            var multiColumnHeader = new MultiColumnHeader(headerState);
            var treeViewState = new TreeViewState();
            treeRenderer =
                new ContentTreeRenderer(treeViewState, multiColumnHeader, PackageToolsEditor.ALL_PROJECT_CACHE);
            treeRenderer.Reload();
        }
    }
}