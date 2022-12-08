// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.PackageTools.Editor.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;

namespace com.Phantoms.ARMODPackageTools.Core.Views
{
    public class AutoReloadDomainProcess
    {
        [UnityEditor.Callbacks.DidReloadScripts]
        private static async void OnScriptsReloaded()
        {
            //Wait to refresh Unity Interface
            await Task.Delay(1000);

            if (!Utility.GetProjectScriptAssemblyFullName(out string tmp_Assembly)) return;
            if (!Utility.GetAutomaticGeneratedPath(out string tmp_Dest)) return;
            if (PackageToolsEditor.ALL_PROJECT_CACHE == null) return;
            if (PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData() == null) return;

            Utility.CopyFileToProject(tmp_Assembly, tmp_Dest, "bytes");
            Utility.CopyFileToProject(tmp_Assembly.Replace("dll", "pdb"), tmp_Dest, "bytes");

            if (!Utility.GetCustomPluginAssemblyFullName(out string tmp_PluginAssembly)) return;
            Utility.CopyFileToProject(tmp_PluginAssembly, tmp_Dest, "bytes");

        }
    }
}