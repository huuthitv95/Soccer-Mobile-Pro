public struct LicensedJerseyLoader
{
	public global::UnityEngine.Texture2D texture;

	public int jerseyID;

	public LicensedAssetManager.TeamLicensedAssetInfo teamLicensedAssetInfo;

	public LicensedJerseyLoader(in LicensedAssetManager.TeamLicensedAssetInfo teamLicensedAssetInfo, bool isGK, bool homeJersey)
	{
		texture = null;
		jerseyID = 0;
		this.teamLicensedAssetInfo = default;
	}
}
