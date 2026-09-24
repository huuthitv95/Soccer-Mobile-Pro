public class TrainingDefenseMissions : TrainingMissions
{
    private bool isPass;
    public TrainingDefenseMissions(AIMatchConfigurer.TrainingConfigure config, ITrainingMissionsHelper helper, int subLevelId, int SubLevelCount, int subsLevelIndex) : base(null, null, 0, 0, 0)
    {
    }

    protected override void DoNext()
    {
    }

    public override void OnStarted()
    {
    }

    protected override void OnRestart()
    {
    }

    protected override void InitStepUI()
    {
    }

    protected override void OnReset()
    {
    }

    protected override void ShowGuidance()
    {
    }

    public override TrainingMissions Clone()
    {
        return null;
    }
}