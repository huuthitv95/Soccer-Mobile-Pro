public static class FormationTool
{
	public enum UIPosition : sbyte
	{
		GK = 0,
		LB = 1,
		CB = 2,
		RB = 3,
		LWB = 4,
		DM = 5,
		RWB = 6,
		LM = 7,
		CM = 8,
		RM = 9,
		AM = 10,
		LW = 11,
		SS = 12,
		RW = 13,
		CF = 14,
		SUB = 15,
		COUNT = 16
	}

	public enum UIRole : sbyte
	{
		GK = 0,
		LB = 1,
		LCB = 2,
		CB = 3,
		RCB = 4,
		RB = 5,
		LWB = 6,
		LDM = 7,
		CDM = 8,
		RDM = 9,
		RWB = 10,
		LM = 11,
		LCM = 12,
		CM = 13,
		RCM = 14,
		RM = 15,
		LAM = 16,
		CAM = 17,
		RAM = 18,
		LW = 19,
		LF = 20,
		CF = 21,
		RF = 22,
		RW = 23,
		LS = 24,
		ST = 25,
		RS = 26,
		SUB = 27
	}

	public enum PositionWithLine
	{
		GK = 0,
		SB = 1,
		CB = 2,
		DM = 3,
		CM_AM = 4,
		WF = 5,
		CF = 6
	}

	public enum PlayerCategory
	{
		Forward = 0,
		Midfielder = 1,
		Defender = 2,
		Goalkeeper = 3,
		Sub = 4
	}

	private static global::System.Collections.Generic.Dictionary<FormationTool.UIRole, int> formationMapHelper;

	private static global::System.Collections.Generic.Dictionary<int, float> formationPosX;

	private static global::System.Collections.Generic.Dictionary<FormationTool.UIRole, int> formationNameHelper;

	public static int ConvertFormationToCode(global::System.Collections.Generic.List<FormationTool.UIRole> formation)
	{
		return 0;
	}

	public static FormationTool.UIPosition ConvertUIRoleToUIPosition(FormationTool.UIRole role)
	{
		return FormationTool.UIPosition.GK;
	}

	public static global::SLLevel.PlayerRole ConvertUIPositionToAIRole(FormationTool.UIPosition position)
	{
		return global::SLLevel.PlayerRole.GK;
	}

	public static global::UnityEngine.Vector2 getUIRole2DPos(FormationTool.UIRole role)
	{
		return default;
	}

	public static global::System.Collections.Generic.List<int> GetFormationLineCount(global::System.Collections.Generic.List<FormationTool.UIRole> formation)
	{
		return null;
	}

	public static int GetLineIdx(FormationTool.UIRole role)
	{
		return 0;
	}

	public static global::Common.FormationEntry ConvertUIRoleToAIRole(FormationTool.UIRole role, global::System.Collections.Generic.List<FormationTool.UIRole> formation)
	{
		return null;
	}

	public static FormationTool.UIPosition ConvertAIRoleToUIPosition(global::Common.FormationEntry formationEntry)
	{
		return FormationTool.UIPosition.GK;
	}

	public static string GetFormationName(global::System.Collections.Generic.List<FormationTool.UIRole> formations, out int code)
	{
		code = default;
		return null;
	}

	public static int GetFormationNameCode(global::System.Collections.Generic.List<FormationTool.UIRole> formations)
	{
		return 0;
	}

	public static FormationTool.PositionWithLine Convert2LinePos(FormationTool.UIPosition pos)
	{
		return FormationTool.PositionWithLine.GK;
	}

	public static global::System.Collections.Generic.List<FormationTool.UIPosition> GetSimilarPosition(FormationTool.UIPosition position)
	{
		return null;
	}

	public static (int, int, int) CalculateRatingByCategory(global::System.Collections.Generic.List<ClubPlayer> players, int start = 0, int count = 11)
	{
		return default;
	}

	public static global::System.Collections.Generic.HashSet<FormationTool.UIRole> GetPositionByCategory(FormationTool.PlayerCategory category)
	{
		return null;
	}

	public static FormationTool.PlayerCategory GetPlayerCategory(FormationTool.UIPosition pos)
	{
		return FormationTool.PlayerCategory.Forward;
	}

	public static FormationTool.PlayerCategory GetPlayerCategory(FormationTool.UIRole pos)
	{
		return FormationTool.PlayerCategory.Forward;
	}
}
