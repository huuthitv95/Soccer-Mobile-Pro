public class ChampionCelebrationMachine : HFSM<TimelinePlayerControler, string>
{
    private class FirstStep : HFSM<TimelinePlayerControler, string>
    {
        public FirstStep(TimelinePlayerControler owner) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(bool isWin)
        {
        }
    }

    private class LoopWithinGroup : HFSM<TimelinePlayerControler, string>
    {
        public LoopWithinGroup(TimelinePlayerControler owner, string name, global::System.Collections.Generic.List<string> group) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }
    }

    private class CelebrateAlone : HFSM<TimelinePlayerControler, string>
    {
        private global::UnityEngine.Vector3 orgPos;
        private global::UnityEngine.Quaternion orgQua;
        private float maxDuration;
        private float timer;
        private string nextState;
        private int role;
        private global::UnityEngine.Vector3 mainPlayerPos;
        private global::UnityEngine.Quaternion mainPlayerRotation;
        private global::UnityEngine.Vector3 cameraPos;
        private global::System.Func<bool> finishedFlag;
        private global::System.Action notifyFinish;
        public CelebrateAlone(TimelinePlayerControler owner, string name, string Next, global::System.Collections.Generic.List<string> mainPlayerAnimations) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(int role, global::UnityEngine.Vector3 mainPlayerPos, global::UnityEngine.Quaternion mainPlayerRotation, global::UnityEngine.Vector3 cameraPos, global::System.Func<bool> finishedFlag, global::System.Action notifyFinish)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }
    }

    private class RaiseCupTimelineState : HFSM<TimelinePlayerControler, string>
    {
        private string nextState;
        private bool skip;
        private float timer;
        public RaiseCupTimelineState(TimelinePlayerControler owner, string nextState) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(bool skip)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }
    }

    private class HoldTrophy : HFSM<TimelinePlayerControler, string>
    {
        private global::System.Func<bool> finishedFlag;
        private global::System.Action notifyFinish;
        private int role;
        private global::UnityEngine.Vector3 pos;
        private global::UnityEngine.Quaternion rotation;
        private TimelineAnimationState holdState;
        private string Next;
        private global::UnityEngine.Vector3 trophyPos;
        private global::UnityEngine.Vector3 trophyRotation;
        private global::UnityEngine.GameObject trophy;
        private string cameraAnimation;
        private float holdAnimationStartTime;
        private float maxDuration;
        private float timer;
        private bool skip;
        private bool withPodium;
        public HoldTrophy(TimelinePlayerControler owner, string stateName, string nextState) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(int role, global::System.Func<bool> finishedFlag, global::System.Action notifyFinish, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rotation, bool skip, bool withPodium, string nextState, string cameraAnimation = null, float holdAnimationStartTime = 0f, float maxDuration = 0f)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }

        private float GetNormalizedTimeOffset(string animation, float time)
        {
            return 0f;
        }
    }

    private const string HoldTrophyStateId = "HoldTrophy";
    private const string SecondHoldTrophyStateId = "HoldTrophySecond";
    private const string RaiseCupTimelineStateId = "RaiseCupTimeline";
    private const string RaiseCupPrefabPath = "Assets/Timeline/raisecup/raiseCup.prefab";
    private const string TrophyPrefabDirectory = "Assets/Models/Trophy/prefab/";
    private const string RaiseCupTrophyFallbackPath = "Assets/Timeline/worlducp_hold_trophy/trophy.prefab";
    private const string RaiseCupTrophyHandPath = "Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 L Clavicle/Bip01 L UpperArm/Bip01 L Forearm/Bip01 L Hand";
    private const float RaiseCupDuration = 5f;
    private const float SecondHoldTrophyDuration = 3f;
    private const float SecondHoldTrophyStartTime = 1.2f;
    private const int RaiseCupAnimatorCount = 10;
    private const int RaiseCupHolderIndex = 0;
    private static readonly global::UnityEngine.Vector3 RaiseCupTrophyLocalPosition;
    private static readonly global::UnityEngine.Vector3 RaiseCupTrophyLocalRotation;
    private static readonly global::UnityEngine.Vector3 RaiseCupTrophyLocalScale;
    private bool isWin;
    private static ChampionCelebrationMachine leader;
    private float timer;
    private static global::System.Collections.Generic.List<string> Celebrate1;
    private static global::System.Collections.Generic.List<string> Celebrate2;
    private static global::UnityEngine.Vector3 mianPlayerPos1;
    private static global::UnityEngine.Quaternion mianPlayerRotation1;
    private static global::UnityEngine.Vector3 cameraPostion1;
    private static global::UnityEngine.Vector3 mianPlayerPos2;
    private static global::UnityEngine.Quaternion mianPlayerRotation2;
    private static global::UnityEngine.Vector3 cameraPostion2;
    private static bool commonInitialized;
    private static global::System.Collections.Generic.List<int> winRoles1;
    private static global::System.Collections.Generic.List<int> winRoles2;
    private static global::System.Collections.Generic.List<int> loseRoles1;
    private static global::System.Collections.Generic.List<int> loseRoles2;
    private static bool flag1;
    private static bool flag2;
    private static bool flag3;
    private static bool flag4;
    private static bool flagRaiseCup;
    private static bool raiseCupShouldPlay;
    private static bool raiseCupPrepared;
    private static global::System.Collections.Generic.List<TimelinePlayerControler> raiseCupPlayers;
    private static TimelinePlayerControler raiseCupController;
    private static TimelinePlayerControler raiseCupHolder;
    private static TimelinePlayerControler raiseCupHiddenPlayer;
    private static global::UnityEngine.Animator[] raiseCupAnimators;
    private static global::UnityEngine.GameObject raiseCupPrefabInstance;
    private static global::UnityEngine.GameObject raiseCupTrophy;
    private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Transform, global::UnityEngine.Transform>> raiseCupPlayerParents;
    private static global::System.Collections.Generic.List<int> holdTrophyRoles;
    private static bool checkForSpecialCup;
    private static bool withPodium;
    public ChampionCelebrationMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public override void Kill()
    {
    }

    private void OnShutdown()
    {
    }

    public override void Shutdown()
    {
    }

    private static void ResetRaiseCupContext()
    {
    }

    private static string GetTrophyPrefabPath()
    {
        return null;
    }

    private static string GetTrophyType()
    {
        return null;
    }

    private static bool TryGetSpecialTrophyPrefabPath(out string trophyType, out string trophyPath)
    {
        trophyType = null;
        trophyPath = null;
        return false;
    }

    private static void ClearRaiseCupTrophy()
    {
    }

    private static void ClearRaiseCupTimeline()
    {
    }

    private static void AttachRaiseCupPlayers()
    {
    }

    private static void AttachRaiseCupTrophy()
    {
    }

    private static void DisableTimelineCameraBlend()
    {
    }

    private static void RestoreRaiseCupPlayers()
    {
    }

    private static bool IsWorldCup2026()
    {
        return false;
    }

    private static void RegisterRaiseCupPlayer(TimelinePlayerControler player)
    {
    }

    private static void PrepareRaiseCupAnimators()
    {
    }

    private static bool IsRaiseCupActor(TimelinePlayerControler player)
    {
        return false;
    }

    private int RandomRole(global::System.Collections.Generic.List<int> roles)
    {
        return 0;
    }

    public void Start(bool isWin, bool needHoldTrophy)
    {
    }

    private void SetUpForSpecialCup()
    {
    }
}