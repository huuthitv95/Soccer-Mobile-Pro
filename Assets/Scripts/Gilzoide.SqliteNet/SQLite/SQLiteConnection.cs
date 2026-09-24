namespace SQLite
{
    [global::SQLite.Preserve]
    public class SQLiteConnection : global::System.IDisposable
    {
        private struct IndexedColumn
        {
            public int Order;
            public string ColumnName;
        }

        private struct IndexInfo
        {
            public string IndexName;
            public string TableName;
            public bool Unique;
            public global::System.Collections.Generic.List<global::SQLite.SQLiteConnection.IndexedColumn> Columns;
        }

        [global::SQLite.Preserve]
        public class ColumnInfo
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return null;
            }
        }

        private bool _open;
        private global::System.TimeSpan _busyTimeout;
        private static readonly global::System.Collections.Generic.Dictionary<string, global::SQLite.TableMapping> _mappings;
        private global::System.Diagnostics.Stopwatch _sw;
        private long _elapsedMilliseconds;
        private int _transactionDepth;
        private global::System.Random _rand;
        private static readonly global::System.IntPtr NullHandle;
        private static readonly global::System.IntPtr NullBackupHandle;
        private readonly global::System.Collections.Generic.Dictionary<global::System.Tuple<string, string>, global::SQLite.PreparedSqlLiteInsertCommand> _insertCommandMap;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.EventHandler<global::SQLite.NotifyTableChangedEventArgs> TableChanged;
        public global::System.IntPtr Handle { get; private set; }
        public string DatabasePath { get; private set; }
        public int LibVersionNumber { get; private set; }
        public bool TimeExecution { get; }
        public bool Trace { get; }
        public global::System.Action<string> Tracer { get; set; }
        public bool StoreDateTimeAsTicks { get; private set; }
        public bool StoreTimeSpanAsTicks { get; private set; }
        public string DateTimeStringFormat { get; private set; }
        internal global::System.Globalization.DateTimeStyles DateTimeStyle { get; private set; }

        public global::System.TimeSpan BusyTimeout
        {
            set
            {
            }
        }

        public SQLiteConnection(string databasePath, global::SQLite.SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = true)
        {
        }

        public SQLiteConnection(global::SQLite.SQLiteConnectionString connectionString)
        {
        }

        public static string Quote(string unsafeString)
        {
            return null;
        }

        private void SetKey(string key)
        {
        }

        private void SetKey(byte[] key)
        {
        }

        private static byte[] GetNullTerminatedUtf8(string s)
        {
            return null;
        }

        public global::SQLite.TableMapping GetMapping(global::System.Type type, global::SQLite.CreateFlags createFlags = global::SQLite.CreateFlags.None)
        {
            return null;
        }

        protected virtual global::SQLite.SQLiteCommand NewCommand()
        {
            return null;
        }

        public global::SQLite.SQLiteCommand CreateCommand(string cmdText, params object[] ps)
        {
            return null;
        }

        public int Execute(string query, params object[] args)
        {
            return 0;
        }

        public T ExecuteScalar<T>(string query, params object[] args)
        {
            return default;
        }

        public global::System.Collections.Generic.List<T> Query<T>(string query, params object[] args)
            where T : new()
        {
            return null;
        }

        public string SaveTransactionPoint()
        {
            return null;
        }

        public void Rollback()
        {
        }

        private void RollbackTo(string savepoint, bool noThrow)
        {
        }

        public void Release(string savepoint)
        {
        }

        private void DoSavePointExecute(string savepoint, string cmd)
        {
        }

        public void RunInTransaction(global::System.Action action)
        {
        }

        public int Insert(object obj)
        {
            return 0;
        }

        public int InsertOrReplace(object obj)
        {
            return 0;
        }

        public int Insert(object obj, string extra, global::System.Type objType)
        {
            return 0;
        }

        private global::SQLite.PreparedSqlLiteInsertCommand GetInsertCommand(global::SQLite.TableMapping map, string extra)
        {
            return null;
        }

        private global::SQLite.PreparedSqlLiteInsertCommand CreateInsertCommand(global::SQLite.TableMapping map, string extra)
        {
            return null;
        }

        ~SQLiteConnection()
        {
        }

        public void Dispose()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        private void OnTableChanged(global::SQLite.TableMapping table, global::SQLite.NotifyTableChangedAction action)
        {
        }
    }
}