namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineHardLookAt : global::Cinemachine.CinemachineComponentBase
    {
        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }
    }
}