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
    public class ExitEditingProjectCommand : BaseGenericMenuItemCommand
    {

        public ExitEditingProjectCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
        }

        public override void Execute()
        {
            var tmp_ProjectCacheData = allProjectsCache.Find(GenericMenuItemCommandData.SelectedId);
            tmp_ProjectCacheData.EntryEditing(true);
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ExitEditingProjectCommand), null);

        }
    }
}