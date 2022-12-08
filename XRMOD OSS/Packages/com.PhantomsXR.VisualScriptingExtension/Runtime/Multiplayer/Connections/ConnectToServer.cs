using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Connections"), UnitTitle("ConnectToServer")]
    public class ConnectToServer : ARMODBaseUnit
    {

        [DoNotSerialize] public ValueInput IPAddress;
        [DoNotSerialize] public ValueInput Port;
        protected override void Definition()
        {
            base.Definition();
            IPAddress = ValueInput<string>(nameof(IPAddress), "localhost");
            Port = ValueInput(nameof(Port), "7777");
        }//                    ARMODServerBridge.GetBridge().ConnectToServerByDiscovery();


        public override ControlOutput Execute(Flow _arg)
        {
            var tmp_IP = _arg.GetValue<string>(IPAddress);
            var tmp_Port = _arg.GetValue<string>(Port);
            XRMODServices.GetBridge().ConnectToServer(tmp_IP, tmp_Port);
            return outputTrigger;
        }
    }
}