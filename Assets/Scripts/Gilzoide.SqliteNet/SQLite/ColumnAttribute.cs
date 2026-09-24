namespace SQLite
{
	public class ColumnAttribute : global::UnityEngine.Scripting.PreserveAttribute
	{
		public string Name { get; set; }

		public ColumnAttribute(string name)
		{
		}
	}
}
