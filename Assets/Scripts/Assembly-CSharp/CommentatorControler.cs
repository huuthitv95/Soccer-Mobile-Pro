public class CommentatorControler : ICommentatorControler
{
    private enum CommentaryID
    {
        None = 0,
        shortPass = 1,
        vfx_short_pass_01 = 2,
        vfx_short_pass_02 = 3,
        vfx_short_pass_03 = 4,
        vfx_short_pass_04 = 5,
        vfx_short_pass_05 = 6,
        vfx_short_pass_06 = 7,
        shoot = 8,
        vfx_game_shot_01 = 9,
        vfx_game_shot_02 = 10,
        vfx_game_shot_03 = 11,
        vfx_game_shot_04 = 12,
        vfx_game_shot_05 = 13,
        miss = 14,
        vfx_missed_target_01 = 15,
        vfx_missed_target_02 = 16,
        vfx_missed_target_03 = 17,
        vfx_missed_target_04 = 18,
        Interfere = 19,
        vfx_successful_defense_01 = 20,
        vfx_successful_defense_02 = 21,
        vfx_successful_defense_03 = 22,
        vfx_successful_defense_04 = 23,
        vfx_successful_defense_05 = 24,
        foul = 25,
        vfx_referee_foul_01 = 26,
        vfx_referee_foul_02 = 27,
        vfx_referee_foul_03 = 28,
        vfx_referee_foul_04 = 29,
        longPass = 30,
        vfx_long_pass_01 = 31,
        vfx_long_pass_02 = 32,
        vfx_long_pass_03 = 33,
        through = 34,
        vfx_through_pass_01 = 35,
        vfx_through_pass_02 = 36,
        vfx_through_pass_03 = 37,
        vfx_through_pass_04 = 38,
        Results = 39,
        Prologue = 40,
        vfx_hello_welcome_01 = 41,
        vfx_hello_welcome_02 = 42,
        vfx_hello_welcome_03 = 43,
        vfx_hello_welcome_04 = 44,
        vfx_hello_welcome_05 = 45,
        Conclusion = 46,
        vfx_end_of_match_win_01 = 47,
        vfx_end_of_match_win_02 = 48,
        vfx_end_of_match_win_03 = 49,
        vfx_end_of_match_draw_01 = 50,
        vfx_end_of_match_draw_02 = 51,
        vfx_end_of_match_draw_03 = 52,
        vfx_end_of_match_win_30 = 53,
        vfx_end_of_match_win_10 = 54,
        vfx_end_of_match_win_11 = 55,
        vfx_end_of_match_win_20 = 56,
        vfx_end_of_match_win_21 = 57,
        vfx_end_of_match_win_22 = 58,
        Kickoff = 59,
        vfx_before_kickoff_01 = 60,
        vfx_before_kickoff_02 = 61,
        vfx_before_kickoff_03 = 62,
        HalfConclusion = 63,
        vfx_whistle_1st_half_01 = 64,
        vfx_whistle_1st_half_02 = 65,
        vfx_whistle_1st_half_03 = 66,
        vfx_whistle_1st_half_04 = 67,
        HalfKickoff = 68,
        vfx_start_second_half_01 = 69,
        vfx_start_second_half_02 = 70,
        vfx_start_second_half_03 = 71,
        AfterScoringKickoff = 72,
        vfx_score_kickoff_01 = 73,
        vfx_score_kickoff_02 = 74,
        vfx_score_kickoff_03 = 75,
        GoalKick = 76,
        vfx_goal_kick_01 = 77,
        vfx_goal_kick_02 = 78,
        vfx_goal_kick_03 = 79,
        vfx_goal_kick_04 = 80,
        FreeKick = 81,
        vfx_free_kick_01 = 82,
        vfx_free_kick_02 = 83,
        vfx_free_kick_03 = 84,
        vfx_free_kick_04 = 85,
        Penalty = 86,
        vfx_penalty_01 = 87,
        vfx_penalty_02 = 88,
        vfx_penalty_03 = 89,
        Corner = 90,
        vfx_corner_01 = 91,
        vfx_corner_02 = 92,
        vfx_corner_03 = 93,
        vfx_corner_04 = 94,
        Offside = 95,
        vfx_offside_01 = 96,
        vfx_offside_02 = 97,
        vfx_offside_03 = 98,
        vfx_offside_04 = 99,
        Save = 100,
        vfx_goalkeeper_save_01 = 101,
        vfx_goalkeeper_save_02 = 102,
        vfx_goalkeeper_save_03 = 103,
        Goal = 104,
        vfx_goal_of_the_game_01 = 105,
        vfx_goal_of_the_game_02 = 106,
        vfx_goal_of_the_game_03 = 107,
        vfx_goal_of_the_game_04 = 108,
        vfx_goal_of_the_game_05 = 109,
        vfx_goal_of_the_game_06 = 110,
        vfx_goal_of_the_game_07 = 111,
        vfx_goal_of_the_game_08 = 112,
        YellowCard = 113,
        vfx_yellow_card_01 = 114,
        vfx_yellow_card_02 = 115,
        vfx_yellow_card_03 = 116,
        RedCard = 117,
        vfx_red_card_01 = 118,
        vfx_red_card_02 = 119,
        vfx_red_card_03 = 120,
        BallOut = 121,
        vfx_ball_out_01 = 122,
        vfx_ball_out_02 = 123,
        vfx_ball_out_03 = 124,
        GameScore = 125,
        vfx_game_score_1_0 = 126,
        vfx_game_score_0_1 = 127,
        vfx_game_score_1_1 = 128,
        vfx_game_score_2_0 = 129,
        vfx_game_score_0_2 = 130,
        vfx_game_score_2_1 = 131,
        vfx_game_score_2_2 = 132,
        vfx_game_score_3_0 = 133,
        vfx_game_score_3_1 = 134,
        vfx_game_score_3_2 = 135,
        vfx_game_score_3_3 = 136,
        vfx_game_score_0_3 = 137,
        vfx_game_score_1_3 = 138,
        vfx_game_score_2_3 = 139,
        GOAL_COMMENTS = 140,
        vfx_goal_comments_01 = 141,
        vfx_goal_comments_02 = 142,
        vfx_goal_comments_03 = 143,
        vfx_goal_comments_04 = 144
    }

    private global::System.Collections.Generic.Dictionary<CommentatorControler.CommentaryID, global::UnityEngine.AudioClip> allAudioClips;
    private int interval;
    private CommentatorControler.CommentaryID playingClip;
    private global::UnityEngine.Coroutine co;
    private int skipCounter;
    private AudioAdTrigger.OnceOnlyTrigger audioAdTrigger;
    private AudioAdTrigger.OnceOnlyTrigger audioAdTrigger2;
    private global::System.Collections.Generic.Dictionary<CommentatorControler.CommentaryID, CommentatorControler.CommentaryID> PlayedRecord;
    private IMatch AiMatch;
    private int frameConter;
    private bool Player1stScore;
    private bool Player2stScore;
    private bool goal;
    public global::UnityEngine.AudioSource audioSource { private get; set; }
    public global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public global::System.Collections.Generic.IEnumerable<FLClientOpCode> FocusClientOpcode => null;
    public global::System.Func<string, global::UnityEngine.AudioClip> LoadClip { get; set; }
    public global::UnityEngine.MonoBehaviour monoHelper { private get; set; }

    public void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public void HandleMessage(FLClientOpCode code, object message, IMatch match)
    {
    }

    private void PlaySound(CommentatorControler.CommentaryID commentaryID)
    {
    }

    public void PlayGoalComments()
    {
    }

    private void PlayPrologue()
    {
    }

    private void PlayKickoff()
    {
    }

    private void PlayHalfKickSound()
    {
    }

    private void PlayConclusion()
    {
    }

    private void PlayAfterScoringKickoff()
    {
    }

    private CommentatorControler.CommentaryID RandomSound(CommentatorControler.CommentaryID start, int Count)
    {
        return CommentatorControler.CommentaryID.None;
    }

    private global::System.Collections.IEnumerator WaitToPlayResult(CommentatorControler.CommentaryID id)
    {
        return null;
    }

    public void OnMatchStart(IMatch match)
    {
    }

    public void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    private void PlayScore(IMatch match)
    {
    }

    void ICommentatorControler.OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }
}