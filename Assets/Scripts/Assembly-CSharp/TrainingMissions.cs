public abstract class TrainingMissions
{
    protected AIMatchConfigurer.TrainingConfigure config;
    protected int trainingStep;
    protected int currentTrainingSetpCount;
    protected ITrainingMissionsHelper helper;
    protected int subLevelId;
    protected int SubLevelCount;
    protected int subsLevelIndex;
    private global::System.Collections.Generic.HashSet<global::EngineMessages.InputFunction> keyDownSet;
    private float timer;
    private bool timStarts;
    public bool BlockAI { get; protected set; }
    private bool IsHelperAlive => false;
    protected virtual string TipTitle => null;
    protected virtual string TipContent => null;
    protected global::UnityEngine.RectTransform BtnSprint => null;
    protected global::UnityEngine.RectTransform BtnPass => null;
    protected global::UnityEngine.RectTransform BtnShoot => null;
    protected global::UnityEngine.RectTransform BtnThrough => null;
    protected global::UnityEngine.RectTransform BtnPress => null;
    protected global::UnityEngine.RectTransform BtnSwitch => null;
    protected global::UnityEngine.RectTransform BtnSlide => null;
    protected global::UnityEngine.RectTransform TutorialHand1 => null;
    protected global::UnityEngine.RectTransform TutorialHand2 => null;

    public void UpdateTrainingSetpCount()
    {
    }

    public virtual void OnStart()
    {
    }

    public virtual string GetTrainingStepInfo(bool levelUp)
    {
        return null;
    }

    protected virtual global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> GetTrainingPassString()
    {
        return null;
    }

    protected abstract void ShowGuidance();
    public virtual void HandleInput(global::EngineMessages.InputData input)
    {
    }

    protected abstract void InitStepUI();
    protected virtual void ResetBtnState()
    {
    }

    public virtual void OnStarted()
    {
    }

    protected virtual void NextStep()
    {
    }

    protected void ChechTimerConfig()
    {
    }

    protected virtual void OnTimeOut()
    {
    }

    public virtual void Update()
    {
    }

    protected void ResetCommon()
    {
    }

    public virtual void ResetConfig()
    {
    }

    protected abstract void OnReset();
    protected virtual void OnRestart()
    {
    }

    private void OnStepOver(global::System.Action nextAction)
    {
    }

    protected virtual void DoNext()
    {
    }

    internal virtual void HandleMessage(AISampleBase.MessageBuffer message)
    {
    }

    protected void ShowSlideTutorial(ref global::DG.Tweening.Sequence seq, global::UnityEngine.RectTransform hand, global::UnityEngine.RectTransform focus, global::UnityEngine.Vector2 moveOffset, global::UnityEngine.Vector2 startPosOffset)
    {
    }

    protected void ShowClickAndSlideTutorial(ref global::DG.Tweening.Sequence seq, global::UnityEngine.RectTransform hand, global::UnityEngine.RectTransform focus, global::UnityEngine.Vector2 moveOffset, global::UnityEngine.Vector2 startPosOffset)
    {
    }

    protected void ShowClickTutorial(ref global::DG.Tweening.Sequence seq, global::UnityEngine.RectTransform hand, global::UnityEngine.RectTransform focus, global::UnityEngine.Vector2 startPosOffset)
    {
    }

    public static string GetTrainingName(global::EngineMessages.TrainingConfig.Types.Type type)
    {
        return null;
    }

    private string GetTrainingName()
    {
        return null;
    }

    protected TrainingMissions(AIMatchConfigurer.TrainingConfigure config, ITrainingMissionsHelper helper, int subLevelId, int SubLevelCount, int subsLevelIndex)
    {
    }

    protected TrainingMissions(AIMatchConfigurer.TrainingConfigure config, ITrainingMissionsHelper helper)
    {
    }

    public static TrainingMissions Create(AIMatchConfigurer.TrainingConfigure config, ITrainingMissionsHelper helper, int subLevelId, int SubLevelCount, int subsLevelIndex)
    {
        return null;
    }

    public virtual TrainingMissions Clone()
    {
        return null;
    }
}