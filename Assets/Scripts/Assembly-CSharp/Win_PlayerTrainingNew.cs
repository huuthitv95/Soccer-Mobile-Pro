public class Win_PlayerTrainingNew : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform checkedList;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo video;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTraining;
    [global::UnityEngine.SerializeField]
    private StringID abilityText;
    [global::UnityEngine.SerializeField]
    private int UIType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title2;
    private bool leave;
    private RegionalLeague masterLeague;
    private PlayerTrainingManager.TrainingType trainingType;
    private global::System.Collections.Generic.List<ClubPlayer> trainingPlayers;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void Leave(global::System.Action next)
    {
    }

    private global::System.Collections.IEnumerator LeaveAnimtion(global::System.Action next)
    {
        return null;
    }

    public void Fill(RegionalLeague masterLeague, Schedule curDay)
    {
    }

    private void OpenMainView(RegionalLeague masterLeague)
    {
    }

    private void RefreshPlayer(global::System.Collections.Generic.List<ClubPlayer> players, RegionalLeague masterLeague, Schedule curDay)
    {
    }

    private void SetAbilityText(PlayerTrainingManager.TrainingType type)
    {
    }

    private void UpdatePlayerInfo(ClubPlayer player, float newExp, int property, global::UnityEngine.Transform item, string PropertyName)
    {
    }

    private void SetAbilityColor(global::UnityEngine.UI.Text text, float value)
    {
    }
}