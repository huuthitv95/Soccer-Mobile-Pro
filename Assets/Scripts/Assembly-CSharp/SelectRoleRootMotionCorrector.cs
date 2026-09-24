public class SelectRoleRootMotionCorrector : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private float backPositionCorrectionRate;
    [global::UnityEngine.SerializeField]
    private float backRotationCorrectionRate;
    [global::UnityEngine.SerializeField]
    private float correctionStartNormalizedTime;
    [global::UnityEngine.SerializeField]
    private float backSnapDistance;
    [global::UnityEngine.SerializeField]
    private float backSnapAngle;
    private static readonly int MoveBackStateHash;
    private static readonly int MoveBack3StateHash;
    private global::UnityEngine.Animator animator;
    private bool enableBackToOriginCorrection;
    private bool enteredBackChain;
    private global::UnityEngine.Vector3 originWorldPosition;
    private global::UnityEngine.Quaternion originWorldRotation;
    private void Awake()
    {
    }

    public void BeginBackToOriginCorrection(global::UnityEngine.Vector3 worldPosition, global::UnityEngine.Quaternion worldRotation)
    {
    }

    public void StopBackToOriginCorrection(bool snapToOrigin = false)
    {
    }

    private void OnAnimatorMove()
    {
    }

    private void ApplyBackToOriginCorrection()
    {
    }

    private bool TryGetBackChainProgress(out float backChainProgress)
    {
        backChainProgress = default;
        return false;
    }

    private bool IsBackChainState(int shortNameHash)
    {
        return false;
    }
}