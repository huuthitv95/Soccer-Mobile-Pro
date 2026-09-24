namespace SL
{
	public class CupRules
	{
		public enum KnockoutFormat
		{
			BO1 = 0,
			BO2 = 1
		}

		public enum RankSortCondition
		{
			Point = 0,
			Relationship = 1,
			GoalBetweenSamePlaces = 2,
			GD_BetweenSamePlaces = 3,
			Goal = 4,
			GD = 5,
			AG = 6,
			OppPointDiff = 7,
			Wins = 8
		}

		public enum KnockoutCircumventionRules
		{
			FirstRoundCircumvention = 0,
			NonCircumvention = 1
		}

		public enum KnockoutDrawRules
		{
			FirstRound = 0,
			UntilTheSemifinal = 1,
			WorldCup = 2,
			AmericanCup = 3,
			AsianChampionsCup = 4,
			Fixed = 5,
			WorldCup26 = 6
		}

		public enum DetailType
		{
			National = 0,
			LeagueCup = 1,
			Champion = 2,
			LeagueSuperCup = 3,
			IntercontinentalSuperCup = 4,
			ClubWorldCup = 5,
			NewClubWorldCup = 6
		}

		public enum ChampionCupDetailType
		{
			None = 0,
			Elite = 1,
			Premier = 2,
			Challenger = 3
		}

		public enum ProgressedRules
		{
			TOP_TWO = 0,
			TOP_TWO_AND_BEST_OF_THIRD = 1,
			CUSTOM = 2
		}

		public enum CupRulesHandlerType
		{
			Normal = 0,
			NewChampionLeague = 1,
			NationalLeagueCup = 2,
			MultiStageTournament = 3,
			NewClubWorldCup = 4
		}

		public string type;

		public int numberOfGroups;

		public int[] teams;

		public int[] teams_OrgSeq;

		public global::SL.LeagueProto.MatchFormat groupFormat;

		public bool HasThirdPlace;

		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::SL.CupRules.KnockoutFormat>> knockoutFormat;

		public global::SL.CupRules.KnockoutFormat finalFormat;

		public bool checkAwayGoals;

		private string _icon;

		public EditableSpirit icon;

		public global::System.Collections.Generic.List<global::SL.CupRules.RankSortCondition> rankSortConditions;

		public global::SL.CupRules.KnockoutCircumventionRules circumventionRules;

		public global::SL.CupRules.KnockoutDrawRules drawRules;

		private string _name;

		public int numOfPreQualifyingTeams;

		public global::SL.CupRules.ProgressedRules progressedRules;

		public int[] bannedTeams;

		public string cupTexture;

		public int TargetKnockoutRoundNum;

		private sbyte isNationalLeagueCup;

		public static global::System.Collections.Generic.Dictionary<string, global::SL.CupRules> AllCups;

		public int id;

		public EditableName name { get; private set; }

		public global::SL.CupRules.DetailType detailType { get; private set; }

		public global::FLDataTable.CupExtensionRules ExtensionRules { get; private set; }

		public global::SL.CupRules.CupRulesHandlerType RulesHandlerType { get; private set; }

		public string NameWithoutYear => null;

		public bool HasGroupStage => false;

		public bool IsNationalLeagueCup => false;

		public bool TeamsFromSameRegion => false;

		public ConfigVariantID VariantID { get; private set; }

		public override int GetHashCode()
		{
			return 0;
		}

		private CupRules()
		{
		}

		public static global::SL.CupRules Deserialization(global::FLDataTable.CupRulesConfig cupRulesConfig, bool LoadTeams = true)
		{
			return null;
		}

		private static global::SL.CupRules.KnockoutFormat ParseKnockoutFormat(string str)
		{
			return global::SL.CupRules.KnockoutFormat.BO1;
		}

		private static global::SL.LeagueProto.MatchFormat ParseMatchFormat(string str)
		{
			return global::SL.LeagueProto.MatchFormat.DoubleRoundRobin;
		}

		private static int[] ParseTeams(string data)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::SL.CupRules> LoadFromFile(bool LoadTeams = true)
		{
			return null;
		}

		public global::SL.CupRules CreateVariant(global::System.Collections.Generic.List<string> datas, ConfigVariantID variantID)
		{
			return null;
		}

		public static global::SL.CupRules CreateCustomLeagueCup(global::Srv.CustomLeagueTemplate template)
		{
			return null;
		}

		public static global::SL.CupRules CreateCustomSuperCup(global::Srv.CustomLeagueTemplate template)
		{
			return null;
		}
	}
}
