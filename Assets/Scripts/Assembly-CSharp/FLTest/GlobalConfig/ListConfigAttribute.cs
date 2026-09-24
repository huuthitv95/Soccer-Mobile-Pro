namespace FLTest.GlobalConfig
{
	public sealed class ListConfigAttribute : global::System.Attribute
	{
		public bool AllowResize { get; }

		public int MinCount { get; }

		public int MaxCount { get; }

		public ListConfigAttribute(bool allowResize = true, int minCount = 0, int maxCount = -1)
		{
		}
	}
}
