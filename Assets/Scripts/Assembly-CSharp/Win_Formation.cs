public class Win_Formation : global::Common.WindowBase
{
    public interface IFormationDecorator
    {
        void ChangeFieldImage(global::UnityEngine.Transform parent);
        void ChangeBg(global::UnityEngine.Transform parent);
    }

    private enum PlayerPosFilter
    {
        all = 0,
        front = 1,
        mid = 2,
        back = 3,
        count = 4
    }

    private struct RoleConfigurator
    {
        private global::UnityEngine.GameObject roleView;
        private global::UnityEngine.GameObject btnSwitch;
        private global::UnityEngine.GameObject teamObj;
        private global::UnityEngine.GameObject btnGroup;
        public bool IsShowingRoleView => false;

        public RoleConfigurator(global::UnityEngine.GameObject roleView, global::UnityEngine.GameObject teamObj, global::UnityEngine.GameObject btnGroup, global::UnityEngine.GameObject btnSwitch)
        {
            this.roleView = null;
            this.btnSwitch = null;
            this.teamObj = null;
            this.btnGroup = null;
        }

        public void ShowRoleView(bool show)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSwitch;
    private global::UnityEngine.UI.Button btnFormation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform subList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform starterList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnContinue;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBakc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.ScrollRect LeftList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject userFlag;
    private bool lastMultiTouchState;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnVideo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnRestoreStaminaVideo;
    private IngameTacticsMgr.IngameTacticsData ingameTacticsData;
    private global::UnityEngine.UI.Button btnEdit;
    [global::UnityEngine.SerializeField]
    private GUIPlayerDetailInfo detailInfo1;
    [global::UnityEngine.SerializeField]
    private GUIPlayerDetailInfo detailInfo2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnRecoverInjury;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform videoGourp2;
    private FormationBtnPanelBase ActiveBtnPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle iapPlayerToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform subsNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform roleNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button autoChangeRole;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform ratingByPos;
    [global::UnityEngine.SerializeField]
    private GUITeam gUITeam;
    private global::UnityEngine.UI.Button btnTacticsStyle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button roleBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle normalBenchToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform backgroundNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform fieldImageNode;
    private global::UnityEngine.UI.Button btnRole;
    private Win_Formation.RoleConfigurator roleConfigurator;
    private bool showBanner;
    private RegionalLeague masterLeague;
    private bool disableRV;
    private bool optionLocked;
    private global::System.Action OnFormationChange;
    private TeamsData myTeam;
    private TeamsData oppTeam;
    private CupMatchBase localPVPMatch;
    private bool CheckIngame;
    private IMatchManager matchManager;
    private bool isShow3dBoard;
    private global::UnityEngine.Coroutine ScrollCo;
    private global::System.Collections.Generic.List<GUIFormationBench> GUIBenchs;
    private TeamsData currentTeam;
    private GUIFormationExchanger subsExchanger;
    private GUIFormationExchanger roleExchanger;
    private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> ExclusivePlayers;
    private global::System.Collections.Generic.HashSet<int> starterPlayers;
    private bool _disableChangeFormation;
    private global::System.Collections.Generic.Dictionary<Win_Formation.PlayerPosFilter, global::System.Collections.Generic.HashSet<FormationTool.UIPosition>> filterHelper;
    private Win_Formation.PlayerPosFilter currentFilter;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image[] fieldbg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image[] buttonbg;
    private bool CanShowRewardVideoButtons => false;

    private void DecorateFormation(Win_Formation.IFormationDecorator decorator)
    {
    }

    private void UpdateTeamRating()
    {
    }

    private void UpdateOperationType(bool isRole)
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private void SetBoostMoraleVideoVisible(bool visible)
    {
    }

    private void SetRestoreStaminaVideoVisible(bool visible)
    {
    }

    public void SetPlayerCareerFormation(Win_PlayerCareerFormation win)
    {
    }

    public void HideTempBoostEntry()
    {
    }

    private void OnOpen()
    {
    }

    public Win_Formation ShowBackBtn(global::System.Action nextAction = null)
    {
        return null;
    }

    private void OnDestroy()
    {
    }

    private void OnDisable()
    {
    }

    public Win_Formation ShowRestoreStaminaVideo()
    {
        return null;
    }

    public Win_Formation ShowBoostMorale()
    {
        return null;
    }

    public void ShowPlayerManager(global::System.Action OpenView)
    {
    }

    public void ShowPlayerContract(global::System.Func<Win_PlayerContract> OpenView)
    {
    }

    public void ShowSalePlayer(global::System.Action OpenView)
    {
    }

    public void ShowPlayerExp(global::System.Action OpenView)
    {
    }

    public Win_Formation Fill(global::System.Action changeFormationAction, TeamsData myTeam, TeamsData oppTeam, IMatchManager matchManager, bool showOppFormation = true, bool CloseWhenContinue = true)
    {
        return null;
    }

    public Win_Formation FillLocalPVP(CupMatchBase match, TeamsData selectedTeam)
    {
        return null;
    }

    private Win_Formation FillInternal(global::System.Action changeFormationAction, TeamsData myTeam, TeamsData oppTeam, IMatchManager matchManager, bool showOppFormation, bool CloseWhenContinue)
    {
        return null;
    }

    private void SelectLocalPVPTeam(TeamsData team)
    {
    }

    private void UpdateEditButtonVisibility()
    {
    }

    private ClubPlayer GetSuitableSubstitute(global::System.Collections.Generic.List<ClubPlayer> players, ClubPlayer outPlayer)
    {
        return null;
    }

    private void OptimizingStarter()
    {
    }

    public Win_Formation ShowRecoverInjury()
    {
        return null;
    }

    public Win_Formation ShowRenewalContarct(bool startMatch)
    {
        return null;
    }

    public Win_Formation ShowContinueBtn()
    {
        return null;
    }

    private void Show3dBoard()
    {
    }

    public Win_Formation SetNextAction(global::System.Action nextAction)
    {
        return null;
    }

    private global::System.Collections.IEnumerator ScrollLeftList(float speed)
    {
        return null;
    }

    public void StartScrollLeftList(float speed)
    {
    }

    public void StopScrollLeftList()
    {
    }

    public static void UpdateFormationUI(global::UnityEngine.RectTransform field, global::UnityEngine.Transform players, float[] formation, bool isVertical = false)
    {
    }

    public static void UpdateFormationUI(float height, float width, global::UnityEngine.Transform players, float[] formation, bool isVertical = false)
    {
    }

    private void onChangeFormation()
    {
    }

    public void UpdateCaptainFlag(TeamsData team)
    {
    }

    private void OnSelectItem(GUIFormationItem selected)
    {
    }

    private void AddExclusivePair(int a, int b)
    {
    }

    private void UpdateExclusivePlayers(TeamsData myTeam)
    {
    }

    private global::System.Collections.Generic.List<int> CheckExclusivePlayers(int player)
    {
        return null;
    }

    private GUIFormationExchanger GetActiveExchanger()
    {
        return null;
    }

    private void UpdateRoleList()
    {
    }

    private void OnRoleChange()
    {
    }

    private void BenchPlayerFilter(global::UnityEngine.Transform item, ClubPlayer player)
    {
    }

    private void UpdateUI(TeamsData team, bool isOnOpen = false, bool iapBenchPlayers = false)
    {
    }

    public void BoostPlayerState()
    {
    }

    public override void OnClose()
    {
    }

    private void UpdateRatingByPos()
    {
    }

    private void FillForChristmasTheme()
    {
    }
}