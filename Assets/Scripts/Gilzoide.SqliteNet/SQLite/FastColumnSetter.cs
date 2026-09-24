namespace SQLite
{
	internal class FastColumnSetter
	{
		internal static global::System.Action<object, global::System.IntPtr, int> GetFastSetter<T>(global::SQLite.SQLiteConnection conn, global::SQLite.TableMapping.Column column)
		{
			return null;
		}

		private static global::System.Action<object, global::System.IntPtr, int> CreateNullableTypedSetterDelegate<ObjectType, ColumnMemberType>(global::SQLite.TableMapping.Column column, global::System.Func<global::System.IntPtr, int, ColumnMemberType> getColumnValue) where ColumnMemberType : struct
		{
			return null;
		}

		private static global::System.Action<object, global::System.IntPtr, int> CreateTypedSetterDelegate<ObjectType, ColumnMemberType>(global::SQLite.TableMapping.Column column, global::System.Func<global::System.IntPtr, int, ColumnMemberType> getColumnValue)
		{
			return null;
		}
	}
}
