using Unity.VisualScripting;
using com.PhantomsXR.VisualScriptingExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    //[Descriptor(typeof(RemoteActionsEventReceiverUnit))]
    public class RemoteActionsEventReceiverUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public RemoteActionsEventReceiverUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }

        protected override string DefinedSummary()
        {
            return "Receive the RPC event.";
        }

        protected override EditorTexture DefaultIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/transmit_blue.png"));
        }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(
                AssetDatabase.LoadAssetAtPath<Texture>(
                    "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/transmit_blue.png"));
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "RemoteAction":
                    _description.summary = "The network system has ways to perform actions across the network. " +
                                           "These type of actions are sometimes called Remote Procedure Calls.";
                    break;
                case "EventTarget":
                    _description.summary =
                        "Where is the [Network Status] event responder(Custom Event Node in bolt) in the graph.";
                    break;
            }
        }
    }
}