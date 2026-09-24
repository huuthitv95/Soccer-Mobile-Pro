namespace FLTest.GlobalConfig
{
	public sealed class GlobalConfigReloadListenAttribute : global::System.Attribute
	{
		public string MethodName { get; }

		public GlobalConfigReloadListenAttribute(string methodName = "OnReloaded")
		{
		}
	}
}
