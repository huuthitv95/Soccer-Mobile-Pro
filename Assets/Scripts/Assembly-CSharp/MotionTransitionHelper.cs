public class MotionTransitionHelper
{
    private float duration;
    private float ogrDuration;
    private float currentTime;
    private string clipName;
    private global::UnityEngine.Animator animator;
    private global::UnityEngine.GameObject player;
    private TimelinePlayerControler playerControler;
    private global::System.Collections.Generic.List<global::UnityEngine.Quaternion> rotation;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> pos;
    private bool animatorState;
    private global::UnityEngine.AnimationClip current;
    private bool finised;
    private global::UnityEngine.Vector3? lastPos;
    private global::UnityEngine.Quaternion? lastRotation;
    public MotionTransitionHelper(float duration, string clipName, global::UnityEngine.Animator animator, global::UnityEngine.GameObject player, TimelinePlayerControler playerCtr)
    {
    }

    public void Start(string clipName, float normalizedTimeOffset = 0f)
    {
    }

    public bool Update()
    {
        return false;
    }
}