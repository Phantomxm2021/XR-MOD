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
using System.Text;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class CreateProjectCommand : BaseGenericMenuItemCommand
    {
        private const string CONST_SCRIPTS_NAME = "Scripts";
        private const string CONST_ARTWORK_NAME = "Artwork";
        private const string CONST_EDITOR_NAME = "Editor";
        private const string CONST_RUNTIME_NAME = "Runtime";
        private const string CONST_MAIN_ENTRY_NAME = "MainEntry";
        private const string CONST_PACKAGE_NAME = "Packages";
        private const string CONST_SCRIPT_TEMPLATE_NAME = "EntryTemplate.txt";
        private const string CONST_NAME_SPACE_NAME = "#NAMESPACE#";
        private const string CONST_SCRIP_NAME = "#SCRIPTNAME#";
        private const string CONST_ASMDEF_NAME = "asmdef";
        private const string CONST_CACHE_FOLDER_NAME = "Cache";
        private const string CONST_TEMPLATES_PATH = "Packages/com.phantomsxr.armodpackagetools/Editor/Templates";
        private const string CONST_TEMPLATE_TEMP_PATH = "Editor Default Resources/ARMOD PackageTools Cache";
        private const string CONST_TEMPLATE_FOLDER_NAME = "Templates";
        private const string CONST_DESTINATION_PATH = "DestinationPath";
        private const string CONST_PROJECT_CACHE_DATA = "Cache/ProjectCacheData.asset";
        private const string CONST_TEMPLATE_CACHE = "TempCache";
        private const string CONST_UNITY_SUFIXX = "unitypackage";
        private const string CONST_REGISTER_IMPORT_EVENT_NAME = "canRegisterImportListener";

        public CreateProjectCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
        }

        public override void Execute()
        {
            switch (GenericMenuItemCommandData.MenuType)
            {
                case MenuType.CreateProjectFromTemplate:
                    CreateProjectFromTemplate();
                    break;
                case MenuType.CreateProjectWithBlank:
                    CreateBlankProject();
                    break;
            }
        }

        #region Create Blank project

        private void CreateBlankProject()
        {
            var tmp_ProjectPath = GenericMenuItemCommandData.DestinationPath;
            string tmp_ProjectName = new DirectoryInfo(tmp_ProjectPath).Name;

            CreateProjectStructure(tmp_ProjectPath, out var tmp_AutoRuntimeFolderPath,
                out var tmp_AutoEditorFolderPath);

            CreateProjectScripts(tmp_ProjectName, tmp_AutoRuntimeFolderPath, tmp_AutoEditorFolderPath);

            CreateProjectCache(tmp_ProjectPath, tmp_ProjectName);

            //Close all editing projects
            allProjectsCache.ExitEditingForAll();

            //Tell <ProjectTreeRenderer.WaitToCompiling> is creating new AR experience project now
            EditorPrefs.SetBool(ConstKey.CONST_CREATE_NEW_AR_EXPERIENCE, true);
        }

        private void CreateProjectCache(string _projectPath, string _projectName)
        {
            var tmp_ShortenPath = Utility.ShortenPath(_projectPath);

            //Create project cache data asset to the path
            var tmp_ProjectCacheData = ScriptableObject.CreateInstance<ProjectCacheData>();
            var tmp_ProjectCacheSavePath = Path.Combine(tmp_ShortenPath,
                $"{CONST_CACHE_FOLDER_NAME}/{nameof(ProjectCacheData)}.asset");
            AssetDatabase.CreateAsset(tmp_ProjectCacheData, tmp_ProjectCacheSavePath);
            AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(tmp_ProjectCacheData));

            //Add build setting asset to current project cache asset
            var tmp_BuildSettingData = ScriptableObject.CreateInstance<BuildSettingData>();
            tmp_BuildSettingData.name = nameof(BuildSettingData);
            AssetDatabase.AddObjectToAsset(tmp_BuildSettingData, tmp_ProjectCacheData);
            AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(tmp_BuildSettingData));

            var tmp_ProjectConfigures = ScriptableObject.CreateInstance<Configures>();
            tmp_ProjectConfigures.name = nameof(Configures);
            AssetDatabase.AddObjectToAsset(tmp_ProjectConfigures, tmp_ProjectCacheData);
            AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(tmp_ProjectConfigures));


            //Reference new project cache data and new project detail
            var tmp_NewProjectCacheData = new ProjectModel
            {
                Id = allProjectsCache.GetTotalOfProjects,
                DisplayName = _projectName,
                ProjectStatus = ProjectModel.ProjectStatusEnum.Close
            };

            var tmp_NewProjectDetail = new ProjectDetailCacheData
            {
                //Match to our project model id
                Id = tmp_NewProjectCacheData.Id,
                SubPath = tmp_ShortenPath,
                //Linking the build setting and configure files
                BuildSettingData = tmp_BuildSettingData,
                Configures = tmp_ProjectConfigures
            };


            tmp_ProjectCacheData.Project = tmp_NewProjectCacheData;
            tmp_ProjectCacheData.DetailCacheData = tmp_NewProjectDetail;

            // Deprecated
            // var tmp_ConfigCache = JsonUtility.ToJson(GetTreeModel.Find(tmp_Id));
            // File.WriteAllText(Path.Combine(tmp_AutoEditorFolderPath, "ConfigCacheJson.json"), tmp_ConfigCache,
            //     Encoding.UTF8);

            //Hosting new project cache
            allProjectsCache.AddNewProject(ref tmp_ProjectCacheData);

            //Force save and refresh unity assets
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }


        private void CreateProjectScripts(string _projectName, string _runtimeFolderPath,
            string _editorFolderPath)
        {
            //Create runtime assembly defined
            GenerationASMDEF(_projectName, CONST_RUNTIME_NAME, _runtimeFolderPath, new List<string>(),
                new List<string>
                {
                    ConstKey.ARMOD_API,
                    ConstKey.PACKAGE_TOOLS,
                    ConstKey.ACTION_NOTIFICATION,
                    ConstKey.CONST_MIRROR,
                    ConstKey.CONST_MIRROR_EXTENSION
                });


            //Create editor assembly defined
            GenerationASMDEF(_projectName, CONST_EDITOR_NAME, _editorFolderPath, new List<string>
            {
                CONST_EDITOR_NAME
            }, new List<string>
            {
                $"{_projectName}.{CONST_RUNTIME_NAME}"
            });

            GenerationMainEntryScript(_runtimeFolderPath, _projectName,
                $"{_projectName}{CONST_MAIN_ENTRY_NAME}");
        }

        private void CreateProjectStructure(string _projectPath, out string _runtimeFolderPath,
            out string _editorFolderPath)
        {
            //Create folder to hold the all scripts
            string tmp_AutoScriptFolderPath = Path.Combine(_projectPath, CONST_SCRIPTS_NAME);
            Directory.CreateDirectory(tmp_AutoScriptFolderPath);

            string tmp_AutoArtworkFolderPath = Path.Combine(_projectPath, CONST_ARTWORK_NAME);
            Directory.CreateDirectory(tmp_AutoArtworkFolderPath);

            _editorFolderPath =
                Path.Combine(Path.Combine(_projectPath, CONST_SCRIPTS_NAME), CONST_EDITOR_NAME);
            Directory.CreateDirectory(_editorFolderPath);

            _runtimeFolderPath = Path.Combine(Path.Combine(_projectPath, CONST_SCRIPTS_NAME), CONST_RUNTIME_NAME);
            Directory.CreateDirectory(_runtimeFolderPath);

            var tmp_CacheFolderPath = Path.Combine(_projectPath, CONST_CACHE_FOLDER_NAME);
            Directory.CreateDirectory(tmp_CacheFolderPath);

            //Avoid not folder found
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }


        /// <summary>
        /// Create C# script from template
        /// </summary>
        /// <param name="_destFilePath">save path</param>
        /// <param name="_namespace">Script's namespace</param>
        /// <param name="_scriptName">Script name(file name and class name)</param>
        private void GenerationMainEntryScript(string _destFilePath, string _namespace,
            string _scriptName)
        {
            var tmp_BaseDir = $"{CONST_PACKAGE_NAME}/{ConstKey.PACKAGE_NAME}/{CONST_EDITOR_NAME}/";

            var tmp_EntryScriptPath = Path.GetFullPath($"{tmp_BaseDir}/{CONST_SCRIPT_TEMPLATE_NAME}");
            var tmp_EntryScriptText = File.ReadAllText(tmp_EntryScriptPath);
            tmp_EntryScriptText = tmp_EntryScriptText.Replace(CONST_NAME_SPACE_NAME, _namespace);
            tmp_EntryScriptText = tmp_EntryScriptText.Replace(CONST_SCRIP_NAME, _scriptName);
            File.WriteAllText(Path.Combine(_destFilePath, _scriptName + ".cs"), tmp_EntryScriptText, Encoding.UTF8);
        }


        /// <summary>
        /// Create the script assemble
        /// </summary>
        /// <param name="_fileName"></param>
        /// <param name="_suffix"></param>
        /// <param name="_path"></param>
        /// <param name="_includePlatforms"></param>
        /// <param name="_references"></param>
        private void GenerationASMDEF(string _fileName, string _suffix, string _path, List<string> _includePlatforms,
            List<string> _references)
        {
            var tmp_FileName = !string.IsNullOrEmpty(_suffix) ? $"{_fileName}.{_suffix}" : _fileName;

            //Create assembly defined
            var tmp_RuntimeAssemblyDefined = new AssemblyDataModel
            {
                name = tmp_FileName,
                autoReferenced = true,
                allowUnsafeCode=true,
                includePlatforms = _includePlatforms,
                references = _references,
                rootNamespace = tmp_FileName
            };

            string tmp_RuntimeAssemblyDefinedJson = JsonUtility.ToJson(tmp_RuntimeAssemblyDefined);
            File.WriteAllText(Path.Combine(_path, $"{tmp_FileName}.{CONST_ASMDEF_NAME}"),
                tmp_RuntimeAssemblyDefinedJson);
        }

        #endregion

        #region Create project from temlpate

        [InitializeOnLoadMethod]
        private static void RegisterImportPackageCompletedListener()
        {
            AssetDatabase.importPackageCompleted += ImportPackageCompletedCallback;
        }

        private void CreateProjectFromTemplate()
        {
            //A small tips. Because package contains scripts, when we import them Unity Editor must to compile them first.
            //So all assemblies will be reload and the all callback events will removed. It broken our process.
            //We store the new project destination path to disk for next process
            EditorPrefs.SetString(CONST_DESTINATION_PATH, GenericMenuItemCommandData.DestinationPath);
            var tmp_SourceDir =
                Path.Combine(CONST_TEMPLATES_PATH,
                    $"{GenericMenuItemCommandData.GenericParameter}.{CONST_UNITY_SUFIXX}");
            AssetDatabase.ImportPackage(tmp_SourceDir, false);
        }

        private static void ImportPackageCompletedCallback(string _templateName)
        {
            if (!EditorPrefs.GetBool(CONST_REGISTER_IMPORT_EVENT_NAME)) return;
            //Fix path on windows platform
#if UNITY_EDITOR_WIN
            _templateName = _templateName.Replace($"{CONST_TEMPLATE_FOLDER_NAME}\\", "");
#endif
            EditorApplication.delayCall += () =>
            {
                try
                {
                    var tmp_TemplateFolderPath = Path.Combine(Application.dataPath, _templateName);
                    var tmp_TemplateDirectory = new DirectoryInfo(tmp_TemplateFolderPath);

                    //Move to project-cache folder
                    var tmp_CachePathRoot = Path.Combine(Application.dataPath, CONST_TEMPLATE_TEMP_PATH,
                        CONST_TEMPLATE_FOLDER_NAME);
                    var tmp_TemplateCachePath = Path.Combine(tmp_CachePathRoot, _templateName);
                    if (!Directory.Exists(tmp_CachePathRoot))
                    {
                        Directory.CreateDirectory(tmp_CachePathRoot);
                        AssetDatabase.Refresh();
                    }

                    if (!Directory.Exists(tmp_TemplateCachePath))
                    {
                        tmp_TemplateDirectory.MoveTo(tmp_TemplateCachePath);
                        AssetDatabase.Refresh();
                    }

                    //Delete the UnityPackage folder
                    var tmp_ImportPackageTMPFolder = $"Assets/{_templateName}";
                    if (AssetDatabase.IsValidFolder(tmp_ImportPackageTMPFolder))
                    {
                        AssetDatabase.DeleteAsset(tmp_ImportPackageTMPFolder);
                        AssetDatabase.Refresh();
                    }


                    //Copy to temp-cache folder.
                    //It should be noted here that we need to copy it outside the Unity project, otherwise the association cannot be recreated.
                    var tmp_UnityProjectRootPath = Application.dataPath.Replace("Assets", "");
                    var tmp_OutsideTempFolderPath =
                        Path.Combine(tmp_UnityProjectRootPath, $"{CONST_TEMPLATE_CACHE}/{_templateName}");
                    if (!Directory.Exists(tmp_OutsideTempFolderPath))
                    {
                        Directory.CreateDirectory(tmp_OutsideTempFolderPath);
                        AssetDatabase.Refresh();
                    }

                    CopyTemplate(tmp_TemplateCachePath, tmp_OutsideTempFolderPath, true);

                    //Regenerate Guid for our assets
                    UtilGuids.RegenerateGuids(tmp_TemplateCachePath);

                    //Read the new project destination path from disk
                    var tmp_NewProjectPath = EditorPrefs.GetString(CONST_DESTINATION_PATH);

                    //Create a new folder for our new project assets
                    if (!Directory.Exists(tmp_NewProjectPath))
                    {
                        Directory.CreateDirectory(tmp_NewProjectPath);
                        AssetDatabase.Refresh();
                    }

                    CopyTemplate(tmp_TemplateCachePath, tmp_NewProjectPath, true);
                    AssetDatabase.DeleteAsset(Utility.ShortenPath(tmp_TemplateCachePath));
                    AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

                    // Re-import the cache outside the project into Unity
                    // CopyTemplate(tmp_OutsideTempFolderPath, tmp_TemplateCachePath, true);


                    //Redirection our asset path and configure
                    var tmp_CacheDataFullPath = Path.Combine(tmp_NewProjectPath, CONST_PROJECT_CACHE_DATA);
                    var tmp_CacheDataInProjectPath = Utility.ShortenPath(tmp_CacheDataFullPath);

                    var tmp_ProjectCacheData =
                        AssetDatabase.LoadAssetAtPath<ProjectCacheData>(tmp_CacheDataInProjectPath);
                    if (!tmp_ProjectCacheData) return;
                    var tmp_NewProjectName = new DirectoryInfo(tmp_NewProjectPath).Name;

                    ProjectModel tmp_NewProjectModel = new ProjectModel
                    {
                        DisplayName = tmp_NewProjectName,
                        Id = PackageToolsEditor.ALL_PROJECT_CACHE.GetTotalOfProjects,
                    };
                    tmp_ProjectCacheData.Project = tmp_NewProjectModel;
                    tmp_ProjectCacheData.DetailCacheData.SubPath = Utility.ShortenPath(tmp_NewProjectPath);
                    tmp_ProjectCacheData.DetailCacheData.ChangeAssetsPath(_templateName);

                    //Apply scripts to our new project
                    ModifiedScript(tmp_NewProjectPath, _templateName);

                    //Add this project to our project-list
                    GenericMenuItemCommandData tmp_Data = new GenericMenuItemCommandData()
                    {
                        CommandId = nameof(OpenProjectCommand),
                        AllProjectsCache = PackageToolsEditor.ALL_PROJECT_CACHE,
                        SelectedId = -1,
                        DestinationPath = tmp_NewProjectPath
                    };
                    CommandFactory.CreateAndExecuteCommand(tmp_Data);


                    //Delete the temp-cache folder
                    if (Directory.Exists(tmp_OutsideTempFolderPath))
                        Directory.Delete(tmp_OutsideTempFolderPath, true);

                    AssetDatabase.importPackageCompleted -= ImportPackageCompletedCallback;
                    AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
                    EditorPrefs.DeleteKey(CONST_REGISTER_IMPORT_EVENT_NAME);
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception);
                }
            };
        }


        /// <summary>
        /// Copy entire project assets and scripts to other path
        /// </summary>
        /// <param name="_sourceDirectory"></param>
        /// <param name="_destDirName"></param>
        /// <param name="_copySubDirs"></param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        private static void CopyTemplate(string _sourceDirectory, string _destDirName, bool _copySubDirs)
        {
            DirectoryInfo tmp_SourceDir = new DirectoryInfo(_sourceDirectory);
            if (!tmp_SourceDir.Exists)
            {
                throw new DirectoryNotFoundException(
                    $"Source directory does not exist or could not be found:{CONST_TEMPLATES_PATH}");
            }

            DirectoryInfo[] tmp_Directories = tmp_SourceDir.GetDirectories();
            FileInfo[] tmp_FileInfos = tmp_SourceDir.GetFiles();
            foreach (FileInfo tmp_FileInfo in tmp_FileInfos)
            {
                //Ignore meta files
                //if (tmp_FileInfo.Name.EndsWith("meta")) continue;
                string tmp_Path = Path.Combine(_destDirName, tmp_FileInfo.Name);
                try
                {
                    tmp_FileInfo.CopyTo(tmp_Path, true);
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception.ToString());
                }
            }

            if (!_copySubDirs) return;

            foreach (DirectoryInfo tmp_SubDir in tmp_Directories)
            {
                var tmp_Path = Path.Combine(_destDirName, tmp_SubDir.FullName.Substring(_sourceDirectory.Length + 1));

                if (!Directory.Exists(tmp_Path))
                    Directory.CreateDirectory(tmp_Path);


                //Recursion
                CopyTemplate(tmp_SubDir.FullName, tmp_Path, true);
            }
        }

        private static void ModifiedScript(string _newProjectPath, string _templateName)
        {
            var tmp_BaseScriptFolder = Path.Combine(_newProjectPath, "Scripts");
            var tmp_EditorFolder = Path.Combine(tmp_BaseScriptFolder, "Editor");
            var tmp_RuntimeFolder = Path.Combine(tmp_BaseScriptFolder, "Runtime");

            //Create editor asmdef file from template
            var tmp_EditorFiles = new DirectoryInfo(tmp_EditorFolder).GetFiles();
            foreach (var tmp_FileInfo in tmp_EditorFiles)
            {
                if (tmp_FileInfo.Name.Contains("meta")) continue;
                CopyScriptsFromTemplate(tmp_FileInfo.FullName, _newProjectPath, _templateName);
            }

            //Create runtime scripts and asmdef file from template
            var tmp_RuntimeFiles = new DirectoryInfo(tmp_RuntimeFolder).GetFiles();
            foreach (var tmp_FileInfo in tmp_RuntimeFiles)
            {
                if (tmp_FileInfo.Name.Contains("meta")) continue;
                CopyScriptsFromTemplate(tmp_FileInfo.FullName, _newProjectPath, _templateName);
            }
        }


        private static void CopyScriptsFromTemplate(string _sourceFile, string _newProjectPath, string _templateName)
        {
            var tmp_NewProjectName = new DirectoryInfo(_newProjectPath).Name;

            //Rename
            var tmp_NewPath = _sourceFile.Replace(_templateName, tmp_NewProjectName);

            //Replace template name to specific project name
            var tmp_AllTxt = File.ReadAllText(_sourceFile);
            tmp_AllTxt = tmp_AllTxt.Replace(_templateName, tmp_NewProjectName);
            File.Delete(_sourceFile);

            //Save change
            File.WriteAllText(tmp_NewPath.Replace(".txt", ""), tmp_AllTxt);
            AssetDatabase.Refresh();
        }

        #endregion
    }
}