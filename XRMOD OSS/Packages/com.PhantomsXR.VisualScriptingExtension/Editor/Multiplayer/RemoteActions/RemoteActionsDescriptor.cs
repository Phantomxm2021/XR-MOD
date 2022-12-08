using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime.Editor;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Editor
{
    [Descriptor(typeof(BaseCommandRemoteActionUnit<int>)),
     Descriptor(typeof(BaseCommandRemoteActionUnit<float>)),
     Descriptor(typeof(BaseCommandRemoteActionUnit<bool>)),
     Descriptor(typeof(BaseCommandRemoteActionUnit<Vector3>)),
     Descriptor(typeof(BaseCommandRemoteActionUnit<Quaternion>)),
     Descriptor(typeof(BaseCommandRemoteActionUnit<GameObject>)),
     Descriptor(typeof(BaseCommandRemoteActionUnit<TransformData>)),
     Descriptor(typeof(CommandRemoteActionsUnit)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<int>)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<float>)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<Vector3>)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<Quaternion>)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<GameObject>)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<bool>)),
     Descriptor(typeof(BaseTargetRpcRemoteActionUnit<TransformData>)),
     Descriptor(typeof(TargetRpcRemoteActionsUnit)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<int>)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<float>)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<Vector3>)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<Quaternion>)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<GameObject>)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<bool>)),
     Descriptor(typeof(BaseClientRPCRemoteActionUnit<TransformData>))]
    public class RemoteActionsDescriptor : ARMODBaseUnitDescriptor
    {
        public RemoteActionsDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }


        // protected override EditorTexture DefaultIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/action.png"));
        // }
        //
        // protected override EditorTexture DefinedIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/action.png"));
        // }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "NetworkAttribute":
                    _description.summary = "The network system has ways to perform actions across the network. " +
                                           "These type of actions are sometimes called Remote Procedure Calls.";
                    break;
                case "EventTarget":
                    _description.summary =
                        "Where is the [Client Attribute] event responder(Custom Event Node in bolt) in the graph.";
                    break;
                case "Parameters":
                    _description.summary =
                        "The parameters that need to be transmitted, only basic parameters are allowed";
                    break;
            }
        }
    }
}
