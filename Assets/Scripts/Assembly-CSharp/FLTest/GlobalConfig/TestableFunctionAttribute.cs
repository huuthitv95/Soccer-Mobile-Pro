namespace FLTest.GlobalConfig
{
	public sealed class TestableFunctionAttribute : global::System.Attribute
	{
		public string DisplayName { get; }

		public string Description { get; }

		public TestableFunctionAttribute(string displayName = null, string description = null)
		{
		}
	}
}
