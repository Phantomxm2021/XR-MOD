namespace ILRuntime.Runtime.Generated
{
    public class MirrorClrBinding
    {
        public static void Binding(Enviorment.AppDomain _app)
        {
            BaseMultiplayerData_Binding.Register(_app);
            MultiplayerConnectionResponseData_Binding.Register(_app);
            XRMODServerBridge_Binding.Register(_app);
            NetworkAttributes_Binding.Register(_app);
            NetworkPropertiesSync_Binding.Register(_app);
            CreatePrefabMessage_Binding.Register(_app);
            TransformData_Binding.Register(_app);
            NetworkRemoteActions_Binding.Register(_app);
            NumberSynchronizer_Binding.Register(_app);
            QuaternionSynchronizer_Binding.Register(_app);
            Vector3Synchronizer_Binding.Register(_app);
            BoolSynchronizer_Binding.Register(_app);
        }
    }
}