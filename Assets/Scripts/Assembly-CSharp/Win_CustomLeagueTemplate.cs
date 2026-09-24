public class Win_CustomLeagueTemplate : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField leagueNameInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image leagueLogo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button customLeagueLogo;
    [global::UnityEngine.SerializeField]
    private GUIWheel leagueTrophyWheel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject leagueTrophyDots;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle cupToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle superCupToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField cupNameInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image cupLogo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button customCupLogo;
    [global::UnityEngine.SerializeField]
    private GUIWheel cupTrophyWheel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject cupTrophyDots;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField supercupNameInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image supercupLogo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button supercustomCupLogo;
    [global::UnityEngine.SerializeField]
    private GUIWheel supercupTrophyWheel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject supercupTrophyDots;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_next;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_back;
    private global::System.Collections.Generic.Dictionary<string, FixtureListProfile> profiles;
    private global::System.Collections.Generic.List<FixtureListProfile> profilesList;
    private global::Srv.CustomLeagueTemplate template;
    private global::System.Collections.Generic.List<int> op_numOfTeams;
    private global::System.Collections.Generic.List<string> op_leagueSchedule;
    private global::System.Collections.Generic.List<CustomLeagueCupRule> op_CupRules;
    public override void OnOpen(object parameter)
    {
    }

    private void InitTemplate(FixtureListProfile data)
    {
    }

    private void SetModificationName()
    {
    }

    private void UpdateOptions(int index)
    {
    }

    private void UpdateDots(global::UnityEngine.GameObject dotsGroup, int index)
    {
    }

    private void InitFormTemplate()
    {
    }

    private void UpdateLeagueLogo(int idx)
    {
    }

    private void UpdateCupLogo(int idx)
    {
    }

    private void UpdateSuperCupLogo(int idx)
    {
    }

    private void UpdateLogo(global::UnityEngine.UI.Image logo, string data)
    {
    }

    private void UpdateLeagueTrophy(int idx)
    {
    }

    private void UpdateCupTrophy(int idx)
    {
    }

    private void UpdateSuperCupTrophy(int idx)
    {
    }

    private void UpdateTrophy(global::UnityEngine.Transform root, string data)
    {
    }

    private void UpdateNumOfTeams(int idx)
    {
    }

    private void UpdateOPLeagueSchedule()
    {
    }

    private void InitOPLeagueSchedule(int current)
    {
    }

    public void UpdateCupType(bool placeHolder)
    {
    }

    private void DownloadLeagueIcon()
    {
    }

    private void DownloadCupLeagueIcon()
    {
    }

    private void DownloadSuperCupLeagueIcon()
    {
    }

    private global::UnityEngine.Texture2D HandleTempTexture(string path, global::UnityEngine.Texture2D texture)
    {
        return null;
    }
}