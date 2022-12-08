using System;
using com.PhantomsXR.MirrorExtension.Runtime;
using Unity.VisualScripting;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    [UnitCategory("ARMOD/Multiplayer/Connections"), UnitTitle("Start Host Or Server Only")]
    public class StartHostOrServerOnlyUnit : ARMODBaseUnit
    {
        [DoNotSerialize] public ValueInput ServerType;

        protected override void Definition()
        {
            base.Definition();
            ServerType = ValueInput<ServerType>(nameof(ServerType), Runtime.ServerType.Host);
        }

        public override ControlOutput Execute(Flow _arg)
        {
            switch (_arg.GetValue<ServerType>(ServerType))
            {
                case Runtime.ServerType.Host:
                    XRMODServices.GetBridge().StartHost();
                    break;
                case Runtime.ServerType.ServerOnly:
                    XRMODServices.GetBridge().StartAsAServer();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return outputTrigger;
        }
    }

    public enum ServerType
    {
        Host,
        ServerOnly
    }
}