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
using System.Collections;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Assertions;
using UnityEngine.Networking;
using Button = UnityEngine.UIElements.Button;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class NewProjectWizard : EditorWindow
    {
        private const string CONST_SAVE_FILE_PANEL_TITLE = "New Project Wizard";
        private const string CONST_ROOT_PATH = "Assets";
        private const string CONST_STYLES = "NewProjectWizard";
        private const string CONST_TEMPLATES_PATH = "Packages/com.phantomsxr.armodpackagetools/Editor/Templates";
        private const string CONST_CACHE_FOLDER = "ARMOD PackageTools Cache";
        private const string CONST_TEMPLATE_FOLDER_NAME = "Templates";
        private const string CONST_IMPORT_PACKAGE_AFTER = "ImportPackageAfter";

        internal const string CONST_TEMPLATE_DATA_URL =
            "https://raw.githubusercontent.com/Phantomxm2021/ARMOD-PackageToolsTemplate/main/TemplateData.json";

        private static string NEW_PROJECT_PATH;
        private static string NEW_PROJECT_NAME;

        private TemplateDataModel selectedTemplateData;
        private TemplatesScriptableObject templatesScriptableObject;

        //[MenuItem("Tools/AR-MOD/Create New Project")]
        public static void ShowNewProjectWizard()
        {
            var tmp_Wnd = GetWindow<NewProjectWizard>(true, "New Project Wizard", true);
            tmp_Wnd.maxSize = new Vector2(600, 450);
            tmp_Wnd.minSize = new Vector2(600, 450);
            tmp_Wnd.ShowUtility();
        }

        public void CreateGUI()
        {
            VisualElement tmp_Root = rootVisualElement;

            var tmp_VisualTree =
                AssetDatabase.LoadAssetAtPath<VisualTreeAsset>($"{ConstKey.CONST_UASSETS_PATH}/{CONST_STYLES}.uxml");
            if (!tmp_VisualTree) return;
            tmp_VisualTree.CloneTree(tmp_Root);
            var tmp_StyleSheet =
                AssetDatabase.LoadAssetAtPath<StyleSheet>($"{ConstKey.CONST_UASSETS_PATH}/{CONST_STYLES}.uss");
            tmp_Root.styleSheets.Add(tmp_StyleSheet);

            var tmp_ProjectNameInputer = tmp_Root.Q<TextField>("project-inputer");
            tmp_ProjectNameInputer.RegisterCallback<ChangeEvent<string>>(_evt =>
            {
                tmp_Root.Q<Button>("select-path-button").SetEnabled(!_evt.newValue.Equals(_evt.previousValue));
            });

            var tmp_SelectPathBtn = tmp_Root.Q<Button>("select-path-button");
            tmp_SelectPathBtn.SetEnabled(false);
            tmp_SelectPathBtn.RegisterCallback<ClickEvent>(_evt =>
            {
                var tmp_SelectPath =
                    EditorUtility.SaveFolderPanel(CONST_SAVE_FILE_PANEL_TITLE, CONST_ROOT_PATH, string.Empty);
                if (string.IsNullOrEmpty(tmp_SelectPath)) return;
                NEW_PROJECT_NAME = tmp_Root.Q<TextField>("project-inputer").value;
                tmp_SelectPath = Path.Combine(tmp_SelectPath, NEW_PROJECT_NAME);
                NEW_PROJECT_PATH = tmp_SelectPath;
                tmp_Root.Q<Label>("path-label").text = NEW_PROJECT_PATH;
                tmp_Root.Q<TextField>("project-inputer").SetEnabled(false);
            });

            tmp_Root.Q<Button>("create-button").RegisterCallback<ClickEvent>(_evt =>
            {
                if (!VerifyProjectPath()) return;
                CreateNewProjectEvent();
            });

            tmp_Root.Q<Button>("cancel-button").RegisterCallback<ClickEvent>(_evt => { Close(); });


            var tmp_TemplateDataPath = Path.Combine(ConstKey.CONST_UASSETS_PATH, "TemplatesData.asset");
            templatesScriptableObject = AssetDatabase.LoadAssetAtPath<TemplatesScriptableObject>(tmp_TemplateDataPath);
            Assert.IsNotNull(templatesScriptableObject);

            // As the user scrolls through the list, the ListView object
            // will recycle elements created by the "makeItem"
            // and invoke the "bindItem" callback to associate
            // the element with the matching data item (specified as an index in the list)
            var tmp_ListView = tmp_Root.Q<ListView>();
            tmp_ListView.makeItem = CreateTemplateCell;
            tmp_ListView.showAlternatingRowBackgrounds = AlternatingRowBackground.None;
            tmp_ListView.reorderable = false;
            tmp_ListView.showBoundCollectionSize = false;

            tmp_ListView.bindItem = BindItem;
            tmp_ListView.itemsSource = templatesScriptableObject.Templates;
            tmp_ListView.selectionType = SelectionType.Single;

            // Callback invoked when the user changes the selection inside the ListView
            tmp_ListView.onSelectionChange += _result =>
            {
                foreach (object tmp_Selected in _result)
                {
                    if (tmp_Selected is TemplateDataModel tmp_TemplateData)
                    {
                        selectedTemplateData = tmp_TemplateData;
                    }
                }
            };

            tmp_ListView.AddToSelection(0);
            tmp_ListView.SetSelection(0);
        }

        private void CreateNewProjectEvent()
        {
            string CONST_REGISTER_IMPORT_EVENT_NAME = "canRegisterImportListener";
            EditorPrefs.SetBool(CONST_REGISTER_IMPORT_EVENT_NAME, true);
            GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
            {
                CommandId = nameof(CreateProjectCommand),
                AllProjectsCache = PackageToolsEditor.ALL_PROJECT_CACHE,
                SelectedId = -1,
                DestinationPath = NEW_PROJECT_PATH,
                MenuType = selectedTemplateData.ID.Equals(0)
                    ? MenuType.CreateProjectWithBlank
                    : MenuType.CreateProjectFromTemplate,
                GenericParameter = selectedTemplateData.TemplateName
            };
            CommandFactory.CreateAndExecuteCommand(tmp_Data);
            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();


            Close();
        }

        /// <summary>
        /// Avoid create incorrect project
        /// </summary>
        /// <returns>True: valid,False:Invalid</returns>
        private bool VerifyProjectPath()
        {
            NEW_PROJECT_NAME = rootVisualElement.Q<TextField>("project-inputer").value;
            if (string.IsNullOrEmpty(NEW_PROJECT_NAME))
            {
                EditorUtility.DisplayDialog("ERROR", "Invalid project name", "Ok");
                return false;
            }

            if (string.IsNullOrEmpty(NEW_PROJECT_PATH) || NEW_PROJECT_PATH.Length.Equals(NEW_PROJECT_NAME.Length))
            {
                EditorUtility.DisplayDialog("ERROR", "You must choose a location to store AR experience project", "Ok");
                return false;
            }

            if (selectedTemplateData != null) return true;
            EditorUtility.DisplayDialog("ERROR", "You must select an AR experience template", "Ok");
            return false;
        }


        /// <summary>
        /// Bind list cell data
        /// </summary>
        /// <param name="e"></param>
        /// <param name="i"></param>
        private async void BindItem(VisualElement e, int i)
        {
            var tmp_Data = templatesScriptableObject.Templates[i];
            e.name = tmp_Data.TemplateDisplayName;
            e.Q<Label>("CellLabel").text = e.name.ToUpper();
            e.Q<Label>("DetailLabel").text = tmp_Data.TemplateDescription;
            e.Q<Label>("TemplateTypeLabel").text = tmp_Data.TemplateType;

            if (string.IsNullOrEmpty(tmp_Data.TemplateIcon)) return;
            var tmp_Texture2D = await Utility.TextureDownloader(tmp_Data.TemplateIcon);
            tmp_Texture2D = tmp_Texture2D != null ? tmp_Texture2D : Resources.Load<Texture2D>(tmp_Data.TemplateIcon);
            e.Q<VisualElement>("CellIcon").style.backgroundImage = new StyleBackground(tmp_Texture2D);
        }

        /// <summary>
        /// Create list cell
        /// </summary>
        /// <returns>Cell</returns>
        private VisualElement CreateTemplateCell()
        {
            VisualElement tmp_CellBackground = new VisualElement() {name = "Cell"};
            VisualElement tmp_CellIcon = new VisualElement() {name = "CellIcon"};
            VisualElement tmp_DetailGroup = new VisualElement() {name = "DetailGroup"};
            VisualElement tmp_TitleGroup = new VisualElement() {name = "TitleGroup"};


            Label tmp_CellTitleLabel = new Label("Cell Label") {name = "CellLabel"};
            Label tmp_DetailLabel = new Label("Detail Label") {name = "DetailLabel"};
            Label tmp_TemplateTypeLabel = new Label("Template Type Label") {name = "TemplateTypeLabel"};


            Button tmp_DownloadButton = new Button(() => { }) {name = "DownloadButton"};
            tmp_CellBackground.Add(tmp_CellIcon);

            tmp_TitleGroup.Add(tmp_CellTitleLabel);
            tmp_TitleGroup.Add(tmp_TemplateTypeLabel);
            //tmp_TitleGroup.Add(tmp_DownloadButton);

            tmp_CellBackground.Add(tmp_DetailGroup);
            tmp_DetailGroup.Add(tmp_TitleGroup);
            tmp_DetailGroup.Add(tmp_DetailLabel);

            tmp_DownloadButton.AddToClassList("download-template-button");
            tmp_TemplateTypeLabel.AddToClassList("template-type-label");
            tmp_TitleGroup.AddToClassList("title-group");
            tmp_CellIcon.AddToClassList("cell-icon");
            tmp_CellBackground.AddToClassList("cell-background");
            tmp_DetailGroup.AddToClassList("cell-detailgroup");
            tmp_CellTitleLabel.AddToClassList("cell-detail-title");
            tmp_DetailLabel.AddToClassList("cell-detail-content");
            return tmp_CellBackground;
        }

        private void TestRequestTemplateData()
        {
            UnityWebRequest tmp_Request = UnityWebRequest.Get(CONST_TEMPLATE_DATA_URL);
            tmp_Request.SendWebRequest().completed += _operation => { Debug.Log(tmp_Request.downloadHandler.text); };
        }
    }
}