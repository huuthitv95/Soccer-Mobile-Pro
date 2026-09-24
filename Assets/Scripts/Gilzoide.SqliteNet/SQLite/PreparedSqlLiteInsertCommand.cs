namespace SQLite
{
    internal class PreparedSqlLiteInsertCommand : global::System.IDisposable
    {
        private bool Initialized;
        private global::SQLite.SQLiteConnection Connection;
        private string CommandText;
        private global::System.IntPtr Statement;
        private static readonly global::System.IntPtr NullStatement;
        public PreparedSqlLiteInsertCommand(global::SQLite.SQLiteConnection conn, string commandText)
        {
        }

        public int ExecuteNonQuery(object[] source)
        {
            return 0;
        }

        public void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        ~PreparedSqlLiteInsertCommand()
        {
        }
    }
}