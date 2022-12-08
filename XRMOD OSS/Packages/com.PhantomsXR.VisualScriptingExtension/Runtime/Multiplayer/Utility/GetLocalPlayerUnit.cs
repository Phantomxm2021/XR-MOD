using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;
using com.PhantomsXR.VisualScriptingExtension.Runtime;
using UnityEngine;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Utility"), UnitTitle("Get LocalPlayer"), UnitShortTitle("Get LocalPlayer")]
    public class GetLocalPlayerUnit : ARMODBaseWithResultUnit
    {
        private GameObject localPlayer;

        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput(nameof(Result), _flow => localPlayer);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            localPlayer = XRMODServices.GetBridge().GetLocalPlayer();
            return outputTrigger;
        }
    }
}