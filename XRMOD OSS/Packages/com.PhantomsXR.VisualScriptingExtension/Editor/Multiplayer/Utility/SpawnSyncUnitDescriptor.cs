using Unity.VisualScripting;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(SpawnSyncUnit))]
    public class SpawnSyncUnitDescriptor : ARMODBaseUnitDescriptor
    {
        protected override string DefinedSummary()
        {
            return "Synchronize to other clients when game object is instanced.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/spawnsync.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/spawnsync.png"));
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "GameObject":
                    _description.summary = "Need to synchronize game object. ";
                    break;
            }
        }

        public SpawnSyncUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }
    }
}