public class Coach : global::UnityEngine.MonoBehaviour
{
    private static string[] commandAnims;
    private static string[] foulAnims;
    private static string[] standAnims;
    private global::System.Collections.Generic.Queue<string> animQueue;
    private global::UnityEngine.Animator animator;
    private string currentAnimation;
    [global::UnityEngine.HideInInspector]
    public global::UnityEngine.Vector3 startPosition;
    [global::UnityEngine.HideInInspector]
    public global::UnityEngine.Quaternion startRotation;
    public int accumulativeProb;
    private bool ballIn;
    private float time;
    private float lastBallOutSecondsRemained;
    private string lastStandAnim;
    private float pauseTime;
    private bool paused;
    public void Init()
    {
    }

    private int RandomNum(int num)
    {
        return 0;
    }

    private void Update()
    {
    }

    public void Pause()
    {
    }

    public void Resume()
    {
    }

    public void Idle(float seconds)
    {
    }

    private void CheckCommand()
    {
    }

    private bool IsCurrentAnimationFinished()
    {
        return false;
    }

    private void PlayAnimation(string anim)
    {
    }

    private void PlayCommand()
    {
    }

    public void PlayFoul()
    {
    }

    public void SwitchPosition(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
    {
    }

    public void BallIn()
    {
    }

    public void BallOut()
    {
    }
}