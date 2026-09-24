public class PlayerCareerLeagueController : IRegionalLeagueController, RegionalLeagueEventListener, UpdateSeasonChangeTeamRequester
{
    private static bool openingTransferPresentation;
    private global::FLGameProgressSetting.LocalArchives storer;
    private PlayerRetirementRebirthContext retirementRebirthContext;
    private RegionalLeague RegionalLeague { get; set; }
    private TransferClubArchiveContext ClubArchiveContext { get; set; }

    void RegionalLeagueEventListener.OnChooseTeam()
    {
    }

    void RegionalLeagueEventListener.OnFinishSeason()
    {
    }

    void RegionalLeagueEventListener.OnInitialize()
    {
    }

    void IRegionalLeagueController.OnMatchExit(CupMatchBase match, bool isFake, bool inGame, bool isLastDay, ClubPlayer AwardWinningPlayer)
    {
    }

    void RegionalLeagueEventListener.OnMatchFinish(CupMatchBase.MatchSettlementData match)
    {
    }

    void RegionalLeagueEventListener.OnRest()
    {
    }

    void RegionalLeagueEventListener.OnUpdateRound()
    {
    }

    void RegionalLeagueEventListener.OnUpdateSeason()
    {
    }

    global::Common.WindowBase IRegionalLeagueController.OpenSeasonMainView(CupMatchBase cupMatch)
    {
        return null;
    }

    private void TryOpenTransferJerseySelection(global::FL.PlayerCareer playerCareer)
    {
    }

    private void OpenTransferJerseySelection(global::FL.PlayerCareer playerCareer)
    {
    }

    private void OnTransferJerseySelectionClosed(global::FL.PlayerCareer playerCareer)
    {
    }

    public static void OpenWelcomeToNewClub(global::FL.PlayerCareer playerCareer, string textStringId = null, global::System.Action onWindowClosed = null)
    {
    }

    void IRegionalLeagueController.ShowNewSeasonView(FixtureListData fixtureList, bool isOnCreate)
    {
    }

    public static void ShowMatchBonusView(CupMatchBase match, PlayerCareerInMatchManager ingameManager, global::UnityEngine.Events.UnityAction nextAction)
    {
    }

    public PlayerCareerLeagueController(RegionalLeague regionalLeague, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    private void OnUpdateToNextSchedule(FixtureListData fixtureListData, Schedule schedule)
    {
    }

    private void CheckPlayerRetirement(TeamsData team, ClubPlayer clubPlayer)
    {
    }

    private void HandlePlayerRetirement(TeamsData Team, ClubPlayer clubPlayer)
    {
    }

    private void CheckRetirement()
    {
    }

    public bool OnSeasonChangeTeam(out int leagueProtoId, out TeamsData team)
    {
        leagueProtoId = default;
        team = null;
        return false;
    }
}