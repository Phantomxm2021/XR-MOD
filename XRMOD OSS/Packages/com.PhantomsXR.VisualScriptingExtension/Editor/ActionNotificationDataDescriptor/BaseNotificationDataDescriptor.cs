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

using Unity.VisualScripting;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(VSBaseData))]
    // ReSharper disable once IdentifierTypo
    public class BaseNotificationDataDescriptor : UnitDescriptor<VSBaseData>
    {
        // ReSharper disable once IdentifierTypo
        public BaseNotificationDataDescriptor(VSBaseData _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "The base notification data.";
        }

        protected override EditorTexture DefaultIcon()
        {
           
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/database_green.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/database_green.png"));
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "ActionName":
                    _description.summary = "The name of the currently triggered action.";
                    break;
                case "BaseData":
                    _description.summary = "Base string data.";
                    break;
                case "EventTarget":
                    _description.summary = "Where is the event responder(Custom Event Node in bolt) in the graph.";
                    break;
                case "EventName":
                    _description.summary = "Event name.";
                    break;
                case "EventNamewithresult":
                    _description.summary = "Event responder(Custom Event Node in bolt) name.";
                    break;
                case "Result":
                    _description.summary = "Event responder(Custom Event Node in bolt) name.";
                    break;
            }
        }
    }
}