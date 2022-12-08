// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using SDKEntry.Runtime.DataRequest;
using UnityEngine;
using UnityEngine.Assertions;
using XRMODEngineCore.Runtime;

namespace SDKEntry.Runtime
{
    public class BuildExceptionCollectorCommand : ICommand, IReleaseCommand
    {
        private Dictionary<string, string> body;

        private async void OnlogMessageReceivedThreaded(string _condition, string _stacktrace, LogType _type)
        {
            switch (_type)
            {
                case LogType.Assert:
                    break;
                case LogType.Warning:
                    break;
                case LogType.Log:
                    break;
                case LogType.Error:
                case LogType.Exception:
                    Assert.IsNotNull(body);
                    if (!String.IsNullOrEmpty(_condition) && !body.ContainsKey("condition"))
                        body.Add("condition", _condition);
                    if (!String.IsNullOrEmpty(_stacktrace) && !body.ContainsKey("stacktrace"))
                        body.Add("stacktrace", _stacktrace);
                    if (!body.ContainsKey("type"))
                        body.Add("type", _type.ToString());
                    await new ExceptionReporter(body).Execute();
                    Release();
                    Debug.LogError($"Bug Report:[{_type}]:{_condition}\n{_stacktrace}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_type), _type, null);
            }
        }

        public void Execute()
        {
            body = new Dictionary<string, string>();
            Application.logMessageReceivedThreaded += OnlogMessageReceivedThreaded;
        }

        public void Release()
        {
            Application.logMessageReceivedThreaded -= OnlogMessageReceivedThreaded;
            body.Clear();
            body = null;
        }
    }
}