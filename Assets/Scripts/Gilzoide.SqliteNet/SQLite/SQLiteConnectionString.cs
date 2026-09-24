namespace SQLite
{
	public class SQLiteConnectionString
	{
		private readonly string UniqueKey;

		public string DatabasePath { get; }

		public bool StoreDateTimeAsTicks { get; }

		public bool StoreTimeSpanAsTicks { get; }

		public string DateTimeStringFormat { get; }

		public global::System.Globalization.DateTimeStyles DateTimeStyle { get; }

		public object Key { get; }

		public global::SQLite.SQLiteOpenFlags OpenFlags { get; }

		public global::System.Action<global::SQLite.SQLiteConnection> PreKeyAction { get; }

		public global::System.Action<global::SQLite.SQLiteConnection> PostKeyAction { get; }

		public string VfsName { get; }

		public SQLiteConnectionString(string databasePath, global::SQLite.SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks, object key = null, global::System.Action<global::SQLite.SQLiteConnection> preKeyAction = null, global::System.Action<global::SQLite.SQLiteConnection> postKeyAction = null, string vfsName = null, string dateTimeStringFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", bool storeTimeSpanAsTicks = true)
		{
		}
	}
}
