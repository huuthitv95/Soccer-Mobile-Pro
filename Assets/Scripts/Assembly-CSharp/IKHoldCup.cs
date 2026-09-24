public class IKHoldCup : global::UnityEngine.MonoBehaviour
{
    private global::UnityEngine.Animator anim;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform LeftHand;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform RightHand;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cupDummy;
    [global::UnityEngine.SerializeField]
    private HoldCupIKConfigs configs;
    [global::UnityEngine.SerializeField]
    private bool PlayAnimOnStart;
    private global::UnityEngine.Vector3 leftIKPos;
    private global::UnityEngine.Vector3 rightIKPos;
    private global::UnityEngine.Quaternion leftIKQua;
    private global::UnityEngine.Quaternion rightIKQua;
    private FingerIKConfigs leftHandFinger;
    private FingerIKConfigs rightHandFinger;
    private bool hasFingerIK;
    public void Init(global::UnityEngine.Transform player)
    {
    }

    private void Start()
    {
    }

    private void OnAnimatorIK(int layerIndex)
    {
    }
}