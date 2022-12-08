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

using System.Threading.Tasks;

namespace SDKEntry.Runtime
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler nextHandler;
        
        public IHandler SetNext(IHandler _header)
        {
            nextHandler = _header;
            return nextHandler;
        }

        public IHandler GetNext()
        {
            return nextHandler;
        }

        public virtual void Handle()
        {
            nextHandler?.Handle();
        }
    }
}