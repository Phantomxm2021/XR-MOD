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
using SDKEntry.Runtime.Mapper;

namespace SDKEntry.Runtime.DataRequest
{
    public interface IHttpRequestCommand
    {
        Task<string> Executed();
    }

    public interface IHttpRequestCommand<T>
    {
        Task<T> Execute();
    }
}