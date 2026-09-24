namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachinePOV : global::Cinemachine.CinemachineComponentBase
    {
        public global::Cinemachine.AxisState m_VerticalAxis;
        public global::Cinemachine.AxisState m_HorizontalAxis;
        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;

        private void OnValidate()
        {
        }

        private void OnEnable()
        {
        }

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }
    }
}