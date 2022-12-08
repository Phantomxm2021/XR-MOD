using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ARMODToCloudSpaceUnit))]
    public class ARMODToCloudSpaceUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public ARMODToCloudSpaceUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Convert the position and rotation to cloud space.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/google_map.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/google_map.png"));
        }

        // ReSharper disable once ParameterHidesMember
        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "Position":
                    _description.summary = "Input position.";
                    break;
                case "Rotation":
                    _description.summary = "Input rotation.";
                    break;
                case "CloudSpaceRotation":
                    _description.summary = "Converted rotation.";
                    break;
                case "CloudSpacePosition":
                    _description.summary = "Converted Position.";
                    break;
            }
        }
    }
}