namespace Cinemachine
{
	public sealed class DocumentationSortingAttribute : global::System.Attribute
	{
		public enum Level
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}

		public float SortOrder { get; private set; }

		public global::Cinemachine.DocumentationSortingAttribute.Level Category { get; private set; }

		public DocumentationSortingAttribute(float sortOrder, global::Cinemachine.DocumentationSortingAttribute.Level category)
		{
		}
	}
}
