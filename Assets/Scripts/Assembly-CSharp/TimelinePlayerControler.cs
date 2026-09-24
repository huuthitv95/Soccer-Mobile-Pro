public class TimelinePlayerControler : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.Animator anim;
    public global::UnityEngine.AnimatorStateInfo AnimatorStateInfo;
    public global::UnityEngine.Transform player;
    public InGamePlayer InGamePlayer;
    public int orderInTeam;
    public IMatch aiMatach;
    public bool isOfficials;
    private HFSM<TimelinePlayerControler, string> fsm;
    private StartMatchStateMachine startMatchTimeline;
    private CelebrationStateMachine celebrationFSM;
    private LeaveMatchStateHalfMachine LeaveMatchHalfStateFSM;
    private LeaveMatchStateMachine LeaveMatchStateMachine;
    private SubstitutionStateMachine SubstitutionStateMachine;
    private FoulStateMachine foulStateMachine;
    private HalfMarchInStateMachine halfMarchInStateMachine;
    private ChampionCelebrationMachine ChampionCelebrationMachine;
    private InjuredStateMachine injuredStateMachine;
    private CelebrationMate celebrationMate;
    private MatchStartSubInTimeline matchStartSubInTimeline;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Vector3, global::UnityEngine.Quaternion>> aiPlayerBone;
    protected global::System.Collections.Generic.List<global::DG.Tweening.Tween> tweens;
    private bool paused;
    private bool hasTargetRotation;
    private global::UnityEngine.Quaternion playerTargetRotation;
    private global::UnityEngine.Vector3? targetPosition;
    private float moveSpeed;
    public bool freezeXZOffset;
    private global::UnityEngine.Quaternion lastAnimRotation;
    public bool EnableYCorrect;
    public global::UnityEngine.Vector3 BodyPos;
    public global::UnityEngine.Quaternion BodyRot;
    public void init(InGamePlayer p, int orderInTeam, IMatch aiMatch)
    {
    }

    public CelebrationMate EnableCelebrationMate()
    {
        return null;
    }

    private void Start()
    {
    }

    public void ShutDown()
    {
    }

    public void KillCurrnetState()
    {
    }

    private void OnDestroy()
    {
    }

    public void InitState()
    {
    }

    public void OnTimelineStart(TimelineType type, object extraData = null)
    {
    }

    public void OnTimelineOver(bool checkAlreadyDone = true)
    {
    }

    private void OnDisable()
    {
    }

    public global::System.Collections.IEnumerator ResetPlayerBone(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Vector3, global::UnityEngine.Quaternion>> bones, float blendDuration, global::System.Action action, bool ignoreRoot = false)
    {
        return null;
    }

    public void StopBoneTween()
    {
    }

    public void TransitionPlayerBone(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Vector3, global::UnityEngine.Quaternion>> bones, float blendDuration, bool ignoreRoot = false)
    {
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

    public void SetPlayerPosition(global::UnityEngine.Vector3 pos)
    {
    }

    public void SetPlayerRotation(global::UnityEngine.Quaternion quaternion)
    {
    }

    public void ResetAnimationParameters()
    {
    }

    private void OnAnimatorMove()
    {
    }

    public void OnAnimatorMove(global::UnityEngine.Vector3 deltaPosition, global::UnityEngine.Quaternion deltaRotation)
    {
    }

    public bool MoveToTarget(global::UnityEngine.Vector3 targetPos, global::UnityEngine.Quaternion targetRotation, float speed, float deltaTime)
    {
        return false;
    }

    private void OnAnimatorIK(int layerIndex)
    {
    }

    public void SetPlayerTransform(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion quaternion)
    {
    }
}