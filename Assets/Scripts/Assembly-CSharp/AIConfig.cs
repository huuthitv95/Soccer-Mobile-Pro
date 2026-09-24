public class AIConfig
{
	public float playSpeed;

	public float match_duration;

	public float match_difficult;

	public float teammate_difficulty;

	public int autoSwitchPlayerLevel;

	public int PowerAssist;

	public int DirectionAssist;

	public int shoot_charge_max_time;

	public int pass_charge_max_time;

	public float max_receiver_stopping_time;

	public float min_physical_reaction_time;

	public float max_physical_reaction_time;

	public bool ai_attack_run;

	public float fatigue_factor_inv;

	public float fatigue_stamina_factor;

	public float ability_pow;

	public float sliding_rate;

	public int ai_version;

	public int trainingSubLevelID;

	public DebugMode debugMatchState;

	public bool aiKeyboard;

	public float ballRadius;

	public int TouchInputType;

	public bool HasMatchSnapshot;

	public int startTeamId;

	public int yellowCard;

	public int redCard;

	public int team1PlayerLimit;

	public int team2PlayerLimit;

	public bool enable_tackle;

	public bool enable_support;

	public global::EngineMessages.ControlStyle control_style;

	public float low_pass_distance_weight;

	public float low_pass_direction_weight;

	public float low_pass_score_weight;

	public float low_pass_score_weight2;

	public float high_pass_distance_weight;

	public float high_pass_direction_weight;

	public float high_pass_score_weight;

	public float manual_low_pass_threshold;

	public float manual_high_pass_threshold;

	public float low_pass_direction_filter;

	public float low_pass_distance_filter;

	public bool enable_player_skills;

	public float throughpass_max_speed_rate;

	public float throughpass_scalar_offset_max;

	public float throughpass_scalar_limit;

	public float GetPlayerAbilityOffset(bool isUserTeam)
	{
		return 0f;
	}

	public float CalculatePlayerPropertyValue(ClubPlayer clubPlayer, global::EngineMessages.PlayerProperty property, float ratingOffset)
	{
		return 0f;
	}
}
