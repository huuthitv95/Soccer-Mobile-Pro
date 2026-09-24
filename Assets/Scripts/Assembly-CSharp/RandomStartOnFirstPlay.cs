[global::UnityEngine.DisallowMultipleComponent]
public class RandomStartOnFirstPlay : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.AnimationClip targetClip;
    [global::UnityEngine.SerializeField]
    private string targetStateName;
    [global::UnityEngine.SerializeField]
    private int layerIndex;
    [global::UnityEngine.SerializeField]
    private float normalizedMaxStart;
    [global::UnityEngine.SerializeField]
    private bool onlyFirstTime;
    private global::UnityEngine.Animator _animator;
    private bool _appliedOnce;
    private int _lastStateHash;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void Update()
    {
    }

    private bool IsTargetCurrentlyPlaying(global::UnityEngine.AnimatorStateInfo stateInfo)
    {
        return false;
    }
}