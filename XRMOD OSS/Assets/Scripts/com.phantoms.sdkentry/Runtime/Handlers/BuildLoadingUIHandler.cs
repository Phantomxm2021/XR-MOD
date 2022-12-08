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
using NativePlugins.Plugin;
using UnityEngine;

namespace SDKEntry.Runtime
{
    public class BuildLoadingUIHandler : AbstractHandler
    {
        public override void Handle()
        {
            NativeAPI.AddLoadingOverlay();
            base.Handle();
        }
    }


    public static class HandlerExtension
    {
        public static async Task<string> GetEmptyResult(this AbstractHandler _abstractHandler)
        {
            await Task.Yield();
            return string.Empty;
        }
    }
}