namespace Google.Protobuf.Reflection
{
	public class OriginalNameAttribute : global::System.Attribute
	{
		public string Name { get; set; }

		public bool PreferredAlias { get; set; }

		public OriginalNameAttribute(string name)
		{
		}
	}
}
