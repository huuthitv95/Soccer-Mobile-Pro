public class DebugPreset : global::UnityEngine.MonoBehaviour
{
    public class PlayerDebugConfig
    {
        public int teamId;
        public int playerId;
        public global::System.Collections.Generic.Dictionary<global::EngineMessages.PlayerProperty, float> properties;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject _templateOption;
    private PitchPatternManager _pitchPatternManager;
    private bool _showPlayerPropertyEditor;
    private int _selectedTeamId;
    private int _selectedPlayerIndex;
    private global::System.Collections.Generic.Dictionary<global::EngineMessages.PlayerProperty, float> _editingProperties;
    private global::UnityEngine.Vector2 _scrollPosition;
    private static global::System.Collections.Generic.List<DebugPreset.PlayerDebugConfig> _playerDebugConfigs;
    public IMatch sample { get; set; }

    private static DebugPreset.PlayerDebugConfig GetPlayerDebugConfig(int playerId)
    {
        return null;
    }

    public static void ApplyDebugConfig(int player, global::EngineMessages.PlayerData playerData)
    {
    }

    public static void ClearPlayerDebugConfig()
    {
    }

    private void Start()
    {
    }

    public void ShowPlayerPropertyEditor()
    {
    }

    private void OnGUI()
    {
    }

    private void DrawPlayerPropertyEditorWindow(int windowID)
    {
    }

    private void PopulateEditingProperties(TeamsData team, ClubPlayer player)
    {
    }

    private void SavePlayerPropertyConfig(TeamsData team, ClubPlayer player, global::System.Collections.Generic.Dictionary<global::EngineMessages.PlayerProperty, float> properties)
    {
    }

    private void CreateOption(string v, global::System.Collections.Generic.List<string> counts, global::System.Action<string> onvalue, object defaultvalue)
    {
    }

    private void CreateOption(string name, global::System.Collections.Generic.List<string> options, global::System.Action<string> onValue, string defaultvalue)
    {
    }

    public void OnChangeTime(string t)
    {
    }

    private void OnChangeAutoSwitchPlayerLevel(string level)
    {
    }

    public void OnChangeDifficult(string difficulty)
    {
    }

    private void OnPassPower(string level)
    {
    }

    private void OnPassDir(string level)
    {
    }

    public void OnReplay()
    {
    }

    public void OnStartLastReplay()
    {
    }

    public void FakeFinish(bool win)
    {
    }

    public void OnMatchIdChanged(string id)
    {
    }
}