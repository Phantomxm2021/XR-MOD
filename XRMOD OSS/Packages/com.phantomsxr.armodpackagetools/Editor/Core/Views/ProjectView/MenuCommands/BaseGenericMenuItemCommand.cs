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

namespace com.Phantoms.ARMODPackageTools.Core
{
    public abstract class BaseGenericMenuItemCommand
    {
        protected AllProjectsCache allProjectsCache;
        protected readonly GenericMenuItemCommandData GenericMenuItemCommandData;

        public BaseGenericMenuItemCommand(GenericMenuItemCommandData _commandData )
        {
            GenericMenuItemCommandData = _commandData;
            allProjectsCache = _commandData.AllProjectsCache;
        }

        public abstract void Execute();
    }
}