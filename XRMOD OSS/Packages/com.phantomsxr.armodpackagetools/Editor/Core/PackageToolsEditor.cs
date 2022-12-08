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
using System.IO;
using com.Phantoms.ActionNotification.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class PackageToolsEditor : EditorWindow
    {
        private static PackageToolsEditor PACKAGE_TOOLS_EDITOR;
        private static AllProjectsCache INSTANCE;

        public static AllProjectsCache ALL_PROJECT_CACHE
        {
            get
            {
                if (INSTANCE) return INSTANCE;
                LoadAllProjectCache();
                return INSTANCE;
            }
            set => INSTANCE = value;
        }


        private VisualElement root;

        readonly List<ToolbarToggle> toolbarToggles = new List<ToolbarToggle>();
        readonly StyleEnum<DisplayStyle> displayFlex = new StyleEnum<DisplayStyle>(DisplayStyle.Flex);
        readonly StyleEnum<DisplayStyle> displayNone = new StyleEnum<DisplayStyle>(DisplayStyle.None);

        // [InitializeOnLoadMethod]
        // private static void PrepareData()
        // {
        //     LoadAllProjectCache();
        // }

        [MenuItem("Tools/AR-MOD/Package Tools Editor")]
        public static void ShowPackageToolsEditor()
        {
            PACKAGE_TOOLS_EDITOR = GetWindow<PackageToolsEditor>();
            PACKAGE_TOOLS_EDITOR.titleContent = new GUIContent(ConstKey.CONST_PACKAGE_TOOLS_WINDOW_TITLE);
//            PACKAGE_TOOLS_EDITOR.Close();
        }


        private void OnDisable()
        {
            //Remove all of commands
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(EditingProjectCommand));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(OpenProjectCommand));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(CreateProjectCommand));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ExitEditingProjectCommand));

            if (INSTANCE == null) return;

            //Save all changed. 
            EditorUtility.SetDirty(INSTANCE);

            //`SetDirty` only saves the current data.
            //It will not automatically save other scriptable object contained in it(Changed will be lost)
            //So we need to save each object manually
            foreach (ProjectCacheData tmp_ProjectCache in INSTANCE.ProjectCacheDataList)
            {
                EditorUtility.SetDirty(tmp_ProjectCache.DetailCacheData.BuildSettingData);
                EditorUtility.SetDirty(tmp_ProjectCache.DetailCacheData.Configures);
                EditorUtility.SetDirty(tmp_ProjectCache);
            }
        }


        public void CreateGUI()
        {
            //Register editing event for showing project details and hided not editing view
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
                {
                    GenerateDetailViews();

                    var tmp_NoEditingView = root.Q<VisualElement>(ConstKey.CONST_NO_EDITING_VIEW);
                    tmp_NoEditingView.style.display = displayNone;

                    var tmp_EditingView = root.Q<VisualElement>(ConstKey.CONST_EDITING_VIEW);
                    tmp_EditingView.style.display = displayFlex;

                    toolbarToggles[INSTANCE.SeletedId].value = true;
                },
                nameof(EditingProjectCommand));


            //Register editing event for hiding project details and showed not editing view 
            ActionNotificationCenter.DefaultCenter.AddObserver(_data =>
                {
                    var tmp_NoEditingView = root.Q<VisualElement>(ConstKey.CONST_NO_EDITING_VIEW);
                    tmp_NoEditingView.style.display = displayFlex;

                    var tmp_EditingView = root.Q<VisualElement>(ConstKey.CONST_EDITING_VIEW);
                    tmp_EditingView.style.display = displayNone;
                    INSTANCE.SeletedId = 0;
                },
                nameof(ExitEditingProjectCommand));


            //Avoid Null data after scripts re-compiler
            // if (ALL_PROJECT_CACHE == null)
            LoadAllProjectCache();

            // Each editor window contains a root VisualElement object
            root = rootVisualElement;

            // Import UXML
            var tmp_UXML = Path.Combine(ConstKey.CONST_UASSETS_PATH, ConstKey.CONST_PACKAGE_TOOLS_EDITOR_UXML);
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(tmp_UXML);
            visualTree.CloneTree(root);

            // A stylesheet can be added to a VisualElement.
            // The style will be applied to the VisualElement and all of its children.
            var tmp_USS = Path.Combine(ConstKey.CONST_UASSETS_PATH, ConstKey.CONST_PACKAGE_TOOLS_EDITOR_USS);
            var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(tmp_USS);
            root.styleSheets.Add(styleSheet);

            CreateToolbarTabView();

            //Avoid display error when script re-compiler or re-open this editor there have project editing
            CheckProjectState();
        }


        private static void LoadAllProjectCache()
        {
            var tmp_CachePath = Utility.GetRootDataPath(ConstKey.CONST_ALL_PROJECT_CACHE_FILE);
            INSTANCE = AssetDatabase.LoadAssetAtPath<AllProjectsCache>(tmp_CachePath);
            if (INSTANCE)
            {
                INSTANCE.Initialization();
            }
            else
            {
                INSTANCE = CreateInstance<AllProjectsCache>();
                INSTANCE.Initialization();

                var tmp_SaveCachePath = Utility.GetRootDataPath(ConstKey.CONST_ALL_PROJECT_CACHE_FILE);
                AssetDatabase.CreateAsset(INSTANCE, tmp_SaveCachePath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        private static void CheckProjectState()
        {
            if (EditorApplication.isCompiling || INSTANCE == null) return;
            var tmp_EditingProjectData = INSTANCE.GetEditingProjectData();
            if (tmp_EditingProjectData)
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(EditingProjectCommand), null);
            }
        }

        private void GenerateDetailViews()
        {
            if (root.Q<PropertiesView>(nameof(PropertiesView)) != null) return;
            var tmp_View = root.Q<VisualElement>(ConstKey.CONST_VIEW_TAG);

            var tmp_PropertiesView = new PropertiesView() {name = nameof(PropertiesView)};
            var tmp_ContentView = new ContentView() {name = nameof(ContentView)};
            var tmp_BuildView = new BuildView() {name = nameof(BuildView)};

            tmp_View.Add(tmp_PropertiesView);
            tmp_View.Add(tmp_ContentView);
            tmp_View.Add(tmp_BuildView);
            
            tmp_PropertiesView.style.display = displayFlex;
            tmp_ContentView.style.display = displayNone;
            tmp_BuildView.style.display = displayNone;
        }


        /// <summary>
        /// Create a toolbar toggle group
        /// </summary>
        private void CreateToolbarTabView()
        {
            toolbarToggles.Add(root.Q<ToolbarToggle>(ConstKey.CONST_PROPERTIES_TOGGLE));
            toolbarToggles.Add(root.Q<ToolbarToggle>(ConstKey.CONST_CONTENTS_TOGGLE));
            toolbarToggles.Add(root.Q<ToolbarToggle>(ConstKey.CONST_BUILD_TOGGLE));

            foreach (ToolbarToggle tmp_Toggle in toolbarToggles)
            {
                //Apply style to label
                tmp_Toggle.Q<Label>().AddToClassList(ConstKey.CONST_TOOLBAR_LABEL_ITEM_USS);

                //Make toggles to a group.
                tmp_Toggle.RegisterCallback<ChangeEvent<bool>>(_evt =>
                {
                    ToggleValueChangedCallback(tmp_Toggle.name);
                });
            }
        }

        private void ToggleValueChangedCallback(string _name)
        {
            switch (_name)
            {
                case ConstKey.CONST_PROPERTIES_TOGGLE:
                    INSTANCE.SeletedId = 0;
                    root.Q<VisualElement>(nameof(PropertiesView)).style.display = displayFlex;
                    root.Q<VisualElement>(nameof(ContentView)).style.display = displayNone;
                    root.Q<VisualElement>(nameof(BuildView)).style.display = displayNone;
                    break;
                case ConstKey.CONST_CONTENTS_TOGGLE:
                    INSTANCE.SeletedId = 1;
                    root.Q<VisualElement>(nameof(PropertiesView)).style.display = displayNone;
                    root.Q<VisualElement>(nameof(ContentView)).style.display = displayFlex;
                    root.Q<VisualElement>(nameof(BuildView)).style.display = displayNone;
                    break;
                case ConstKey.CONST_BUILD_TOGGLE:
                    INSTANCE.SeletedId = 2;
                    root.Q<VisualElement>(nameof(PropertiesView)).style.display = displayNone;
                    root.Q<VisualElement>(nameof(ContentView)).style.display = displayNone;
                    root.Q<VisualElement>(nameof(BuildView)).style.display = displayFlex;
                    break;
            }


            //Only toggle one
            foreach (ToolbarToggle tmp_Toggle in toolbarToggles)
            {
                tmp_Toggle.SetValueWithoutNotify(toolbarToggles[INSTANCE.SeletedId].name
                    .Equals(tmp_Toggle.name));
            }
        }
    }
}