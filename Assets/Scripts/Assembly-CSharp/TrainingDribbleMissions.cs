public class TrainingDribbleMissions : TrainingMissions
{
    private global::DG.Tweening.Sequence seq;
    private global::DG.Tweening.Sequence seq2;
    public override string GetTrainingStepInfo(bool levelUp)
    {
        return null;
    }

    protected override global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> GetTrainingPassString()
    {
        return null;
    }

    public TrainingDribbleMissions(AIMatchConfigurer.TrainingConfigure config, ITrainingMissionsHelper helper, int subLevelId, int SubLevelCount, int subsLevelIndex) : base(null, null, 0, 0, 0)
    {
    }

    private void ShowJoyTutorial()
    {
    }

    protected override void ShowGuidance()
    {
    }

    public override void HandleInput(global::EngineMessages.InputData input)
    {
    }

    private void HideGuidance()
    {
    }

    protected override void OnReset()
    {
    }

    protected override void InitStepUI()
    {
    }
}