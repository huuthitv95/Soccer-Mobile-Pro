public static class AllCommentaryIds
{
	public class CommentaryID
	{
		public readonly string Id;

		public float CommentaryFrequency;

		public int MinEventInterval;

		public const float _eventIntervalTime = 1f;

		public const float _lowPriorityIntervalTime = 3.5f;

		public const float _highPriorityIntervalTime = 0.6f;

		public const float _highestPriorityIntervalTime = 0.4f;

		public const int _minEventInterval = 0;

		public CommentaryID(string id, float frequency = 1f, int minEventInterval = 0)
		{
		}
	}

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> MatchStart_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> MatchStart_important;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> MatchStart_final;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ShowFormation;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> NewGameKickoff;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> GoalKickoff_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> GoalKickoff_advantage;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> GoalKickoff_disadvantage;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndOfFirstHalf_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndOfFirstHalf_advantage;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndOfFirstHalf_disadvantage;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> HalftimeKickoff;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndOfSecondHalf_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndOfSecondHalf_extraTime;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ExtratimeKickoff;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndExtratimeFirstHalf;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ExtratimeKickoff_SecondHalf;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndExtratimeSecondHalf_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> EndExtratimeSecondHalf_PenaltyShootOut;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> penaltyShootoutKickoff;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Dribble_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Dribble_protection;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Dribble_forward;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Dribble_singlePole;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Dribble_dribble;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Dribble_fail;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ShortPass_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ShortPass_forward;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ShortPass_horizontal;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ShortPass_back;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> LongPass_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> LongPass_forward;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> LongPass_crossPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ThroughPass_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ThroughPass_left;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ThroughPass_right;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ThroughPass_penaltyArea;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PassSuccess_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PassSuccess_short;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PassSuccess_long;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PassFail_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_outsidePenaltyArea;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_insidePenaltyArea;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_highSpeed;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_push;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_poke;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_volley;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_chip;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_header;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Shoot_bicycleKick;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_draw;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_double;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_hatTrick;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_15min;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_keepAttack;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_setPiece;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_ownGoal;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_penaltyMiss;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_Miss;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_crossbar;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Goal_post;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> SetPiece_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> SetPiece_shortPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> SetPiece_longPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> CornerKick_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> CornerKick_shortPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> CornerKick_longPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKick_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKick_Shoot;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKick_shortPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKick_longPass;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PenaltyKick_save;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PenaltyKick_post;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PenaltyKick_crossbar;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PenaltyKick_goal;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PenaltyKick_miss;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ThrowInKick;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Steal_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Steal_success;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Steal_tackle;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Interception_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Clearance;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Clearance_fail;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Corner;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> GoalKick;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> ThrowIn;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Foul_general;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> YellowCard;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> RedCard;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Offside;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded_front;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded_leftFront;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded_rightFront;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded_center;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded_leftCenter;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FreeKickAwarded_rightCenter;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> PenaltyAwarded;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> GoalkeeperSave;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> AddedTime;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Substitution;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> LeagueChampion;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> CupChampion;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> GoalReplay;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> FoulReplay;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> CardReplay;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Win_2_3;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Win_4;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Win_1;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Draw;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Win_penalty;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> Injury;

	public static readonly global::System.Collections.Generic.Dictionary<(int, int), AllCommentaryIds.CommentaryID> ScoreCommentary;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> firstHalf0_0;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> firstHalfDraw;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> firstHalfLead;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> firstHalfBehind;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> secondHalf0_0;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> secondHalfDraw;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> secondHalfLead;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> secondHalfBehind;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> overview_15min;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> overview_30min;

	public static readonly global::SL.RandomList<AllCommentaryIds.CommentaryID> overview_60min;
}
