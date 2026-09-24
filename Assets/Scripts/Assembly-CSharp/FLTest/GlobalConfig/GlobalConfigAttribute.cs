namespace FLTest.GlobalConfig
{
	public sealed class GlobalConfigAttribute : global::System.Attribute
	{
		public string SectionName { get; }

		public string Comment { get; }

		public GlobalConfigAttribute()
		{
		}

		public GlobalConfigAttribute(string sectionName)
		{
		}

		public GlobalConfigAttribute(string sectionName, string comment)
		{
		}
	}
}
