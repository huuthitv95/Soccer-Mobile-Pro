public class UserPlayerData
{
	public ClubPlayer PlayerData { get; private set; }

	public global::FL.UserPlayerType PlayerType => global::FL.UserPlayerType.Power;

	public int AppearanceId => 0;

	public string KitName => null;

	private global::Srv.UserPlayerDataArchive archive { get; set; }

	private PlayerCareerLocalArchives store { get; set; }

	public CoachTrustRules CoachTrust { get; private set; }

	public UserPlayerData(ClubPlayer clubPlayer, global::Srv.UserPlayerDataArchive archive, PlayerCareerLocalArchives store)
	{
	}
}
