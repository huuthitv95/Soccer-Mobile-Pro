public class UvOffsetAnimator : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer targetRenderer;
    [global::UnityEngine.SerializeField]
    private string texturePropertyName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 startOffset;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 maxOffset;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 firstRoundOffset;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 offsetStep;
    [global::UnityEngine.SerializeField]
    private float switchInterval;
    [global::UnityEngine.SerializeField]
    private float switchAnimationDuration;
    [global::UnityEngine.SerializeField]
    private bool playOnEnable;
    [global::UnityEngine.SerializeField]
    private bool useSharedMaterial;
    [global::UnityEngine.SerializeField]
    private bool useUnscaledTime;
    private global::UnityEngine.Material targetMaterial;
    private global::UnityEngine.Vector2 currentOffset;
    private global::UnityEngine.Vector2 logicalOffset;
    private global::UnityEngine.Vector2 animationStartOffset;
    private global::UnityEngine.Vector2 animationTargetOffset;
    private float elapsed;
    private float animationElapsed;
    private int currentStepIndex;
    private bool isPlaying;
    private bool isSwitchAnimating;
    private bool isInFirstRound;
    private void Reset()
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void Update()
    {
    }

    public void Play()
    {
    }

    public void Pause()
    {
    }

    public void SyncProgressFrom(UvOffsetAnimator source)
    {
    }

    public void Stop()
    {
    }

    public void ResetOffset()
    {
    }

    private global::UnityEngine.Vector2 GetOffsetByStepIndex(int stepIndex, bool firstRound)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetFirstRoundStartOffset()
    {
        return default;
    }

    private void CacheMaterial()
    {
    }

    private void StepOffset()
    {
    }

    private void StartSwitchAnimation(global::UnityEngine.Vector2 targetOffset)
    {
    }

    private void UpdateSwitchAnimation(float deltaTime)
    {
    }

    private bool HasReachedMax(global::UnityEngine.Vector2 value)
    {
        return false;
    }

    private bool WillPassMax(global::UnityEngine.Vector2 value)
    {
        return false;
    }

    private bool HasSameSettings(UvOffsetAnimator other)
    {
        return false;
    }

    private static bool ReachedOnAxis(float value, float max, float step)
    {
        return false;
    }

    private static bool PassedOnAxis(float value, float max, float step)
    {
        return false;
    }

    private void ApplyOffset(global::UnityEngine.Vector2 offset)
    {
    }
}