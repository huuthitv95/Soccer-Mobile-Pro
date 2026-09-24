public class Win_TourEventWelcome : global::Common.WindowBase
{
    public class OpenParameter
    {
        public global::FL.TourEvent.TourEventManager Manager;
        public bool ShowContinueButton;
        public OpenParameter(global::FL.TourEvent.TourEventManager manager, bool showContinueButton)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnContinue;
    [global::UnityEngine.SerializeField]
    private GUIPlayer[] rewards;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text descriptionText;
    private global::FL.TourEvent.TourEventManager manager;
    private bool showContinueButton;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action m_OnContinue;
    public event global::System.Action OnContinue
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

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void BindButtons()
    {
    }

    private void UpdateRewards()
    {
    }

    private global::System.Collections.Generic.List<int> GetRewardPlayerIds()
    {
        return null;
    }

    private void AddRewardPlayerIds(global::System.Collections.Generic.List<int> playerIds, global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> rewardConfigs)
    {
    }

    private void OnBackClick()
    {
    }

    private void OnContinueClick()
    {
    }
}