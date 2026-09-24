namespace SQLite
{
	[global::System.Flags]
	public enum CreateFlags
	{
		None = 0,
		ImplicitPK = 1,
		ImplicitIndex = 2,
		AllImplicit = ImplicitPK | ImplicitIndex,
		AutoIncPK = 4,
		FullTextSearch3 = 0x100,
		FullTextSearch4 = 0x200
	}
}
