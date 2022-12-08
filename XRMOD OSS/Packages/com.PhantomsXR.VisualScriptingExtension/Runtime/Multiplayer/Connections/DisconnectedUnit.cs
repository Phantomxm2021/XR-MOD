using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Connections"), UnitTitle("Disconnected")]
    public class DisconnectedUnit : ARMODBaseUnit
    {
        public override ControlOutput Execute(Flow _arg)
        {
            XRMODServices.GetBridge().Disconnected();
            return outputTrigger;
        }
    }
}