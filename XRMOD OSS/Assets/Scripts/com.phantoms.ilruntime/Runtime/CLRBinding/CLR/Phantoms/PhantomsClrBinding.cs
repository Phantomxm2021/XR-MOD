namespace ILRuntime.Runtime.Generated
{
    public class PhantomsClrBinding
    {
        public static void Binding(Enviorment.AppDomain _app)
        {
            //action
            ActionNotificationCenter_Binding.Register(_app);
            AlgorithmSetterNotificationData_Binding.Register(_app);
            ARRaycastNotificationData_Binding.Register(_app);
            AnchorNotificationData_Binding.Register(_app);
            ARAlgorithmNotificationData_Binding.Register(_app);
            BaseNotificationData_Binding.Register(_app);
            FaceMeshNotificationData_Binding.Register(_app);
            FocusResultNotificationData_Binding.Register(_app);
            ImmersalNotificationData_Binding.Register(_app);
            LoadObjectNotificationData_Binding.Register(_app);
            MarkerNotificationData_Binding.Register(_app);
            OpenBuiltInNotificationData_Binding.Register(_app);
            TryAcquireAppInfoNotificationData_Binding.Register(_app);
            AROcclusionNotificationData_Binding.Register(_app);
            ResizeARWorldScaleNotificationData_Binding.Register(_app);
            TryAcquireCurrentFrameNotificationData_Binding.Register(_app);
            SaveMediaNotificationData_Binding.Register(_app);
            ARMODAPI_Runtime_API_Binding.Register(_app);
            GameObjectRuntimeTag_Binding.Register(_app);
            IRuntimeTag_Binding.Register(_app);
            RuntimeTagManager_Binding.Register(_app);
            TransformNotificationData_Binding.Register(_app);
            MessageNotificationData_Binding.Register(_app);
            //BarracudaExtension_NNEInference_Binding.Register(_app);

            LeanAudio_Binding.Register(_app);
            LeanAudioOptions_Binding.Register(_app);
            LeanSmooth_Binding.Register(_app);
            LeanTweenExt_Binding.Register(_app);
            LTDescr_Binding.Register(_app);
            // UIMonoBehaviour_Binding.Register(_app);
            // XRMODBehaviour_Binding.Register(_app);
            //UniTask_Binding.Register(_app);
        }
    }
}