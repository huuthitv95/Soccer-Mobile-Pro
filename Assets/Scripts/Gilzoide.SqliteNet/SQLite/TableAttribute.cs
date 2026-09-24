namespace SQLite
{
	public class TableAttribute : global::System.Attribute
	{
		public string Name { get; set; }

		public bool WithoutRowId { get; }

		public TableAttribute(string name)
		{
		}
	}
}
