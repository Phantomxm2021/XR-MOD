using Unity.VisualScripting;
using com.PhantomsXR.MirrorExtension.Runtime;


namespace com.PhantomsXR.VisualScriptingExtension.Runtime.Editor
{
    [Descriptor(typeof(BaseSynchronizerUnit))]
    public class BaseSynchronousUnitDescriptor : ARMODBaseWithResultUnitDescriptor
    {
        public BaseSynchronousUnitDescriptor(ARMODBaseWithResultUnit _target) : base(_target)
        {
        }


        protected override string DefinedSummary()
        {
            return "Synchronous the value to remote client. Like the [Syncvar] attribute";
        }

        protected override void DefinedPort(IUnitPort _port, UnitPortDescription _description)
        {
            base.DefinedPort(_port, _description);

            switch (_port.key)
            {
                case "Target":
                    _description.summary = "Where is the Synchronous component.";
                    break;
                case "CallbackTarget":
                    _description.summary = "Where is the callback event listener.";
                    break;
                case "Write":
                    _description.summary = "Enter modification mode. To modify the value.";
                    break;
            }
        }
    }
}