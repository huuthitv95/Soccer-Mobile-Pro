namespace SQLite
{
	public class SQLiteException : global::System.Exception
	{
		public global::SQLite.SQLite3.Result Result { get; private set; }

		protected SQLiteException(global::SQLite.SQLite3.Result r, string message)
		{
		}

		public static global::SQLite.SQLiteException New(global::SQLite.SQLite3.Result r, string message)
		{
			return null;
		}
	}
}
