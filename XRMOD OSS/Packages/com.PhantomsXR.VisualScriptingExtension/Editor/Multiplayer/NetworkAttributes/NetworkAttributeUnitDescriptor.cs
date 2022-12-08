using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;

using UnityEditor;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(ClientRPCRemoteActionsUnit)),
     Descriptor(typeof(BaseServerAttributeUnit<int>)),
     Descriptor(typeof(BaseServerAttributeUnit<float>)),
     Descriptor(typeof(BaseServerAttributeUnit<Vector3>)),
     Descriptor(typeof(BaseServerAttributeUnit<Quaternion>)),
     Descriptor(typeof(BaseServerAttributeUnit<GameObject>)),
     Descriptor(typeof(BaseServerAttributeUnit<bool>)),
     Descriptor(typeof(BaseServerAttributeUnit<TransformData>)),
     Descriptor(typeof(ServerAttributeUnit)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<int>)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<float>)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<Vector3>)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<Quaternion>)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<GameObject>)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<bool>)),
     Descriptor(typeof(BaseServerCallbackAttributeUnit<TransformData>)),
     Descriptor(typeof(ServerCallbackAttributeUnit)),
     Descriptor(typeof(BaseClientAttributeUnit<int>)),
     Descriptor(typeof(BaseClientAttributeUnit<float>)),
     Descriptor(typeof(BaseClientAttributeUnit<Vector3>)),
     Descriptor(typeof(BaseClientAttributeUnit<Quaternion>)),
     Descriptor(typeof(BaseClientAttributeUnit<GameObject>)),
     Descriptor(typeof(BaseClientAttributeUnit<bool>)),
     Descriptor(typeof(BaseClientAttributeUnit<TransformData>)),
     Descriptor(typeof(ClientAttributeUnit)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<int>)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<float>)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<Vector3>)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<Quaternion>)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<GameObject>)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<bool>)),
     Descriptor(typeof(BaseClientCallbackAttributeUnit<TransformData>)),
     Descriptor(typeof(ClientCallbackAttributeUnit)),]
    public class NetworkAttributeUnitDescriptor : ARMODBaseUnitDescriptor
    {
        public NetworkAttributeUnitDescriptor(ARMODBaseUnit _target) : base(_target)
        {
        }


        // protected override EditorTexture DefaultIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/getting_started_wizard.png"));
        // }
        //
        // protected override EditorTexture DefinedIcon()
        // {
        //     return EditorTexture.Single(
        //         AssetDatabase.LoadAssetAtPath<Texture>(
        //             "Packages/com.phantomsxr.visualscriptingextension/Editor/Icons/getting_started_wizard.png"));
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