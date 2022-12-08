using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(GetNetworkPrefabUnit))]
    public class GetNetworkPrefabUnitDescriptor : ARMODBaseWithResultUnitDescriptor
    {
        public GetNetworkPrefabUnitDescriptor(ARMODBaseWithResultUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Get the network prefab from registration list.";
        }

        // protected override EditorTexture DefaultIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/aol_messenger.png"));
        // }
        //
        // protected override EditorTexture DefinedIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/aol_messenger.png"));
        // }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "PrefabName":
                    _description.summary = "Name with prefab in the registration list.";
                    break;
                
                case "networkPrefab":
                    _description.summary = "The network prefab.";
                    break;
            }
        }
    }
}