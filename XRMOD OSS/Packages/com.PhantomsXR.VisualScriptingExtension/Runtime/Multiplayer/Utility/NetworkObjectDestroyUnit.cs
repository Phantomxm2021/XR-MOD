using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("NetworkObject Destroy"),
     UnitShortTitle("NetworkObject Destroy")]
    public class NetworkObjectDestroyUnit : ARMODBaseWithResultUnit
    {
        [DoNotSerialize] [NullMeansSelf] [PortLabelHidden]
        public ValueInput NetworkGameObject;

        

        protected override void Definition()
        {
            base.Definition();
            NetworkGameObject = ValueInput(nameof(NetworkGameObject), (GameObject) null).NullMeansSelf();
        }

        public override ControlOutput Execute(Flow _arg)
        {
            Assert.IsNotNull(NetworkGameObject);
            var tmp_NetworkGameObject = _arg.GetValue<GameObject>(NetworkGameObject);
            XRMODServices.GetBridge().NetworkObjectDestroy(tmp_NetworkGameObject);
            return outputTrigger;
        }
    }
}