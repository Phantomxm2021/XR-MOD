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

using com.Phantoms.ActionNotification.Runtime;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class EditingProjectCommand : BaseGenericMenuItemCommand
    {
        public EditingProjectCommand( GenericMenuItemCommandData _commandData) : base(_commandData)
        {
        }

        public override void Execute()
        {
            //Close all editing projects before editing the specified project
            allProjectsCache.ExitEditingForAll();
            var tmp_ProjectCacheData = allProjectsCache.Find(GenericMenuItemCommandData.SelectedId);
            tmp_ProjectCacheData.EntryEditing(false);
            var tmp_ProjectName = tmp_ProjectCacheData.Project.DisplayName;
            var tmp_ProjectConfigures = tmp_ProjectCacheData.DetailCacheData.Configures;
            tmp_ProjectConfigures.ProjectName = tmp_ProjectName;
            tmp_ProjectConfigures.DomainName = tmp_ProjectName;
            tmp_ProjectConfigures.MainEntry = $"{tmp_ProjectName}MainEntry";
            if (allProjectsCache.GetEditingProjectData())
                ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ExitEditingProjectCommand), null);
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(EditingProjectCommand), null);
        }
    }
}