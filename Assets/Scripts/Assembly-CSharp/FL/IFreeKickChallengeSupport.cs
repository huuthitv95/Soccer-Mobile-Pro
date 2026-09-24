namespace FL
{
	public interface IFreeKickChallengeSupport : global::FL.IFreeKickMatchResultListener
	{
		MirroredMatchChallengeConfig.FreeKickChallengeConfigs GetFreeKickChallengeConfig(int challengeId);
	}
}
