public abstract class TimelinePlayable : global::UnityEngine.MonoBehaviour
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action m_Completed;
    private bool playing;
    private bool completing;
    private float timer;
    protected abstract global::UnityEngine.Playables.PlayableDirector Director { get; }

    public event global::System.Action Completed
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    protected virtual void Awake()
    {
    }

    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }

    protected virtual void Update()
    {
    }

    public void Play()
    {
    }

    public void Stop()
    {
    }

    protected bool BindAnimatorTrack(global::UnityEngine.Animator animator)
    {
        return false;
    }

    private void OnPlayableDirectorStopped(global::UnityEngine.Playables.PlayableDirector director)
    {
    }

    private void Complete()
    {
    }
}