public class PlayerSkillHUD : global::UnityEngine.MonoBehaviour
{
    private class PlayerSkillHUDTrigger
    {
        protected InGamePlayer focusPlayer;
        private PlayerSkillHUD state;
        private global::System.Collections.Generic.Dictionary<global::EngineMessages.PlayerSkill, PlayerSkillHUD.PlayerSkillHUDState> skillHUDStates;
        private float globalCD;
        private float lastPlayTime;
        public PlayerSkillHUDTrigger(InGamePlayer player, global::System.Collections.Generic.IEnumerable<global::EngineMessages.PlayerSkill> skills, PlayerSkillHUD hud)
        {
        }

        private bool CheckGlobalCD()
        {
            return false;
        }

        public void Updater()
        {
        }

        private void ShowSkillHUD(PlayerSkillHUD.PlayerSkillHUDState skill)
        {
        }

        private bool CheckDribble()
        {
            return false;
        }

        private bool CheckSpeed()
        {
            return false;
        }

        private bool CheckSteal()
        {
            return false;
        }

        private bool CheckPowerShot()
        {
            return false;
        }
    }

    private class PlayerSkillHUDState
    {
        public HUDFollowPlayer hudRect;
        private float lastPlayTime;
        private float CD;
        public global::EngineMessages.PlayerSkill playerSkill;
        public void Play()
        {
        }

        public bool CheckCanPlay()
        {
            return false;
        }

        public PlayerSkillHUDState(HUDFollowPlayer hud, float cd, global::EngineMessages.PlayerSkill skill)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private HUDFollowPlayer[] skillIcons;
    private global::System.Collections.Generic.List<PlayerSkillHUD.PlayerSkillHUDTrigger> skillHUDTrigger;
    private AISampleBase aiMatch;
    public global::UnityEngine.Vector2 offset;
    private bool hasMoveInput;
    private bool isSpeeding;
    private int successfulSteal;
    private bool powerShot;
    public static PlayerSkillHUD TryCreate(AISampleBase aISample, UIPlayerInfo uIPlayerInfo)
    {
        return null;
    }

    public void OnAIUpdate()
    {
    }

    public void MarkMoveInput()
    {
    }

    public void MarkSpeeding()
    {
    }

    private void MarkSuccessfulSteal(int playerId, global::FLMessageSystem.FullPlayerStatisticsType stealType)
    {
    }

    public void MarkPowerShot()
    {
    }

    private void ResetState()
    {
    }

    public void Reset()
    {
    }
}