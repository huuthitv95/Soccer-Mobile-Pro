public class ProbabilisticStateAnimationTransitioner : global::UnityEngine.MonoBehaviour
{
    public enum ParamType
    {
        Trigger = 0,
        Bool = 1,
        Int = 2,
        Float = 3
    }

    [global::UnityEngine.SerializeField]
    private string parameterName;
    [global::UnityEngine.SerializeField]
    private ProbabilisticStateAnimationTransitioner.ParamType parameterType;
    [global::UnityEngine.SerializeField]
    private bool boolValue;
    [global::UnityEngine.SerializeField]
    private int intValue;
    [global::UnityEngine.SerializeField]
    private float floatValue;
    [global::UnityEngine.SerializeField]
    private float durationSeconds;
    [global::UnityEngine.SerializeField]
    private bool forceTriggerAtEnd;
    [global::UnityEngine.SerializeField]
    private bool useUnscaledTime;
    private global::UnityEngine.Animator _animator;
    private float _startTime;
    private bool _triggered;
    private float Now => 0f;

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void Update()
    {
    }

    private void DoTrigger()
    {
    }
}