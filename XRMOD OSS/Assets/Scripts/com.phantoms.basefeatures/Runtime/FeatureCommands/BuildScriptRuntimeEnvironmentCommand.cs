// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ILRuntime.Runtime;
using com.phantoms.models.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace com.phantoms.BaseFeatures.Runtime
{
    public class BuildScriptRuntimeEnvironmentCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        public async void Execute()
        {
            base.Initializer();
            switch (RuntimeProjectConfig.CurrentConfigures.Value.ProgrammableType)
            {
                case ProgrammableType.CSharp:
                    if ((!string.IsNullOrEmpty(RuntimeProjectConfig.CurrentConfigures.Value.MainEntry)
                         || !string.IsNullOrEmpty(RuntimeProjectConfig.CurrentConfigures.Value.DomainName)))
                    {
                        //CodesHook.WarmNotificationCode();
                        BaseContextDataModel.CodeHook.Value ??= new CodesHook
                            {debug = RuntimeProjectConfig.CurrentConfigures.Value.DebugModel};

                        var tmp_ProjectName = Config.ProjectName;
                        BaseContextDataModel.CodeHook.Value?.InitializeHook(tmp_ProjectName, Config.DomainName,
                            Config.MainEntry,
                            (int) Config.JitFlag);
                        ActionNotificationCenter.DefaultCenter.AddObserver(BaseContextDataModel.CodeHook.Value.OnEvent,
                            nameof(ActionParameterDataType.OnEvent));

                        if (Config.Multiplayer)
                        {
                            ActionNotificationCenter.DefaultCenter.AddObserver(
                                BaseContextDataModel.CodeHook.Value.OnMultiplayerEvent,
                                nameof(ActionParameterDataType.OnMultiplayerEvent));
                        }
                    }

                    break;
                case ProgrammableType.VisualScripting:

                    var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                        nameof(ActionParameterDataType.TryAcquireLoadObject), new LoadObjectNotificationData()
                        {
                            LoadObjectType = typeof(GameObject),
                            LoadObjectName = new List<string>() {Config.MainVisualScripting}
                        });
                    if (tmp_Result != null || tmp_Result.Count > 0)
                    {
                        if (tmp_Result[0] is Task<List<Object>> tmp_TempTask)
                        {
                            var tmp_Results = await tmp_TempTask;
                            if (tmp_Results[0] is GameObject tmp_GameObject)
                            {
                                BaseContextDataModel.VisualScriptingGo = Object.Instantiate(tmp_GameObject);
                            }
                        }
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Release()
        {
            BaseContextDataModel.CodeHook.Value.Dispose();
            BaseContextDataModel.CodeHook.Value = null;
        }
    }
}