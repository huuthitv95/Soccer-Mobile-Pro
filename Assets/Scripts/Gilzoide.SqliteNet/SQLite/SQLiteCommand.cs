namespace SQLite
{
    public class SQLiteCommand
    {
        private class Binding
        {
            public string Name { get; set; }
            public object Value { get; set; }
            public int Index { get; set; }
        }

        private global::SQLite.SQLiteConnection _conn;
        private global::System.Collections.Generic.List<global::SQLite.SQLiteCommand.Binding> _bindings;
        private static global::System.IntPtr NegativePointer;
        public string CommandText { get; set; }

        public SQLiteCommand(global::SQLite.SQLiteConnection conn)
        {
        }

        public int ExecuteNonQuery()
        {
            return 0;
        }

        public global::System.Collections.Generic.List<T> ExecuteQuery<T>()
        {
            return null;
        }

        protected virtual void OnInstanceCreated(object obj)
        {
        }

        public global::System.Collections.Generic.IEnumerable<T> ExecuteDeferredQuery<T>(global::SQLite.TableMapping map)
        {
            return null;
        }

        public T ExecuteScalar<T>()
        {
            return default;
        }

        public void Bind(string name, object val)
        {
        }

        public void Bind(object val)
        {
        }

        public override string ToString()
        {
            return null;
        }

        private global::System.IntPtr Prepare()
        {
            return (global::System.IntPtr)0;
        }

        private void Finalize(global::System.IntPtr stmt)
        {
        }

        private void BindAll(global::System.IntPtr stmt)
        {
        }

        internal static void BindParameter(global::System.IntPtr stmt, int index, object value, bool storeDateTimeAsTicks, string dateTimeStringFormat, bool storeTimeSpanAsTicks)
        {
        }

        private object ReadCol(global::System.IntPtr stmt, int index, global::SQLite.SQLite3.ColType type, global::System.Type clrType)
        {
            return null;
        }
    }
}