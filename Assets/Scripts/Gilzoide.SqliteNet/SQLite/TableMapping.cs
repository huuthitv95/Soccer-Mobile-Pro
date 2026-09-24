namespace SQLite
{
    public class TableMapping
    {
        public class Column
        {
            private global::System.Reflection.MemberInfo _member;
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            private string Collation__BackingField;
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            private int? MaxStringLength__BackingField;
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            private bool StoreAsText__BackingField;
            public string Name { get; private set; }
            public global::System.Reflection.PropertyInfo PropertyInfo => null;
            public global::System.Type ColumnType { get; private set; }

            private string Collation
            {
                [global::System.Runtime.CompilerServices.CompilerGenerated]
                set
                {
                    Collation__BackingField = value;
                }
            }

            public bool IsAutoInc { get; private set; }
            public bool IsAutoGuid { get; private set; }
            public bool IsPK { get; private set; }
            public global::System.Collections.Generic.IEnumerable<global::SQLite.IndexedAttribute> Indices { get; set; }
            public bool IsNullable { get; private set; }

            private int? MaxStringLength
            {
                [global::System.Runtime.CompilerServices.CompilerGenerated]
                set
                {
                    MaxStringLength__BackingField = value;
                }
            }

            private bool StoreAsText
            {
                [global::System.Runtime.CompilerServices.CompilerGenerated]
                set
                {
                    StoreAsText__BackingField = value;
                }
            }

            public Column(global::System.Reflection.MemberInfo member, global::SQLite.CreateFlags createFlags = global::SQLite.CreateFlags.None)
            {
            }

            public void SetValue(object obj, object val)
            {
            }

            public object GetValue(object obj)
            {
                return null;
            }

            private static global::System.Type GetMemberType(global::System.Reflection.MemberInfo m)
            {
                return null;
            }
        }

        internal enum MapMethod
        {
            ByName = 0,
            ByPosition = 1
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private bool WithoutRowId__BackingField;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private string GetByPrimaryKeySql__BackingField;
        private readonly global::SQLite.TableMapping.Column _autoPk;
        private readonly global::SQLite.TableMapping.Column[] _insertColumns;
        private readonly global::SQLite.TableMapping.Column[] _insertOrReplaceColumns;
        public global::System.Type MappedType { get; private set; }
        public string TableName { get; private set; }

        private bool WithoutRowId
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            set
            {
                WithoutRowId__BackingField = value;
            }
        }

        public global::SQLite.TableMapping.Column[] Columns { get; private set; }
        public global::SQLite.TableMapping.Column PK { get; private set; }

        private string GetByPrimaryKeySql
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            set
            {
                GetByPrimaryKeySql__BackingField = value;
            }
        }

        public global::SQLite.CreateFlags CreateFlags { get; private set; }
        internal global::SQLite.TableMapping.MapMethod Method { get; private set; }
        public bool HasAutoIncPK { get; private set; }
        public global::SQLite.TableMapping.Column[] InsertColumns => null;
        public global::SQLite.TableMapping.Column[] InsertOrReplaceColumns => null;

        public TableMapping(global::System.Type type, global::SQLite.CreateFlags createFlags = global::SQLite.CreateFlags.None)
        {
        }

        private global::System.Collections.Generic.IReadOnlyCollection<global::System.Reflection.MemberInfo> GetPublicMembers(global::System.Type type)
        {
            return null;
        }

        private global::System.Collections.Generic.IReadOnlyCollection<global::System.Reflection.MemberInfo> GetFieldsFromValueTuple(global::System.Type type)
        {
            return null;
        }

        public void SetAutoIncPK(object obj, long id)
        {
        }

        public global::SQLite.TableMapping.Column FindColumn(string columnName)
        {
            return null;
        }
    }
}