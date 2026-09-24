public struct PlayerAppearancePathInfo
{
	public string SkinPath;

	public string FaceTexturePaths;

	public string EyePath;

	public string eyebrow;

	public string beard;

	public JerseyNumberConfig CoatNumberConfig;

	public JerseyNumberConfig ShortsNumberConfig;

	public int CoatNumber;

	public global::UnityEngine.Color? HairColor;

	public global::UnityEngine.Color? HairDarkColor;

	public global::UnityEngine.Color? HairSpecColor;

	public global::UnityEngine.Color BeardColor;

	public string HairMeshName;

	public sbyte[] HeadData;

	public sbyte[] somatotype;

	public string face_decoration;

	public BodyType? BodyType;

	public short Height;

	public string GlovePath;

	public string ArmSleevePath;

	public string WristbandPath;

	public int PlayerID;

	public string ShoePath;

	public string NoHairPath;

	public string HDHeadMeshName;

	public bool IsFemale;

	public global::FLDataTable.StarPlayerAppearance starPlayerAppearance;

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
