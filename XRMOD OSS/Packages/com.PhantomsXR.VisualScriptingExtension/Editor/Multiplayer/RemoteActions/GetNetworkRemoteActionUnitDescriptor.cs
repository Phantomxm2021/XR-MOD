using Unity.VisualScripting;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(GetNetworkRemoteActionUnit))]
    public class GetNetworkRemoteActionUnitDescriptor : ARMODBaseWithResultUnitDescriptor
    {
        public GetNetworkRemoteActionUnitDescriptor(GetNetworkRemoteActionUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Get the MultiplayerRemoteAction from the target object.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/script_bricks.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/script_bricks.png"));
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "Target":
                    _description.summary = "Which game object has the MultiplayerRemoteAction component.";
                    break;
                case "Result":
                    _description.summary = "The MultiplayerRemoteAction component.";
                    break;
            }
        }
    }
}