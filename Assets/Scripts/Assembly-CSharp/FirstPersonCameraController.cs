public class FirstPersonCameraController : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.Transform target;
    public global::UnityEngine.Transform ball;
    public global::UnityEngine.Transform opponentGoal;
    public bool playerHasBall;
    public FirstPersonCameraSettings settings;
    private global::UnityEngine.Camera _camera;
    private FirstPersonCameraState _state;
    private void Start()
    {
    }

    private void LateUpdate()
    {
    }
}