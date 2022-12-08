using Unity.VisualScripting;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(GetLocalNetworkConnectionUnit))]
    public class GetLocalNetworkConnectionUnitDescriptor:ARMODBaseWithResultUnitDescriptor
    {
        public GetLocalNetworkConnectionUnitDescriptor(ARMODBaseWithResultUnit _target) : base(_target)
        {
        }
        
        protected override string DefaultSummary()
        {
            return "Get Information about the player connecting to the server.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/link.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/link.png"));
        }


        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);
            switch (_port.key)
            {
                case "NetworkConnection":
                    _description.summary = "Information about the player connecting to the server.";
                    break;
            }
        }
    }
}